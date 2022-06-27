using CometUI;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MechVibesSoundPackInstaller
{
	public partial class MainForm : CometForm
	{
		public MainForm()
		{
			InitializeComponent();

			string cursor = Registry.CurrentUser.OpenSubKey("Control Panel").OpenSubKey("Cursors").GetValue("Hand").ToString();
			IntPtr cursorHandle = string.IsNullOrEmpty(cursor) ? IntPtr.Zero : LoadCursorFromFile(cursor);
			Cursor cursorHand = cursorHandle == IntPtr.Zero ? Cursors.Hand : new Cursor(cursorHandle);

			chckShowInstalledPack.Cursor = cursorHand;
			btnInstallSoundPack.Cursor = cursorHand;
		}

		[DllImport("user32.dll")]
		private static extern IntPtr LoadCursorFromFile(string lpFilename);

		private void InstallSoundPack(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(fileSoundPackPath.File))
				MessageBox.Show("Please select a soundpack to install it.", "No SoundPack Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				string mechvibesFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\mechvibes_custom";
				string soundpackName = Path.GetFileName(fileSoundPackPath.File);

				if (Directory.Exists($"{mechvibesFolder}\\{Path.GetFileNameWithoutExtension(soundpackName)}"))
					MessageBox.Show("Cannot install soundpack because it's already been installed into the custom soundpacks folder in Mechvibes.",
						"SoundPack Already Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					File.Copy(fileSoundPackPath.File, $"{mechvibesFolder}\\{soundpackName}");
					ZipFile.ExtractToDirectory(fileSoundPackPath.File, mechvibesFolder);
					File.Delete($"{mechvibesFolder}\\{soundpackName}");

					if (chckShowInstalledPack.Checked)
						Process.Start("explorer.exe", mechvibesFolder);

					int mechvibesCount = 0;
					foreach (Process proc in Process.GetProcesses())
						if (proc.ProcessName == "Mechvibes")
							mechvibesCount++;

					if (mechvibesCount >= 1)
					{
						if (MessageBox.Show("You need to restart MechVibes to load the new soundpack.\n\nWould you like to restart it now?",
							"SoundPack Installed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
						{
							foreach (Process proc in Process.GetProcesses())
								if (proc.ProcessName == "Mechvibes")
									proc.Kill();

							Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Programs\\mechvibes\\Mechvibes.exe");
						}
					}
					else
					{
						if (MessageBox.Show("Would you like to load Mechvibes with your new soundpack?", "Load Mechvibes",
							MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Programs\\mechvibes\\Mechvibes.exe");
					}
				}
			}
		}
	}
}
