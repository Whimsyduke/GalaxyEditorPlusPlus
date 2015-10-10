namespace Galaxy_Editor_2
{
    partial class CompileModWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompileModWindow));
            this.CBAllowRename = new System.Windows.Forms.CheckBox();
            this.CBUpload = new System.Windows.Forms.CheckBox();
            this.GBUpload = new System.Windows.Forms.GroupBox();
            this.CBProtectMap = new System.Windows.Forms.CheckBox();
            this.GBProtect = new System.Windows.Forms.GroupBox();
            this.TBPassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLoadMapFolder = new System.Windows.Forms.Button();
            this.BTNLoadMapFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMapPath = new System.Windows.Forms.TextBox();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNCompile = new System.Windows.Forms.Button();
            this.GBUpload.SuspendLayout();
            this.GBProtect.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBAllowRename
            // 
            resources.ApplyResources(this.CBAllowRename, "CBAllowRename");
            this.CBAllowRename.Checked = true;
            this.CBAllowRename.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBAllowRename.Name = "CBAllowRename";
            this.CBAllowRename.UseVisualStyleBackColor = true;
            // 
            // CBUpload
            // 
            resources.ApplyResources(this.CBUpload, "CBUpload");
            this.CBUpload.Name = "CBUpload";
            this.CBUpload.UseVisualStyleBackColor = true;
            this.CBUpload.CheckedChanged += new System.EventHandler(this.CBUpload_CheckedChanged);
            // 
            // GBUpload
            // 
            resources.ApplyResources(this.GBUpload, "GBUpload");
            this.GBUpload.Controls.Add(this.CBProtectMap);
            this.GBUpload.Controls.Add(this.GBProtect);
            this.GBUpload.Controls.Add(this.BTNLoadMapFolder);
            this.GBUpload.Controls.Add(this.BTNLoadMapFile);
            this.GBUpload.Controls.Add(this.label1);
            this.GBUpload.Controls.Add(this.TBMapPath);
            this.GBUpload.Name = "GBUpload";
            this.GBUpload.TabStop = false;
            // 
            // CBProtectMap
            // 
            resources.ApplyResources(this.CBProtectMap, "CBProtectMap");
            this.CBProtectMap.Name = "CBProtectMap";
            this.CBProtectMap.UseVisualStyleBackColor = true;
            this.CBProtectMap.CheckedChanged += new System.EventHandler(this.CBProtectMap_CheckedChanged);
            // 
            // GBProtect
            // 
            resources.ApplyResources(this.GBProtect, "GBProtect");
            this.GBProtect.Controls.Add(this.TBPassword);
            this.GBProtect.Controls.Add(this.label2);
            this.GBProtect.Name = "GBProtect";
            this.GBProtect.TabStop = false;
            // 
            // TBPassword
            // 
            resources.ApplyResources(this.TBPassword, "TBPassword");
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '•';
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BTNLoadMapFolder
            // 
            resources.ApplyResources(this.BTNLoadMapFolder, "BTNLoadMapFolder");
            this.BTNLoadMapFolder.Name = "BTNLoadMapFolder";
            this.BTNLoadMapFolder.UseVisualStyleBackColor = true;
            this.BTNLoadMapFolder.Click += new System.EventHandler(this.BTNLoadMapFolder_Click);
            // 
            // BTNLoadMapFile
            // 
            resources.ApplyResources(this.BTNLoadMapFile, "BTNLoadMapFile");
            this.BTNLoadMapFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNLoadMapFile.Name = "BTNLoadMapFile";
            this.BTNLoadMapFile.UseVisualStyleBackColor = true;
            this.BTNLoadMapFile.Click += new System.EventHandler(this.BTNLoadMapFile_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TBMapPath
            // 
            resources.ApplyResources(this.TBMapPath, "TBMapPath");
            this.TBMapPath.Name = "TBMapPath";
            // 
            // BTNCancel
            // 
            resources.ApplyResources(this.BTNCancel, "BTNCancel");
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            // 
            // BTNCompile
            // 
            resources.ApplyResources(this.BTNCompile, "BTNCompile");
            this.BTNCompile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNCompile.Name = "BTNCompile";
            this.BTNCompile.UseVisualStyleBackColor = true;
            this.BTNCompile.Click += new System.EventHandler(this.BTNCompile_Click);
            // 
            // CompileModWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTNCompile);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.CBUpload);
            this.Controls.Add(this.GBUpload);
            this.Controls.Add(this.CBAllowRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompileModWindow";
            this.GBUpload.ResumeLayout(false);
            this.GBUpload.PerformLayout();
            this.GBProtect.ResumeLayout(false);
            this.GBProtect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBAllowRename;
        private System.Windows.Forms.CheckBox CBUpload;
        private System.Windows.Forms.GroupBox GBUpload;
        private System.Windows.Forms.GroupBox GBProtect;
        private System.Windows.Forms.CheckBox CBProtectMap;
        private System.Windows.Forms.Button BTNLoadMapFolder;
        private System.Windows.Forms.Button BTNLoadMapFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMapPath;
        private System.Windows.Forms.MaskedTextBox TBPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNCompile;
    }
}