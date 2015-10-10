namespace Galaxy_Editor_2
{
    partial class NewConstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewConstructorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.BTNOK = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.checkBoxPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BTNOK
            // 
            resources.ApplyResources(this.BTNOK, "BTNOK");
            this.BTNOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.UseVisualStyleBackColor = true;
            // 
            // BTNCancel
            // 
            resources.ApplyResources(this.BTNCancel, "BTNCancel");
            this.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPanel
            // 
            resources.ApplyResources(this.checkBoxPanel, "checkBoxPanel");
            this.checkBoxPanel.BackColor = System.Drawing.Color.White;
            this.checkBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkBoxPanel.Name = "checkBoxPanel";
            // 
            // NewConstructorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxPanel);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNOK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewConstructorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNOK;
        private System.Windows.Forms.Button BTNCancel;
        private System.Windows.Forms.Panel checkBoxPanel;
    }
}