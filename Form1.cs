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
			txtOutput.AppendText(Environment.NewLine + text);
		}

		private void Log(string[] text)
		{
			txtOutput.AppendText(Environment.NewLine + string.Join(Environment.NewLine, text));
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
			Log("=============================");
			Log("Starting new deployment");

			DirectoryInfo dirSrc = new DirectoryInfo(txtSrc.Text);
			DirectoryInfo dirDeploy = new DirectoryInfo(txtDeploy.Text);
			string wildcard = txtWildcard.Text;

			Log("Source Directory: " + dirSrc.FullName);
			Log("Deploy Parent Directory: " + dirDeploy.FullName);
			Log("Folder Wildcard: " + wildcard);

			Log("--------------------------");

			Log("Source directories:");

			string[] srcDirs = Directory.GetDirectories(txtSrc.Text);
			var srcFiltered = srcDirs.Where(d => !(new DirectoryInfo(d)).Attributes.HasFlag(FileAttributes.Hidden));
			Log(srcFiltered.ToArray());

			Log("--------------------------");

			Log("Output directories:");

			string[] deployDirs = Directory.GetDirectories(txtDeploy.Text);
			var deployFiltered = deployDirs.Where(d => !(new DirectoryInfo(d)).Attributes.HasFlag(FileAttributes.Hidden));
			Log(deployFiltered.ToArray());

			Log("--------------------------");
		}
	}
}
