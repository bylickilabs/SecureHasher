using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;

namespace SecureHasher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnHashFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                txtOutput.Text = string.Join(Environment.NewLine, new[]
                {
                    $"MD5: {ComputeHash(path, MD5.Create())}",
                    $"SHA1: {ComputeHash(path, SHA1.Create())}",
                    $"SHA256: {ComputeHash(path, SHA256.Create())}",
                    $"SHA512: {ComputeHash(path, SHA512.Create())}"
                });
            }
        }

        private void btnHashFolder_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();
                foreach (var file in Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories))
                {
                    sb.AppendLine($"{Path.GetFileName(file)} → SHA256: {ComputeHash(file, SHA256.Create())}");
                }
                txtOutput.Text = sb.ToString();
            }
        }

        private void btnHashZip_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new() { Filter = "ZIP files (*.zip)|*.zip" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();
                using var archive = ZipFile.OpenRead(ofd.FileName);
                foreach (var entry in archive.Entries)
                {
                    sb.AppendLine($"[{entry.FullName}] → {entry.Length} bytes");
                }
                txtOutput.Text = sb.ToString();
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtOutput.Text = GeneratePassword(16);
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/bylickilabs",
                UseShellExecute = true
            });
        }

        private static string ComputeHash(string filePath, HashAlgorithm algo)
        {
            using var stream = File.OpenRead(filePath);
            var hash = algo.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }

        private static string GeneratePassword(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
            var rnd = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(chars[rnd.Next(chars.Length)]);
            return sb.ToString();
        }
    }
}