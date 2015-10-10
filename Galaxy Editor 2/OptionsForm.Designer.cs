namespace Galaxy_Editor_2
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNOkay = new System.Windows.Forms.Button();
            this.tabStrip = new FarsiLibrary.Win.FATabStrip();
            this.compilerTab = new FarsiLibrary.Win.FATabStripItem();
            this.CBCAutoInline = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBCNeverAskToOpenSavedFile = new System.Windows.Forms.CheckBox();
            this.CBCRunCopy = new System.Windows.Forms.CheckBox();
            this.TBCMapBackups = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBCObfuscateStrings = new System.Windows.Forms.CheckBox();
            this.CBCShortNames = new System.Windows.Forms.CheckBox();
            this.CBCOneFile = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBCRemoveMethods = new System.Windows.Forms.CheckBox();
            this.CBCRemoveStructs = new System.Windows.Forms.CheckBox();
            this.CBCRemoveFields = new System.Windows.Forms.CheckBox();
            this.editorTab = new FarsiLibrary.Win.FATabStripItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEPickFontContext = new System.Windows.Forms.ComboBox();
            this.CBEFontStrikeout = new System.Windows.Forms.CheckBox();
            this.BTNEFontColor = new System.Windows.Forms.Button();
            this.CBEFontUnderline = new System.Windows.Forms.CheckBox();
            this.CBEBoldFond = new System.Windows.Forms.CheckBox();
            this.CBEItalicsFont = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBECharWidth = new System.Windows.Forms.TextBox();
            this.BTNEFontPick = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbEditorReadOnlyOut = new System.Windows.Forms.CheckBox();
            this.CBEOpenPreviousProjectAtLaunch = new System.Windows.Forms.CheckBox();
            this.cbEditorReplaceTabs = new System.Windows.Forms.CheckBox();
            this.CBEInsertEndBracket = new System.Windows.Forms.CheckBox();
            this.runOptionsTab = new FarsiLibrary.Win.FATabStripItem();
            this.TBROAdditionalArgs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBROAllowCheat = new System.Windows.Forms.CheckBox();
            this.CBROEnablePreload = new System.Windows.Forms.CheckBox();
            this.CBROWindowed = new System.Windows.Forms.CheckBox();
            this.CBROShowTriggerDebug = new System.Windows.Forms.CheckBox();
            this.TBROSeed = new System.Windows.Forms.TextBox();
            this.LROSeed = new System.Windows.Forms.Label();
            this.CBROFixedSeed = new System.Windows.Forms.CheckBox();
            this.CBROGameSpeed = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBRODifficulty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).BeginInit();
            this.tabStrip.SuspendLayout();
            this.compilerTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editorTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.runOptionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.BTNOkay);
            this.panel1.Name = "panel1";
            // 
            // BTNOkay
            // 
            resources.ApplyResources(this.BTNOkay, "BTNOkay");
            this.BTNOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNOkay.Name = "BTNOkay";
            this.BTNOkay.UseVisualStyleBackColor = true;
            // 
            // tabStrip
            // 
            resources.ApplyResources(this.tabStrip, "tabStrip");
            this.tabStrip.AlwaysShowClose = false;
            this.tabStrip.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.compilerTab,
            this.editorTab,
            this.runOptionsTab});
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedItem = this.compilerTab;
            // 
            // compilerTab
            // 
            resources.ApplyResources(this.compilerTab, "compilerTab");
            this.compilerTab.CanClose = false;
            this.compilerTab.Controls.Add(this.CBCAutoInline);
            this.compilerTab.Controls.Add(this.groupBox8);
            this.compilerTab.Controls.Add(this.groupBox3);
            this.compilerTab.Controls.Add(this.groupBox2);
            this.compilerTab.Controls.Add(this.groupBox1);
            this.compilerTab.IsDrawn = true;
            this.compilerTab.Name = "compilerTab";
            this.compilerTab.Selected = true;
            this.compilerTab.Title = "编译";
            // 
            // CBCAutoInline
            // 
            resources.ApplyResources(this.CBCAutoInline, "CBCAutoInline");
            this.CBCAutoInline.Name = "CBCAutoInline";
            this.CBCAutoInline.UseVisualStyleBackColor = true;
            this.CBCAutoInline.CheckedChanged += new System.EventHandler(this.CBCAutoInline_CheckedChanged);
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.CBCNeverAskToOpenSavedFile);
            this.groupBox3.Controls.Add(this.CBCRunCopy);
            this.groupBox3.Controls.Add(this.TBCMapBackups);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // CBCNeverAskToOpenSavedFile
            // 
            resources.ApplyResources(this.CBCNeverAskToOpenSavedFile, "CBCNeverAskToOpenSavedFile");
            this.CBCNeverAskToOpenSavedFile.Name = "CBCNeverAskToOpenSavedFile";
            this.CBCNeverAskToOpenSavedFile.UseVisualStyleBackColor = true;
            this.CBCNeverAskToOpenSavedFile.CheckedChanged += new System.EventHandler(this.CBCNeverAskToOpenSavedFile_CheckedChanged);
            // 
            // CBCRunCopy
            // 
            resources.ApplyResources(this.CBCRunCopy, "CBCRunCopy");
            this.CBCRunCopy.Name = "CBCRunCopy";
            this.CBCRunCopy.UseVisualStyleBackColor = true;
            this.CBCRunCopy.CheckedChanged += new System.EventHandler(this.CBCRunCopy_CheckedChanged);
            // 
            // TBCMapBackups
            // 
            resources.ApplyResources(this.TBCMapBackups, "TBCMapBackups");
            this.TBCMapBackups.Name = "TBCMapBackups";
            this.TBCMapBackups.TextChanged += new System.EventHandler(this.TBCMapBackups_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.CBCObfuscateStrings);
            this.groupBox2.Controls.Add(this.CBCShortNames);
            this.groupBox2.Controls.Add(this.CBCOneFile);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // CBCObfuscateStrings
            // 
            resources.ApplyResources(this.CBCObfuscateStrings, "CBCObfuscateStrings");
            this.CBCObfuscateStrings.Name = "CBCObfuscateStrings";
            this.CBCObfuscateStrings.UseVisualStyleBackColor = true;
            this.CBCObfuscateStrings.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CBCShortNames
            // 
            resources.ApplyResources(this.CBCShortNames, "CBCShortNames");
            this.CBCShortNames.Name = "CBCShortNames";
            this.CBCShortNames.UseVisualStyleBackColor = true;
            this.CBCShortNames.CheckedChanged += new System.EventHandler(this.CBCShortNames_CheckedChanged);
            // 
            // CBCOneFile
            // 
            resources.ApplyResources(this.CBCOneFile, "CBCOneFile");
            this.CBCOneFile.Name = "CBCOneFile";
            this.CBCOneFile.UseVisualStyleBackColor = true;
            this.CBCOneFile.CheckedChanged += new System.EventHandler(this.CBCOneFile_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.CBCRemoveMethods);
            this.groupBox1.Controls.Add(this.CBCRemoveStructs);
            this.groupBox1.Controls.Add(this.CBCRemoveFields);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CBCRemoveMethods
            // 
            resources.ApplyResources(this.CBCRemoveMethods, "CBCRemoveMethods");
            this.CBCRemoveMethods.Name = "CBCRemoveMethods";
            this.CBCRemoveMethods.UseVisualStyleBackColor = true;
            this.CBCRemoveMethods.CheckedChanged += new System.EventHandler(this.CBCRemoveDecls_CheckedChanged);
            // 
            // CBCRemoveStructs
            // 
            resources.ApplyResources(this.CBCRemoveStructs, "CBCRemoveStructs");
            this.CBCRemoveStructs.Name = "CBCRemoveStructs";
            this.CBCRemoveStructs.UseVisualStyleBackColor = true;
            this.CBCRemoveStructs.CheckedChanged += new System.EventHandler(this.CBCRemoveDecls_CheckedChanged);
            // 
            // CBCRemoveFields
            // 
            resources.ApplyResources(this.CBCRemoveFields, "CBCRemoveFields");
            this.CBCRemoveFields.Name = "CBCRemoveFields";
            this.CBCRemoveFields.UseVisualStyleBackColor = true;
            this.CBCRemoveFields.CheckedChanged += new System.EventHandler(this.CBCRemoveDecls_CheckedChanged);
            // 
            // editorTab
            // 
            resources.ApplyResources(this.editorTab, "editorTab");
            this.editorTab.CanClose = false;
            this.editorTab.Controls.Add(this.groupBox5);
            this.editorTab.Controls.Add(this.groupBox4);
            this.editorTab.IsDrawn = true;
            this.editorTab.Name = "editorTab";
            this.editorTab.Title = "编辑";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.CBEPickFontContext);
            this.groupBox7.Controls.Add(this.CBEFontStrikeout);
            this.groupBox7.Controls.Add(this.BTNEFontColor);
            this.groupBox7.Controls.Add(this.CBEFontUnderline);
            this.groupBox7.Controls.Add(this.CBEBoldFond);
            this.groupBox7.Controls.Add(this.CBEItalicsFont);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CBEPickFontContext
            // 
            resources.ApplyResources(this.CBEPickFontContext, "CBEPickFontContext");
            this.CBEPickFontContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEPickFontContext.FormattingEnabled = true;
            this.CBEPickFontContext.Items.AddRange(new object[] {
            resources.GetString("CBEPickFontContext.Items"),
            resources.GetString("CBEPickFontContext.Items1"),
            resources.GetString("CBEPickFontContext.Items2"),
            resources.GetString("CBEPickFontContext.Items3"),
            resources.GetString("CBEPickFontContext.Items4"),
            resources.GetString("CBEPickFontContext.Items5"),
            resources.GetString("CBEPickFontContext.Items6")});
            this.CBEPickFontContext.Name = "CBEPickFontContext";
            this.CBEPickFontContext.SelectedIndexChanged += new System.EventHandler(this.CBEPickFontContext_SelectedIndexChanged);
            // 
            // CBEFontStrikeout
            // 
            resources.ApplyResources(this.CBEFontStrikeout, "CBEFontStrikeout");
            this.CBEFontStrikeout.Name = "CBEFontStrikeout";
            this.CBEFontStrikeout.UseVisualStyleBackColor = true;
            this.CBEFontStrikeout.CheckedChanged += new System.EventHandler(this.FontCheckBoxes_CheckedChanged);
            // 
            // BTNEFontColor
            // 
            resources.ApplyResources(this.BTNEFontColor, "BTNEFontColor");
            this.BTNEFontColor.Name = "BTNEFontColor";
            this.BTNEFontColor.UseVisualStyleBackColor = true;
            this.BTNEFontColor.Click += new System.EventHandler(this.BTNEFontColor_Click);
            // 
            // CBEFontUnderline
            // 
            resources.ApplyResources(this.CBEFontUnderline, "CBEFontUnderline");
            this.CBEFontUnderline.Name = "CBEFontUnderline";
            this.CBEFontUnderline.UseVisualStyleBackColor = true;
            this.CBEFontUnderline.CheckedChanged += new System.EventHandler(this.FontCheckBoxes_CheckedChanged);
            // 
            // CBEBoldFond
            // 
            resources.ApplyResources(this.CBEBoldFond, "CBEBoldFond");
            this.CBEBoldFond.Name = "CBEBoldFond";
            this.CBEBoldFond.UseVisualStyleBackColor = true;
            this.CBEBoldFond.CheckedChanged += new System.EventHandler(this.FontCheckBoxes_CheckedChanged);
            // 
            // CBEItalicsFont
            // 
            resources.ApplyResources(this.CBEItalicsFont, "CBEItalicsFont");
            this.CBEItalicsFont.Name = "CBEItalicsFont";
            this.CBEItalicsFont.UseVisualStyleBackColor = true;
            this.CBEItalicsFont.CheckedChanged += new System.EventHandler(this.FontCheckBoxes_CheckedChanged);
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.TBECharWidth);
            this.groupBox6.Controls.Add(this.BTNEFontPick);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TBECharWidth
            // 
            resources.ApplyResources(this.TBECharWidth, "TBECharWidth");
            this.TBECharWidth.Name = "TBECharWidth";
            this.TBECharWidth.TextChanged += new System.EventHandler(this.TBECharWidth_TextChanged);
            // 
            // BTNEFontPick
            // 
            resources.ApplyResources(this.BTNEFontPick, "BTNEFontPick");
            this.BTNEFontPick.Name = "BTNEFontPick";
            this.BTNEFontPick.UseVisualStyleBackColor = true;
            this.BTNEFontPick.Click += new System.EventHandler(this.BTNEFontPick_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.cbEditorReadOnlyOut);
            this.groupBox4.Controls.Add(this.CBEOpenPreviousProjectAtLaunch);
            this.groupBox4.Controls.Add(this.cbEditorReplaceTabs);
            this.groupBox4.Controls.Add(this.CBEInsertEndBracket);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // cbEditorReadOnlyOut
            // 
            resources.ApplyResources(this.cbEditorReadOnlyOut, "cbEditorReadOnlyOut");
            this.cbEditorReadOnlyOut.Name = "cbEditorReadOnlyOut";
            this.cbEditorReadOnlyOut.UseVisualStyleBackColor = true;
            this.cbEditorReadOnlyOut.CheckedChanged += new System.EventHandler(this.cbEditorReadOnlyOut_CheckedChanged);
            // 
            // CBEOpenPreviousProjectAtLaunch
            // 
            resources.ApplyResources(this.CBEOpenPreviousProjectAtLaunch, "CBEOpenPreviousProjectAtLaunch");
            this.CBEOpenPreviousProjectAtLaunch.Name = "CBEOpenPreviousProjectAtLaunch";
            this.CBEOpenPreviousProjectAtLaunch.UseVisualStyleBackColor = true;
            this.CBEOpenPreviousProjectAtLaunch.CheckedChanged += new System.EventHandler(this.CBEOpenPreviousProjectAtLaunch_CheckedChanged);
            // 
            // cbEditorReplaceTabs
            // 
            resources.ApplyResources(this.cbEditorReplaceTabs, "cbEditorReplaceTabs");
            this.cbEditorReplaceTabs.Name = "cbEditorReplaceTabs";
            this.cbEditorReplaceTabs.UseVisualStyleBackColor = true;
            this.cbEditorReplaceTabs.CheckedChanged += new System.EventHandler(this.cbEditorReplaceTabs_CheckedChanged);
            // 
            // CBEInsertEndBracket
            // 
            resources.ApplyResources(this.CBEInsertEndBracket, "CBEInsertEndBracket");
            this.CBEInsertEndBracket.Name = "CBEInsertEndBracket";
            this.CBEInsertEndBracket.UseVisualStyleBackColor = true;
            this.CBEInsertEndBracket.CheckedChanged += new System.EventHandler(this.CBEInsertEndBracket_CheckedChanged);
            // 
            // runOptionsTab
            // 
            resources.ApplyResources(this.runOptionsTab, "runOptionsTab");
            this.runOptionsTab.CanClose = false;
            this.runOptionsTab.Controls.Add(this.TBROAdditionalArgs);
            this.runOptionsTab.Controls.Add(this.label8);
            this.runOptionsTab.Controls.Add(this.CBROAllowCheat);
            this.runOptionsTab.Controls.Add(this.CBROEnablePreload);
            this.runOptionsTab.Controls.Add(this.CBROWindowed);
            this.runOptionsTab.Controls.Add(this.CBROShowTriggerDebug);
            this.runOptionsTab.Controls.Add(this.TBROSeed);
            this.runOptionsTab.Controls.Add(this.LROSeed);
            this.runOptionsTab.Controls.Add(this.CBROFixedSeed);
            this.runOptionsTab.Controls.Add(this.CBROGameSpeed);
            this.runOptionsTab.Controls.Add(this.label6);
            this.runOptionsTab.Controls.Add(this.CBRODifficulty);
            this.runOptionsTab.Controls.Add(this.label5);
            this.runOptionsTab.IsDrawn = true;
            this.runOptionsTab.Name = "runOptionsTab";
            this.runOptionsTab.Title = "执行选项";
            // 
            // TBROAdditionalArgs
            // 
            resources.ApplyResources(this.TBROAdditionalArgs, "TBROAdditionalArgs");
            this.TBROAdditionalArgs.Name = "TBROAdditionalArgs";
            this.TBROAdditionalArgs.TextChanged += new System.EventHandler(this.TBROAdditionalArgs_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // CBROAllowCheat
            // 
            resources.ApplyResources(this.CBROAllowCheat, "CBROAllowCheat");
            this.CBROAllowCheat.Name = "CBROAllowCheat";
            this.CBROAllowCheat.UseVisualStyleBackColor = true;
            this.CBROAllowCheat.CheckedChanged += new System.EventHandler(this.CBROAllowCheat_CheckedChanged);
            // 
            // CBROEnablePreload
            // 
            resources.ApplyResources(this.CBROEnablePreload, "CBROEnablePreload");
            this.CBROEnablePreload.Name = "CBROEnablePreload";
            this.CBROEnablePreload.UseVisualStyleBackColor = true;
            this.CBROEnablePreload.CheckedChanged += new System.EventHandler(this.CBROEnablePreload_CheckedChanged);
            // 
            // CBROWindowed
            // 
            resources.ApplyResources(this.CBROWindowed, "CBROWindowed");
            this.CBROWindowed.Name = "CBROWindowed";
            this.CBROWindowed.UseVisualStyleBackColor = true;
            this.CBROWindowed.CheckedChanged += new System.EventHandler(this.CBROWindowed_CheckedChanged);
            // 
            // CBROShowTriggerDebug
            // 
            resources.ApplyResources(this.CBROShowTriggerDebug, "CBROShowTriggerDebug");
            this.CBROShowTriggerDebug.Name = "CBROShowTriggerDebug";
            this.CBROShowTriggerDebug.UseVisualStyleBackColor = true;
            this.CBROShowTriggerDebug.CheckedChanged += new System.EventHandler(this.CBROShowTriggerDebug_CheckedChanged);
            // 
            // TBROSeed
            // 
            resources.ApplyResources(this.TBROSeed, "TBROSeed");
            this.TBROSeed.Name = "TBROSeed";
            this.TBROSeed.TextChanged += new System.EventHandler(this.TBROSeed_TextChanged);
            // 
            // LROSeed
            // 
            resources.ApplyResources(this.LROSeed, "LROSeed");
            this.LROSeed.Name = "LROSeed";
            // 
            // CBROFixedSeed
            // 
            resources.ApplyResources(this.CBROFixedSeed, "CBROFixedSeed");
            this.CBROFixedSeed.Name = "CBROFixedSeed";
            this.CBROFixedSeed.UseVisualStyleBackColor = true;
            this.CBROFixedSeed.CheckedChanged += new System.EventHandler(this.CBROFixedSeed_CheckedChanged);
            // 
            // CBROGameSpeed
            // 
            resources.ApplyResources(this.CBROGameSpeed, "CBROGameSpeed");
            this.CBROGameSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBROGameSpeed.FormattingEnabled = true;
            this.CBROGameSpeed.Items.AddRange(new object[] {
            resources.GetString("CBROGameSpeed.Items"),
            resources.GetString("CBROGameSpeed.Items1"),
            resources.GetString("CBROGameSpeed.Items2"),
            resources.GetString("CBROGameSpeed.Items3"),
            resources.GetString("CBROGameSpeed.Items4")});
            this.CBROGameSpeed.Name = "CBROGameSpeed";
            this.CBROGameSpeed.SelectedIndexChanged += new System.EventHandler(this.CBROGameSpeed_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // CBRODifficulty
            // 
            resources.ApplyResources(this.CBRODifficulty, "CBRODifficulty");
            this.CBRODifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRODifficulty.FormattingEnabled = true;
            this.CBRODifficulty.Items.AddRange(new object[] {
            resources.GetString("CBRODifficulty.Items"),
            resources.GetString("CBRODifficulty.Items1"),
            resources.GetString("CBRODifficulty.Items2"),
            resources.GetString("CBRODifficulty.Items3"),
            resources.GetString("CBRODifficulty.Items4"),
            resources.GetString("CBRODifficulty.Items5")});
            this.CBRODifficulty.Name = "CBRODifficulty";
            this.CBRODifficulty.SelectedIndexChanged += new System.EventHandler(this.CBRODifficulty_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).EndInit();
            this.tabStrip.ResumeLayout(false);
            this.compilerTab.ResumeLayout(false);
            this.compilerTab.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editorTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.runOptionsTab.ResumeLayout(false);
            this.runOptionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.FATabStrip tabStrip;
        private FarsiLibrary.Win.FATabStripItem compilerTab;
        private System.Windows.Forms.CheckBox CBCRemoveStructs;
        private System.Windows.Forms.CheckBox CBCRemoveFields;
        private System.Windows.Forms.CheckBox CBCRemoveMethods;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNOkay;
        private FarsiLibrary.Win.FATabStripItem editorTab;
        private System.Windows.Forms.CheckBox cbEditorReadOnlyOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CBCShortNames;
        private System.Windows.Forms.CheckBox CBCOneFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TBCMapBackups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBCRunCopy;
        private System.Windows.Forms.CheckBox CBCObfuscateStrings;
        private System.Windows.Forms.CheckBox cbEditorReplaceTabs;
        private System.Windows.Forms.CheckBox CBCNeverAskToOpenSavedFile;
        private System.Windows.Forms.CheckBox CBEInsertEndBracket;
        private System.Windows.Forms.CheckBox CBEOpenPreviousProjectAtLaunch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CBEPickFontContext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CBEItalicsFont;
        private System.Windows.Forms.CheckBox CBEBoldFond;
        private System.Windows.Forms.Button BTNEFontColor;
        private System.Windows.Forms.CheckBox CBEFontStrikeout;
        private System.Windows.Forms.CheckBox CBEFontUnderline;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBECharWidth;
        private System.Windows.Forms.Button BTNEFontPick;
        private System.Windows.Forms.CheckBox CBCAutoInline;
        private System.Windows.Forms.GroupBox groupBox8;
        private FarsiLibrary.Win.FATabStripItem runOptionsTab;
        private System.Windows.Forms.TextBox TBROAdditionalArgs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CBROAllowCheat;
        private System.Windows.Forms.CheckBox CBROEnablePreload;
        private System.Windows.Forms.CheckBox CBROWindowed;
        private System.Windows.Forms.CheckBox CBROShowTriggerDebug;
        private System.Windows.Forms.TextBox TBROSeed;
        private System.Windows.Forms.Label LROSeed;
        private System.Windows.Forms.CheckBox CBROFixedSeed;
        private System.Windows.Forms.ComboBox CBROGameSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBRODifficulty;
        private System.Windows.Forms.Label label5;
    }
}