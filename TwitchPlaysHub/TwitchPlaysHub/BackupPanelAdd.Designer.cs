namespace TwitchPlaysHub
{
    partial class BackupPanelAdd
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
            this.fileToBackupLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.fileToBackupFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backupFolderLabel = new System.Windows.Forms.Label();
            this.fileToBackupButton = new System.Windows.Forms.Button();
            this.chosenFileLabel = new System.Windows.Forms.Label();
            this.chosenBackupDirLabel = new System.Windows.Forms.Label();
            this.backupDirButton = new System.Windows.Forms.Button();
            this.backupDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // fileToBackupLabel
            // 
            this.fileToBackupLabel.AutoSize = true;
            this.fileToBackupLabel.Location = new System.Drawing.Point(13, 13);
            this.fileToBackupLabel.Name = "fileToBackupLabel";
            this.fileToBackupLabel.Size = new System.Drawing.Size(91, 16);
            this.fileToBackupLabel.TabIndex = 0;
            this.fileToBackupLabel.Text = "File to backup";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(16, 137);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fileToBackupFileDialog
            // 
            this.fileToBackupFileDialog.InitialDirectory = "%userprofile%";
            this.fileToBackupFileDialog.Title = "File to backup";
            // 
            // backupFolderLabel
            // 
            this.backupFolderLabel.AutoSize = true;
            this.backupFolderLabel.Location = new System.Drawing.Point(16, 66);
            this.backupFolderLabel.Name = "backupFolderLabel";
            this.backupFolderLabel.Size = new System.Drawing.Size(90, 16);
            this.backupFolderLabel.TabIndex = 2;
            this.backupFolderLabel.Text = "Backup folder";
            // 
            // fileToBackupButton
            // 
            this.fileToBackupButton.Location = new System.Drawing.Point(133, 10);
            this.fileToBackupButton.Name = "fileToBackupButton";
            this.fileToBackupButton.Size = new System.Drawing.Size(75, 23);
            this.fileToBackupButton.TabIndex = 3;
            this.fileToBackupButton.Text = "Choose file";
            this.fileToBackupButton.UseVisualStyleBackColor = true;
            this.fileToBackupButton.Click += new System.EventHandler(this.fileToBackupButton_Click);
            // 
            // chosenFileLabel
            // 
            this.chosenFileLabel.AutoSize = true;
            this.chosenFileLabel.Location = new System.Drawing.Point(40, 41);
            this.chosenFileLabel.Name = "chosenFileLabel";
            this.chosenFileLabel.Size = new System.Drawing.Size(0, 16);
            this.chosenFileLabel.TabIndex = 4;
            // 
            // chosenBackupDirLabel
            // 
            this.chosenBackupDirLabel.AutoSize = true;
            this.chosenBackupDirLabel.Location = new System.Drawing.Point(31, 86);
            this.chosenBackupDirLabel.Name = "chosenBackupDirLabel";
            this.chosenBackupDirLabel.Size = new System.Drawing.Size(0, 16);
            this.chosenBackupDirLabel.TabIndex = 5;
            // 
            // backupDirButton
            // 
            this.backupDirButton.Location = new System.Drawing.Point(133, 66);
            this.backupDirButton.Name = "backupDirButton";
            this.backupDirButton.Size = new System.Drawing.Size(75, 23);
            this.backupDirButton.TabIndex = 6;
            this.backupDirButton.Text = "Choose file";
            this.backupDirButton.UseVisualStyleBackColor = true;
            this.backupDirButton.Click += new System.EventHandler(this.backupDirButton_Click);
            // 
            // BackupPanelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 172);
            this.Controls.Add(this.backupDirButton);
            this.Controls.Add(this.chosenBackupDirLabel);
            this.Controls.Add(this.chosenFileLabel);
            this.Controls.Add(this.fileToBackupButton);
            this.Controls.Add(this.backupFolderLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fileToBackupLabel);
            this.Name = "BackupPanelAdd";
            this.Text = "BackupPanelAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileToBackupLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.OpenFileDialog fileToBackupFileDialog;
        private System.Windows.Forms.Label backupFolderLabel;
        private System.Windows.Forms.Button fileToBackupButton;
        private System.Windows.Forms.Label chosenFileLabel;
        private System.Windows.Forms.Label chosenBackupDirLabel;
        private System.Windows.Forms.Button backupDirButton;
        private System.Windows.Forms.FolderBrowserDialog backupDirDialog;
    }
}