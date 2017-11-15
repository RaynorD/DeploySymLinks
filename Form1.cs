using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DeploySymlinks
{

	public partial class Form1 : Form
	{
		[DllImport("kernel32.dll")]
		static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymbolicLink dwFlags);

		enum SymbolicLink
		{
			File = 0,
			Directory = 1
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Log(string text)
		{
			txtOutput.Text += Environment.NewLine + text;
		}

		private void Log(string[] text)
		{
			txtOutput.Text += Environment.NewLine + string.Join(Environment.NewLine, text);
		}

		private void UserSelectFolder(TextBox box)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if(!string.IsNullOrEmpty(box.Text) && Directory.Exists(box.Text))
			{
				dialog.SelectedPath = box.Text;
			}
			DialogResult res = dialog.ShowDialog();

			if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
			{
				box.Text = dialog.SelectedPath;
			}
		}

		private void BtnBrowseSrc_Click(object sender, EventArgs e)
		{
			UserSelectFolder(txtSrc);
		}

		private void BtnBrowseDeploy_Click(object sender, EventArgs e)
		{
			UserSelectFolder(txtDeploy);
		}

		private void BtnGo_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtSrc.Text) || !Directory.Exists(txtSrc.Text))
			{
				Log("Source folder not valid");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtDeploy.Text) || !Directory.Exists(txtDeploy.Text))
			{
				Log("Deploy folder not valid");
				return;
			}

			if (string.IsNullOrWhiteSpace(txtWildcard.Text))
			{
				Log("Wildcard text not valid");
				return;
			}

			Log("=============================");

			DirectoryInfo dirSrc = new DirectoryInfo(txtSrc.Text);
			DirectoryInfo dirDeploy = new DirectoryInfo(txtDeploy.Text);
			string wildcard = txtWildcard.Text;

			Log("Source Directory: " + dirSrc.FullName);
			Log("Deploy Parent Directory: " + dirDeploy.FullName);
			Log("Folder Wildcard: " + wildcard);

			Log("--------------------------");

			Log("Source directories:");

			string[] dirs = Directory.GetDirectories(txtSrc.Text);
			var filtered = dirs.Where(d => !(new DirectoryInfo(d)).Attributes.HasFlag(FileAttributes.Hidden));
			Log(filtered.ToArray());

			Log("--------------------------");
		}
	}
}
