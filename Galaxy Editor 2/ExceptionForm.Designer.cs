namespace Galaxy_Editor_2
{
    partial class ExceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userMessage = new System.Windows.Forms.RichTextBox();
            this.exceptionMessage = new System.Windows.Forms.RichTextBox();
            this.BTNSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            this.CBSendCode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // userMessage
            // 
            resources.ApplyResources(this.userMessage, "userMessage");
            this.userMessage.Name = "userMessage";
            // 
            // exceptionMessage
            // 
            resources.ApplyResources(this.exceptionMessage, "exceptionMessage");
            this.exceptionMessage.Name = "exceptionMessage";
            this.exceptionMessage.ReadOnly = true;
            // 
            // BTNSend
            // 
            resources.ApplyResources(this.BTNSend, "BTNSend");
            this.BTNSend.Name = "BTNSend";
            this.BTNSend.UseVisualStyleBackColor = true;
            this.BTNSend.Click += new System.EventHandler(this.BTNSend_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // BTNClose
            // 
            resources.ApplyResources(this.BTNClose, "BTNClose");
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // CBSendCode
            // 
            resources.ApplyResources(this.CBSendCode, "CBSendCode");
            this.CBSendCode.Name = "CBSendCode";
            this.CBSendCode.UseVisualStyleBackColor = true;
            // 
            // ExceptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBSendCode);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNSend);
            this.Controls.Add(this.exceptionMessage);
            this.Controls.Add(this.userMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExceptionForm";
            this.Load += new System.EventHandler(this.ExceptionForm_Load);
            this.Shown += new System.EventHandler(this.ExceptionForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox userMessage;
        private System.Windows.Forms.RichTextBox exceptionMessage;
        private System.Windows.Forms.Button BTNSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.CheckBox CBSendCode;
    }
}