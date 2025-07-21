namespace SecureHasher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnHashFile;
        private Button btnHashFolder;
        private Button btnHashZip;
        private Button btnGeneratePassword;
        private Button btnGitHub;
        private TextBox txtOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnHashFile = new Button();
            btnHashFolder = new Button();
            btnHashZip = new Button();
            btnGeneratePassword = new Button();
            btnGitHub = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnHashFile
            // 
            btnHashFile.Location = new Point(12, 12);
            btnHashFile.Name = "btnHashFile";
            btnHashFile.Size = new Size(75, 23);
            btnHashFile.TabIndex = 0;
            btnHashFile.Text = "Datei hashen";
            btnHashFile.Click += btnHashFile_Click;
            // 
            // btnHashFolder
            // 
            btnHashFolder.Location = new Point(120, 12);
            btnHashFolder.Name = "btnHashFolder";
            btnHashFolder.Size = new Size(75, 23);
            btnHashFolder.TabIndex = 1;
            btnHashFolder.Text = "Ordner hashen";
            btnHashFolder.Click += btnHashFolder_Click;
            // 
            // btnHashZip
            // 
            btnHashZip.Location = new Point(228, 12);
            btnHashZip.Name = "btnHashZip";
            btnHashZip.Size = new Size(75, 23);
            btnHashZip.TabIndex = 2;
            btnHashZip.Text = "ZIP hashen";
            btnHashZip.Click += btnHashZip_Click;
            // 
            // btnGeneratePassword
            // 
            btnGeneratePassword.Location = new Point(336, 12);
            btnGeneratePassword.Name = "btnGeneratePassword";
            btnGeneratePassword.Size = new Size(75, 23);
            btnGeneratePassword.TabIndex = 3;
            btnGeneratePassword.Text = "Passwort";
            btnGeneratePassword.Click += btnGeneratePassword_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.Location = new Point(444, 12);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(75, 23);
            btnGitHub.TabIndex = 4;
            btnGitHub.Text = "GitHub";
            btnGitHub.Click += btnGitHub_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 50);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(560, 300);
            txtOutput.TabIndex = 5;
            // 
            // MainForm
            // 
            ClientSize = new Size(584, 361);
            Controls.Add(btnHashFile);
            Controls.Add(btnHashFolder);
            Controls.Add(btnHashZip);
            Controls.Add(btnGeneratePassword);
            Controls.Add(btnGitHub);
            Controls.Add(txtOutput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "🔐 SecureHasher | ©Thorsten Bylicki | © BYLICKILABS";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}