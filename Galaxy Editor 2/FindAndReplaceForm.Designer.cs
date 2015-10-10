namespace Galaxy_Editor_2
{
    partial class FindAndReplaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAndReplaceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TBFind = new System.Windows.Forms.TextBox();
            this.TBReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNFind = new System.Windows.Forms.Button();
            this.BTNReplace = new System.Windows.Forms.Button();
            this.BTNReplaceAll = new System.Windows.Forms.Button();
            this.RBCurrent = new System.Windows.Forms.RadioButton();
            this.RBProject = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CBLookSource = new System.Windows.Forms.CheckBox();
            this.CBLookOutput = new System.Windows.Forms.CheckBox();
            this.CBMatchCase = new System.Windows.Forms.CheckBox();
            this.CBSearchUp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TBFind
            // 
            resources.ApplyResources(this.TBFind, "TBFind");
            this.TBFind.Name = "TBFind";
            this.TBFind.TextChanged += new System.EventHandler(this.TBFind_TextChanged);
            // 
            // TBReplace
            // 
            resources.ApplyResources(this.TBReplace, "TBReplace");
            this.TBReplace.Name = "TBReplace";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // BTNFind
            // 
            resources.ApplyResources(this.BTNFind, "BTNFind");
            this.BTNFind.Name = "BTNFind";
            this.BTNFind.UseVisualStyleBackColor = true;
            this.BTNFind.Click += new System.EventHandler(this.BTNFind_Click);
            // 
            // BTNReplace
            // 
            resources.ApplyResources(this.BTNReplace, "BTNReplace");
            this.BTNReplace.Name = "BTNReplace";
            this.BTNReplace.UseVisualStyleBackColor = true;
            this.BTNReplace.Click += new System.EventHandler(this.BTNReplace_Click);
            // 
            // BTNReplaceAll
            // 
            resources.ApplyResources(this.BTNReplaceAll, "BTNReplaceAll");
            this.BTNReplaceAll.Name = "BTNReplaceAll";
            this.BTNReplaceAll.UseVisualStyleBackColor = true;
            this.BTNReplaceAll.Click += new System.EventHandler(this.BTNReplaceAll_Click);
            // 
            // RBCurrent
            // 
            resources.ApplyResources(this.RBCurrent, "RBCurrent");
            this.RBCurrent.Checked = true;
            this.RBCurrent.Name = "RBCurrent";
            this.RBCurrent.TabStop = true;
            this.RBCurrent.UseVisualStyleBackColor = true;
            // 
            // RBProject
            // 
            resources.ApplyResources(this.RBProject, "RBProject");
            this.RBProject.Name = "RBProject";
            this.RBProject.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // CBLookSource
            // 
            resources.ApplyResources(this.CBLookSource, "CBLookSource");
            this.CBLookSource.Name = "CBLookSource";
            this.CBLookSource.UseVisualStyleBackColor = true;
            this.CBLookSource.CheckedChanged += new System.EventHandler(this.CBLook_CheckedChanged);
            // 
            // CBLookOutput
            // 
            resources.ApplyResources(this.CBLookOutput, "CBLookOutput");
            this.CBLookOutput.Name = "CBLookOutput";
            this.CBLookOutput.UseVisualStyleBackColor = true;
            this.CBLookOutput.CheckedChanged += new System.EventHandler(this.CBLook_CheckedChanged);
            // 
            // CBMatchCase
            // 
            resources.ApplyResources(this.CBMatchCase, "CBMatchCase");
            this.CBMatchCase.Name = "CBMatchCase";
            this.CBMatchCase.UseVisualStyleBackColor = true;
            // 
            // CBSearchUp
            // 
            resources.ApplyResources(this.CBSearchUp, "CBSearchUp");
            this.CBSearchUp.Name = "CBSearchUp";
            this.CBSearchUp.UseVisualStyleBackColor = true;
            // 
            // FindAndReplaceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CBSearchUp);
            this.Controls.Add(this.CBMatchCase);
            this.Controls.Add(this.CBLookOutput);
            this.Controls.Add(this.CBLookSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RBProject);
            this.Controls.Add(this.RBCurrent);
            this.Controls.Add(this.BTNReplaceAll);
            this.Controls.Add(this.BTNReplace);
            this.Controls.Add(this.BTNFind);
            this.Controls.Add(this.TBReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FindAndReplaceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindAndReplaceForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindAndReplaceForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBFind;
        private System.Windows.Forms.TextBox TBReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNFind;
        private System.Windows.Forms.Button BTNReplace;
        private System.Windows.Forms.Button BTNReplaceAll;
        private System.Windows.Forms.RadioButton RBCurrent;
        private System.Windows.Forms.RadioButton RBProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBLookSource;
        private System.Windows.Forms.CheckBox CBLookOutput;
        private System.Windows.Forms.CheckBox CBMatchCase;
        private System.Windows.Forms.CheckBox CBSearchUp;
    }
}