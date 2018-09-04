﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static V2RayGCon.Lib.StringResource;

namespace V2RayGCon.Model.Data
{
    public class ServerItem
    {
        public event EventHandler<Model.Data.StrEvent> OnLog;
        public event EventHandler OnPropertyChanged;
        public event EventHandler OnRequireMenuUpdate;
        public event EventHandler<Model.Data.StrEvent> OnRequireDelete;

        public string config; // plain text of config.json
        public bool isAutoRun, isInjectImport;
        public string name, summary, inboundIP;
        public int inboundOverwriteType, inboundPort, index;

        [JsonIgnore]
        public bool isServerOn;

        [JsonIgnore]
        public Model.BaseClass.CoreServer server;

        public ServerItem()
        {
            isServerOn = false;
            isAutoRun = false;
            isInjectImport = false;

            name = string.Empty;
            summary = string.Empty;
            config = string.Empty;
            inboundOverwriteType = 0;
            inboundIP = "127.0.0.1";
            inboundPort = 1080;

            server = new BaseClass.CoreServer();
            server.OnLog += SendLogHandler;
        }

        #region public method
        public void Delete()
        {
            CleanupThen(() =>
            {
                OnRequireDelete?.Invoke(this, new StrEvent(config));
            });
        }

        public void SetInboundIP(string ip)
        {
            if (!NeedStopCoreFirst())
            {
                inboundIP = ip;
            }
            InvokeOnPropertyChange();
        }

        public void SetInboundPort(string port)
        {
            if (!NeedStopCoreFirst())
            {
                inboundPort = Lib.Utils.Str2Int(port);
            }
            InvokeOnPropertyChange();
        }

        public void SetIndex(int index)
        {
            this.index = index;
            InvokeOnPropertyChange();
        }

        public void SetAutoRun(bool autorun)
        {
            this.isAutoRun = autorun;
            InvokeOnPropertyChange();
        }

        public void SetInjectImport(bool import)
        {
            var changed = this.isInjectImport != import;
            this.isInjectImport = import;

            if (changed)
            {
                UpdateSummaryThen(
                    () => InvokeOnRequireMenuUpdate());
            }
            else
            {
                InvokeOnPropertyChange();
            }

            if (isServerOn)
            {
                RestartCoreThen();
            }
        }

        public void SetInboundType(int type)
        {
            this.inboundOverwriteType = Lib.Utils.Clamp(type, 0, GetInboundTypeCount());
            InvokeOnPropertyChange();
            if (isServerOn)
            {
                RestartCoreThen();
            }
        }

        public void UpdateSummaryThen(Action lambda = null)
        {
            Task.Factory.StartNew(() =>
            {
                var configString = isInjectImport ?
                    Lib.Utils.InjectGlobalImport(this.config) :
                    config;
                try
                {
                    UpdateSummary(
                        Lib.ImportParser.ParseImport(configString));
                }
                catch
                {
                    UpdateSummary(JObject.Parse(configString));
                }

                InvokeOnPropertyChange();
                lambda?.Invoke();
            });
        }

        public void CleanupThen(Action lambda)
        {
            this.server.StopCoreThen(() =>
            {
                this.server.OnLog -= SendLogHandler;
                lambda();
            });
        }

        public void ChangeConfig(string config)
        {
            this.config = config;
            InvokeOnPropertyChange();
            UpdateSummaryThen(() =>
            {
                InvokeOnRequireMenuUpdate();
            });

            if (server.isRunning)
            {
                RestartCoreThen();
            }
        }

        public void StopCoreThen(Action lambda = null)
        {
            server.StopCoreThen(lambda);
            var a = Properties.Settings.Default.DecodeCache;
        }

        public void RestartCoreThen(Action next = null)
        {
            JObject cfg = null;
            try
            {
                cfg = Lib.ImportParser.ParseImport(
                    isInjectImport ?
                    Lib.Utils.InjectGlobalImport(config) :
                    config);

                // cache successful decode result
                Service.Cache.Instance.core[config] =
                    cfg.ToString(Formatting.None);

            }
            catch { }

            if (cfg == null)
            {
                SendLog(I18N("DecodeImportFail"));

                try
                {
                    cfg = JObject.Parse(
                        Service.Cache.Instance.core[config]);
                }
                catch (KeyNotFoundException)
                {
                    StopCoreThen(next);
                    return;
                }

                SendLog(I18N("UsingDecodeCache"));
            }

            if (!OverwriteInboundSettings(ref cfg))
            {
                StopCoreThen(next);
                return;
            }

            var env = Lib.Utils.GetEnvVarsFromConfig(cfg);
            var s = cfg.ToString();
            cfg = null;

            server.RestartCoreThen(s, OnCoreStateChanged, next, env);
        }

        public void OnCoreStateChanged()
        {
            isServerOn = server.isRunning;
            InvokeOnPropertyChange();
        }
        #endregion

        #region private method
        bool NeedStopCoreFirst()
        {
            if (!isServerOn)
            {
                return false;
            }

            if (inboundOverwriteType == (int)Model.Data.Enum.ProxyTypes.HTTP
                || inboundOverwriteType == (int)Model.Data.Enum.ProxyTypes.SOCKS)
            {
                Task.Factory.StartNew(
                    () => MessageBox.Show(I18N("StopServerFirst")));
                return true;
            }

            return false;
        }

        bool OverwriteInboundSettings(ref JObject config)
        {
            var type = inboundOverwriteType;

            if (!(type == (int)Model.Data.Enum.ProxyTypes.HTTP
                || type == (int)Model.Data.Enum.ProxyTypes.SOCKS))
            {
                return true;
            }

            var protocol = Model.Data.Table.inboundOverwriteTypesName[type];

            var part = protocol + "In";
            try
            {
                config["inbound"]["protocol"] = protocol;
                config["inbound"]["listen"] = this.inboundIP;
                config["inbound"]["port"] = this.inboundPort;
                config["inbound"]["settings"] =
                    Service.Cache.Instance.tpl.LoadTemplate(part);

                if (type == (int)Model.Data.Enum.ProxyTypes.SOCKS)
                {
                    config["inbound"]["settings"]["ip"] = this.inboundIP;
                }

                return true;
            }
            catch
            {
                SendLog(I18N("CoreCantSetLocalAddr"));
            }
            return false;
        }

        void SendLog(string message)
        {
            var log = new Model.Data.StrEvent(
                string.Format("[{0}] {1}", this.name, message));

            try
            {
                OnLog?.Invoke(this, log);
            }
            catch { }
        }

        void SendLogHandler(object sender, Model.Data.StrEvent arg)
        {
            var log = new Model.Data.StrEvent(
                string.Format("[{0}] {1}", this.name, arg.Data));

            try
            {
                OnLog?.Invoke(this, log);
            }
            catch { }
        }

        void InvokeOnRequireMenuUpdate()
        {
            OnRequireMenuUpdate?.Invoke(this, EventArgs.Empty);
        }

        void InvokeOnPropertyChange()
        {
            // things happen while invoking
            try
            {
                OnPropertyChanged?.Invoke(this, EventArgs.Empty);
            }
            catch { }
        }

        void UpdateSummary(JObject config)
        {
            var name = Lib.Utils.GetAliasFromConfig(config);
            var summary = string.Format("[{0}] {1}", name, Lib.Utils.GetSummaryFromConfig(config));

            this.name = name;
            this.summary = Lib.Utils.CutStr(summary, 39);
        }

        private int GetInboundTypeCount()
        {
            return Model.Data.Table.inboundOverwriteTypesName.Length;
        }
        #endregion
    }
}
