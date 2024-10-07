namespace wfHome
{
	partial class HangHoaGui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoaGui));
			this.pn_data = new System.Windows.Forms.Panel();
			this.k_datagrview_hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.pn_nut_tao = new System.Windows.Forms.Panel();
			this.kybtn_pn_themsua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.pn_nhap = new System.Windows.Forms.Panel();
			this.kbtn_Them_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbx_don_vi_tinh = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.txb_xuat_xu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Ten_hang = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Malh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Mahh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txb_tim_kiem_TT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.pn_tab_trang = new System.Windows.Forms.Panel();
			this.bt_next_page = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.bt_back_page = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.pn_data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).BeginInit();
			this.pn_nut_tao.SuspendLayout();
			this.pn_nhap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbx_don_vi_tinh)).BeginInit();
			this.panel1.SuspendLayout();
			this.pn_tab_trang.SuspendLayout();
			this.SuspendLayout();
			// 
			// pn_data
			// 
			this.pn_data.BackColor = System.Drawing.Color.White;
			this.pn_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pn_data.Controls.Add(this.k_datagrview_hang_hoa);
			this.pn_data.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_data.Location = new System.Drawing.Point(0, 270);
			this.pn_data.Name = "pn_data";
			this.pn_data.Size = new System.Drawing.Size(1069, 423);
			this.pn_data.TabIndex = 2;
			// 
			// k_datagrview_hang_hoa
			// 
			this.k_datagrview_hang_hoa.AllowUserToAddRows = false;
			this.k_datagrview_hang_hoa.AllowUserToResizeColumns = false;
			this.k_datagrview_hang_hoa.AllowUserToResizeRows = false;
			this.k_datagrview_hang_hoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.k_datagrview_hang_hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.k_datagrview_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.k_datagrview_hang_hoa.Location = new System.Drawing.Point(0, 0);
			this.k_datagrview_hang_hoa.Name = "k_datagrview_hang_hoa";
			this.k_datagrview_hang_hoa.RowHeadersVisible = false;
			this.k_datagrview_hang_hoa.RowHeadersWidth = 4;
			this.k_datagrview_hang_hoa.RowTemplate.Height = 45;
			this.k_datagrview_hang_hoa.Size = new System.Drawing.Size(1067, 421);
			this.k_datagrview_hang_hoa.StateCommon.Background.Color1 = System.Drawing.Color.White;
			this.k_datagrview_hang_hoa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
			this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Width = 1;
			this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Border.Width = 1;
			this.k_datagrview_hang_hoa.TabIndex = 2;
			this.k_datagrview_hang_hoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrview_hang_hoa_CellClick);
			// 
			// pn_nut_tao
			// 
			this.pn_nut_tao.BackColor = System.Drawing.Color.White;
			this.pn_nut_tao.Controls.Add(this.txb_tim_kiem_TT);
			this.pn_nut_tao.Controls.Add(this.kybtn_pn_themsua);
			this.pn_nut_tao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_nut_tao.Location = new System.Drawing.Point(0, 0);
			this.pn_nut_tao.Name = "pn_nut_tao";
			this.pn_nut_tao.Size = new System.Drawing.Size(1069, 58);
			this.pn_nut_tao.TabIndex = 3;
			// 
			// kybtn_pn_themsua
			// 
			this.kybtn_pn_themsua.Location = new System.Drawing.Point(1010, 5);
			this.kybtn_pn_themsua.Name = "kybtn_pn_themsua";
			this.kybtn_pn_themsua.Size = new System.Drawing.Size(46, 46);
			this.kybtn_pn_themsua.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kybtn_pn_themsua.StateCommon.Back.Image")));
			this.kybtn_pn_themsua.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
			this.kybtn_pn_themsua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kybtn_pn_themsua.StateCommon.Border.Rounding = 50;
			this.kybtn_pn_themsua.StateCommon.Border.Width = 1;
			this.kybtn_pn_themsua.TabIndex = 3;
			this.kybtn_pn_themsua.Values.Text = "";
			this.kybtn_pn_themsua.Click += new System.EventHandler(this.kybtn_pn_themsua_Click);
			// 
			// pn_nhap
			// 
			this.pn_nhap.Controls.Add(this.kbtn_Them_sua);
			this.pn_nhap.Controls.Add(this.label5);
			this.pn_nhap.Controls.Add(this.label4);
			this.pn_nhap.Controls.Add(this.label3);
			this.pn_nhap.Controls.Add(this.label2);
			this.pn_nhap.Controls.Add(this.label6);
			this.pn_nhap.Controls.Add(this.cbx_don_vi_tinh);
			this.pn_nhap.Controls.Add(this.txb_xuat_xu);
			this.pn_nhap.Controls.Add(this.txb_Ten_hang);
			this.pn_nhap.Controls.Add(this.txb_Malh);
			this.pn_nhap.Controls.Add(this.txb_Mahh);
			this.pn_nhap.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_nhap.Location = new System.Drawing.Point(0, 58);
			this.pn_nhap.Name = "pn_nhap";
			this.pn_nhap.Size = new System.Drawing.Size(1069, 212);
			this.pn_nhap.TabIndex = 4;
			// 
			// kbtn_Them_sua
			// 
			this.kbtn_Them_sua.Location = new System.Drawing.Point(914, 145);
			this.kbtn_Them_sua.Name = "kbtn_Them_sua";
			this.kbtn_Them_sua.Size = new System.Drawing.Size(128, 45);
			this.kbtn_Them_sua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.StateCommon.Border.Rounding = 10;
			this.kbtn_Them_sua.TabIndex = 21;
			this.kbtn_Them_sua.Values.Text = "Thêm";
			this.kbtn_Them_sua.Click += new System.EventHandler(this.kbtn_Them_sua_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(728, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Đơn vị tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(396, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "Xuất xứ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Tên hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(395, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Mã loại hàng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Mã hàng";
			// 
			// cbx_don_vi_tinh
			// 
			this.cbx_don_vi_tinh.DropDownWidth = 311;
			this.cbx_don_vi_tinh.Location = new System.Drawing.Point(728, 40);
			this.cbx_don_vi_tinh.Name = "cbx_don_vi_tinh";
			this.cbx_don_vi_tinh.Size = new System.Drawing.Size(298, 41);
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.Rounding = 30;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Border.Width = 1;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
			this.cbx_don_vi_tinh.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.cbx_don_vi_tinh.TabIndex = 15;
			this.cbx_don_vi_tinh.Text = "Đơn vị tính";
			this.cbx_don_vi_tinh.DropDown += new System.EventHandler(this.cbx_don_vi_tinh_DropDown);
			// 
			// txb_xuat_xu
			// 
			this.txb_xuat_xu.Location = new System.Drawing.Point(398, 130);
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
			this.txb_xuat_xu.TabIndex = 14;
			this.txb_xuat_xu.Text = "Nhập xuất xứ";
			// 
			// txb_Ten_hang
			// 
			this.txb_Ten_hang.Location = new System.Drawing.Point(34, 130);
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
			this.txb_Ten_hang.TabIndex = 13;
			this.txb_Ten_hang.Text = "Nhập tên hàng";
			// 
			// txb_Malh
			// 
			this.txb_Malh.Location = new System.Drawing.Point(398, 39);
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
			this.txb_Malh.TabIndex = 12;
			this.txb_Malh.Text = "Nhập mã loại hàng";
			// 
			// txb_Mahh
			// 
			this.txb_Mahh.Location = new System.Drawing.Point(34, 39);
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
			this.txb_Mahh.TabIndex = 11;
			this.txb_Mahh.Text = "Nhập mã hàng hóa";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pn_tab_trang);
			this.panel1.Controls.Add(this.pn_data);
			this.panel1.Controls.Add(this.pn_nhap);
			this.panel1.Controls.Add(this.pn_nut_tao);
			this.panel1.Location = new System.Drawing.Point(248, 93);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1069, 756);
			this.panel1.TabIndex = 5;
			// 
			// txb_tim_kiem_TT
			// 
			this.txb_tim_kiem_TT.Location = new System.Drawing.Point(31, 7);
			this.txb_tim_kiem_TT.Multiline = true;
			this.txb_tim_kiem_TT.Name = "txb_tim_kiem_TT";
			this.txb_tim_kiem_TT.Size = new System.Drawing.Size(398, 43);
			this.txb_tim_kiem_TT.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_tim_kiem_TT.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_tim_kiem_TT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_tim_kiem_TT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_tim_kiem_TT.StateCommon.Border.Rounding = 20;
			this.txb_tim_kiem_TT.StateCommon.Border.Width = 1;
			this.txb_tim_kiem_TT.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
			this.txb_tim_kiem_TT.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 10, 0);
			this.txb_tim_kiem_TT.TabIndex = 4;
			this.txb_tim_kiem_TT.Text = "Tìm kiếm";
			// 
			// pn_tab_trang
			// 
			this.pn_tab_trang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pn_tab_trang.Controls.Add(this.bt_back_page);
			this.pn_tab_trang.Controls.Add(this.bt_next_page);
			this.pn_tab_trang.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_tab_trang.Location = new System.Drawing.Point(0, 693);
			this.pn_tab_trang.Name = "pn_tab_trang";
			this.pn_tab_trang.Size = new System.Drawing.Size(1069, 62);
			this.pn_tab_trang.TabIndex = 5;
			// 
			// bt_next_page
			// 
			this.bt_next_page.Location = new System.Drawing.Point(936, 14);
			this.bt_next_page.Name = "bt_next_page";
			this.bt_next_page.Size = new System.Drawing.Size(90, 25);
			this.bt_next_page.TabIndex = 0;
			this.bt_next_page.Values.Text = "kryptonButton1";
			// 
			// bt_back_page
			// 
			this.bt_back_page.Location = new System.Drawing.Point(804, 14);
			this.bt_back_page.Name = "bt_back_page";
			this.bt_back_page.Size = new System.Drawing.Size(90, 25);
			this.bt_back_page.TabIndex = 1;
			this.bt_back_page.Values.Text = "kryptonButton2";
			// 
			// HangHoaGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(1333, 861);
			this.Controls.Add(this.panel1);
			this.Name = "HangHoaGui";
			this.Text = "HangHoaGui";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.pn_data.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).EndInit();
			this.pn_nut_tao.ResumeLayout(false);
			this.pn_nut_tao.PerformLayout();
			this.pn_nhap.ResumeLayout(false);
			this.pn_nhap.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cbx_don_vi_tinh)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pn_tab_trang.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_data;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_hang_hoa;
		private System.Windows.Forms.Panel pn_nut_tao;
		private System.Windows.Forms.Panel pn_nhap;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_don_vi_tinh;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_xuat_xu;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Ten_hang;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Malh;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Mahh;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kybtn_pn_themsua;
		private System.Windows.Forms.Panel panel1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Them_sua;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_TT;
		private System.Windows.Forms.Panel pn_tab_trang;
		private ComponentFactory.Krypton.Toolkit.KryptonButton bt_back_page;
		private ComponentFactory.Krypton.Toolkit.KryptonButton bt_next_page;
	}
}