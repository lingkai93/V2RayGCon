﻿using System.Windows.Forms;

namespace V2RayGCon.Views.WinForms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.flyServerListContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSelectAllCurPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInverseSelectionCurPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSelectNoneCurPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCollapseSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExpanSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRestartSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStopSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonModifySelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSortSelectedBySummary = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSortSelectedBySpeedTestResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFormOption = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelMarkFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxMarkFilter = new System.Windows.Forms.ToolStripComboBox();
            this.mainMneuStrip = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemSimAddVmessServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportLinkFromClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemExportAllServerToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemImportFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllCurPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionCurPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneCurPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectNoSpeedTestAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTimeoutAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoMarkAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAutorunAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRunningAllPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertSelectionAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectNoSpeedTestAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectTimeoutAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoMarkAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAutorunAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRunningAllServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemModifySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMoveToTop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMoveToBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortBySpeedTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSortBySummary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemModifySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemFoldingPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExpansePanel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyAsV2rayLink = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyAsVmessLink = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopyAsSubscription = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRestartSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpeedTestOnSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPackSelectedServers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteServers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteAllServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDeleteSelectedServers = new System.Windows.Forms.ToolStripMenuItem();
            this.systemProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCurrentSysProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPACURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitPACDebuggerURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemClearSysProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.startPACServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopPACServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemConfigEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDownLoadV2rayCore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveV2rayCore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButtonPager = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripStatusLabelPrePage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNextPage = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainMneuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer2
            // 
            resources.ApplyResources(this.toolStripContainer2, "toolStripContainer2");
            // 
            // toolStripContainer2.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer2.BottomToolStripPanel, "toolStripContainer2.BottomToolStripPanel");
            this.toolTip1.SetToolTip(this.toolStripContainer2.BottomToolStripPanel, resources.GetString("toolStripContainer2.BottomToolStripPanel.ToolTip"));
            this.toolStripContainer2.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer2.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer2.ContentPanel, "toolStripContainer2.ContentPanel");
            this.toolStripContainer2.ContentPanel.Controls.Add(this.flyServerListContainer);
            this.toolTip1.SetToolTip(this.toolStripContainer2.ContentPanel, resources.GetString("toolStripContainer2.ContentPanel.ToolTip"));
            // 
            // toolStripContainer2.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer2.LeftToolStripPanel, "toolStripContainer2.LeftToolStripPanel");
            this.toolTip1.SetToolTip(this.toolStripContainer2.LeftToolStripPanel, resources.GetString("toolStripContainer2.LeftToolStripPanel.ToolTip"));
            this.toolStripContainer2.LeftToolStripPanelVisible = false;
            this.toolStripContainer2.Name = "toolStripContainer2";
            // 
            // toolStripContainer2.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer2.RightToolStripPanel, "toolStripContainer2.RightToolStripPanel");
            this.toolTip1.SetToolTip(this.toolStripContainer2.RightToolStripPanel, resources.GetString("toolStripContainer2.RightToolStripPanel.ToolTip"));
            this.toolStripContainer2.RightToolStripPanelVisible = false;
            this.toolTip1.SetToolTip(this.toolStripContainer2, resources.GetString("toolStripContainer2.ToolTip"));
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer2.TopToolStripPanel, "toolStripContainer2.TopToolStripPanel");
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolTip1.SetToolTip(this.toolStripContainer2.TopToolStripPanel, resources.GetString("toolStripContainer2.TopToolStripPanel.ToolTip"));
            // 
            // flyServerListContainer
            // 
            resources.ApplyResources(this.flyServerListContainer, "flyServerListContainer");
            this.flyServerListContainer.AllowDrop = true;
            this.flyServerListContainer.BackColor = System.Drawing.Color.White;
            this.flyServerListContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flyServerListContainer.Name = "flyServerListContainer";
            this.toolTip1.SetToolTip(this.flyServerListContainer, resources.GetString("flyServerListContainer.ToolTip"));
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSelectAllCurPage,
            this.toolStripButtonInverseSelectionCurPage,
            this.toolStripButtonSelectNoneCurPage,
            this.toolStripSeparator2,
            this.toolStripButtonCollapseSelected,
            this.toolStripButtonExpanSelected,
            this.toolStripSeparator6,
            this.toolStripButtonRestartSelected,
            this.toolStripButtonStopSelected,
            this.toolStripSeparator7,
            this.toolStripButtonModifySelected,
            this.toolStripButtonSortSelectedBySummary,
            this.toolStripButtonSortSelectedBySpeedTestResult,
            this.toolStripSeparator9,
            this.toolStripButtonFormOption,
            this.toolStripSeparator10,
            this.toolStripLabelMarkFilter,
            this.toolStripComboBoxMarkFilter});
            this.toolStrip1.Name = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // toolStripButtonSelectAllCurPage
            // 
            resources.ApplyResources(this.toolStripButtonSelectAllCurPage, "toolStripButtonSelectAllCurPage");
            this.toolStripButtonSelectAllCurPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectAllCurPage.Name = "toolStripButtonSelectAllCurPage";
            // 
            // toolStripButtonInverseSelectionCurPage
            // 
            resources.ApplyResources(this.toolStripButtonInverseSelectionCurPage, "toolStripButtonInverseSelectionCurPage");
            this.toolStripButtonInverseSelectionCurPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInverseSelectionCurPage.Name = "toolStripButtonInverseSelectionCurPage";
            // 
            // toolStripButtonSelectNoneCurPage
            // 
            resources.ApplyResources(this.toolStripButtonSelectNoneCurPage, "toolStripButtonSelectNoneCurPage");
            this.toolStripButtonSelectNoneCurPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectNoneCurPage.Name = "toolStripButtonSelectNoneCurPage";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripButtonCollapseSelected
            // 
            resources.ApplyResources(this.toolStripButtonCollapseSelected, "toolStripButtonCollapseSelected");
            this.toolStripButtonCollapseSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCollapseSelected.Name = "toolStripButtonCollapseSelected";
            // 
            // toolStripButtonExpanSelected
            // 
            resources.ApplyResources(this.toolStripButtonExpanSelected, "toolStripButtonExpanSelected");
            this.toolStripButtonExpanSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExpanSelected.Name = "toolStripButtonExpanSelected";
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // toolStripButtonRestartSelected
            // 
            resources.ApplyResources(this.toolStripButtonRestartSelected, "toolStripButtonRestartSelected");
            this.toolStripButtonRestartSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRestartSelected.Name = "toolStripButtonRestartSelected";
            // 
            // toolStripButtonStopSelected
            // 
            resources.ApplyResources(this.toolStripButtonStopSelected, "toolStripButtonStopSelected");
            this.toolStripButtonStopSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStopSelected.Name = "toolStripButtonStopSelected";
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // toolStripButtonModifySelected
            // 
            resources.ApplyResources(this.toolStripButtonModifySelected, "toolStripButtonModifySelected");
            this.toolStripButtonModifySelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModifySelected.Name = "toolStripButtonModifySelected";
            // 
            // toolStripButtonSortSelectedBySummary
            // 
            resources.ApplyResources(this.toolStripButtonSortSelectedBySummary, "toolStripButtonSortSelectedBySummary");
            this.toolStripButtonSortSelectedBySummary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSortSelectedBySummary.Name = "toolStripButtonSortSelectedBySummary";
            // 
            // toolStripButtonSortSelectedBySpeedTestResult
            // 
            resources.ApplyResources(this.toolStripButtonSortSelectedBySpeedTestResult, "toolStripButtonSortSelectedBySpeedTestResult");
            this.toolStripButtonSortSelectedBySpeedTestResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSortSelectedBySpeedTestResult.Name = "toolStripButtonSortSelectedBySpeedTestResult";
            // 
            // toolStripSeparator9
            // 
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            // 
            // toolStripButtonFormOption
            // 
            resources.ApplyResources(this.toolStripButtonFormOption, "toolStripButtonFormOption");
            this.toolStripButtonFormOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFormOption.Name = "toolStripButtonFormOption";
            // 
            // toolStripSeparator10
            // 
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            // 
            // toolStripLabelMarkFilter
            // 
            resources.ApplyResources(this.toolStripLabelMarkFilter, "toolStripLabelMarkFilter");
            this.toolStripLabelMarkFilter.Name = "toolStripLabelMarkFilter";
            // 
            // toolStripComboBoxMarkFilter
            // 
            resources.ApplyResources(this.toolStripComboBoxMarkFilter, "toolStripComboBoxMarkFilter");
            this.toolStripComboBoxMarkFilter.Name = "toolStripComboBoxMarkFilter";
            // 
            // mainMneuStrip
            // 
            resources.ApplyResources(this.mainMneuStrip, "mainMneuStrip");
            this.mainMneuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMneuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.toolMenuItemServer,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.mainMneuStrip.Name = "mainMneuStrip";
            this.toolTip1.SetToolTip(this.mainMneuStrip, resources.GetString("mainMneuStrip.ToolTip"));
            // 
            // operationToolStripMenuItem
            // 
            resources.ApplyResources(this.operationToolStripMenuItem, "operationToolStripMenuItem");
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemSimAddVmessServer,
            this.toolMenuItemImportLinkFromClipboard,
            this.toolStripSeparator5,
            this.toolMenuItemExportAllServerToFile,
            this.toolMenuItemImportFromFile,
            this.toolStripSeparator8,
            this.exitToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            // 
            // toolMenuItemSimAddVmessServer
            // 
            resources.ApplyResources(this.toolMenuItemSimAddVmessServer, "toolMenuItemSimAddVmessServer");
            this.toolMenuItemSimAddVmessServer.Name = "toolMenuItemSimAddVmessServer";
            // 
            // toolMenuItemImportLinkFromClipboard
            // 
            resources.ApplyResources(this.toolMenuItemImportLinkFromClipboard, "toolMenuItemImportLinkFromClipboard");
            this.toolMenuItemImportLinkFromClipboard.Name = "toolMenuItemImportLinkFromClipboard";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolMenuItemExportAllServerToFile
            // 
            resources.ApplyResources(this.toolMenuItemExportAllServerToFile, "toolMenuItemExportAllServerToFile");
            this.toolMenuItemExportAllServerToFile.Name = "toolMenuItemExportAllServerToFile";
            // 
            // toolMenuItemImportFromFile
            // 
            resources.ApplyResources(this.toolMenuItemImportFromFile, "toolMenuItemImportFromFile");
            this.toolMenuItemImportFromFile.Name = "toolMenuItemImportFromFile";
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            resources.ApplyResources(this.selectToolStripMenuItem, "selectToolStripMenuItem");
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPageToolStripMenuItem,
            this.allPagesToolStripMenuItem,
            this.allServersToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            // 
            // currentPageToolStripMenuItem
            // 
            resources.ApplyResources(this.currentPageToolStripMenuItem, "currentPageToolStripMenuItem");
            this.currentPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllCurPageToolStripMenuItem,
            this.invertSelectionCurPageToolStripMenuItem,
            this.selectNoneCurPageToolStripMenuItem1});
            this.currentPageToolStripMenuItem.Name = "currentPageToolStripMenuItem";
            // 
            // selectAllCurPageToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAllCurPageToolStripMenuItem, "selectAllCurPageToolStripMenuItem");
            this.selectAllCurPageToolStripMenuItem.Name = "selectAllCurPageToolStripMenuItem";
            // 
            // invertSelectionCurPageToolStripMenuItem
            // 
            resources.ApplyResources(this.invertSelectionCurPageToolStripMenuItem, "invertSelectionCurPageToolStripMenuItem");
            this.invertSelectionCurPageToolStripMenuItem.Name = "invertSelectionCurPageToolStripMenuItem";
            // 
            // selectNoneCurPageToolStripMenuItem1
            // 
            resources.ApplyResources(this.selectNoneCurPageToolStripMenuItem1, "selectNoneCurPageToolStripMenuItem1");
            this.selectNoneCurPageToolStripMenuItem1.Name = "selectNoneCurPageToolStripMenuItem1";
            // 
            // allPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.allPagesToolStripMenuItem, "allPagesToolStripMenuItem");
            this.allPagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllAllPagesToolStripMenuItem,
            this.invertSelectionAllPagesToolStripMenuItem,
            this.selectNoneAllPagesToolStripMenuItem,
            this.toolStripMenuItem3,
            this.selectNoSpeedTestAllPagesToolStripMenuItem,
            this.selectTimeoutAllPagesToolStripMenuItem,
            this.selectNoMarkAllPagesToolStripMenuItem,
            this.selectAutorunAllPagesToolStripMenuItem,
            this.selectRunningAllPagesToolStripMenuItem});
            this.allPagesToolStripMenuItem.Name = "allPagesToolStripMenuItem";
            // 
            // selectAllAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAllAllPagesToolStripMenuItem, "selectAllAllPagesToolStripMenuItem");
            this.selectAllAllPagesToolStripMenuItem.Name = "selectAllAllPagesToolStripMenuItem";
            // 
            // invertSelectionAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.invertSelectionAllPagesToolStripMenuItem, "invertSelectionAllPagesToolStripMenuItem");
            this.invertSelectionAllPagesToolStripMenuItem.Name = "invertSelectionAllPagesToolStripMenuItem";
            // 
            // selectNoneAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoneAllPagesToolStripMenuItem, "selectNoneAllPagesToolStripMenuItem");
            this.selectNoneAllPagesToolStripMenuItem.Name = "selectNoneAllPagesToolStripMenuItem";
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // selectNoSpeedTestAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoSpeedTestAllPagesToolStripMenuItem, "selectNoSpeedTestAllPagesToolStripMenuItem");
            this.selectNoSpeedTestAllPagesToolStripMenuItem.Name = "selectNoSpeedTestAllPagesToolStripMenuItem";
            // 
            // selectTimeoutAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectTimeoutAllPagesToolStripMenuItem, "selectTimeoutAllPagesToolStripMenuItem");
            this.selectTimeoutAllPagesToolStripMenuItem.Name = "selectTimeoutAllPagesToolStripMenuItem";
            // 
            // selectNoMarkAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoMarkAllPagesToolStripMenuItem, "selectNoMarkAllPagesToolStripMenuItem");
            this.selectNoMarkAllPagesToolStripMenuItem.Name = "selectNoMarkAllPagesToolStripMenuItem";
            // 
            // selectAutorunAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAutorunAllPagesToolStripMenuItem, "selectAutorunAllPagesToolStripMenuItem");
            this.selectAutorunAllPagesToolStripMenuItem.Name = "selectAutorunAllPagesToolStripMenuItem";
            // 
            // selectRunningAllPagesToolStripMenuItem
            // 
            resources.ApplyResources(this.selectRunningAllPagesToolStripMenuItem, "selectRunningAllPagesToolStripMenuItem");
            this.selectRunningAllPagesToolStripMenuItem.Name = "selectRunningAllPagesToolStripMenuItem";
            // 
            // allServersToolStripMenuItem
            // 
            resources.ApplyResources(this.allServersToolStripMenuItem, "allServersToolStripMenuItem");
            this.allServersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllAllServersToolStripMenuItem,
            this.invertSelectionAllServersToolStripMenuItem,
            this.selectNoneAllServersToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectNoSpeedTestAllServersToolStripMenuItem,
            this.selectTimeoutAllServersToolStripMenuItem,
            this.selectNoMarkAllServersToolStripMenuItem,
            this.selectAutorunAllServersToolStripMenuItem,
            this.selectRunningAllServersToolStripMenuItem});
            this.allServersToolStripMenuItem.Name = "allServersToolStripMenuItem";
            // 
            // selectAllAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAllAllServersToolStripMenuItem, "selectAllAllServersToolStripMenuItem");
            this.selectAllAllServersToolStripMenuItem.Name = "selectAllAllServersToolStripMenuItem";
            // 
            // invertSelectionAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.invertSelectionAllServersToolStripMenuItem, "invertSelectionAllServersToolStripMenuItem");
            this.invertSelectionAllServersToolStripMenuItem.Name = "invertSelectionAllServersToolStripMenuItem";
            // 
            // selectNoneAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoneAllServersToolStripMenuItem, "selectNoneAllServersToolStripMenuItem");
            this.selectNoneAllServersToolStripMenuItem.Name = "selectNoneAllServersToolStripMenuItem";
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // selectNoSpeedTestAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoSpeedTestAllServersToolStripMenuItem, "selectNoSpeedTestAllServersToolStripMenuItem");
            this.selectNoSpeedTestAllServersToolStripMenuItem.Name = "selectNoSpeedTestAllServersToolStripMenuItem";
            // 
            // selectTimeoutAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectTimeoutAllServersToolStripMenuItem, "selectTimeoutAllServersToolStripMenuItem");
            this.selectTimeoutAllServersToolStripMenuItem.Name = "selectTimeoutAllServersToolStripMenuItem";
            // 
            // selectNoMarkAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectNoMarkAllServersToolStripMenuItem, "selectNoMarkAllServersToolStripMenuItem");
            this.selectNoMarkAllServersToolStripMenuItem.Name = "selectNoMarkAllServersToolStripMenuItem";
            // 
            // selectAutorunAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectAutorunAllServersToolStripMenuItem, "selectAutorunAllServersToolStripMenuItem");
            this.selectAutorunAllServersToolStripMenuItem.Name = "selectAutorunAllServersToolStripMenuItem";
            // 
            // selectRunningAllServersToolStripMenuItem
            // 
            resources.ApplyResources(this.selectRunningAllServersToolStripMenuItem, "selectRunningAllServersToolStripMenuItem");
            this.selectRunningAllServersToolStripMenuItem.Name = "selectRunningAllServersToolStripMenuItem";
            // 
            // toolMenuItemServer
            // 
            resources.ApplyResources(this.toolMenuItemServer, "toolMenuItemServer");
            this.toolMenuItemServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModifySelected,
            this.toolStripMenuItem1,
            this.toolStripMenuItemRestartSelected,
            this.toolStripMenuItemStopSelected,
            this.toolStripMenuItemSpeedTestOnSelected,
            this.toolStripMenuItemPackSelectedServers,
            this.toolStripSeparator1,
            this.refreshSummaryToolStripMenuItem,
            this.toolStripMenuItemDeleteServers,
            this.systemProxyToolStripMenuItem});
            this.toolMenuItemServer.Name = "toolMenuItemServer";
            // 
            // toolStripMenuItemModifySelected
            // 
            resources.ApplyResources(this.toolStripMenuItemModifySelected, "toolStripMenuItemModifySelected");
            this.toolStripMenuItemModifySelected.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMoveToTop,
            this.toolStripMenuItemMoveToBottom,
            this.toolStripMenuItemSortBySpeedTest,
            this.toolStripMenuItemSortBySummary,
            this.toolStripSeparator3,
            this.toolStripMenuItemModifySettings,
            this.toolStripSeparator4,
            this.toolStripMenuItemFoldingPanel,
            this.toolStripMenuItemExpansePanel});
            this.toolStripMenuItemModifySelected.Name = "toolStripMenuItemModifySelected";
            // 
            // toolStripMenuItemMoveToTop
            // 
            resources.ApplyResources(this.toolStripMenuItemMoveToTop, "toolStripMenuItemMoveToTop");
            this.toolStripMenuItemMoveToTop.Name = "toolStripMenuItemMoveToTop";
            // 
            // toolStripMenuItemMoveToBottom
            // 
            resources.ApplyResources(this.toolStripMenuItemMoveToBottom, "toolStripMenuItemMoveToBottom");
            this.toolStripMenuItemMoveToBottom.Name = "toolStripMenuItemMoveToBottom";
            // 
            // toolStripMenuItemSortBySpeedTest
            // 
            resources.ApplyResources(this.toolStripMenuItemSortBySpeedTest, "toolStripMenuItemSortBySpeedTest");
            this.toolStripMenuItemSortBySpeedTest.Name = "toolStripMenuItemSortBySpeedTest";
            // 
            // toolStripMenuItemSortBySummary
            // 
            resources.ApplyResources(this.toolStripMenuItemSortBySummary, "toolStripMenuItemSortBySummary");
            this.toolStripMenuItemSortBySummary.Name = "toolStripMenuItemSortBySummary";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripMenuItemModifySettings
            // 
            resources.ApplyResources(this.toolStripMenuItemModifySettings, "toolStripMenuItemModifySettings");
            this.toolStripMenuItemModifySettings.Name = "toolStripMenuItemModifySettings";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripMenuItemFoldingPanel
            // 
            resources.ApplyResources(this.toolStripMenuItemFoldingPanel, "toolStripMenuItemFoldingPanel");
            this.toolStripMenuItemFoldingPanel.Name = "toolStripMenuItemFoldingPanel";
            // 
            // toolStripMenuItemExpansePanel
            // 
            resources.ApplyResources(this.toolStripMenuItemExpansePanel, "toolStripMenuItemExpansePanel");
            this.toolStripMenuItemExpansePanel.Name = "toolStripMenuItemExpansePanel";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopyAsV2rayLink,
            this.toolStripMenuItemCopyAsVmessLink,
            this.toolStripMenuItemCopyAsSubscription});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // toolStripMenuItemCopyAsV2rayLink
            // 
            resources.ApplyResources(this.toolStripMenuItemCopyAsV2rayLink, "toolStripMenuItemCopyAsV2rayLink");
            this.toolStripMenuItemCopyAsV2rayLink.Name = "toolStripMenuItemCopyAsV2rayLink";
            // 
            // toolStripMenuItemCopyAsVmessLink
            // 
            resources.ApplyResources(this.toolStripMenuItemCopyAsVmessLink, "toolStripMenuItemCopyAsVmessLink");
            this.toolStripMenuItemCopyAsVmessLink.Name = "toolStripMenuItemCopyAsVmessLink";
            // 
            // toolStripMenuItemCopyAsSubscription
            // 
            resources.ApplyResources(this.toolStripMenuItemCopyAsSubscription, "toolStripMenuItemCopyAsSubscription");
            this.toolStripMenuItemCopyAsSubscription.Name = "toolStripMenuItemCopyAsSubscription";
            // 
            // toolStripMenuItemRestartSelected
            // 
            resources.ApplyResources(this.toolStripMenuItemRestartSelected, "toolStripMenuItemRestartSelected");
            this.toolStripMenuItemRestartSelected.Name = "toolStripMenuItemRestartSelected";
            // 
            // toolStripMenuItemStopSelected
            // 
            resources.ApplyResources(this.toolStripMenuItemStopSelected, "toolStripMenuItemStopSelected");
            this.toolStripMenuItemStopSelected.Name = "toolStripMenuItemStopSelected";
            // 
            // toolStripMenuItemSpeedTestOnSelected
            // 
            resources.ApplyResources(this.toolStripMenuItemSpeedTestOnSelected, "toolStripMenuItemSpeedTestOnSelected");
            this.toolStripMenuItemSpeedTestOnSelected.Name = "toolStripMenuItemSpeedTestOnSelected";
            // 
            // toolStripMenuItemPackSelectedServers
            // 
            resources.ApplyResources(this.toolStripMenuItemPackSelectedServers, "toolStripMenuItemPackSelectedServers");
            this.toolStripMenuItemPackSelectedServers.Name = "toolStripMenuItemPackSelectedServers";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // refreshSummaryToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshSummaryToolStripMenuItem, "refreshSummaryToolStripMenuItem");
            this.refreshSummaryToolStripMenuItem.Name = "refreshSummaryToolStripMenuItem";
            // 
            // toolStripMenuItemDeleteServers
            // 
            resources.ApplyResources(this.toolStripMenuItemDeleteServers, "toolStripMenuItemDeleteServers");
            this.toolStripMenuItemDeleteServers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDeleteAllServer,
            this.toolStripMenuItemDeleteSelectedServers});
            this.toolStripMenuItemDeleteServers.Name = "toolStripMenuItemDeleteServers";
            // 
            // toolStripMenuItemDeleteAllServer
            // 
            resources.ApplyResources(this.toolStripMenuItemDeleteAllServer, "toolStripMenuItemDeleteAllServer");
            this.toolStripMenuItemDeleteAllServer.Name = "toolStripMenuItemDeleteAllServer";
            // 
            // toolStripMenuItemDeleteSelectedServers
            // 
            resources.ApplyResources(this.toolStripMenuItemDeleteSelectedServers, "toolStripMenuItemDeleteSelectedServers");
            this.toolStripMenuItemDeleteSelectedServers.Name = "toolStripMenuItemDeleteSelectedServers";
            // 
            // systemProxyToolStripMenuItem
            // 
            resources.ApplyResources(this.systemProxyToolStripMenuItem, "systemProxyToolStripMenuItem");
            this.systemProxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemCurrentSysProxy,
            this.copyPACURLToolStripMenuItem,
            this.visitPACDebuggerURLToolStripMenuItem,
            this.toolStripSeparator11,
            this.toolMenuItemClearSysProxy,
            this.startPACServerToolStripMenuItem,
            this.stopPACServerToolStripMenuItem});
            this.systemProxyToolStripMenuItem.Name = "systemProxyToolStripMenuItem";
            // 
            // toolMenuItemCurrentSysProxy
            // 
            resources.ApplyResources(this.toolMenuItemCurrentSysProxy, "toolMenuItemCurrentSysProxy");
            this.toolMenuItemCurrentSysProxy.Name = "toolMenuItemCurrentSysProxy";
            // 
            // copyPACURLToolStripMenuItem
            // 
            resources.ApplyResources(this.copyPACURLToolStripMenuItem, "copyPACURLToolStripMenuItem");
            this.copyPACURLToolStripMenuItem.Name = "copyPACURLToolStripMenuItem";
            // 
            // visitPACDebuggerURLToolStripMenuItem
            // 
            resources.ApplyResources(this.visitPACDebuggerURLToolStripMenuItem, "visitPACDebuggerURLToolStripMenuItem");
            this.visitPACDebuggerURLToolStripMenuItem.Name = "visitPACDebuggerURLToolStripMenuItem";
            // 
            // toolStripSeparator11
            // 
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            // 
            // toolMenuItemClearSysProxy
            // 
            resources.ApplyResources(this.toolMenuItemClearSysProxy, "toolMenuItemClearSysProxy");
            this.toolMenuItemClearSysProxy.Name = "toolMenuItemClearSysProxy";
            // 
            // startPACServerToolStripMenuItem
            // 
            resources.ApplyResources(this.startPACServerToolStripMenuItem, "startPACServerToolStripMenuItem");
            this.startPACServerToolStripMenuItem.Name = "startPACServerToolStripMenuItem";
            // 
            // stopPACServerToolStripMenuItem
            // 
            resources.ApplyResources(this.stopPACServerToolStripMenuItem, "stopPACServerToolStripMenuItem");
            this.stopPACServerToolStripMenuItem.Name = "stopPACServerToolStripMenuItem";
            // 
            // windowToolStripMenuItem
            // 
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemConfigEditor,
            this.toolMenuItemQRCode,
            this.toolMenuItemLog,
            this.toolMenuItemOptions});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            // 
            // toolMenuItemConfigEditor
            // 
            resources.ApplyResources(this.toolMenuItemConfigEditor, "toolMenuItemConfigEditor");
            this.toolMenuItemConfigEditor.Name = "toolMenuItemConfigEditor";
            // 
            // toolMenuItemQRCode
            // 
            resources.ApplyResources(this.toolMenuItemQRCode, "toolMenuItemQRCode");
            this.toolMenuItemQRCode.Name = "toolMenuItemQRCode";
            // 
            // toolMenuItemLog
            // 
            resources.ApplyResources(this.toolMenuItemLog, "toolMenuItemLog");
            this.toolMenuItemLog.Name = "toolMenuItemLog";
            // 
            // toolMenuItemOptions
            // 
            resources.ApplyResources(this.toolMenuItemOptions, "toolMenuItemOptions");
            this.toolMenuItemOptions.Name = "toolMenuItemOptions";
            // 
            // aboutToolStripMenuItem1
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDownLoadV2rayCore,
            this.toolStripMenuItemRemoveV2rayCore,
            this.toolMenuItemCheckUpdate,
            this.toolMenuItemAbout,
            this.toolMenuItemHelp});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            // 
            // toolStripMenuItemDownLoadV2rayCore
            // 
            resources.ApplyResources(this.toolStripMenuItemDownLoadV2rayCore, "toolStripMenuItemDownLoadV2rayCore");
            this.toolStripMenuItemDownLoadV2rayCore.Name = "toolStripMenuItemDownLoadV2rayCore";
            // 
            // toolStripMenuItemRemoveV2rayCore
            // 
            resources.ApplyResources(this.toolStripMenuItemRemoveV2rayCore, "toolStripMenuItemRemoveV2rayCore");
            this.toolStripMenuItemRemoveV2rayCore.Name = "toolStripMenuItemRemoveV2rayCore";
            // 
            // toolMenuItemCheckUpdate
            // 
            resources.ApplyResources(this.toolMenuItemCheckUpdate, "toolMenuItemCheckUpdate");
            this.toolMenuItemCheckUpdate.Name = "toolMenuItemCheckUpdate";
            // 
            // toolMenuItemAbout
            // 
            resources.ApplyResources(this.toolMenuItemAbout, "toolMenuItemAbout");
            this.toolMenuItemAbout.Name = "toolMenuItemAbout";
            // 
            // toolMenuItemHelp
            // 
            resources.ApplyResources(this.toolMenuItemHelp, "toolMenuItemHelp");
            this.toolMenuItemHelp.Name = "toolMenuItemHelp";
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTotal,
            this.toolStripDropDownButtonPager,
            this.toolStripStatusLabelPrePage,
            this.toolStripStatusLabelNextPage});
            this.statusStrip1.Name = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // toolStripStatusLabelTotal
            // 
            resources.ApplyResources(this.toolStripStatusLabelTotal, "toolStripStatusLabelTotal");
            this.toolStripStatusLabelTotal.Name = "toolStripStatusLabelTotal";
            // 
            // toolStripDropDownButtonPager
            // 
            resources.ApplyResources(this.toolStripDropDownButtonPager, "toolStripDropDownButtonPager");
            this.toolStripDropDownButtonPager.Name = "toolStripDropDownButtonPager";
            // 
            // toolStripStatusLabelPrePage
            // 
            resources.ApplyResources(this.toolStripStatusLabelPrePage, "toolStripStatusLabelPrePage");
            this.toolStripStatusLabelPrePage.Name = "toolStripStatusLabelPrePage";
            // 
            // toolStripStatusLabelNextPage
            // 
            resources.ApplyResources(this.toolStripStatusLabelNextPage, "toolStripStatusLabelNextPage");
            this.toolStripStatusLabelNextPage.Name = "toolStripStatusLabelNextPage";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.toolStripContainer2);
            this.panel1.Name = "panel1";
            this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMneuStrip);
            this.MainMenuStrip = this.mainMneuStrip;
            this.Name = "FormMain";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainMneuStrip.ResumeLayout(false);
            this.mainMneuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMneuStrip;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemImportLinkFromClipboard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemConfigEditor;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemQRCode;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemSimAddVmessServer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportAllServerToFile;
        private System.Windows.Forms.ToolStripMenuItem toolMenuItemImportFromFile;
        private ToolStripMenuItem toolMenuItemHelp;
        private ToolStripMenuItem toolMenuItemOptions;
        private FlowLayoutPanel flyServerListContainer;
        private ToolStripMenuItem toolMenuItemServer;
        private ToolStripMenuItem toolStripMenuItemStopSelected;
        private ToolStripMenuItem toolStripMenuItemRestartSelected;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem systemProxyToolStripMenuItem;
        private ToolStripMenuItem toolMenuItemCurrentSysProxy;
        private ToolStripMenuItem toolMenuItemClearSysProxy;
        private ToolStripMenuItem toolStripMenuItemSpeedTestOnSelected;
        private ToolStripMenuItem toolStripMenuItemDeleteServers;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItemCopyAsV2rayLink;
        private ToolStripMenuItem toolStripMenuItemCopyAsVmessLink;
        private ToolStripMenuItem toolStripMenuItemDeleteAllServer;
        private ToolStripMenuItem toolStripMenuItemDeleteSelectedServers;
        private ToolStripMenuItem toolStripMenuItemDownLoadV2rayCore;
        private ToolStripMenuItem toolStripMenuItemRemoveV2rayCore;
        private ToolStripMenuItem toolStripMenuItemCopyAsSubscription;
        private ToolStripMenuItem toolStripMenuItemPackSelectedServers;
        private ToolStripMenuItem toolStripMenuItemModifySelected;
        private ToolStripMenuItem toolStripMenuItemModifySettings;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItemMoveToTop;
        private ToolStripMenuItem toolStripMenuItemMoveToBottom;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItemFoldingPanel;
        private ToolStripMenuItem toolStripMenuItemExpansePanel;
        private ToolStripMenuItem toolStripMenuItemSortBySpeedTest;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemSortBySummary;
        private ToolStripContainer toolStripContainer2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonSelectAllCurPage;
        private ToolStripButton toolStripButtonInverseSelectionCurPage;
        private ToolStripButton toolStripButtonSelectNoneCurPage;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonCollapseSelected;
        private ToolStripButton toolStripButtonExpanSelected;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButtonRestartSelected;
        private ToolStripButton toolStripButtonStopSelected;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButtonModifySelected;
        private ToolStripButton toolStripButtonSortSelectedBySummary;
        private ToolStripButton toolStripButtonSortSelectedBySpeedTestResult;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton toolStripButtonFormOption;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelTotal;
        private Panel panel1;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripLabel toolStripLabelMarkFilter;
        private ToolStripComboBox toolStripComboBoxMarkFilter;
        private ToolStripDropDownButton toolStripDropDownButtonPager;
        private ToolStripStatusLabel toolStripStatusLabelPrePage;
        private ToolStripStatusLabel toolStripStatusLabelNextPage;
        private ToolStripMenuItem currentPageToolStripMenuItem;
        private ToolStripMenuItem selectAllCurPageToolStripMenuItem;
        private ToolStripMenuItem invertSelectionCurPageToolStripMenuItem;
        private ToolStripMenuItem selectNoneCurPageToolStripMenuItem1;
        private ToolStripMenuItem allPagesToolStripMenuItem;
        private ToolStripMenuItem selectAllAllPagesToolStripMenuItem;
        private ToolStripMenuItem invertSelectionAllPagesToolStripMenuItem;
        private ToolStripMenuItem selectNoneAllPagesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectNoSpeedTestAllPagesToolStripMenuItem;
        private ToolStripMenuItem selectTimeoutAllPagesToolStripMenuItem;
        private ToolStripMenuItem selectNoMarkAllPagesToolStripMenuItem;
        private ToolStripMenuItem selectAutorunAllPagesToolStripMenuItem;
        private ToolStripMenuItem selectRunningAllPagesToolStripMenuItem;
        private ToolStripMenuItem allServersToolStripMenuItem;
        private ToolStripMenuItem selectAllAllServersToolStripMenuItem;
        private ToolStripMenuItem invertSelectionAllServersToolStripMenuItem;
        private ToolStripMenuItem selectNoneAllServersToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem selectNoSpeedTestAllServersToolStripMenuItem;
        private ToolStripMenuItem selectTimeoutAllServersToolStripMenuItem;
        private ToolStripMenuItem selectNoMarkAllServersToolStripMenuItem;
        private ToolStripMenuItem selectAutorunAllServersToolStripMenuItem;
        private ToolStripMenuItem selectRunningAllServersToolStripMenuItem;
        private ToolStripMenuItem startPACServerToolStripMenuItem;
        private ToolStripMenuItem stopPACServerToolStripMenuItem;
        private ToolStripMenuItem refreshSummaryToolStripMenuItem;
        private ToolStripMenuItem copyPACURLToolStripMenuItem;
        private ToolStripMenuItem visitPACDebuggerURLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator11;
    }
}
