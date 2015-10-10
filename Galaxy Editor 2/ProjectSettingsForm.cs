﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;


namespace Galaxy_Editor_2
{
    public partial class ProjectSettingsForm : AutoSizeForm
    {
        private ResourceManager LocRM = new ResourceManager("Galaxy_Editor_2.ProjectSettingsForm", typeof(ProjectSettingsForm).Assembly);
        private bool initializing;

        public ProjectSettingsForm()
        {
            initializing = true;
            InitializeComponent();

            


            TBCurrentMap.Text = ProjectProperties.CurrentProjectPropperties.MapPath;
            if (TBCurrentMap.Text.Contains("\\"))
                TBCurrentMap.Text = TBCurrentMap.Text.Remove(0, TBCurrentMap.Text.LastIndexOf("\\") + 1);
            TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath;
            if (TBOutputMap.Text.Contains("\\"))
                TBOutputMap.Text = TBOutputMap.Text.Remove(0, TBOutputMap.Text.LastIndexOf("\\") + 1);
            CBSaveScriptToMap.Checked = ProjectProperties.CurrentProjectPropperties.LoadSaveScriptToMap;
            initializing = false;
        }

        private void BTNSelectCurrentMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = LocRM.GetString("SC2Map.Text") + "|" + LocRM.GetString("SC2Mod.Text");
            if (dialog.ShowDialog(this) == DialogResult.Cancel)
                return;
            TBCurrentMap.Text = ProjectProperties.CurrentProjectPropperties.MapPath = dialog.FileName;
            TBCurrentMap.Text = TBCurrentMap.Text.Remove(0, TBCurrentMap.Text.LastIndexOf("\\") + 1);

            if (ProjectProperties.CurrentProjectPropperties.InputMapIsMod != ProjectProperties.CurrentProjectPropperties.OutputMapIsMod)
            {
                TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = "";
            }

            Form1.Form.RefreshObjectBrowser();
            extractOrInjectScript();
            IOMapChanged();
        }

        
        private void TBCurrentMap_TextChanged(object sender, EventArgs e)
        {
            //ProjectProperties.CurrentProjectPropperties.MapPath = TBCurrentMap.Text;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
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
                if (dialog.SelectedPath.TrimEnd('\\', '/').ToLower().EndsWith(".sc2map") || dialog.SelectedPath.TrimEnd('\\', '/').ToLower().EndsWith(".sc2mod"))
                    break;
                MessageBox.Show(this, LocRM.GetString("ErrorMsg.Text"), LocRM.GetString("Error.Text"));
            }
            TBCurrentMap.Text = ProjectProperties.CurrentProjectPropperties.MapPath = dialog.SelectedPath.TrimEnd('\\', '/');
            TBCurrentMap.Text = TBCurrentMap.Text.Remove(0, TBCurrentMap.Text.LastIndexOf("\\") + 1);


            if (ProjectProperties.CurrentProjectPropperties.InputMapIsMod != ProjectProperties.CurrentProjectPropperties.OutputMapIsMod)
            {
                TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = "";
            }

