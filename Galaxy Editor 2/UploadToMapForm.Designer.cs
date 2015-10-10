namespace Galaxy_Editor_2
{
    partial class UploadToMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadToMapForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNExtract = new System.Windows.Forms.Button();
            this.BTNInject = new System.Windows.Forms.Button();
            this.BTNNeither = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTNExtract
            // 
            resources.ApplyResources(this.BTNExtract, "BTNExtract");
            this.BTNExtract.Name = "BTNExtract";
            this.BTNExtract.UseVisualStyleBackColor = true;
            this.BTNExtract.Click += new System.EventHandler(this.BTNExtract_Click);
            // 
            // BTNInject
            // 
            resources.ApplyResources(this.BTNInject, "BTNInject");
            this.BTNInject.Name = "BTNInject";
            this.BTNInject.UseVisualStyleBackColor = true;
            this.BTNInject.Click += new System.EventHandler(this.BTNInject_Click);
            // 
            // BTNNeither
            // 
            resources.ApplyResources(this.BTNNeither, "BTNNeither");
            this.BTNNeither.Name = "BTNNeither";
            this.BTNNeither.UseVisualStyleBackColor = true;
            this.BTNNeither.Click += new System.EventHandler(this.BTNNeither_Click);
            // 
            // UploadToMapForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.BTNNeither);
            this.Controls.Add(this.BTNInject);
            this.Controls.Add(this.BTNExtract);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadToMapForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNExtract;
        private System.Windows.Forms.Button BTNInject;
        private System.Windows.Forms.Button BTNNeither;
    }
}