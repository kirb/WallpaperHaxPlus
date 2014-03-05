﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

			// hide console
			ShowWindow(FindWindowEx(IntPtr.Zero, IntPtr.Zero, "ConsoleWindowClass", null), SW_HIDE);

			// load image
			this.BackgroundImage = Image.FromFile((string)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", "C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg"));

			// set sizing
			Int32 style = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", 2));

			switch (style)
			{
				case 0:
				default:
					this.BackgroundImageLayout = ImageLayout.Center;
					break;

				case 1:
				case 2: // TOOD: this is probably wrong
					this.BackgroundImageLayout = ImageLayout.Stretch;
					break;

				case 3:
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

		private void SizeToFit()
		{
			this.Top = 0;
			this.Left = 0;
			this.Width = Screen.PrimaryScreen.Bounds.Width;
			this.Height = Screen.PrimaryScreen.Bounds.Height;
		}
	}
}