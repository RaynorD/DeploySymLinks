namespace DeploySymlinks
{
	partial class Form1
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
			this.btnBrowseSrc = new System.Windows.Forms.Button();
			this.txtSrc = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDeploy = new System.Windows.Forms.TextBox();
			this.btnBrowseDeploy = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWildcard = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnBrowseSrc
			// 
			this.btnBrowseSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseSrc.Location = new System.Drawing.Point(729, 25);
			this.btnBrowseSrc.Name = "btnBrowseSrc";
			this.btnBrowseSrc.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseSrc.TabIndex = 0;
			this.btnBrowseSrc.Text = "Browse...";
			this.btnBrowseSrc.UseVisualStyleBackColor = true;
			this.btnBrowseSrc.Click += new System.EventHandler(this.BtnBrowseSrc_Click);
			// 
			// txtSrc
			// 
			this.txtSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSrc.Location = new System.Drawing.Point(12, 27);
			this.txtSrc.Name = "txtSrc";
			this.txtSrc.Size = new System.Drawing.Size(711, 20);
			this.txtSrc.TabIndex = 1;
			this.txtSrc.Text = "C:\\test\\source";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Source Directory:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 269);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Deploy Parent Directory:";
			// 
			// txtDeploy
			// 
			this.txtDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDeploy.Location = new System.Drawing.Point(11, 287);
			this.txtDeploy.Name = "txtDeploy";
			this.txtDeploy.Size = new System.Drawing.Size(711, 20);
			this.txtDeploy.TabIndex = 4;
			this.txtDeploy.Text = "C:\\test\\deploy";
			// 
			// btnBrowseDeploy
			// 
			this.btnBrowseDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseDeploy.Location = new System.Drawing.Point(728, 285);
			this.btnBrowseDeploy.Name = "btnBrowseDeploy";
			this.btnBrowseDeploy.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseDeploy.TabIndex = 3;
			this.btnBrowseDeploy.Text = "Browse...";
			this.btnBrowseDeploy.UseVisualStyleBackColor = true;
			this.btnBrowseDeploy.Click += new System.EventHandler(this.BtnBrowseDeploy_Click);
			// 
			// btnGo
			// 
			this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnGo.Location = new System.Drawing.Point(363, 361);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(92, 29);
			this.btnGo.TabIndex = 6;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(12, 54);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(792, 204);
			this.txtOutput.TabIndex = 7;
			this.txtOutput.WordWrap = false;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 317);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Folder Wildcard:";
			// 
			// txtWildcard
			// 
			this.txtWildcard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWildcard.Location = new System.Drawing.Point(12, 335);
			this.txtWildcard.Name = "txtWildcard";
			this.txtWildcard.Size = new System.Drawing.Size(791, 20);
			this.txtWildcard.TabIndex = 8;
			this.txtWildcard.Text = "testMission_v11*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 399);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtWildcard);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDeploy);
			this.Controls.Add(this.btnBrowseDeploy);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSrc);
			this.Controls.Add(this.btnBrowseSrc);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowseSrc;
		private System.Windows.Forms.TextBox txtSrc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDeploy;
		private System.Windows.Forms.Button btnBrowseDeploy;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtWildcard;
	}
}

