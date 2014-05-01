namespace WallpaperHaxPlus
{
	partial class WelcomeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelBrowse = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.labelSizing = new System.Windows.Forms.Label();
			this.comboBoxSizing = new System.Windows.Forms.ComboBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.tableLayoutPanel.Controls.Add(this.labelTitle, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 6);
			this.tableLayoutPanel.Controls.Add(this.labelBrowse, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.textBoxPath, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.buttonBrowse, 1, 2);
			this.tableLayoutPanel.Controls.Add(this.labelSizing, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.comboBoxSizing, 0, 4);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 7;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(434, 234);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.labelTitle, 2);
			this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(10, 15);
			this.labelTitle.Margin = new System.Windows.Forms.Padding(10, 15, 10, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(414, 45);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "WallpaperHax";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonOK, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 188);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 11);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 46);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(349, 12);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(268, 12);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(0);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVersion.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVersion.Location = new System.Drawing.Point(10, 12);
			this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(98, 23);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "Version 1.0 beta 3";
			this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBrowse
			// 
			this.labelBrowse.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.labelBrowse, 2);
			this.labelBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBrowse.Location = new System.Drawing.Point(10, 70);
			this.labelBrowse.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
			this.labelBrowse.Name = "labelBrowse";
			this.labelBrowse.Size = new System.Drawing.Size(414, 15);
			this.labelBrowse.TabIndex = 3;
			this.labelBrowse.Text = "Picture location:";
			// 
			// textBoxPath
			// 
			this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPath.Enabled = false;
			this.textBoxPath.Location = new System.Drawing.Point(10, 88);
			this.textBoxPath.Margin = new System.Windows.Forms.Padding(10, 3, 3, 0);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(336, 22);
			this.textBoxPath.TabIndex = 4;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonBrowse.Location = new System.Drawing.Point(349, 88);
			this.buttonBrowse.Margin = new System.Windows.Forms.Padding(0, 3, 10, 0);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
			this.buttonBrowse.TabIndex = 5;
			this.buttonBrowse.Text = "&Browse...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// labelSizing
			// 
			this.labelSizing.AutoSize = true;
			this.tableLayoutPanel.SetColumnSpan(this.labelSizing, 2);
			this.labelSizing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSizing.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSizing.Location = new System.Drawing.Point(10, 119);
			this.labelSizing.Margin = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.labelSizing.Name = "labelSizing";
			this.labelSizing.Size = new System.Drawing.Size(414, 15);
			this.labelSizing.TabIndex = 6;
			this.labelSizing.Text = "Picture position:";
			// 
			// comboBoxSizing
			// 
			this.tableLayoutPanel.SetColumnSpan(this.comboBoxSizing, 2);
			this.comboBoxSizing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxSizing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSizing.FormattingEnabled = true;
			this.comboBoxSizing.Items.AddRange(new object[] {
            "Center",
            "Stretch",
            "Fit",
            "Fill"});
			this.comboBoxSizing.Location = new System.Drawing.Point(10, 137);
			this.comboBoxSizing.Margin = new System.Windows.Forms.Padding(10, 3, 10, 15);
			this.comboBoxSizing.Name = "comboBoxSizing";
			this.comboBoxSizing.Size = new System.Drawing.Size(414, 21);
			this.comboBoxSizing.TabIndex = 8;
			this.comboBoxSizing.SelectedIndexChanged += new System.EventHandler(this.comboBoxSizing_SelectedIndexChanged);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Images|*.png; *.jpg; *.gif; *.bmp";
			this.openFileDialog.ShowHelp = true;
			this.openFileDialog.Title = "Choose Picture";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(434, 234);
			this.Controls.Add(this.tableLayoutPanel);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WelcomeForm";
			this.Text = "WallpaperHax Setup";
			this.tableLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelBrowse;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Label labelSizing;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.ComboBox comboBoxSizing;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}