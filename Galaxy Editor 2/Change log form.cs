using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Galaxy_Editor_2
{
    public partial class Change_log_form : Form
    {
        public Change_log_form()
        {
            InitializeComponent();

        }

        public void ApplyResource()
        {
            int Height = this.Height;
            int Width = this.Width;
            System.ComponentModel.ComponentResourceManager res = new ComponentResourceManager(typeof(Change_log_form));

            res.ApplyResources(richTextBox1, richTextBox1.Name);

            //Caption
            res.ApplyResources(this, "$this");

            this.Height = Height;
            this.Width = Width;
            this.Refresh();
        }

    }
}
