namespace MechVibesSoundPackInstaller
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblSoundPackPath = new CometUI.CometLabel();
			this.fileSoundPackPath = new CometUI.CometFileInput();
			this.btnInstallSoundPack = new CometUI.CometButton();
			this.chckShowInstalledPack = new CometUI.CometCheckBox();
			this.SuspendLayout();
			// 
			// lblSoundPackPath
			// 
			this.lblSoundPackPath.AutoSize = true;
			this.lblSoundPackPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lblSoundPackPath.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblSoundPackPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lblSoundPackPath.Location = new System.Drawing.Point(12, 47);
			this.lblSoundPackPath.Name = "lblSoundPackPath";
			this.lblSoundPackPath.Size = new System.Drawing.Size(83, 19);
			this.lblSoundPackPath.TabIndex = 0;
			this.lblSoundPackPath.Text = "Sound Pack:";
			// 
			// fileSoundPackPath
			// 
			this.fileSoundPackPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.fileSoundPackPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.fileSoundPackPath.Cursor = System.Windows.Forms.Cursors.Default;
			this.fileSoundPackPath.DefaultFilter = 1;
			this.fileSoundPackPath.DialogTitle = "Please select the soundpack to install...";
			this.fileSoundPackPath.FileChooserColor = System.Drawing.Color.DodgerBlue;
			this.fileSoundPackPath.FileFilter = "SoundPack|*.zip";
			this.fileSoundPackPath.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.fileSoundPackPath.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.fileSoundPackPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.fileSoundPackPath.InputType = CometUI.CometFileInputType.OpenFile;
			this.fileSoundPackPath.Location = new System.Drawing.Point(101, 44);
			this.fileSoundPackPath.Name = "fileSoundPackPath";
			this.fileSoundPackPath.Size = new System.Drawing.Size(262, 26);
			this.fileSoundPackPath.TabIndex = 1;
			this.fileSoundPackPath.UnderlineBorder = false;
			// 
			// btnInstallSoundPack
			// 
			this.btnInstallSoundPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.btnInstallSoundPack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInstallSoundPack.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btnInstallSoundPack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.btnInstallSoundPack.Location = new System.Drawing.Point(243, 84);
			this.btnInstallSoundPack.Name = "btnInstallSoundPack";
			this.btnInstallSoundPack.Size = new System.Drawing.Size(120, 39);
			this.btnInstallSoundPack.TabIndex = 2;
			this.btnInstallSoundPack.Text = "Install SoundPack";
			this.btnInstallSoundPack.Click += new System.EventHandler(this.InstallSoundPack);
			// 
			// chckShowInstalledPack
			// 
			this.chckShowInstalledPack.AutoSize = true;
			this.chckShowInstalledPack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.chckShowInstalledPack.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.chckShowInstalledPack.Checked = true;
			this.chckShowInstalledPack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chckShowInstalledPack.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.chckShowInstalledPack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.chckShowInstalledPack.Location = new System.Drawing.Point(12, 92);
			this.chckShowInstalledPack.Name = "chckShowInstalledPack";
			this.chckShowInstalledPack.Size = new System.Drawing.Size(198, 23);
			this.chckShowInstalledPack.TabIndex = 3;
			this.chckShowInstalledPack.Text = "Show Pack After Installation";
			this.chckShowInstalledPack.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(375, 135);
			this.Controls.Add(this.chckShowInstalledPack);
			this.Controls.Add(this.btnInstallSoundPack);
			this.Controls.Add(this.fileSoundPackPath);
			this.Controls.Add(this.lblSoundPackPath);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(375, 135);
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MechVibes SoundPack Installer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometLabel lblSoundPackPath;
		private CometUI.CometFileInput fileSoundPackPath;
		private CometUI.CometButton btnInstallSoundPack;
		private CometUI.CometCheckBox chckShowInstalledPack;
	}
}

