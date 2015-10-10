namespace Galaxy_Editor_2
{
    partial class NewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNResetFolder = new System.Windows.Forms.Button();
            this.BTNSelectFolder = new System.Windows.Forms.Button();
            this.TBDirectory = new System.Windows.Forms.TextBox();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.BTNOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBName
            // 
            resources.ApplyResources(this.TBName, "TBName");
            this.TBName.Name = "TBName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.BTNResetFolder);
            this.groupBox1.Controls.Add(this.BTNSelectFolder);
            this.groupBox1.Controls.Add(this.TBDirectory);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BTNResetFolder
            // 
            resources.ApplyResources(this.BTNResetFolder, "BTNResetFolder");
            this.BTNResetFolder.Name = "BTNResetFolder";
            this.BTNResetFolder.UseVisualStyleBackColor = true;
            this.BTNResetFolder.Click += new System.EventHandler(this.BTNResetFolder_Click);
            // 
            // BTNSelectFolder
            // 
            resources.ApplyResources(this.BTNSelectFolder, "BTNSelectFolder");
            this.BTNSelectFolder.Name = "BTNSelectFolder";
            this.BTNSelectFolder.UseVisualStyleBackColor = true;
            this.BTNSelectFolder.Click += new System.EventHandler(this.BTNSelectFolder_Click);
            // 
            // TBDirectory
            // 
            resources.ApplyResources(this.TBDirectory, "TBDirectory");
            this.TBDirectory.Name = "TBDirectory";
            // 
            // BTNCancel
            // 
            resources.ApplyResources(this.BTNCancel, "BTNCancel");
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            // 
            // BTNOK
            // 
            resources.ApplyResources(this.BTNOK, "BTNOK");
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.UseVisualStyleBackColor = true;
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
            // 
            // NewProjectForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewProjectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNResetFolder;
        private System.Windows.Forms.Button BTNSelectFolder;
        private System.Windows.Forms.TextBox TBDirectory;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Button BTNOK;
    }
}