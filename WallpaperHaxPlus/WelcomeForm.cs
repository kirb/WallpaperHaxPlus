using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WallpaperHaxPlus
{
	public partial class WelcomeForm : Form
	{
		public WallpaperForm WallpaperForm;
		private string OldPath;
		private Int32 OldStyle;

		public WelcomeForm()
		{
			InitializeComponent();

			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

			textBoxPath.Text = OldPath = (string)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", "C:\\Windows\\Web\\Wallpaper\\Windows\\img0.jpg");
			Int32 style = OldStyle = Convert.ToInt32(Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", 2));

			switch (style)
			{
				case 0:
				default:
					comboBoxSizing.SelectedIndex = 0;
					break;

				case 2:
					comboBoxSizing.SelectedIndex = 1;
					break;

				case 6:
					comboBoxSizing.SelectedIndex = 2;
					break;

				case 10:
					comboBoxSizing.SelectedIndex = 3;
					break;
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			WallpaperForm.UpdateWallpaper();
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", OldPath, RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", OldStyle, RegistryValueKind.DWord);

			WallpaperForm.UpdateWallpaper();
			this.Close();
		}

		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			textBoxPath.Text = openFileDialog.FileName;
			UpdateRegistry();
		}

		private void UpdateRegistry()
		{
			if (textBoxPath.Text == "" || WallpaperForm == null)
			{
				return;
			}

			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", textBoxPath.Text, RegistryValueKind.String);

			Int32 style = 0;

			switch (comboBoxSizing.SelectedIndex)
			{
				case 0:
				default:
					style = 0;
					break;

				case 1:
					style = 2;
					break;

				case 2:
					style = 6;
					break;

				case 3:
					style = 10;
					break;
			}

			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", style, RegistryValueKind.DWord);

			WallpaperForm.UpdateWallpaper();
		}

		private void comboBoxSizing_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateRegistry();
		}
	}
}
