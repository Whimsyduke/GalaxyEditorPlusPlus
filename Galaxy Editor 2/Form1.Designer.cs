using FarsiLibrary.Win;
using Galaxy_Editor_2.Editor_control;

namespace Galaxy_Editor_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.projectViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.objectBrowserSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ObjectBrowserPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mapObjectBrowserPage = new System.Windows.Forms.TabPage();
            this.ObjectBrowserList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ObjectBrowserCatagory = new System.Windows.Forms.ToolStripComboBox();
            this.TBRefreshObjectList = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UnitFilterGrid = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBUnitFilterCompress = new System.Windows.Forms.CheckBox();
            this.BTNUnitFilterReset = new System.Windows.Forms.Button();
            this.BTNUnitFilterInsert = new System.Windows.Forms.Button();
            this.messageViewImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBShowWarnings = new System.Windows.Forms.CheckBox();
            this.CBShowErrors = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapObjectBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAndCopyToMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAndSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAndSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectViewProjectMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.compilerStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TBNewProject = new System.Windows.Forms.ToolStripButton();
            this.TBNewFile = new System.Windows.Forms.ToolStripButton();
            this.TBNewFolder = new System.Windows.Forms.ToolStripButton();
            this.TBDelete = new System.Windows.Forms.ToolStripButton();
            this.TBSave = new System.Windows.Forms.ToolStripButton();
            this.TBSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TBCut = new System.Windows.Forms.ToolStripButton();
            this.TBCopy = new System.Windows.Forms.ToolStripButton();
            this.TBPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TBUndo = new System.Windows.Forms.ToolStripButton();
            this.TBRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TBRun = new System.Windows.Forms.ToolStripSplitButton();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TBFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.TBComment = new System.Windows.Forms.ToolStripButton();
            this.TBUncomment = new System.Windows.Forms.ToolStripButton();
            this.editorRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClickCut = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.RightClickFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSInsertConstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.goToDeclarationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectBrowserTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.projectView = new Galaxy_Editor_2.TreeViewDragDrop();
            this.tabStrip = new FarsiLibrary.Win.FATabStrip();
            this.messageView = new Galaxy_Editor_2.TreeViewDragDrop();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectBrowserSplitContainer)).BeginInit();
            this.objectBrowserSplitContainer.Panel1.SuspendLayout();
            this.objectBrowserSplitContainer.Panel2.SuspendLayout();
            this.objectBrowserSplitContainer.SuspendLayout();
            this.ObjectBrowserPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mapObjectBrowserPage.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.projectViewMenu.SuspendLayout();
            this.projectViewProjectMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.editorRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.projectView);
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // projectViewImageList
            // 
            this.projectViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("projectViewImageList.ImageStream")));
            this.projectViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.projectViewImageList.Images.SetKeyName(0, "icon.ico");
            this.projectViewImageList.Images.SetKeyName(1, "Folder.png");
            this.projectViewImageList.Images.SetKeyName(2, "GalaxyFileV3-16.png");
            this.projectViewImageList.Images.SetKeyName(3, "XMLIcon.ico");
            this.projectViewImageList.Images.SetKeyName(4, "");
            this.projectViewImageList.Images.SetKeyName(5, "DialogIcon.png");
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.objectBrowserSplitContainer);
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer2.Panel1, resources.GetString("splitContainer2.Panel1.ToolTip"));
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.messageView);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer2.Panel2, resources.GetString("splitContainer2.Panel2.ToolTip"));
            this.ObjectBrowserTooltip.SetToolTip(this.splitContainer2, resources.GetString("splitContainer2.ToolTip"));
            // 
            // objectBrowserSplitContainer
            // 
            resources.ApplyResources(this.objectBrowserSplitContainer, "objectBrowserSplitContainer");
            this.objectBrowserSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.objectBrowserSplitContainer.Name = "objectBrowserSplitContainer";
            // 
            // objectBrowserSplitContainer.Panel1
            // 
            resources.ApplyResources(this.objectBrowserSplitContainer.Panel1, "objectBrowserSplitContainer.Panel1");
            this.objectBrowserSplitContainer.Panel1.Controls.Add(this.tabStrip);
            this.ObjectBrowserTooltip.SetToolTip(this.objectBrowserSplitContainer.Panel1, resources.GetString("objectBrowserSplitContainer.Panel1.ToolTip"));
            // 
            // objectBrowserSplitContainer.Panel2
            // 
            resources.ApplyResources(this.objectBrowserSplitContainer.Panel2, "objectBrowserSplitContainer.Panel2");
            this.objectBrowserSplitContainer.Panel2.Controls.Add(this.ObjectBrowserPanel);
            this.ObjectBrowserTooltip.SetToolTip(this.objectBrowserSplitContainer.Panel2, resources.GetString("objectBrowserSplitContainer.Panel2.ToolTip"));
            this.ObjectBrowserTooltip.SetToolTip(this.objectBrowserSplitContainer, resources.GetString("objectBrowserSplitContainer.ToolTip"));
            // 
            // ObjectBrowserPanel
            // 
            resources.ApplyResources(this.ObjectBrowserPanel, "ObjectBrowserPanel");
            this.ObjectBrowserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectBrowserPanel.Controls.Add(this.tabControl1);
            this.ObjectBrowserPanel.Name = "ObjectBrowserPanel";
            this.ObjectBrowserTooltip.SetToolTip(this.ObjectBrowserPanel, resources.GetString("ObjectBrowserPanel.ToolTip"));
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.mapObjectBrowserPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.ObjectBrowserTooltip.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // mapObjectBrowserPage
            // 
            resources.ApplyResources(this.mapObjectBrowserPage, "mapObjectBrowserPage");
            this.mapObjectBrowserPage.BackColor = System.Drawing.SystemColors.Control;
            this.mapObjectBrowserPage.Controls.Add(this.ObjectBrowserList);
            this.mapObjectBrowserPage.Controls.Add(this.toolStrip2);
            this.mapObjectBrowserPage.Name = "mapObjectBrowserPage";
            this.ObjectBrowserTooltip.SetToolTip(this.mapObjectBrowserPage, resources.GetString("mapObjectBrowserPage.ToolTip"));
            // 
            // ObjectBrowserList
            // 
            resources.ApplyResources(this.ObjectBrowserList, "ObjectBrowserList");
            this.ObjectBrowserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ObjectBrowserList.MultiSelect = false;
            this.ObjectBrowserList.Name = "ObjectBrowserList";
            this.ObjectBrowserTooltip.SetToolTip(this.ObjectBrowserList, resources.GetString("ObjectBrowserList.ToolTip"));
            this.ObjectBrowserList.UseCompatibleStateImageBehavior = false;
            this.ObjectBrowserList.View = System.Windows.Forms.View.Details;
            this.ObjectBrowserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ObjectBrowserList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ObjectBrowserCatagory,
            this.TBRefreshObjectList});
            this.toolStrip2.Name = "toolStrip2";
            this.ObjectBrowserTooltip.SetToolTip(this.toolStrip2, resources.GetString("toolStrip2.ToolTip"));
            // 
            // ObjectBrowserCatagory
            // 
            resources.ApplyResources(this.ObjectBrowserCatagory, "ObjectBrowserCatagory");
            this.ObjectBrowserCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectBrowserCatagory.Name = "ObjectBrowserCatagory";
            this.ObjectBrowserCatagory.SelectedIndexChanged += new System.EventHandler(this.ObjectBrowserCatagory_SelectedIndexChanged);
            // 
            // TBRefreshObjectList
            // 
            resources.ApplyResources(this.TBRefreshObjectList, "TBRefreshObjectList");
            this.TBRefreshObjectList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBRefreshObjectList.Name = "TBRefreshObjectList";
            this.TBRefreshObjectList.Click += new System.EventHandler(this.TBRefreshObjectList_Click);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.UnitFilterGrid);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Name = "tabPage2";
            this.ObjectBrowserTooltip.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            // 
            // UnitFilterGrid
            // 
            resources.ApplyResources(this.UnitFilterGrid, "UnitFilterGrid");
            this.UnitFilterGrid.Name = "UnitFilterGrid";
            this.UnitFilterGrid.ToolbarVisible = false;
            this.ObjectBrowserTooltip.SetToolTip(this.UnitFilterGrid, resources.GetString("UnitFilterGrid.ToolTip"));
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.CBUnitFilterCompress);
            this.panel2.Controls.Add(this.BTNUnitFilterReset);
            this.panel2.Controls.Add(this.BTNUnitFilterInsert);
            this.panel2.Name = "panel2";
            this.ObjectBrowserTooltip.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // CBUnitFilterCompress
            // 
            resources.ApplyResources(this.CBUnitFilterCompress, "CBUnitFilterCompress");
            this.CBUnitFilterCompress.Name = "CBUnitFilterCompress";
            this.ObjectBrowserTooltip.SetToolTip(this.CBUnitFilterCompress, resources.GetString("CBUnitFilterCompress.ToolTip"));
            this.CBUnitFilterCompress.UseVisualStyleBackColor = true;
            // 
            // BTNUnitFilterReset
            // 
            resources.ApplyResources(this.BTNUnitFilterReset, "BTNUnitFilterReset");
            this.BTNUnitFilterReset.Name = "BTNUnitFilterReset";
            this.ObjectBrowserTooltip.SetToolTip(this.BTNUnitFilterReset, resources.GetString("BTNUnitFilterReset.ToolTip"));
            this.BTNUnitFilterReset.UseVisualStyleBackColor = true;
            this.BTNUnitFilterReset.Click += new System.EventHandler(this.BTNUnitFilterReset_Click);
            // 
            // BTNUnitFilterInsert
            // 
            resources.ApplyResources(this.BTNUnitFilterInsert, "BTNUnitFilterInsert");
            this.BTNUnitFilterInsert.Name = "BTNUnitFilterInsert";
            this.ObjectBrowserTooltip.SetToolTip(this.BTNUnitFilterInsert, resources.GetString("BTNUnitFilterInsert.ToolTip"));
            this.BTNUnitFilterInsert.UseVisualStyleBackColor = true;
            this.BTNUnitFilterInsert.Click += new System.EventHandler(this.BTNUnitFilterInsert_Click);
            // 
            // messageViewImageList
            // 
            this.messageViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("messageViewImageList.ImageStream")));
            this.messageViewImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.messageViewImageList.Images.SetKeyName(0, "Error.bmp");
            this.messageViewImageList.Images.SetKeyName(1, "Warning.bmp");
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.CBShowWarnings);
            this.panel1.Controls.Add(this.CBShowErrors);
            this.panel1.Name = "panel1";
            this.ObjectBrowserTooltip.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
            // 
            // CBShowWarnings
            // 
            resources.ApplyResources(this.CBShowWarnings, "CBShowWarnings");
            this.CBShowWarnings.Name = "CBShowWarnings";
            this.ObjectBrowserTooltip.SetToolTip(this.CBShowWarnings, resources.GetString("CBShowWarnings.ToolTip"));
            this.CBShowWarnings.UseVisualStyleBackColor = true;
            this.CBShowWarnings.CheckedChanged += new System.EventHandler(this.CBShowWarnings_CheckedChanged);
            // 
            // CBShowErrors
            // 
            resources.ApplyResources(this.CBShowErrors, "CBShowErrors");
            this.CBShowErrors.Name = "CBShowErrors";
            this.ObjectBrowserTooltip.SetToolTip(this.CBShowErrors, resources.GetString("CBShowErrors.ToolTip"));
            this.CBShowErrors.UseVisualStyleBackColor = true;
            this.CBShowErrors.CheckedChanged += new System.EventHandler(this.CBShowErrors_CheckedChanged);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.buildToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.LanguageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.ObjectBrowserTooltip.SetToolTip(this.menuStrip1, resources.GetString("menuStrip1.ToolTip"));
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.openExistingProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.closeProjectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // newToolStripMenuItem
            // 
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.sourceFileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            // 
            // projectToolStripMenuItem
            // 
            resources.ApplyResources(this.projectToolStripMenuItem, "projectToolStripMenuItem");
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // sourceFileToolStripMenuItem
            // 
            resources.ApplyResources(this.sourceFileToolStripMenuItem, "sourceFileToolStripMenuItem");
            this.sourceFileToolStripMenuItem.Name = "sourceFileToolStripMenuItem";
            this.sourceFileToolStripMenuItem.Click += new System.EventHandler(this.sourceFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAllToolStripMenuItem, "saveAllToolStripMenuItem");
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // openExistingProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.openExistingProjectToolStripMenuItem, "openExistingProjectToolStripMenuItem");
            this.openExistingProjectToolStripMenuItem.Name = "openExistingProjectToolStripMenuItem";
            this.openExistingProjectToolStripMenuItem.Click += new System.EventHandler(this.openExistingProjectToolStripMenuItem_Click);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveProjectAsToolStripMenuItem, "saveProjectAsToolStripMenuItem");
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Click += new System.EventHandler(this.saveProjectAsToolStripMenuItem_Click);
            // 
            // closeProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.closeProjectToolStripMenuItem, "closeProjectToolStripMenuItem");
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapObjectBrowserToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // mapObjectBrowserToolStripMenuItem
            // 
            resources.ApplyResources(this.mapObjectBrowserToolStripMenuItem, "mapObjectBrowserToolStripMenuItem");
            this.mapObjectBrowserToolStripMenuItem.Checked = true;
            this.mapObjectBrowserToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mapObjectBrowserToolStripMenuItem.Name = "mapObjectBrowserToolStripMenuItem";
            this.mapObjectBrowserToolStripMenuItem.Click += new System.EventHandler(this.mapObjectBrowserToolStripMenuItem_Click);
            // 
            // buildToolStripMenuItem
            // 
            resources.ApplyResources(this.buildToolStripMenuItem, "buildToolStripMenuItem");
            this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileAndCopyToMapToolStripMenuItem,
            this.compileAndSaveToolStripMenuItem,
            this.compileAndSaveAsToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
            // 
            // compileAndCopyToMapToolStripMenuItem
            // 
            resources.ApplyResources(this.compileAndCopyToMapToolStripMenuItem, "compileAndCopyToMapToolStripMenuItem");
            this.compileAndCopyToMapToolStripMenuItem.Name = "compileAndCopyToMapToolStripMenuItem";
            this.compileAndCopyToMapToolStripMenuItem.Click += new System.EventHandler(this.compileAndCopyToMapToolStripMenuItem_Click);
            // 
            // compileAndSaveToolStripMenuItem
            // 
            resources.ApplyResources(this.compileAndSaveToolStripMenuItem, "compileAndSaveToolStripMenuItem");
            this.compileAndSaveToolStripMenuItem.Name = "compileAndSaveToolStripMenuItem";
            this.compileAndSaveToolStripMenuItem.Click += new System.EventHandler(this.compileAndSaveToolStripMenuItem_Click);
            // 
            // compileAndSaveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.compileAndSaveAsToolStripMenuItem, "compileAndSaveAsToolStripMenuItem");
            this.compileAndSaveAsToolStripMenuItem.Name = "compileAndSaveAsToolStripMenuItem";
            this.compileAndSaveAsToolStripMenuItem.Click += new System.EventHandler(this.compileAndSaveAsToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            resources.ApplyResources(this.compileToolStripMenuItem, "compileToolStripMenuItem");
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectSettingsToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // projectSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.projectSettingsToolStripMenuItem, "projectSettingsToolStripMenuItem");
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Click += new System.EventHandler(this.projectSettingsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // LanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.LanguageToolStripMenuItem, "LanguageToolStripMenuItem");
            this.LanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chineseSimpleToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem";
            // 
            // chineseSimpleToolStripMenuItem
            // 
            resources.ApplyResources(this.chineseSimpleToolStripMenuItem, "chineseSimpleToolStripMenuItem");
            this.chineseSimpleToolStripMenuItem.Checked = true;
            this.chineseSimpleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chineseSimpleToolStripMenuItem.Name = "chineseSimpleToolStripMenuItem";
            this.chineseSimpleToolStripMenuItem.Click += new System.EventHandler(this.chineseSimpleToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.searchDefinitionsToolStripMenuItem,
            this.changeLogToolStripMenuItem,
            this.reportErrorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem1
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem1, "aboutToolStripMenuItem1");
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // searchDefinitionsToolStripMenuItem
            // 
            resources.ApplyResources(this.searchDefinitionsToolStripMenuItem, "searchDefinitionsToolStripMenuItem");
            this.searchDefinitionsToolStripMenuItem.Name = "searchDefinitionsToolStripMenuItem";
            this.searchDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.searchDefinitionsToolStripMenuItem_Click);
            // 
            // changeLogToolStripMenuItem
            // 
            resources.ApplyResources(this.changeLogToolStripMenuItem, "changeLogToolStripMenuItem");
            this.changeLogToolStripMenuItem.Name = "changeLogToolStripMenuItem";
            this.changeLogToolStripMenuItem.Click += new System.EventHandler(this.changeLogToolStripMenuItem_Click);
            // 
            // reportErrorToolStripMenuItem
            // 
            resources.ApplyResources(this.reportErrorToolStripMenuItem, "reportErrorToolStripMenuItem");
            this.reportErrorToolStripMenuItem.Name = "reportErrorToolStripMenuItem";
            this.reportErrorToolStripMenuItem.Click += new System.EventHandler(this.reportErrorToolStripMenuItem_Click);
            // 
            // projectViewMenu
            // 
            resources.ApplyResources(this.projectViewMenu, "projectViewMenu");
            this.projectViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.newDialogToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.openInExploreToolStripMenuItem,
            this.activateToolStripMenuItem});
            this.projectViewMenu.Name = "projectViewMenu";
            this.ObjectBrowserTooltip.SetToolTip(this.projectViewMenu, resources.GetString("projectViewMenu.ToolTip"));
            // 
            // newFileToolStripMenuItem
            // 
            resources.ApplyResources(this.newFileToolStripMenuItem, "newFileToolStripMenuItem");
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // newDialogToolStripMenuItem
            // 
            resources.ApplyResources(this.newDialogToolStripMenuItem, "newDialogToolStripMenuItem");
            this.newDialogToolStripMenuItem.Name = "newDialogToolStripMenuItem";
            this.newDialogToolStripMenuItem.Click += new System.EventHandler(this.newDialogToolStripMenuItem_Click);
            // 
            // newFolderToolStripMenuItem
            // 
            resources.ApplyResources(this.newFolderToolStripMenuItem, "newFolderToolStripMenuItem");
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            resources.ApplyResources(this.removeToolStripMenuItem, "removeToolStripMenuItem");
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            resources.ApplyResources(this.renameToolStripMenuItem, "renameToolStripMenuItem");
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // openInExploreToolStripMenuItem
            // 
            resources.ApplyResources(this.openInExploreToolStripMenuItem, "openInExploreToolStripMenuItem");
            this.openInExploreToolStripMenuItem.Name = "openInExploreToolStripMenuItem";
            this.openInExploreToolStripMenuItem.Click += new System.EventHandler(this.openInExploreToolStripMenuItem_Click);
            // 
            // activateToolStripMenuItem
            // 
            resources.ApplyResources(this.activateToolStripMenuItem, "activateToolStripMenuItem");
            this.activateToolStripMenuItem.Checked = true;
            this.activateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // projectViewProjectMenu
            // 
            resources.ApplyResources(this.projectViewProjectMenu, "projectViewProjectMenu");
            this.projectViewProjectMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.deleteProjectToolStripMenuItem});
            this.projectViewProjectMenu.Name = "projectViewProjectMenu";
            this.ObjectBrowserTooltip.SetToolTip(this.projectViewProjectMenu, resources.GetString("projectViewProjectMenu.ToolTip"));
            // 
            // newProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.newProjectToolStripMenuItem, "newProjectToolStripMenuItem");
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // deleteProjectToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteProjectToolStripMenuItem, "deleteProjectToolStripMenuItem");
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Click += new System.EventHandler(this.deleteProjectToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilerStatusText});
            this.statusStrip1.Name = "statusStrip1";
            this.ObjectBrowserTooltip.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // compilerStatusText
            // 
            resources.ApplyResources(this.compilerStatusText, "compilerStatusText");
            this.compilerStatusText.Name = "compilerStatusText";
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TBNewProject,
            this.TBNewFile,
            this.TBNewFolder,
            this.TBDelete,
            this.TBSave,
            this.TBSaveAll,
            this.toolStripSeparator3,
            this.TBCut,
            this.TBCopy,
            this.TBPaste,
            this.toolStripSeparator2,
            this.TBUndo,
            this.TBRedo,
            this.toolStripSeparator1,
            this.TBRun,
            this.toolStripSeparator4,
            this.TBFind,
            this.toolStripSeparator7,
            this.TBComment,
            this.TBUncomment});
            this.toolStrip1.Name = "toolStrip1";
            this.ObjectBrowserTooltip.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // TBNewProject
            // 
            resources.ApplyResources(this.TBNewProject, "TBNewProject");
            this.TBNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBNewProject.Name = "TBNewProject";
            this.TBNewProject.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // TBNewFile
            // 
            resources.ApplyResources(this.TBNewFile, "TBNewFile");
            this.TBNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBNewFile.Name = "TBNewFile";
            this.TBNewFile.Click += new System.EventHandler(this.sourceFileToolStripMenuItem_Click);
            // 
            // TBNewFolder
            // 
            resources.ApplyResources(this.TBNewFolder, "TBNewFolder");
            this.TBNewFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBNewFolder.Name = "TBNewFolder";
            this.TBNewFolder.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // TBDelete
            // 
            resources.ApplyResources(this.TBDelete, "TBDelete");
            this.TBDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBDelete.Name = "TBDelete";
            this.TBDelete.Click += new System.EventHandler(this.TBDelete_Click);
            // 
            // TBSave
            // 
            resources.ApplyResources(this.TBSave, "TBSave");
            this.TBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBSave.Name = "TBSave";
            this.TBSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // TBSaveAll
            // 
            resources.ApplyResources(this.TBSaveAll, "TBSaveAll");
            this.TBSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBSaveAll.Name = "TBSaveAll";
            this.TBSaveAll.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // TBCut
            // 
            resources.ApplyResources(this.TBCut, "TBCut");
            this.TBCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBCut.Name = "TBCut";
            this.TBCut.Click += new System.EventHandler(this.TBCut_Click);
            // 
            // TBCopy
            // 
            resources.ApplyResources(this.TBCopy, "TBCopy");
            this.TBCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBCopy.Name = "TBCopy";
            this.TBCopy.Click += new System.EventHandler(this.TBCopy_Click);
            // 
            // TBPaste
            // 
            resources.ApplyResources(this.TBPaste, "TBPaste");
            this.TBPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBPaste.Name = "TBPaste";
            this.TBPaste.Click += new System.EventHandler(this.TBPaste_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // TBUndo
            // 
            resources.ApplyResources(this.TBUndo, "TBUndo");
            this.TBUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBUndo.Name = "TBUndo";
            this.TBUndo.Click += new System.EventHandler(this.TBUndo_Click);
            // 
            // TBRedo
            // 
            resources.ApplyResources(this.TBRedo, "TBRedo");
            this.TBRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBRedo.Name = "TBRedo";
            this.TBRedo.Click += new System.EventHandler(this.TBRedo_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // TBRun
            // 
            resources.ApplyResources(this.TBRun, "TBRun");
            this.TBRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBRun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.buildOnlyToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem});
            this.TBRun.Name = "TBRun";
            this.TBRun.ButtonClick += new System.EventHandler(this.compileAndCopyToMapToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            resources.ApplyResources(this.runToolStripMenuItem, "runToolStripMenuItem");
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.compileAndCopyToMapToolStripMenuItem_Click);
            // 
            // buildOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.buildOnlyToolStripMenuItem, "buildOnlyToolStripMenuItem");
            this.buildOnlyToolStripMenuItem.Name = "buildOnlyToolStripMenuItem";
            this.buildOnlyToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            resources.ApplyResources(this.saveToolStripMenuItem1, "saveToolStripMenuItem1");
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.compileAndSaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.compileAndSaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // TBFind
            // 
            resources.ApplyResources(this.TBFind, "TBFind");
            this.TBFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBFind.Name = "TBFind";
            this.TBFind.Click += new System.EventHandler(this.TBFind_Click);
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // TBComment
            // 
            resources.ApplyResources(this.TBComment, "TBComment");
            this.TBComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBComment.Name = "TBComment";
            this.TBComment.Click += new System.EventHandler(this.TBComment_Click);
            // 
            // TBUncomment
            // 
            resources.ApplyResources(this.TBUncomment, "TBUncomment");
            this.TBUncomment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TBUncomment.Name = "TBUncomment";
            this.TBUncomment.Click += new System.EventHandler(this.TBUncomment_Click);
            // 
            // editorRightClick
            // 
            resources.ApplyResources(this.editorRightClick, "editorRightClick");
            this.editorRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClickCut,
            this.RightClickCopy,
            this.RightClickPaste,
            this.toolStripSeparator5,
            this.RightClickFind,
            this.toolStripSeparator6,
            this.jumpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.goToDeclarationToolStripMenuItem});
            this.editorRightClick.Name = "editorRightClick";
            this.ObjectBrowserTooltip.SetToolTip(this.editorRightClick, resources.GetString("editorRightClick.ToolTip"));
            // 
            // RightClickCut
            // 
            resources.ApplyResources(this.RightClickCut, "RightClickCut");
            this.RightClickCut.Image = global::Galaxy_Editor_2.Properties.Resources.CutHS;
            this.RightClickCut.Name = "RightClickCut";
            this.RightClickCut.Click += new System.EventHandler(this.TBCut_Click);
            // 
            // RightClickCopy
            // 
            resources.ApplyResources(this.RightClickCopy, "RightClickCopy");
            this.RightClickCopy.Image = global::Galaxy_Editor_2.Properties.Resources.CopyHS;
            this.RightClickCopy.Name = "RightClickCopy";
            this.RightClickCopy.Click += new System.EventHandler(this.TBCopy_Click);
            // 
            // RightClickPaste
            // 
            resources.ApplyResources(this.RightClickPaste, "RightClickPaste");
            this.RightClickPaste.Image = global::Galaxy_Editor_2.Properties.Resources.PasteHS;
            this.RightClickPaste.Name = "RightClickPaste";
            this.RightClickPaste.Click += new System.EventHandler(this.TBPaste_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // RightClickFind
            // 
            resources.ApplyResources(this.RightClickFind, "RightClickFind");
            this.RightClickFind.Name = "RightClickFind";
            this.RightClickFind.Click += new System.EventHandler(this.TBFind_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // jumpToolStripMenuItem
            // 
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            this.jumpToolStripMenuItem.Click += new System.EventHandler(this.jumpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSInsertConstructor});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // TSInsertConstructor
            // 
            resources.ApplyResources(this.TSInsertConstructor, "TSInsertConstructor");
            this.TSInsertConstructor.Name = "TSInsertConstructor";
            this.TSInsertConstructor.Click += new System.EventHandler(this.TSInsertConstructor_Click);
            // 
            // goToDeclarationToolStripMenuItem
            // 
            resources.ApplyResources(this.goToDeclarationToolStripMenuItem, "goToDeclarationToolStripMenuItem");
            this.goToDeclarationToolStripMenuItem.Name = "goToDeclarationToolStripMenuItem";
            this.goToDeclarationToolStripMenuItem.Click += new System.EventHandler(this.goToDeclarationToolStripMenuItem_Click);
            // 
            // projectView
            // 
            resources.ApplyResources(this.projectView, "projectView");
            this.projectView.AllowDrop = true;
            this.projectView.DragCursor = null;
            this.projectView.DragCursorType = Galaxy_Editor_2.DragCursorType.None;
            this.projectView.DragImageIndex = 0;
            this.projectView.DragMode = System.Windows.Forms.DragDropEffects.Move;
            this.projectView.DragNodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectView.DragNodeOpacity = 0.3D;
            this.projectView.DragOverNodeBackColor = System.Drawing.SystemColors.Highlight;
            this.projectView.DragOverNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.projectView.ImageList = this.projectViewImageList;
            this.projectView.Name = "projectView";
            this.ObjectBrowserTooltip.SetToolTip(this.projectView, resources.GetString("projectView.ToolTip"));
            this.projectView.DragStart += new Galaxy_Editor_2.DragItemEventHandler(this.projectView_DragStart);
            this.projectView.DragComplete += new Galaxy_Editor_2.DragCompleteEventHandler(this.projectView_DragComplete);
            this.projectView.DragCompleteValid += new Galaxy_Editor_2.DragCompletionValidEventHandler(this.projectView_DragCompleteValid);
            this.projectView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.projectView_BeforeLabelEdit);
            this.projectView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.projectView_AfterLabelEdit);
            this.projectView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.projectView_AfterCollapse);
            this.projectView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.projectView_AfterExpand);
            this.projectView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.projectView_AfterSelect);
            this.projectView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.projectView_KeyDown);
            this.projectView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.projectView_KeyPress);
            this.projectView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.projectView_MouseDoubleClick);
            this.projectView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.projectView_MouseDown);
            // 
            // tabStrip
            // 
            resources.ApplyResources(this.tabStrip, "tabStrip");
            this.tabStrip.Name = "tabStrip";
            this.ObjectBrowserTooltip.SetToolTip(this.tabStrip, resources.GetString("tabStrip.ToolTip"));
            this.tabStrip.TabStripItemClosing += new FarsiLibrary.Win.TabStripItemClosingHandler(this.tabStrip_TabStripItemClosing);
            this.tabStrip.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.tabStrip_TabStripItemSelectionChanged);
            // 
            // messageView
            // 
            resources.ApplyResources(this.messageView, "messageView");
            this.messageView.AllowDrop = true;
            this.messageView.DragCursor = null;
            this.messageView.DragCursorType = Galaxy_Editor_2.DragCursorType.None;
            this.messageView.DragImageIndex = 0;
            this.messageView.DragMode = System.Windows.Forms.DragDropEffects.Move;
            this.messageView.DragNodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageView.DragNodeOpacity = 0.3D;
            this.messageView.DragOverNodeBackColor = System.Drawing.SystemColors.Highlight;
            this.messageView.DragOverNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.messageView.ImageList = this.messageViewImageList;
            this.messageView.Name = "messageView";
            this.ObjectBrowserTooltip.SetToolTip(this.messageView, resources.GetString("messageView.ToolTip"));
            this.messageView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageView_KeyDown);
            this.messageView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.messageView_MouseDoubleClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ObjectBrowserTooltip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.objectBrowserSplitContainer.Panel1.ResumeLayout(false);
            this.objectBrowserSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectBrowserSplitContainer)).EndInit();
            this.objectBrowserSplitContainer.ResumeLayout(false);
            this.ObjectBrowserPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mapObjectBrowserPage.ResumeLayout(false);
            this.mapObjectBrowserPage.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.projectViewMenu.ResumeLayout(false);
            this.projectViewProjectMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.editorRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip projectViewMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ImageList projectViewImageList;
        private TreeViewDragDrop projectView;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        public TreeViewDragDrop messageView;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ImageList messageViewImageList;
        private FarsiLibrary.Win.FATabStrip tabStrip;
        private System.Windows.Forms.ContextMenuStrip projectViewProjectMenu;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInExploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compileAndCopyToMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileAndSaveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel compilerStatusText;
        private System.Windows.Forms.ToolStripMenuItem compileAndSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TBNewFile;
        private System.Windows.Forms.ToolStripButton TBNewFolder;
        private System.Windows.Forms.ToolStripButton TBSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TBUndo;
        private System.Windows.Forms.ToolStripButton TBRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TBNewProject;
        private System.Windows.Forms.ToolStripButton TBSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TBCut;
        private System.Windows.Forms.ToolStripButton TBCopy;
        private System.Windows.Forms.ToolStripButton TBPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TBFind;
        private System.Windows.Forms.ToolStripSplitButton TBRun;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip editorRightClick;
        private System.Windows.Forms.ToolStripMenuItem RightClickCut;
        private System.Windows.Forms.ToolStripMenuItem RightClickCopy;
        private System.Windows.Forms.ToolStripMenuItem RightClickPaste;
        private System.Windows.Forms.ToolStripButton TBDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem RightClickFind;
        private System.Windows.Forms.SplitContainer objectBrowserSplitContainer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox ObjectBrowserCatagory;
        private System.Windows.Forms.ToolStripButton TBRefreshObjectList;
        private System.Windows.Forms.Panel ObjectBrowserPanel;
        private System.Windows.Forms.ListView ObjectBrowserList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolTip ObjectBrowserTooltip;
        private System.Windows.Forms.ToolStripMenuItem changeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSInsertConstructor;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapObjectBrowserToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CBShowWarnings;
        private System.Windows.Forms.CheckBox CBShowErrors;
        private System.Windows.Forms.ToolStripMenuItem newDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportErrorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mapObjectBrowserPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PropertyGrid UnitFilterGrid;
        private System.Windows.Forms.Button BTNUnitFilterReset;
        private System.Windows.Forms.Button BTNUnitFilterInsert;
        private System.Windows.Forms.CheckBox CBUnitFilterCompress;
        private System.Windows.Forms.ToolStripMenuItem goToDeclarationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chineseSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton TBComment;
        private System.Windows.Forms.ToolStripButton TBUncomment;
    }
}

