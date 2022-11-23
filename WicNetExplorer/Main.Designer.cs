﻿namespace WicNetExplorer
{
    partial class Main
    {
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.openRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clearRecentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directXInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honorOrientationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honorColorContextsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDecodableFileExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEncodableFileExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWicComponentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showSystemInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorDebug = new System.Windows.Forms.ToolStripSeparator();
            this.gCCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutWicNetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.openRecentToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.FileToolStripMenuItem_DropDownOpening);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            resources.ApplyResources(this.toolStripMenuItemOpen, "toolStripMenuItemOpen");
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.ToolStripMenuItemOpen_Click);
            // 
            // openRecentToolStripMenuItem
            // 
            this.openRecentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.clearRecentListToolStripMenuItem});
            this.openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            resources.ApplyResources(this.openRecentToolStripMenuItem, "openRecentToolStripMenuItem");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // clearRecentListToolStripMenuItem
            // 
            this.clearRecentListToolStripMenuItem.Name = "clearRecentListToolStripMenuItem";
            resources.ApplyResources(this.clearRecentListToolStripMenuItem, "clearRecentListToolStripMenuItem");
            this.clearRecentListToolStripMenuItem.Click += new System.EventHandler(this.ClearRecentListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.metadataToolStripMenuItem,
            this.directXInfoToolStripMenuItem,
            this.toolStripSeparator7,
            this.openFileLocationToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            resources.ApplyResources(this.imageToolStripMenuItem, "imageToolStripMenuItem");
            this.imageToolStripMenuItem.DropDownOpening += new System.EventHandler(this.ImageToolStripMenuItem_DropDownOpening);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            resources.ApplyResources(this.metadataToolStripMenuItem, "metadataToolStripMenuItem");
            this.metadataToolStripMenuItem.Click += new System.EventHandler(this.MetadataToolStripMenuItem_Click);
            // 
            // directXInfoToolStripMenuItem
            // 
            this.directXInfoToolStripMenuItem.Name = "directXInfoToolStripMenuItem";
            resources.ApplyResources(this.directXInfoToolStripMenuItem, "directXInfoToolStripMenuItem");
            this.directXInfoToolStripMenuItem.Click += new System.EventHandler(this.DirectXInfoToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.honorOrientationToolStripMenuItem,
            this.honorColorContextsToolStripMenuItem,
            this.toolStripSeparator5,
            this.preferencesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.DropDownOpening += new System.EventHandler(this.OptionsToolStripMenuItem_DropDownOpening);
            // 
            // honorOrientationToolStripMenuItem
            // 
            this.honorOrientationToolStripMenuItem.Checked = true;
            this.honorOrientationToolStripMenuItem.CheckOnClick = true;
            this.honorOrientationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.honorOrientationToolStripMenuItem.Name = "honorOrientationToolStripMenuItem";
            resources.ApplyResources(this.honorOrientationToolStripMenuItem, "honorOrientationToolStripMenuItem");
            this.honorOrientationToolStripMenuItem.Click += new System.EventHandler(this.HonorOrientationToolStripMenuItem_Click);
            // 
            // honorColorContextsToolStripMenuItem
            // 
            this.honorColorContextsToolStripMenuItem.Checked = true;
            this.honorColorContextsToolStripMenuItem.CheckOnClick = true;
            this.honorColorContextsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.honorColorContextsToolStripMenuItem.Name = "honorColorContextsToolStripMenuItem";
            resources.ApplyResources(this.honorColorContextsToolStripMenuItem, "honorColorContextsToolStripMenuItem");
            this.honorColorContextsToolStripMenuItem.Click += new System.EventHandler(this.HonorColorContextsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            resources.ApplyResources(this.preferencesToolStripMenuItem, "preferencesToolStripMenuItem");
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDecodableFileExtensionsToolStripMenuItem,
            this.showEncodableFileExtensionsToolStripMenuItem,
            this.showWicComponentsToolStripMenuItem,
            this.toolStripSeparator6,
            this.showSystemInformationToolStripMenuItem,
            this.toolStripSeparatorDebug,
            this.gCCollectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // showDecodableFileExtensionsToolStripMenuItem
            // 
            this.showDecodableFileExtensionsToolStripMenuItem.Name = "showDecodableFileExtensionsToolStripMenuItem";
            resources.ApplyResources(this.showDecodableFileExtensionsToolStripMenuItem, "showDecodableFileExtensionsToolStripMenuItem");
            this.showDecodableFileExtensionsToolStripMenuItem.Click += new System.EventHandler(this.ShowDecodableFileExtensionsToolStripMenuItem_Click);
            // 
            // showEncodableFileExtensionsToolStripMenuItem
            // 
            this.showEncodableFileExtensionsToolStripMenuItem.Name = "showEncodableFileExtensionsToolStripMenuItem";
            resources.ApplyResources(this.showEncodableFileExtensionsToolStripMenuItem, "showEncodableFileExtensionsToolStripMenuItem");
            this.showEncodableFileExtensionsToolStripMenuItem.Click += new System.EventHandler(this.ShowEncodableFileExtensionsToolStripMenuItem_Click);
            // 
            // showWicComponentsToolStripMenuItem
            // 
            this.showWicComponentsToolStripMenuItem.Name = "showWicComponentsToolStripMenuItem";
            resources.ApplyResources(this.showWicComponentsToolStripMenuItem, "showWicComponentsToolStripMenuItem");
            this.showWicComponentsToolStripMenuItem.Click += new System.EventHandler(this.ShowWicComponentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // showSystemInformationToolStripMenuItem
            // 
            this.showSystemInformationToolStripMenuItem.Name = "showSystemInformationToolStripMenuItem";
            resources.ApplyResources(this.showSystemInformationToolStripMenuItem, "showSystemInformationToolStripMenuItem");
            this.showSystemInformationToolStripMenuItem.Click += new System.EventHandler(this.ShowSystemInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparatorDebug
            // 
            this.toolStripSeparatorDebug.Name = "toolStripSeparatorDebug";
            resources.ApplyResources(this.toolStripSeparatorDebug, "toolStripSeparatorDebug");
            // 
            // gCCollectToolStripMenuItem
            // 
            this.gCCollectToolStripMenuItem.Name = "gCCollectToolStripMenuItem";
            resources.ApplyResources(this.gCCollectToolStripMenuItem, "gCCollectToolStripMenuItem");
            this.gCCollectToolStripMenuItem.Click += new System.EventHandler(this.GCCollectToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontallyToolStripMenuItem,
            this.tileVerticallyToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            resources.ApplyResources(this.windowToolStripMenuItem, "windowToolStripMenuItem");
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            resources.ApplyResources(this.cascadeToolStripMenuItem, "cascadeToolStripMenuItem");
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileHorizontallyToolStripMenuItem
            // 
            this.tileHorizontallyToolStripMenuItem.Name = "tileHorizontallyToolStripMenuItem";
            resources.ApplyResources(this.tileHorizontallyToolStripMenuItem, "tileHorizontallyToolStripMenuItem");
            this.tileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontallyToolStripMenuItem_Click);
            // 
            // tileVerticallyToolStripMenuItem
            // 
            this.tileVerticallyToolStripMenuItem.Name = "tileVerticallyToolStripMenuItem";
            resources.ApplyResources(this.tileVerticallyToolStripMenuItem, "tileVerticallyToolStripMenuItem");
            this.tileVerticallyToolStripMenuItem.Click += new System.EventHandler(this.TileVerticallyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutWicNetExplorerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutWicNetExplorerToolStripMenuItem
            // 
            this.aboutWicNetExplorerToolStripMenuItem.Name = "aboutWicNetExplorerToolStripMenuItem";
            resources.ApplyResources(this.aboutWicNetExplorerToolStripMenuItem, "aboutWicNetExplorerToolStripMenuItem");
            this.aboutWicNetExplorerToolStripMenuItem.Click += new System.EventHandler(this.AboutWicNetExplorerToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            resources.ApplyResources(this.openFileLocationToolStripMenuItem, "openFileLocationToolStripMenuItem");
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.OpenFileLocationToolStripMenuItem_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gCCollectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRecentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honorOrientationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honorColorContextsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWicComponentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorDebug;
        private System.Windows.Forms.ToolStripMenuItem showDecodableFileExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEncodableFileExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWicNetExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showSystemInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directXInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
    }
}