            Form1.Form.RefreshObjectBrowser();
            extractOrInjectScript();
            IOMapChanged();
        }

        
        private void BTNSelectOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.Filter = LocRM.GetString("SC2Map.Text") + "|" + LocRM.GetString("SC2Mod.Text")                ;
            if (dialog.ShowDialog(this) == DialogResult.Cancel)
                return;
            TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = dialog.FileName;
            ProjectProperties.CurrentProjectPropperties.IsOutputDirectory = false;
            TBOutputMap.Text = TBOutputMap.Text.Remove(0, TBOutputMap.Text.LastIndexOf("\\") + 1);

            if (ProjectProperties.CurrentProjectPropperties.MapPath != "" && 
                ProjectProperties.CurrentProjectPropperties.OutputMapPath != "" &&
                ProjectProperties.CurrentProjectPropperties.InputMapIsMod != ProjectProperties.CurrentProjectPropperties.OutputMapIsMod)
            {
                TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = "";
                if (ProjectProperties.CurrentProjectPropperties.InputMapIsMod)
                    MessageBox.Show(this, LocRM.GetString("ErrorMsgMod.Text"), LocRM.GetString("Error.Text"));
                else
                    MessageBox.Show(this, LocRM.GetString("ErrorMsgMap.Text"), LocRM.GetString("Error.Text"));
            }
            IOMapChanged();
        }

        private void BTNSelectOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialog.ShowNewFolderButton = true;
            while (true)
            {
                if (dialog.ShowDialog(this) == DialogResult.Cancel)
                    return;
                if (dialog.SelectedPath.TrimEnd('\\', '/').ToLower().EndsWith(".sc2map") || dialog.SelectedPath.TrimEnd('\\', '/').ToLower().EndsWith(".sc2mod"))
                    break;
                MessageBox.Show(this, LocRM.GetString("ErrorMsg.Text"), LocRM.GetString("Error.Text"));
            }
            TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = dialog.SelectedPath.TrimEnd('\\', '/');
            ProjectProperties.CurrentProjectPropperties.IsOutputDirectory = true;
            TBOutputMap.Text = TBOutputMap.Text.Remove(0, TBOutputMap.Text.LastIndexOf("\\") + 1);

            if (ProjectProperties.CurrentProjectPropperties.MapPath != "" &&
                ProjectProperties.CurrentProjectPropperties.OutputMapPath != "" &&
                ProjectProperties.CurrentProjectPropperties.InputMapIsMod != ProjectProperties.CurrentProjectPropperties.OutputMapIsMod)
            {
                TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = "";
                if (ProjectProperties.CurrentProjectPropperties.InputMapIsMod)
                    MessageBox.Show(this, LocRM.GetString("ErrorMsgMod.Text"), LocRM.GetString("Error.Text"));
                else
                    MessageBox.Show(this, LocRM.GetString("ErrorMsgMap.Text"), LocRM.GetString("Error.Text"));
            }
            IOMapChanged();
        }

        private void BTNResetOutput_Click(object sender, EventArgs e)
        {
            TBOutputMap.Text = ProjectProperties.CurrentProjectPropperties.OutputMapPath = "";
        }

        private void BTNResetCurrentMap_Click(object sender, EventArgs e)
        {
            TBCurrentMap.Text = ProjectProperties.CurrentProjectPropperties.MapPath = "";
        }

        private void TBOutputMap_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveScriptToMap_CheckedChanged(object sender, EventArgs e)
        {
            if (initializing)
                return;
            ProjectProperties.CurrentProjectPropperties.LoadSaveScriptToMap = CBSaveScriptToMap.Checked;
            extractOrInjectScript();
        }

        private void extractOrInjectScript()
        {
            if (ProjectProperties.CurrentProjectPropperties.LoadSaveScriptToMap)
            {
                if (File.Exists(ProjectProperties.CurrentProjectPropperties.MapPath))
                {
                    UploadToMapForm questionForm = new UploadToMapForm();
                    questionForm.ShowDialog(this);
                    if (questionForm.Extract)
                    {
                        if (ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Exists)
                            //ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Delete(true);
                            Form1.DeleteDir(ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.FullName);
                        //ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir = new DirectoryInfo(ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.FullName);
                        ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Create();
                        MpqEditor.ExtractGalaxyppScriptFiles(
                            new FileInfo(ProjectProperties.CurrentProjectPropperties.MapPath),
                            ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir, true);
                        ProjectProperties.CurrentProjectPropperties.SrcFolder.FixConflicts(".galaxy++");
                        Form1.Form.ReloadSourceFiles();
                        Form1.Form.RebuildProjectView();
                        Form1.Form.UploadedChangesToMap = true;
                    }
                    else if (questionForm.Inject)
                    {
                        MpqEditor.SaveGalaxyppScriptFiles(
                            new FileInfo(ProjectProperties.CurrentProjectPropperties.MapPath),
                            ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir);
                        Form1.Form.UploadedChangesToMap = true;
                    }
                    else
                    {
                        CBSaveScriptToMap.Checked = false;
                    }
                }
                else if (Directory.Exists(ProjectProperties.CurrentProjectPropperties.MapPath))
                {
                    UploadToMapForm questionForm = new UploadToMapForm();
                    questionForm.ShowDialog(this);
                    if (questionForm.Extract)
                    {
                        if (ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Exists)
                            //ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Delete(true);
                            Form1.DeleteDir(ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.FullName);
                        //ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir = new DirectoryInfo(ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.FullName);
                        ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir.Create();

                        DirectoryInfo codeDir =
                            new DirectoryInfo(Path.Combine(ProjectProperties.CurrentProjectPropperties.MapPath,
                                                           "Galaxy++"));

                        if (!codeDir.Exists)
                        {
                            MessageBox.Show(this, LocRM.GetString("ErrorMsgScript.Text"), LocRM.GetString("Error.Text"));
                            return;
                        }

                        Form1.CopyDirectories(
                            codeDir,
                            ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir);
                        ProjectProperties.CurrentProjectPropperties.SrcFolder.FixConflicts("*.galaxy++");
                        Form1.Form.ReloadSourceFiles();
                        Form1.Form.RebuildProjectView();
                        Form1.Form.UploadedChangesToMap = true;
                    }
                    else if (questionForm.Inject)
                    {
                        string path = Path.Combine(ProjectProperties.CurrentProjectPropperties.MapPath,
                                                   "Galaxy++");
                        if (Directory.Exists(path))
                            Directory.Delete(path, true);
                        Form1.CopyDirectories(ProjectProperties.CurrentProjectPropperties.SrcFolder.Dir,
                            new DirectoryInfo(path));
                        Form1.Form.UploadedChangesToMap = true;
                    }
                    else
                    {
                        CBSaveScriptToMap.Checked = false;
                    }
                }
            }
        }

        private void IOMapChanged()
        {
            Form1.Form.ProjectMapsUpdated(ProjectProperties.CurrentProjectPropperties.IsMod);
        }

    }
}
