namespace TwitchPlaysHub
{
    partial class BackupPanelControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesToBackupLabel = new System.Windows.Forms.Label();
            this.filesToBackupListView = new System.Windows.Forms.ListView();
            this.fileToBackupHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backupDirHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // filesToBackupLabel
            // 
            this.filesToBackupLabel.AutoSize = true;
            this.filesToBackupLabel.Location = new System.Drawing.Point(18, 13);
            this.filesToBackupLabel.Name = "filesToBackupLabel";
            this.filesToBackupLabel.Size = new System.Drawing.Size(169, 16);
            this.filesToBackupLabel.TabIndex = 7;
            this.filesToBackupLabel.Text = "Files backed up on change";
            // 
            // filesToBackupListView
            // 
            this.filesToBackupListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileToBackupHeader,
            this.backupDirHeader});
            this.filesToBackupListView.GridLines = true;
            this.filesToBackupListView.HideSelection = false;
            this.filesToBackupListView.Location = new System.Drawing.Point(21, 32);
            this.filesToBackupListView.MultiSelect = false;
            this.filesToBackupListView.Name = "filesToBackupListView";
            this.filesToBackupListView.Size = new System.Drawing.Size(472, 332);
            this.filesToBackupListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.filesToBackupListView.TabIndex = 8;
            this.filesToBackupListView.UseCompatibleStateImageBehavior = false;
            this.filesToBackupListView.View = System.Windows.Forms.View.Details;
            this.filesToBackupListView.SelectedIndexChanged += new System.EventHandler(this.filesToBackupListView_SelectedIndexChanged);
            // 
            // fileToBackupHeader
            // 
            this.fileToBackupHeader.Text = "File to backup";
            this.fileToBackupHeader.Width = 225;
            // 
            // backupDirHeader
            // 
            this.backupDirHeader.Text = "Backup folder";
            this.backupDirHeader.Width = 257;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 370);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add new file";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(133, 370);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 23);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(245, 370);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // BackupPanelControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.filesToBackupListView);
            this.Controls.Add(this.filesToBackupLabel);
            this.Name = "BackupPanelControls";
            this.Size = new System.Drawing.Size(668, 516);
            this.Load += new System.EventHandler(this.BackupPanelControls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filesToBackupLabel;
        private System.Windows.Forms.ListView filesToBackupListView;
        private System.Windows.Forms.ColumnHeader fileToBackupHeader;
        private System.Windows.Forms.ColumnHeader backupDirHeader;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
