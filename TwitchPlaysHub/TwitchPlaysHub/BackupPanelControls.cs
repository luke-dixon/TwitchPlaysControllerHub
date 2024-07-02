using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchPlaysHub
{
    public partial class BackupPanelControls : UserControl
    {
        public BackupPanelControls()
        {
            InitializeComponent();
            fileSystemWatchers = new Dictionary<(string, string), FileSystemWatcher>();
        }

        private void BackupPanelControls_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BackupFilesList != null)
            {
                this.filesToBackupListView.Items.Clear();
                for (int i = 0; i < Math.Min(Properties.Settings.Default.BackupFilesList.Count, Properties.Settings.Default.BackupDirsList.Count); i++)
                {
                    var fileName = Properties.Settings.Default.BackupFilesList[i];
                    var backupDir = Properties.Settings.Default.BackupDirsList[i];
                    var listViewItem = new ListViewItem(new String[] { fileName, backupDir });
                    this.filesToBackupListView.Items.Add(listViewItem);

                    StartFileWatcher(fileName, backupDir);
                }
            }
        }

        private void StartFileWatcher(string fileName, string backupDir)
        {
            var watcher = new FileSystemWatcher(Path.GetDirectoryName(fileName));

            fileSystemWatchers.Add((fileName, backupDir), watcher);
            watcher.EnableRaisingEvents = true;
            watcher.Changed += (object sender, FileSystemEventArgs e) =>
            {
                OnFileChanged(sender, e, fileName, backupDir);
            };
        }

        private void StopFileWatcher(string fileName, string backupDir)
        {
            var fileSystemWatcher = fileSystemWatchers[(fileName, backupDir)];
            fileSystemWatcher.EnableRaisingEvents = false;
            fileSystemWatchers.Remove((fileName, backupDir));
        }

        private static void OnFileChanged(object sender, FileSystemEventArgs e, string fileName, string backupDir)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            if (e.FullPath != fileName)
            {
                return;
            }

            var baseFileName = Path.GetFileNameWithoutExtension(fileName);
            var fileExtension = Path.GetExtension(fileName);
            var backupFileName = baseFileName + "-" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss.fffffff") + fileExtension;
            var backupFilePath = Path.Combine(backupDir, backupFileName);
            
            File.Copy(fileName, backupFilePath);
        }

        private void SaveProperties()
        {
            Properties.Settings.Default.BackupFilesList.Clear();
            Properties.Settings.Default.BackupDirsList.Clear();
            foreach (ListViewItem item in this.filesToBackupListView.Items)
            {
                Properties.Settings.Default.BackupFilesList.Add(item.SubItems[0].Text);
                Properties.Settings.Default.BackupDirsList.Add(item.SubItems[1].Text);
            }
            Properties.Settings.Default.Save();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.filesToBackupListView.SelectedItems)
            {
                StopFileWatcher(item.SubItems[0].Text, item.SubItems[1].Text);
                BackupPanelAdd editForm = new BackupPanelAdd(item.SubItems[0].Text, item.SubItems[1].Text);
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    item.SubItems[0].Text = editForm.GetResult().SubItems[0].Text;
                    item.SubItems[1].Text = editForm.GetResult().SubItems[1].Text;
                    SaveProperties();
                    StartFileWatcher(item.SubItems[0].Text, item.SubItems[1].Text);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            BackupPanelAdd addForm = new BackupPanelAdd();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var item = addForm.GetResult();
                this.filesToBackupListView.Items.Add(item);
                SaveProperties();
                StartFileWatcher(item.SubItems[0].Text, item.SubItems[1].Text);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.filesToBackupListView.SelectedItems)
            {
                StopFileWatcher(item.SubItems[0].Text, item.SubItems[1].Text);
                this.filesToBackupListView.Items.Remove(item);
                this.deleteButton.Enabled = false;
                SaveProperties();
            }
        }

        private void filesToBackupListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.editButton.Enabled = false;
            this.deleteButton.Enabled = false;
            foreach (ListViewItem item in this.filesToBackupListView.SelectedItems) {
                this.editButton.Enabled = true;
                this.deleteButton.Enabled = true;
            }
        }

        private Dictionary<(string, string), FileSystemWatcher> fileSystemWatchers;
    }
}
