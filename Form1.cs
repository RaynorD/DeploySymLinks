using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DeploySymlinks
{

	public partial class Form1 : Form
	{
		[DllImport("kernel32.dll", SetLastError=true)]
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

		private void Form1_Load(object sender, EventArgs e)
		{
			txtSrc.Text = Properties.filepath.Default.txtSourcePath;
			txtDeploy.Text = Properties.filepath.Default.txtDeployPath;
			txtWildcard.Text = Properties.filepath.Default.txtWildcard;
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
			Properties.filepath.Default.txtSourcePath = txtSrc.Text;
			Properties.filepath.Default.txtDeployPath = txtDeploy.Text;
			Properties.filepath.Default.txtWildcard = txtWildcard.Text;
			Properties.filepath.Default.Save();

			if (string.IsNullOrWhiteSpace(txtSrc.Text) || !Directory.Exists(txtSrc.Text))
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

			Log("Source Directory: " + dirSrc.ToString());
			Log("Deploy Parent Directory: " + dirDeploy.ToString());
			Log("Folder Wildcard: " + wildcard);

			Log("--------------------------");

			Log("Source directories:");

			DirectoryInfo[] srcDirs = Directory.GetDirectories(txtSrc.Text).Select(d => new DirectoryInfo(d)).ToArray();
			var srcFiltered = srcDirs.Where(d => !d.Attributes.HasFlag(FileAttributes.Hidden));
			Log(srcFiltered.Select(d => d.Name).ToArray());

			Log("--------------------------");

			Log("Output directories:");

			DirectoryInfo[] deployDirs = Directory.GetDirectories(txtDeploy.Text, wildcard).Select(d => new DirectoryInfo(d)).ToArray();
			var deployFiltered = deployDirs.Where(d => !d.Attributes.HasFlag(FileAttributes.Hidden));
			Log(deployFiltered.Select(d => d.Name).ToArray());

			Log("--------------------------");

			int deploySuccess = 0;
			int deployFail = 0;

			foreach (DirectoryInfo deployDirInfo in deployFiltered)
			{
				foreach (DirectoryInfo srcDirInfo in srcFiltered)
				{
					string output = "Deploy ";
					if (CreateSymbolicLink(deployDirInfo.FullName + @"\" + srcDirInfo.Name, srcDirInfo.FullName, SymbolicLink.Directory))
					{
						output += "Successful - ";
						deploySuccess++;
					} else
					{
						output += "Failed (" + Marshal.GetLastWin32Error() + ") - ";
						deployFail++;
					}
					output += deployDirInfo.Name + @"\" + srcDirInfo.Name;
					Log(output);
				}
			}
			Log("Deploy complete - Success: " + deploySuccess + " - Failed: " + deployFail);
			Log("------------");
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.filepath.Default.txtSourcePath = txtSrc.Text;
			Properties.filepath.Default.txtDeployPath = txtDeploy.Text;
			Properties.filepath.Default.txtWildcard = txtWildcard.Text;
			Properties.filepath.Default.Save();
		}
	}
}
