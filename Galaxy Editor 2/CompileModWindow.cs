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
    public partial class CompileModWindow : Form
    {
        private ResourceManager LocRM = new ResourceManager("Galaxy_Editor_2.CompileModWindow", typeof(CompileModWindow).Assembly);
        public CompileModWindow()
        {
            InitializeComponent();
        }

        private void CBUpload_CheckedChanged(object sender, EventArgs e)
        {
            GBUpload.Enabled = CBUpload.Checked;
        }

        private void CBProtectMap_CheckedChanged(object sender, EventArgs e)
        {
            GBProtect.Enabled = CBProtectMap.Checked;
        }

        private void BTNLoadMapFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = LocRM.GetString("SC2Map.Text");
            if (dialog.ShowDialog(this) == DialogResult.Cancel)
                return;
            TBMapPath.Text = dialog.FileName;
        }

        private void BTNLoadMapFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = ProjectProperties.CurrentProjectPropperties.MapPath == ""
                                      ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                                      : ProjectProperties.CurrentProjectPropperties.MapPath;
            dialog.ShowNewFolderButton = false;
            while (true)
            {
                if (dialog.ShowDialog(this) == DialogResult.Cancel)
                    return;
                if (dialog.SelectedPath.TrimEnd('\\', '/').ToLower().EndsWith(".sc2map"))
                    break;
                MessageBox.Show(this, LocRM.GetString("ErrorText.Text"), LocRM.GetString("Error.Text"));
            }
            TBMapPath.Text = dialog.SelectedPath.TrimEnd('\\', '/');
        }

        private void BTNCompile_Click(object sender, EventArgs e)
        {
            Options.Mod.AllowRename = CBAllowRename.Checked;
            Options.Mod.UploadNamingMap = CBUpload.Checked;
            //Extract mod name

        }
    }
}
