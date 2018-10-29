namespace FSPM
{
    partial class window_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.contextMenu_Root = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_AddServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ImportPermissions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LoadProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SaveProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SaveProfileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_RecentFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_RemovePermissions = new System.Windows.Forms.CheckBox();
            this.button_ApplyPermissions = new System.Windows.Forms.Button();
            this.contextMenu_Server = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_AddShare = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_DeleteServer = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_Rename1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Share = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_AddDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_AddMultiDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_DeleteShare = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_Rename2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_Directory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_AddDirectory2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_AddMultiDirectory2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_ConvertDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_DeleteDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_Rename3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_MultiDirectory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_AddDirectory3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_AddMultiDirectory3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_ConvertMultiDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_DeleteMultiDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_Rename4 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_RegexPattern = new System.Windows.Forms.TextBox();
            this.label_RegexFilter = new System.Windows.Forms.Label();
            this.label_RegexState = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Share = new System.Windows.Forms.TabPage();
            this.tabPage_NTFS = new System.Windows.Forms.TabPage();
            this.contextMenu_Root.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenu_Server.SuspendLayout();
            this.contextMenu_Share.SuspendLayout();
            this.contextMenu_Directory.SuspendLayout();
            this.contextMenu_MultiDirectory.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(12, 27);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(316, 397);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.treeView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TreeView_KeyUp);
            this.treeView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseUp);
            // 
            // contextMenu_Root
            // 
            this.contextMenu_Root.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_AddServer});
            this.contextMenu_Root.Name = "contextMenuStrip1";
            this.contextMenu_Root.Size = new System.Drawing.Size(132, 26);
            // 
            // contextMenuItem_AddServer
            // 
            this.contextMenuItem_AddServer.Name = "contextMenuItem_AddServer";
            this.contextMenuItem_AddServer.Size = new System.Drawing.Size(131, 22);
            this.contextMenuItem_AddServer.Text = "Add Server";
            this.contextMenuItem_AddServer.Click += new System.EventHandler(this.ContextMenuItem_AddServer_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(659, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_ImportPermissions,
            this.menuItem_LoadProfile,
            this.menuItem_SaveProfile,
            this.menuItem_SaveProfileAs,
            this.toolStripSeparator1,
            this.menuItem_RecentFiles});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "File";
            // 
            // menuItem_ImportPermissions
            // 
            this.menuItem_ImportPermissions.Name = "menuItem_ImportPermissions";
            this.menuItem_ImportPermissions.Size = new System.Drawing.Size(228, 22);
            this.menuItem_ImportPermissions.Text = "Import Existing Permissions...";
            this.menuItem_ImportPermissions.Click += new System.EventHandler(this.MenuItem_ImportPermissions_Click);
            // 
            // menuItem_LoadProfile
            // 
            this.menuItem_LoadProfile.Name = "menuItem_LoadProfile";
            this.menuItem_LoadProfile.Size = new System.Drawing.Size(228, 22);
            this.menuItem_LoadProfile.Text = "Load Profile";
            this.menuItem_LoadProfile.Click += new System.EventHandler(this.MenuItem_LoadProfile_Click);
            // 
            // menuItem_SaveProfile
            // 
            this.menuItem_SaveProfile.Name = "menuItem_SaveProfile";
            this.menuItem_SaveProfile.Size = new System.Drawing.Size(228, 22);
            this.menuItem_SaveProfile.Text = "Save Profile";
            this.menuItem_SaveProfile.Click += new System.EventHandler(this.MenuItem_SaveProfile_Click);
            // 
            // menuItem_SaveProfileAs
            // 
            this.menuItem_SaveProfileAs.Name = "menuItem_SaveProfileAs";
            this.menuItem_SaveProfileAs.Size = new System.Drawing.Size(228, 22);
            this.menuItem_SaveProfileAs.Text = "Save Profile As...";
            this.menuItem_SaveProfileAs.Click += new System.EventHandler(this.MenuItem_SaveProfileAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // menuItem_RecentFiles
            // 
            this.menuItem_RecentFiles.Name = "menuItem_RecentFiles";
            this.menuItem_RecentFiles.Padding = new System.Windows.Forms.Padding(0);
            this.menuItem_RecentFiles.Size = new System.Drawing.Size(228, 20);
            this.menuItem_RecentFiles.Text = "Recent Files";
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_About});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(44, 20);
            this.menu_Help.Text = "Help";
            // 
            // menuItem_About
            // 
            this.menuItem_About.Name = "menuItem_About";
            this.menuItem_About.Size = new System.Drawing.Size(107, 22);
            this.menuItem_About.Text = "About";
            this.menuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // checkBox_RemovePermissions
            // 
            this.checkBox_RemovePermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_RemovePermissions.AutoSize = true;
            this.checkBox_RemovePermissions.Location = new System.Drawing.Point(336, 405);
            this.checkBox_RemovePermissions.Name = "checkBox_RemovePermissions";
            this.checkBox_RemovePermissions.Size = new System.Drawing.Size(190, 17);
            this.checkBox_RemovePermissions.TabIndex = 4;
            this.checkBox_RemovePermissions.Text = "Remove non-matching permissions";
            this.checkBox_RemovePermissions.UseVisualStyleBackColor = true;
            // 
            // button_ApplyPermissions
            // 
            this.button_ApplyPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ApplyPermissions.Location = new System.Drawing.Point(532, 401);
            this.button_ApplyPermissions.Name = "button_ApplyPermissions";
            this.button_ApplyPermissions.Size = new System.Drawing.Size(120, 23);
            this.button_ApplyPermissions.TabIndex = 5;
            this.button_ApplyPermissions.Text = "Apply Permissions";
            this.button_ApplyPermissions.UseVisualStyleBackColor = true;
            // 
            // contextMenu_Server
            // 
            this.contextMenu_Server.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_AddShare,
            this.contextMenuItem_DeleteServer,
            this.contextMenuItem_Rename1});
            this.contextMenu_Server.Name = "contextMenu_Server";
            this.contextMenu_Server.Size = new System.Drawing.Size(153, 70);
            // 
            // contextMenuItem_AddShare
            // 
            this.contextMenuItem_AddShare.Name = "contextMenuItem_AddShare";
            this.contextMenuItem_AddShare.Size = new System.Drawing.Size(152, 22);
            this.contextMenuItem_AddShare.Text = "Add Share";
            this.contextMenuItem_AddShare.Click += new System.EventHandler(this.ContextMenuItem_AddShare_Click);
            // 
            // contextMenuItem_DeleteServer
            // 
            this.contextMenuItem_DeleteServer.Name = "contextMenuItem_DeleteServer";
            this.contextMenuItem_DeleteServer.Size = new System.Drawing.Size(152, 22);
            this.contextMenuItem_DeleteServer.Text = "Delete Server";
            this.contextMenuItem_DeleteServer.Click += new System.EventHandler(this.ContextMenuItem_Delete_Click);
            // 
            // contextMenuItem_Rename1
            // 
            this.contextMenuItem_Rename1.Name = "contextMenuItem_Rename1";
            this.contextMenuItem_Rename1.Size = new System.Drawing.Size(152, 22);
            this.contextMenuItem_Rename1.Text = "Rename Server";
            this.contextMenuItem_Rename1.Click += new System.EventHandler(this.ContextMenuItem_Rename_Click);
            // 
            // contextMenu_Share
            // 
            this.contextMenu_Share.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_AddDirectory,
            this.contextMenuItem_AddMultiDirectory,
            this.contextMenuItem_DeleteShare,
            this.contextMenuItem_Rename2});
            this.contextMenu_Share.Name = "contextMenu_Share";
            this.contextMenu_Share.Size = new System.Drawing.Size(181, 92);
            // 
            // contextMenuItem_AddDirectory
            // 
            this.contextMenuItem_AddDirectory.Name = "contextMenuItem_AddDirectory";
            this.contextMenuItem_AddDirectory.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem_AddDirectory.Text = "Add Directory";
            this.contextMenuItem_AddDirectory.Click += new System.EventHandler(this.ContextMenuItem_AddDirectory_Click);
            // 
            // contextMenuItem_AddMultiDirectory
            // 
            this.contextMenuItem_AddMultiDirectory.Name = "contextMenuItem_AddMultiDirectory";
            this.contextMenuItem_AddMultiDirectory.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem_AddMultiDirectory.Text = "Add Multi-Directory";
            this.contextMenuItem_AddMultiDirectory.Click += new System.EventHandler(this.ContextMenuItem_AddMultiDirectory_Click);
            // 
            // contextMenuItem_DeleteShare
            // 
            this.contextMenuItem_DeleteShare.Name = "contextMenuItem_DeleteShare";
            this.contextMenuItem_DeleteShare.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem_DeleteShare.Text = "Delete Share";
            this.contextMenuItem_DeleteShare.Click += new System.EventHandler(this.ContextMenuItem_Delete_Click);
            // 
            // contextMenuItem_Rename2
            // 
            this.contextMenuItem_Rename2.Name = "contextMenuItem_Rename2";
            this.contextMenuItem_Rename2.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItem_Rename2.Text = "Rename Share";
            this.contextMenuItem_Rename2.Click += new System.EventHandler(this.ContextMenuItem_Rename_Click);
            // 
            // contextMenu_Directory
            // 
            this.contextMenu_Directory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_AddDirectory2,
            this.contextMenuItem_AddMultiDirectory2,
            this.contextMenuItem_ConvertDirectory,
            this.contextMenuItem_DeleteDirectory,
            this.contextMenuItem_Rename3});
            this.contextMenu_Directory.Name = "contextMenu_Directory";
            this.contextMenu_Directory.Size = new System.Drawing.Size(212, 114);
            // 
            // contextMenuItem_AddDirectory2
            // 
            this.contextMenuItem_AddDirectory2.Name = "contextMenuItem_AddDirectory2";
            this.contextMenuItem_AddDirectory2.Size = new System.Drawing.Size(211, 22);
            this.contextMenuItem_AddDirectory2.Text = "Add Directory";
            this.contextMenuItem_AddDirectory2.Click += new System.EventHandler(this.ContextMenuItem_AddDirectory_Click);
            // 
            // contextMenuItem_AddMultiDirectory2
            // 
            this.contextMenuItem_AddMultiDirectory2.Name = "contextMenuItem_AddMultiDirectory2";
            this.contextMenuItem_AddMultiDirectory2.Size = new System.Drawing.Size(211, 22);
            this.contextMenuItem_AddMultiDirectory2.Text = "Add Multi-Directory";
            this.contextMenuItem_AddMultiDirectory2.Click += new System.EventHandler(this.ContextMenuItem_AddMultiDirectory_Click);
            // 
            // contextMenuItem_ConvertDirectory
            // 
            this.contextMenuItem_ConvertDirectory.Name = "contextMenuItem_ConvertDirectory";
            this.contextMenuItem_ConvertDirectory.Size = new System.Drawing.Size(211, 22);
            this.contextMenuItem_ConvertDirectory.Text = "Convert To MultiDirectory";
            this.contextMenuItem_ConvertDirectory.Click += new System.EventHandler(this.ContextMenuItem_ConvertDirectory_Click);
            // 
            // contextMenuItem_DeleteDirectory
            // 
            this.contextMenuItem_DeleteDirectory.Name = "contextMenuItem_DeleteDirectory";
            this.contextMenuItem_DeleteDirectory.Size = new System.Drawing.Size(211, 22);
            this.contextMenuItem_DeleteDirectory.Text = "Delete Directory";
            this.contextMenuItem_DeleteDirectory.Click += new System.EventHandler(this.ContextMenuItem_Delete_Click);
            // 
            // contextMenuItem_Rename3
            // 
            this.contextMenuItem_Rename3.Name = "contextMenuItem_Rename3";
            this.contextMenuItem_Rename3.Size = new System.Drawing.Size(211, 22);
            this.contextMenuItem_Rename3.Text = "Rename Directory";
            this.contextMenuItem_Rename3.Click += new System.EventHandler(this.ContextMenuItem_Rename_Click);
            // 
            // contextMenu_MultiDirectory
            // 
            this.contextMenu_MultiDirectory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_AddDirectory3,
            this.contextMenuItem_AddMultiDirectory3,
            this.contextMenuItem_ConvertMultiDirectory,
            this.contextMenuItem_DeleteMultiDirectory,
            this.contextMenuItem_Rename4});
            this.contextMenu_MultiDirectory.Name = "contextMenu_MultiDirectory";
            this.contextMenu_MultiDirectory.Size = new System.Drawing.Size(192, 114);
            // 
            // contextMenuItem_AddDirectory3
            // 
            this.contextMenuItem_AddDirectory3.Name = "contextMenuItem_AddDirectory3";
            this.contextMenuItem_AddDirectory3.Size = new System.Drawing.Size(191, 22);
            this.contextMenuItem_AddDirectory3.Text = "Add Directory";
            this.contextMenuItem_AddDirectory3.Click += new System.EventHandler(this.ContextMenuItem_AddDirectory_Click);
            // 
            // contextMenuItem_AddMultiDirectory3
            // 
            this.contextMenuItem_AddMultiDirectory3.Name = "contextMenuItem_AddMultiDirectory3";
            this.contextMenuItem_AddMultiDirectory3.Size = new System.Drawing.Size(191, 22);
            this.contextMenuItem_AddMultiDirectory3.Text = "Add Multi-Directory";
            this.contextMenuItem_AddMultiDirectory3.Click += new System.EventHandler(this.ContextMenuItem_AddMultiDirectory_Click);
            // 
            // contextMenuItem_ConvertMultiDirectory
            // 
            this.contextMenuItem_ConvertMultiDirectory.Name = "contextMenuItem_ConvertMultiDirectory";
            this.contextMenuItem_ConvertMultiDirectory.Size = new System.Drawing.Size(191, 22);
            this.contextMenuItem_ConvertMultiDirectory.Text = "Convert To Directory";
            this.contextMenuItem_ConvertMultiDirectory.Click += new System.EventHandler(this.ContextMenuItem_ConvertMultiDirectory_Click);
            // 
            // contextMenuItem_DeleteMultiDirectory
            // 
            this.contextMenuItem_DeleteMultiDirectory.Name = "contextMenuItem_DeleteMultiDirectory";
            this.contextMenuItem_DeleteMultiDirectory.Size = new System.Drawing.Size(191, 22);
            this.contextMenuItem_DeleteMultiDirectory.Text = "Delete Multi-Directory";
            this.contextMenuItem_DeleteMultiDirectory.Click += new System.EventHandler(this.ContextMenuItem_Delete_Click);
            // 
            // contextMenuItem_Rename4
            // 
            this.contextMenuItem_Rename4.Name = "contextMenuItem_Rename4";
            this.contextMenuItem_Rename4.Size = new System.Drawing.Size(191, 22);
            this.contextMenuItem_Rename4.Text = "Rename Directory";
            this.contextMenuItem_Rename4.Click += new System.EventHandler(this.ContextMenuItem_Rename_Click);
            // 
            // textBox_RegexPattern
            // 
            this.textBox_RegexPattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RegexPattern.Location = new System.Drawing.Point(337, 63);
            this.textBox_RegexPattern.Name = "textBox_RegexPattern";
            this.textBox_RegexPattern.Size = new System.Drawing.Size(274, 20);
            this.textBox_RegexPattern.TabIndex = 2;
            this.textBox_RegexPattern.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_RegexPattern_KeyUp);
            // 
            // label_RegexFilter
            // 
            this.label_RegexFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RegexFilter.AutoSize = true;
            this.label_RegexFilter.Location = new System.Drawing.Point(334, 47);
            this.label_RegexFilter.Name = "label_RegexFilter";
            this.label_RegexFilter.Size = new System.Drawing.Size(136, 13);
            this.label_RegexFilter.TabIndex = 9;
            this.label_RegexFilter.Text = "Multi-Directory Regex Filter:";
            // 
            // label_RegexState
            // 
            this.label_RegexState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RegexState.AutoSize = true;
            this.label_RegexState.ForeColor = System.Drawing.Color.Black;
            this.label_RegexState.Location = new System.Drawing.Point(613, 66);
            this.label_RegexState.Name = "label_RegexState";
            this.label_RegexState.Size = new System.Drawing.Size(30, 13);
            this.label_RegexState.TabIndex = 10;
            this.label_RegexState.Text = "Valid";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(378, 24);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(269, 20);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Name_KeyDown);
            this.textBox_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Name_KeyUp);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_Share);
            this.tabControl.Controls.Add(this.tabPage_NTFS);
            this.tabControl.Location = new System.Drawing.Point(337, 89);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(310, 310);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage_Share
            // 
            this.tabPage_Share.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Share.Name = "tabPage_Share";
            this.tabPage_Share.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Share.Size = new System.Drawing.Size(302, 284);
            this.tabPage_Share.TabIndex = 0;
            this.tabPage_Share.Text = "Share Permissions";
            this.tabPage_Share.UseVisualStyleBackColor = true;
            // 
            // tabPage_NTFS
            // 
            this.tabPage_NTFS.Location = new System.Drawing.Point(4, 22);
            this.tabPage_NTFS.Name = "tabPage_NTFS";
            this.tabPage_NTFS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NTFS.Size = new System.Drawing.Size(302, 284);
            this.tabPage_NTFS.TabIndex = 1;
            this.tabPage_NTFS.Text = "NTFS Permissions";
            this.tabPage_NTFS.UseVisualStyleBackColor = true;
            // 
            // window_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 436);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_RegexState);
            this.Controls.Add(this.label_RegexFilter);
            this.Controls.Add(this.textBox_RegexPattern);
            this.Controls.Add(this.button_ApplyPermissions);
            this.Controls.Add(this.checkBox_RemovePermissions);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(515, 340);
            this.Name = "window_Main";
            this.Text = "File Server Permissions Manger";
            this.contextMenu_Root.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenu_Server.ResumeLayout(false);
            this.contextMenu_Share.ResumeLayout(false);
            this.contextMenu_Directory.ResumeLayout(false);
            this.contextMenu_MultiDirectory.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.CheckBox checkBox_RemovePermissions;
        private System.Windows.Forms.Button button_ApplyPermissions;
        private System.Windows.Forms.ToolStripMenuItem menuItem_RecentFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Root;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Server;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Share;
        private System.Windows.Forms.ContextMenuStrip contextMenu_Directory;
        private System.Windows.Forms.ContextMenuStrip contextMenu_MultiDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddServer;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ImportPermissions;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LoadProfile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SaveProfile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SaveProfileAs;
        private System.Windows.Forms.ToolStripMenuItem menuItem_About;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddShare;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddMultiDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddDirectory2;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_ConvertDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddDirectory3;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_ConvertMultiDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddMultiDirectory2;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_AddMultiDirectory3;
        private System.Windows.Forms.TextBox textBox_RegexPattern;
        private System.Windows.Forms.Label label_RegexFilter;
        private System.Windows.Forms.Label label_RegexState;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_Rename1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_Rename2;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_Rename3;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_Rename4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Share;
        private System.Windows.Forms.TabPage tabPage_NTFS;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_DeleteServer;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_DeleteShare;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_DeleteMultiDirectory;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItem_DeleteDirectory;
    }
}

