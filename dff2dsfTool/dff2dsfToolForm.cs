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

        public dff2dsfToolForm()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            InitializeComponent();
        }

        private void dff2dsfToolForm_Load(object sender, EventArgs e)
        {
            exePath                         = Settings.Default["exePath"].ToString();
            destinationPath                 = Settings.Default["destinationPath"].ToString();
            dff2dsfexePathLabel.Text        = Settings.Default["exePath"].ToString();
            DestinationFolderPathLabel.Text = Settings.Default["destinationPath"].ToString();
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
            SelectFileLabel.Text = sourcePath.Length == 1 ? sourcePath[0] : "Multiple files selected";
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
            foreach (var item in sourcePath)
            {
                string item0 = Regex.Replace(item, @"^(.*)\\", "");
                cmdArgs = "/K " + exePath + " \"" + item + "\" \"" + destinationPath + "\\" + item0.Replace("dff", "dsf") + "\"";
                Process.Start("cmd.exe", cmdArgs);
            }
        }
    }
}