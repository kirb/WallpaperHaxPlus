using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Timers;

namespace WallpaperHaxPlus
{
	public partial class WallpaperForm : Form
	{
		private const int SW_HIDE = 0;

		[DllImport("user32.dll", SetLastError = true)]
		static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
		[DllImport("user32.dll", SetLastError = true)]
		static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		public WallpaperForm()
		{
			InitializeComponent();

			// add handlers
			SystemEvents.DisplaySettingsChanged += SystemEvents_DisplaySettingsChanged;

			// make child of the desktop list view
			IntPtr progmanHwnd = FindWindowEx(IntPtr.Zero, IntPtr.Zero, "Progman", null);
			IntPtr defviewHwnd = FindWindowEx(progmanHwnd, IntPtr.Zero, "SHELLDLL_DefView", null);
			SetParent(this.Handle, FindWindowEx(defviewHwnd, IntPtr.Zero, "SysListView32", null));

			// hide powershell
			ShowWindow(FindWindowEx(IntPtr.Zero, IntPtr.Zero, "ConsoleWindowClass", null), SW_HIDE);

			// do our thing
			UpdateWallpaper();
		}

		public void UpdateWallpaper()
		{
			this.BackgroundImage = Image.FromFile((string)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", "C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg"));

			Int32 style = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", 2));

			switch (style)
			{
				case 0:
				default:
					this.BackgroundImageLayout = ImageLayout.Center;
					break;

				case 2:
					this.BackgroundImageLayout = ImageLayout.Stretch;
					break;

				case 6:
				case 10:
					this.BackgroundImageLayout = ImageLayout.Zoom;
					break;
			}
		}

		private void WallpaperForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
		}

		private void WallpaperForm_LocationChanged(object sender, EventArgs e)
		{
			SizeToFit();
		}

		private void WallpaperForm_VisibleChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void WallpaperForm_Deactivate(object sender, EventArgs e)
		{
			this.Activate();
		}

		private void WallpaperForm_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
		{
			SizeToFit();
		}

		private void WallpaperForm_Load(object sender, EventArgs e)
		{
			Int32 lastVersion = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Software\\PCHax Technology\\WallpaperHaxPlus", "LastVersion", 0));

			if (lastVersion == 0)
			{
				System.Timers.Timer timer = new System.Timers.Timer(500);
				timer.Enabled = true;
				timer.AutoReset = false;
				timer.Elapsed += new ElapsedEventHandler(ShowSettingsTimer_Elapsed);
				timer.Start();
			}

			Registry.SetValue("HKEY_CURRENT_USER\\Software\\PCHax Technology\\WallpaperHaxPlus", "LastVersion", 1, RegistryValueKind.DWord);
		}

		private void SizeToFit()
		{
			this.Top = -1;
			this.Left = -1;
			this.Width = Screen.PrimaryScreen.Bounds.Width + 2;
			this.Height = Screen.PrimaryScreen.Bounds.Height + 2;
		}

		private void showIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenDesktop();
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				OpenDesktop();
			}
		}

		private void OpenDesktop()
		{
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)); // TODO: laaaaame
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will reset your wallpaper back to the default.", "WallpaperHax", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
			{
				Environment.Exit(0);
			}
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowSettings();
		}

		private void ShowSettingsTimer_Elapsed(object sender, EventArgs e)
		{
			ShowSettings(); // wtf
		}

		private void ShowSettings()
		{
			WelcomeForm welcomeForm = new WelcomeForm();
			welcomeForm.WallpaperForm = this;
			welcomeForm.ShowDialog();
		}
	}
}
