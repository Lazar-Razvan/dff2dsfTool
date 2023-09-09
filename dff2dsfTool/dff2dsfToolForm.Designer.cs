﻿namespace dff2dsfTool
{
    partial class dff2dsfToolForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SelectDestinationButton = new System.Windows.Forms.Button();
            this.DestinationFolderPathLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dff2dsfexePathLabel = new System.Windows.Forms.Label();
            this.Selectdff2dsfexePathButton = new System.Windows.Forms.Button();
            this.openFileDialog0 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LogBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogBoxContextMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.LogBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "DFF Files (*.dff)|*.dff";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectFileButton.Location = new System.Drawing.Point(12, 36);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(133, 23);
            this.SelectFileButton.TabIndex = 2;
            this.SelectFileButton.Text = "Select DFF file(s)";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SelectDestinationButton
            // 
            this.SelectDestinationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectDestinationButton.Location = new System.Drawing.Point(12, 65);
            this.SelectDestinationButton.Name = "SelectDestinationButton";
            this.SelectDestinationButton.Size = new System.Drawing.Size(133, 23);
            this.SelectDestinationButton.TabIndex = 4;
            this.SelectDestinationButton.Text = "Select Destination Folder";
            this.SelectDestinationButton.UseVisualStyleBackColor = true;
            this.SelectDestinationButton.Click += new System.EventHandler(this.SelectDestinationButton_Click);
            // 
            // DestinationFolderPathLabel
            // 
            this.DestinationFolderPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderPathLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DestinationFolderPathLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinationFolderPathLabel.Location = new System.Drawing.Point(147, 70);
            this.DestinationFolderPathLabel.Name = "DestinationFolderPathLabel";
            this.DestinationFolderPathLabel.Size = new System.Drawing.Size(583, 13);
            this.DestinationFolderPathLabel.TabIndex = 5;
            this.DestinationFolderPathLabel.Click += new System.EventHandler(this.DestinationFolderPathLabel_Click);
            this.DestinationFolderPathLabel.MouseHover += new System.EventHandler(this.DestinationFolderPathLabel_MouseHover);
            // 
            // GoButton
            // 
            this.GoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GoButton.Location = new System.Drawing.Point(12, 92);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(31, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // dff2dsfexePathLabel
            // 
            this.dff2dsfexePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dff2dsfexePathLabel.BackColor = System.Drawing.SystemColors.Control;
            this.dff2dsfexePathLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dff2dsfexePathLabel.Location = new System.Drawing.Point(147, 12);
            this.dff2dsfexePathLabel.Name = "dff2dsfexePathLabel";
            this.dff2dsfexePathLabel.Size = new System.Drawing.Size(583, 13);
            this.dff2dsfexePathLabel.TabIndex = 1;
            this.dff2dsfexePathLabel.Click += new System.EventHandler(this.dff2dsfexePathLabel_Click);
            this.dff2dsfexePathLabel.MouseHover += new System.EventHandler(this.dff2dsfexePathLabel_MouseHover);
            // 
            // Selectdff2dsfexePathButton
            // 
            this.Selectdff2dsfexePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Selectdff2dsfexePathButton.Location = new System.Drawing.Point(12, 7);
            this.Selectdff2dsfexePathButton.Name = "Selectdff2dsfexePathButton";
            this.Selectdff2dsfexePathButton.Size = new System.Drawing.Size(133, 23);
            this.Selectdff2dsfexePathButton.TabIndex = 0;
            this.Selectdff2dsfexePathButton.Text = "Select dff2dsf.exe path";
            this.Selectdff2dsfexePathButton.UseVisualStyleBackColor = true;
            this.Selectdff2dsfexePathButton.Click += new System.EventHandler(this.Selectdff2dsfexePathButton_Click);
            // 
            // openFileDialog0
            // 
            this.openFileDialog0.FileName = "openFileDialog0";
            this.openFileDialog0.Filter = "EXE Files (*.exe)|*.exe";
            this.openFileDialog0.RestoreDirectory = true;
            // 
            // SelectFileLabel
            // 
            this.SelectFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFileLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SelectFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFileLabel.Location = new System.Drawing.Point(147, 41);
            this.SelectFileLabel.Name = "SelectFileLabel";
            this.SelectFileLabel.Size = new System.Drawing.Size(583, 13);
            this.SelectFileLabel.TabIndex = 7;
            this.SelectFileLabel.Click += new System.EventHandler(this.SelectFileLabel_Click);
            this.SelectFileLabel.MouseHover += new System.EventHandler(this.SelectFileLabel_MouseHover);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.ContextMenuStrip = this.LogBoxContextMenu;
            this.LogBox.Location = new System.Drawing.Point(12, 121);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(718, 134);
            this.LogBox.TabIndex = 8;
            this.LogBox.Text = "";
            this.LogBox.WordWrap = false;
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // LogBoxContextMenu
            // 
            this.LogBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogBoxContextMenuClear});
            this.LogBoxContextMenu.Name = "LogBoxContextMenu";
            this.LogBoxContextMenu.Size = new System.Drawing.Size(102, 26);
            // 
            // LogBoxContextMenuClear
            // 
            this.LogBoxContextMenuClear.Name = "LogBoxContextMenuClear";
            this.LogBoxContextMenuClear.Size = new System.Drawing.Size(101, 22);
            this.LogBoxContextMenuClear.Text = "Clear";
            this.LogBoxContextMenuClear.Click += new System.EventHandler(this.LogBoxContextMenuClear_Click);
            // 
            // dff2dsfToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.SelectFileLabel);
            this.Controls.Add(this.dff2dsfexePathLabel);
            this.Controls.Add(this.Selectdff2dsfexePathButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.DestinationFolderPathLabel);
            this.Controls.Add(this.SelectDestinationButton);
            this.Controls.Add(this.SelectFileButton);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "dff2dsfToolForm";
            this.ShowIcon = false;
            this.Text = "dff2dsf Tool";
            this.Load += new System.EventHandler(this.dff2dsfToolForm_Load);
            this.LogBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button SelectDestinationButton;
        private System.Windows.Forms.Label DestinationFolderPathLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label dff2dsfexePathLabel;
        private System.Windows.Forms.Button Selectdff2dsfexePathButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog0;
        private System.Windows.Forms.Label SelectFileLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.ContextMenuStrip LogBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem LogBoxContextMenuClear;
    }
}

