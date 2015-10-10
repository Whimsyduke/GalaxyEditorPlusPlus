namespace Galaxy_Editor_2
{
    partial class SearcDefinitionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearcDefinitionsForm));
            this.CB_Method = new System.Windows.Forms.RadioButton();
            this.CB_Field = new System.Windows.Forms.RadioButton();
            this.CB_Type = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_EndsWith = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_StartsWith = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Contains = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_Params = new System.Windows.Forms.GroupBox();
            this.BTN_RemoveParameters = new System.Windows.Forms.Button();
            this.LB_Parameters = new System.Windows.Forms.ListBox();
            this.BTN_AddParameter = new System.Windows.Forms.Button();
            this.LB_Types = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TB_Output = new System.Windows.Forms.RichTextBox();
            this.GB_Type = new System.Windows.Forms.GroupBox();
            this.CB_RType = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB_Params.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GB_Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Method
            // 
            resources.ApplyResources(this.CB_Method, "CB_Method");
            this.CB_Method.Checked = true;
            this.CB_Method.Name = "CB_Method";
            this.CB_Method.TabStop = true;
            this.CB_Method.UseVisualStyleBackColor = true;
            this.CB_Method.CheckedChanged += new System.EventHandler(this.CB_Method_CheckedChanged);
            // 
            // CB_Field
            // 
            resources.ApplyResources(this.CB_Field, "CB_Field");
            this.CB_Field.Name = "CB_Field";
            this.CB_Field.UseVisualStyleBackColor = true;
            // 
            // CB_Type
            // 
            resources.ApplyResources(this.CB_Type, "CB_Type");
            this.CB_Type.Name = "CB_Type";
            this.CB_Type.UseVisualStyleBackColor = true;
            this.CB_Type.CheckedChanged += new System.EventHandler(this.CB_Type_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_EndsWith);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_StartsWith);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_Contains);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TB_EndsWith
            // 
            resources.ApplyResources(this.TB_EndsWith, "TB_EndsWith");
            this.TB_EndsWith.Name = "TB_EndsWith";
            this.TB_EndsWith.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TB_StartsWith
            // 
            resources.ApplyResources(this.TB_StartsWith, "TB_StartsWith");
            this.TB_StartsWith.Name = "TB_StartsWith";
            this.TB_StartsWith.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // TB_Contains
            // 
            resources.ApplyResources(this.TB_Contains, "TB_Contains");
            this.TB_Contains.Name = "TB_Contains";
            this.TB_Contains.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.CB_Method);
            this.groupBox2.Controls.Add(this.CB_Field);
            this.groupBox2.Controls.Add(this.CB_Type);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // GB_Params
            // 
            resources.ApplyResources(this.GB_Params, "GB_Params");
            this.GB_Params.Controls.Add(this.BTN_RemoveParameters);
            this.GB_Params.Controls.Add(this.LB_Parameters);
            this.GB_Params.Controls.Add(this.BTN_AddParameter);
            this.GB_Params.Controls.Add(this.LB_Types);
            this.GB_Params.Controls.Add(this.label5);
            this.GB_Params.Name = "GB_Params";
            this.GB_Params.TabStop = false;
            // 
            // BTN_RemoveParameters
            // 
            resources.ApplyResources(this.BTN_RemoveParameters, "BTN_RemoveParameters");
            this.BTN_RemoveParameters.Name = "BTN_RemoveParameters";
            this.BTN_RemoveParameters.UseVisualStyleBackColor = true;
            this.BTN_RemoveParameters.Click += new System.EventHandler(this.BTN_RemoveParameters_Click);
            // 
            // LB_Parameters
            // 
            resources.ApplyResources(this.LB_Parameters, "LB_Parameters");
            this.LB_Parameters.FormattingEnabled = true;
            this.LB_Parameters.Name = "LB_Parameters";
            // 
            // BTN_AddParameter
            // 
            resources.ApplyResources(this.BTN_AddParameter, "BTN_AddParameter");
            this.BTN_AddParameter.Name = "BTN_AddParameter";
            this.BTN_AddParameter.UseVisualStyleBackColor = true;
            this.BTN_AddParameter.Click += new System.EventHandler(this.BTN_AddParameter_Click);
            // 
            // LB_Types
            // 
            resources.ApplyResources(this.LB_Types, "LB_Types");
            this.LB_Types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LB_Types.FormattingEnabled = true;
            this.LB_Types.Name = "LB_Types";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.button1);
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.TB_Output);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // TB_Output
            // 
            resources.ApplyResources(this.TB_Output, "TB_Output");
            this.TB_Output.Name = "TB_Output";
            // 
            // GB_Type
            // 
            resources.ApplyResources(this.GB_Type, "GB_Type");
            this.GB_Type.Controls.Add(this.CB_RType);
            this.GB_Type.Name = "GB_Type";
            this.GB_Type.TabStop = false;
            // 
            // CB_RType
            // 
            resources.ApplyResources(this.CB_RType, "CB_RType");
            this.CB_RType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RType.FormattingEnabled = true;
            this.CB_RType.Name = "CB_RType";
            this.CB_RType.SelectedIndexChanged += new System.EventHandler(this.InputChanged);
            // 
            // SearcDefinitionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GB_Params);
            this.Controls.Add(this.GB_Type);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "SearcDefinitionsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GB_Params.ResumeLayout(false);
            this.GB_Params.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.GB_Type.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton CB_Method;
        private System.Windows.Forms.RadioButton CB_Field;
        private System.Windows.Forms.RadioButton CB_Type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_EndsWith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_StartsWith;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Contains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox GB_Params;
        private System.Windows.Forms.Button BTN_RemoveParameters;
        private System.Windows.Forms.ListBox LB_Parameters;
        private System.Windows.Forms.Button BTN_AddParameter;
        private System.Windows.Forms.ComboBox LB_Types;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox TB_Output;
        private System.Windows.Forms.GroupBox GB_Type;
        private System.Windows.Forms.ComboBox CB_RType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}