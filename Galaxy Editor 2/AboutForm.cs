using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;


namespace Galaxy_Editor_2
{
    public partial class AboutForm : AutoSizeForm
    {
        private ResourceManager LocRM = new ResourceManager("Galaxy_Editor_2.AboutForm", typeof(AboutForm).Assembly);

        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.islga.org/read-htm-tid-2152473-page-1-fpage-1.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.islga.org/home.php?mod=space&uid=4487&do=wall&from=space");
        }

        public void Show(Form parent)
        {
            base.Show(parent);   
            Location = new Point(parent.Location.X + (parent.Width - Width)/2,
                parent.Location.Y + (parent.Height - Height)/2);
        }
        
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sc2mapster.com/forums/resources/third-party-tools/19619-galaxy-editor/");
        }

        public void ApplyResource()
        {
            int Height = this.Height;
            int Width = this.Width;

            System.ComponentModel.ComponentResourceManager res = new ComponentResourceManager(typeof(AboutForm));
            foreach (Control ctl in Controls)
            {
                res.ApplyResources(ctl, ctl.Name);
            }

            //Caption
            res.ApplyResources(this, "$this");

            this.Height = Height;
            this.Width = Width;
            this.Refresh();
        }
    }
}
