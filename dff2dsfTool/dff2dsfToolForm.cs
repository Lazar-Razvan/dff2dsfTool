using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using dff2dsfTool.Properties;

namespace dff2dsfTool
{
    public partial class dff2dsfToolForm : Form
    {
        private string exePath;
        private string[] sourcePath;
        private string destinationPath;
        private string cmdArgs;
        private bool hasRun;

        public dff2dsfToolForm()
        {
            InitializeComponent();
        }

        private void dff2dsfToolForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.exePath))
            {
                exePath                  = Settings.Default["exePath"].ToString();
                dff2dsfexePathLabel.Text = Settings.Default["exePath"].ToString();
                LogBox.AppendText("Loaded dff2dsf.exe path from settings: " + Settings.Default.exePath + "\n");
            }
            if (!string.IsNullOrEmpty(Settings.Default.destinationPath))
            {
                destinationPath                 = Settings.Default["destinationPath"].ToString();
                DestinationFolderPathLabel.Text = Settings.Default["destinationPath"].ToString();
                LogBox.AppendText("Loaded destination folder path from settings: " + Settings.Default.destinationPath +
                                  "\n\n");
            }
        }

        private void Selectdff2dsfexePathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog0.ShowDialog() == DialogResult.OK) exePath = openFileDialog0.FileName;

            dff2dsfexePathLabel.Text = exePath;
            Settings.Default["exePath"] = exePath;
            Settings.Default.Save();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) sourcePath = openFileDialog.FileNames;
            try
            {
                SelectFileLabel.Text = sourcePath.Length == 1 ? sourcePath[0] : "Multiple files selected";
            }
            catch (NullReferenceException) { }
        }

        private void SelectDestinationButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) destinationPath = folderBrowserDialog.SelectedPath;

            DestinationFolderPathLabel.Text = destinationPath;
            Settings.Default["destinationPath"] = destinationPath;
            Settings.Default.Save();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string time = "[" + DateTime.Now.TimeOfDay.ToString().Substring(0, 8) + "] ";

            if (hasRun) LogBox.AppendText("\n\n");

            try
            {
                foreach (var item in sourcePath)
                {
                    string item0 = Regex.Replace(item, @"^(.*)\\", "");
                    cmdArgs = "/c " + exePath + " \"" + item + "\" \"" + destinationPath + "\\" + item0.Replace("dff", "dsf") + "\"";

                    var p = new ProcessStartInfo("cmd.exe")
                    {
                        Arguments = cmdArgs,
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    var process = Process.Start(p);
                    string error = process?.StandardError.ReadLine();

                    if (error != null && error.Contains("error"))
                        LogBox.AppendText(time + error);
                    else
                        LogBox.AppendText(time + "Converted: " + item + "\n");
                }
            }
            catch (NullReferenceException) { }

            hasRun = true;
        }

        private void SelectFileLabel_MouseHover(object sender, EventArgs e)
        {
            string labelPath = string.Empty;
            try
            {
                if (sourcePath.Length == 1)
                    toolTip.SetToolTip(SelectFileLabel, sourcePath[0]);
                else
                    foreach (var item in sourcePath)
                    {
                        labelPath = labelPath + item + "\n";
                        toolTip.SetToolTip(SelectFileLabel, labelPath);
                    }
            }
            catch (NullReferenceException) { }
        }

        private void dff2dsfexePathLabel_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(dff2dsfexePathLabel, exePath);
            }
            catch (NullReferenceException) { }
        }

        private void DestinationFolderPathLabel_MouseHover(object sender, EventArgs e)
        {
            try
            {
                toolTip.SetToolTip(DestinationFolderPathLabel, destinationPath);
            }
            catch (NullReferenceException) { }
        }

        private void dff2dsfexePathLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "/select," + exePath);
            }
            catch (NullReferenceException) { }
        }

        private void SelectFileLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "/select," + sourcePath[0]);
            }
            catch (NullReferenceException) { }
        }

        private void DestinationFolderPathLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(destinationPath);
            }
            catch (NullReferenceException) { }
        }

        private void LogBoxContextMenuClear_Click(object sender, EventArgs e)
        {
            LogBox.Clear();
        }
    }
}