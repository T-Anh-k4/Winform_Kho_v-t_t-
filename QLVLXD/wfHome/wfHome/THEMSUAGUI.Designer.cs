namespace wfHome
{
	partial class THEMSUAGUI
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kbtn_Them_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.cbx_don_vi_tinh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.txb_xuat_xu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Ten_hang = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Malh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Mahh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.kbtn_thoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbx_don_vi_tinh)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbx_don_vi_tinh);
			this.panel1.Controls.Add(this.txb_xuat_xu);
			this.panel1.Controls.Add(this.txb_Ten_hang);
			this.panel1.Controls.Add(this.txb_Malh);
			this.panel1.Controls.Add(this.txb_Mahh);
			this.panel1.Location = new System.Drawing.Point(1, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(611, 314);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(122, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Đơn vị tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(321, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Xuất xứ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Tên hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(320, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mã loại hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Mã hàng";
			// 
			// kbtn_Them_sua
			// 
			this.kbtn_Them_sua.Location = new System.Drawing.Point(309, 348);
			this.kbtn_Them_sua.Name = "kbtn_Them_sua";
			this.kbtn_Them_sua.Size = new System.Drawing.Size(128, 45);
			this.kbtn_Them_sua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.StateCommon.Border.Rounding = 10;
			this.kbtn_Them_sua.TabIndex = 4;
			this.kbtn_Them_sua.Values.Text = "Thêm";
			this.kbtn_Them_sua.Click += new System.EventHandler(this.kbtn_Them_sua_Click);
			// 
			// cbx_don_vi_tinh
			// 
			this.cbx_don_vi_tinh.DropDownWidth = 311;
			this.cbx_don_vi_tinh.Location = new System.Drawing.Point(125, 217);
			this.cbx_don_vi_tinh.Name = "cbx_don_vi_tinh";
			this.cbx_don_vi_tinh.Size = new System.Drawing.Size(331, 41);
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.Rounding = 30;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.Width = 1;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.cbx_don_vi_tinh.TabIndex = 6;
			this.cbx_don_vi_tinh.Text = "Đơn vị tính";
			this.cbx_don_vi_tinh.DropDown += new System.EventHandler(this.cbx_don_vi_tinh_DropDown);
			// 
			// txb_xuat_xu
			// 
			this.txb_xuat_xu.Location = new System.Drawing.Point(323, 137);
			this.txb_xuat_xu.Multiline = true;
			this.txb_xuat_xu.Name = "txb_xuat_xu";
			this.txb_xuat_xu.Size = new System.Drawing.Size(268, 46);
			this.txb_xuat_xu.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_xuat_xu.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_xuat_xu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_xuat_xu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_xuat_xu.StateCommon.Border.Rounding = 20;
			this.txb_xuat_xu.StateCommon.Border.Width = 1;
			this.txb_xuat_xu.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
			this.txb_xuat_xu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.txb_xuat_xu.TabIndex = 5;
			this.txb_xuat_xu.Text = "Nhập xuất xứ";
			// 
			// txb_Ten_hang
			// 
			this.txb_Ten_hang.Location = new System.Drawing.Point(20, 137);
			this.txb_Ten_hang.Multiline = true;
			this.txb_Ten_hang.Name = "txb_Ten_hang";
			this.txb_Ten_hang.Size = new System.Drawing.Size(268, 46);
			this.txb_Ten_hang.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Ten_hang.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Ten_hang.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_Ten_hang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Ten_hang.StateCommon.Border.Rounding = 20;
			this.txb_Ten_hang.StateCommon.Border.Width = 1;
			this.txb_Ten_hang.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
			this.txb_Ten_hang.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.txb_Ten_hang.TabIndex = 4;
			this.txb_Ten_hang.Text = "Nhập tên hàng";
			// 
			// txb_Malh
			// 
			this.txb_Malh.Location = new System.Drawing.Point(323, 48);
			this.txb_Malh.Multiline = true;
			this.txb_Malh.Name = "txb_Malh";
			this.txb_Malh.Size = new System.Drawing.Size(268, 46);
			this.txb_Malh.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Malh.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Malh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_Malh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Malh.StateCommon.Border.Rounding = 20;
			this.txb_Malh.StateCommon.Border.Width = 1;
			this.txb_Malh.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
			this.txb_Malh.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.txb_Malh.TabIndex = 3;
			this.txb_Malh.Text = "Nhập mã loại hàng";
			// 
			// txb_Mahh
			// 
			this.txb_Mahh.Location = new System.Drawing.Point(20, 48);
			this.txb_Mahh.Multiline = true;
			this.txb_Mahh.Name = "txb_Mahh";
			this.txb_Mahh.Size = new System.Drawing.Size(268, 46);
			this.txb_Mahh.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Mahh.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Mahh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_Mahh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Mahh.StateCommon.Border.Rounding = 20;
			this.txb_Mahh.StateCommon.Border.Width = 1;
			this.txb_Mahh.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
			this.txb_Mahh.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.txb_Mahh.TabIndex = 2;
			this.txb_Mahh.Text = "Nhập mã hàng hóa";
			// 
			// kryptonPalette1
			// 
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			// 
			// kbtn_thoat
			// 
			this.kbtn_thoat.Location = new System.Drawing.Point(454, 348);
			this.kbtn_thoat.Name = "kbtn_thoat";
			this.kbtn_thoat.Size = new System.Drawing.Size(128, 45);
			this.kbtn_thoat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_thoat.StateCommon.Border.Rounding = 10;
			this.kbtn_thoat.TabIndex = 3;
			this.kbtn_thoat.Values.Text = "Thoát";
			this.kbtn_thoat.Click += new System.EventHandler(this.kbtn_thoat_Click);
			// 
			// THEMSUAGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(617, 393);
			this.Controls.Add(this.kbtn_thoat);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.kbtn_Them_sua);
			this.Name = "THEMSUAGUI";
			this.Palette = this.kryptonPalette1;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm_Sửa";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbx_don_vi_tinh)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Mahh;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_don_vi_tinh;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_xuat_xu;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Ten_hang;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Malh;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_thoat;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Them_sua;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}