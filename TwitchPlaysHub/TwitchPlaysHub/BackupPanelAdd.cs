using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchPlaysHub
{
    public partial class BackupPanelAdd : Form
    {
        public BackupPanelAdd()
        {
            InitializeComponent();
        }

        public BackupPanelAdd(string fileToBackup, string backupDir)
        {
            InitializeComponent();
            this.addButton.Text = "Save";

            if (File.Exists(fileToBackup))
            {
                this.fileToBackupFileDialog.FileName = fileToBackup;
                this.chosenFileLabel.Text = Path.GetFileName(fileToBackup);
            }
            if (Directory.Exists(backupDir))
            {
                this.backupDirDialog.SelectedPath = backupDir;
                this.chosenBackupDirLabel.Text = Path.GetFileName(backupDir);
            }
            updateSaveButton();
        }

        private void updateSaveButton()
        {
            if (this.fileToBackupFileDialog.FileName.Length > 0 && this.backupDirDialog.SelectedPath.Length > 0)
            {
                this.addButton.Enabled = true;
            }
            else
            {
                this.addButton.Enabled = false;
            }
        }

        private void fileToBackupButton_Click(object sender, EventArgs e)
        {
            if (this.fileToBackupFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.chosenFileLabel.Text = Path.GetFileName(this.fileToBackupFileDialog.FileName);
                updateSaveButton();
            }
        }

        private void backupDirButton_Click(object sender, EventArgs e)
        {
            if (this.backupDirDialog.ShowDialog() == DialogResult.OK)
            {
                this.chosenBackupDirLabel.Text = Path.GetFileName(this.backupDirDialog.SelectedPath);
                updateSaveButton();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public ListViewItem GetResult()
        {
            if (this.DialogResult != DialogResult.OK)
            {
                throw new Exception("Dialog was not successful, check for DialogResult.OK before calling this method.");
            }
            return new ListViewItem(new String[] {this.fileToBackupFileDialog.FileName, this.backupDirDialog.SelectedPath});
        }
    }
}
