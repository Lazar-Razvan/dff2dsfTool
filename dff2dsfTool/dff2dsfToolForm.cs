using System;
using System.Diagnostics;
using System.Windows.Forms;
using dff2dsfTool.Properties;

namespace dff2dsfTool
{
    public partial class dff2dsfToolForm : Form
    {
        private string exePath;
        private string sourcePath;
        private string sourceFileName;
        private string destinationPath;
        private string cmdArgs;

        public dff2dsfToolForm()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void dff2dsfToolForm_Load(object sender, EventArgs e)
        {
            exePath                         = Settings.Default["exePath"].ToString();
            sourcePath                      = Settings.Default["sourcePath"].ToString();
            destinationPath                 = Settings.Default["destinationPath"].ToString();
            sourceFileName                  = Settings.Default["sourceFileName"].ToString();
            dff2dsfexePathLabel.Text        = Settings.Default["exePath"].ToString();
            SourceFilePathLabel.Text        = Settings.Default["sourcePath"].ToString();
            DestinationFolderPathLabel.Text = Settings.Default["destinationPath"].ToString();
        }

        private void Selectdff2dsfexePathButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog0.ShowDialog() == DialogResult.OK) exePath = openFileDialog0.FileName;

            dff2dsfexePathLabel.Text = exePath;
            Settings.Default["exePath"] = exePath;
            Settings.Default["sourceFileName"] = sourceFileName;
            Settings.Default.Save();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath = openFileDialog.FileName;
                if (openFileDialog.SafeFileName != null)
                    sourceFileName = openFileDialog.SafeFileName.Replace("dff", "dsf");
            }

            SourceFilePathLabel.Text = sourcePath;
            Settings.Default["sourcePath"] = sourcePath;
            Settings.Default.Save();
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
            cmdArgs = "/K " + exePath + " \"" + sourcePath + "\" \"" + destinationPath + "\\" + sourceFileName + "\"";
            Process.Start("cmd.exe", cmdArgs);
            Clipboard.SetText(cmdArgs);
        }
    }
}
