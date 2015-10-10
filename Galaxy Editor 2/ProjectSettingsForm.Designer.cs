namespace Galaxy_Editor_2
{
    partial class ProjectSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNSelectCurrentMap = new System.Windows.Forms.Button();
            this.TBCurrentMap = new System.Windows.Forms.TextBox();
            this.BTNResetCurrentMap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.BTNSelectOutputFolder = new System.Windows.Forms.Button();
            this.BTNResetOutput = new System.Windows.Forms.Button();
            this.TBOutputMap = new System.Windows.Forms.TextBox();
            this.BTNSelectOutputFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSaveScriptToMap = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTNSelectCurrentMap
            // 
            resources.ApplyResources(this.BTNSelectCurrentMap, "BTNSelectCurrentMap");
            this.BTNSelectCurrentMap.Name = "BTNSelectCurrentMap";
            this.BTNSelectCurrentMap.UseVisualStyleBackColor = true;
            this.BTNSelectCurrentMap.Click += new System.EventHandler(this.BTNSelectCurrentMap_Click);
            // 
            // TBCurrentMap
            // 
            resources.ApplyResources(this.TBCurrentMap, "TBCurrentMap");
            this.TBCurrentMap.BackColor = System.Drawing.Color.White;
            this.TBCurrentMap.Name = "TBCurrentMap";
            this.TBCurrentMap.ReadOnly = true;
            this.TBCurrentMap.TextChanged += new System.EventHandler(this.TBCurrentMap_TextChanged);
            // 
            // BTNResetCurrentMap
            // 
            resources.ApplyResources(this.BTNResetCurrentMap, "BTNResetCurrentMap");
            this.BTNResetCurrentMap.Name = "BTNResetCurrentMap";
            this.BTNResetCurrentMap.UseVisualStyleBackColor = true;
            this.BTNResetCurrentMap.Click += new System.EventHandler(this.BTNResetCurrentMap_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelectFolder
            // 
            resources.ApplyResources(this.btnSelectFolder, "btnSelectFolder");
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // BTNSelectOutputFolder
            // 
            resources.ApplyResources(this.BTNSelectOutputFolder, "BTNSelectOutputFolder");
            this.BTNSelectOutputFolder.Name = "BTNSelectOutputFolder";
            this.BTNSelectOutputFolder.UseVisualStyleBackColor = true;
            this.BTNSelectOutputFolder.Click += new System.EventHandler(this.BTNSelectOutputFolder_Click);
            // 
            // BTNResetOutput
            // 
            resources.ApplyResources(this.BTNResetOutput, "BTNResetOutput");
            this.BTNResetOutput.Name = "BTNResetOutput";
            this.BTNResetOutput.UseVisualStyleBackColor = true;
            this.BTNResetOutput.Click += new System.EventHandler(this.BTNResetOutput_Click);
            // 
            // TBOutputMap
            // 
            resources.ApplyResources(this.TBOutputMap, "TBOutputMap");
            this.TBOutputMap.BackColor = System.Drawing.Color.White;
            this.TBOutputMap.Name = "TBOutputMap";
            this.TBOutputMap.ReadOnly = true;
            this.TBOutputMap.TextChanged += new System.EventHandler(this.TBOutputMap_TextChanged);
            // 
            // BTNSelectOutputFile
            // 
            resources.ApplyResources(this.BTNSelectOutputFile, "BTNSelectOutputFile");
            this.BTNSelectOutputFile.Name = "BTNSelectOutputFile";
            this.BTNSelectOutputFile.UseVisualStyleBackColor = true;
            this.BTNSelectOutputFile.Click += new System.EventHandler(this.BTNSelectOutputFile_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CBSaveScriptToMap
            // 
            resources.ApplyResources(this.CBSaveScriptToMap, "CBSaveScriptToMap");
            this.CBSaveScriptToMap.Name = "CBSaveScriptToMap";
            this.CBSaveScriptToMap.UseVisualStyleBackColor = true;
            this.CBSaveScriptToMap.CheckedChanged += new System.EventHandler(this.saveScriptToMap_CheckedChanged);
            // 
            // ProjectSettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.CBSaveScriptToMap);
            this.Controls.Add(this.BTNSelectOutputFolder);
            this.Controls.Add(this.BTNResetOutput);
            this.Controls.Add(this.TBOutputMap);
            this.Controls.Add(this.BTNSelectOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNResetCurrentMap);
            this.Controls.Add(this.TBCurrentMap);
            this.Controls.Add(this.BTNSelectCurrentMap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProjectSettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNSelectCurrentMap;
        private System.Windows.Forms.TextBox TBCurrentMap;
        private System.Windows.Forms.Button BTNResetCurrentMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button BTNSelectOutputFolder;
        private System.Windows.Forms.Button BTNResetOutput;
        private System.Windows.Forms.TextBox TBOutputMap;
        private System.Windows.Forms.Button BTNSelectOutputFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CBSaveScriptToMap;
    }
}