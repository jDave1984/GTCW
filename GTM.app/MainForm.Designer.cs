
namespace GTM.app
{
    partial class MainForm
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.GameFolderButton = new System.Windows.Forms.Button();
            this.GameFolder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // GameFolderButton
            // 
            this.GameFolderButton.ForeColor = System.Drawing.Color.Black;
            this.GameFolderButton.Location = new System.Drawing.Point(12, 26);
            this.GameFolderButton.Name = "GameFolderButton";
            this.GameFolderButton.Size = new System.Drawing.Size(71, 19);
            this.GameFolderButton.TabIndex = 0;
            this.GameFolderButton.Text = "Browse";
            this.GameFolderButton.UseVisualStyleBackColor = true;
            this.GameFolderButton.Click += new System.EventHandler(this.GameFolderButton_Click);
            // 
            // GameFolder
            // 
            this.GameFolder.AutoSize = true;
            this.GameFolder.Location = new System.Drawing.Point(89, 32);
            this.GameFolder.Name = "GameFolder";
            this.GameFolder.Size = new System.Drawing.Size(143, 13);
            this.GameFolder.TabIndex = 1;
            this.GameFolder.Text = "Path to Game Folder Not Set";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1984, 961);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameFolder);
            this.Controls.Add(this.GameFolderButton);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Tactician Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button GameFolderButton;
        private System.Windows.Forms.Label GameFolder;
        private System.Windows.Forms.Button button1;
    }
}

