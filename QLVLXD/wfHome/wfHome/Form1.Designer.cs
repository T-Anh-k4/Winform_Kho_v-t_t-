namespace wfHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel_menu = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.icbt_huongdan = new FontAwesome.Sharp.IconButton();
			this.pn_bao_cao = new System.Windows.Forms.Panel();
			this.bt_bc_Kho = new FontAwesome.Sharp.IconButton();
			this.bt_bc_xuat_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_nhap_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_loai_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_hang_hoa = new FontAwesome.Sharp.IconButton();
			this.bt_bc_Nha_cung_cap = new FontAwesome.Sharp.IconButton();
			this.bt_bc_Khach_hang = new FontAwesome.Sharp.IconButton();
			this.icbt_baocao = new FontAwesome.Sharp.IconButton();
			this.pn_danh_muc = new System.Windows.Forms.Panel();
			this.bt_Kho = new FontAwesome.Sharp.IconButton();
			this.bt_xuat_hang = new FontAwesome.Sharp.IconButton();
			this.bt_nhap_hang = new FontAwesome.Sharp.IconButton();
			this.bt_loai_hang = new FontAwesome.Sharp.IconButton();
			this.bt_hang_hoa = new FontAwesome.Sharp.IconButton();
			this.bt_Nha_cung_cap = new FontAwesome.Sharp.IconButton();
			this.bt_Khach_hang = new FontAwesome.Sharp.IconButton();
			this.icbt_Danhmuc = new FontAwesome.Sharp.IconButton();
			this.icbt_trangchu = new FontAwesome.Sharp.IconButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel_search = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panel_menu.SuspendLayout();
			this.panel4.SuspendLayout();
			this.pn_bao_cao.SuspendLayout();
			this.pn_danh_muc.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel_search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_menu
			// 
			this.panel_menu.BackColor = System.Drawing.Color.White;
			this.panel_menu.Controls.Add(this.panel4);
			this.panel_menu.Controls.Add(this.panel3);
			this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel_menu.Location = new System.Drawing.Point(0, 0);
			this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
			this.panel_menu.Name = "panel_menu";
			this.panel_menu.Size = new System.Drawing.Size(232, 861);
			this.panel_menu.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.icbt_huongdan);
			this.panel4.Controls.Add(this.pn_bao_cao);
			this.panel4.Controls.Add(this.icbt_baocao);
			this.panel4.Controls.Add(this.pn_danh_muc);
			this.panel4.Controls.Add(this.icbt_Danhmuc);
			this.panel4.Controls.Add(this.icbt_trangchu);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 108);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 800);
			this.panel4.TabIndex = 10;
			// 
			// icbt_huongdan
			// 
			this.icbt_huongdan.BackColor = System.Drawing.Color.White;
			this.icbt_huongdan.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_huongdan.FlatAppearance.BorderSize = 0;
			this.icbt_huongdan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_huongdan.ForeColor = System.Drawing.SystemColors.GrayText;
			this.icbt_huongdan.IconChar = FontAwesome.Sharp.IconChar.Book;
			this.icbt_huongdan.IconColor = System.Drawing.Color.Gray;
			this.icbt_huongdan.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_huongdan.IconSize = 35;
			this.icbt_huongdan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_huongdan.Location = new System.Drawing.Point(0, 751);
			this.icbt_huongdan.Name = "icbt_huongdan";
			this.icbt_huongdan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_huongdan.Size = new System.Drawing.Size(232, 57);
			this.icbt_huongdan.TabIndex = 8;
			this.icbt_huongdan.Text = "Hướng dẫn";
			this.icbt_huongdan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_huongdan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_huongdan.UseVisualStyleBackColor = false;
			this.icbt_huongdan.Click += new System.EventHandler(this.icbt_huongdan_Click);
			// 
			// pn_bao_cao
			// 
			this.pn_bao_cao.BackColor = System.Drawing.Color.White;
			this.pn_bao_cao.Controls.Add(this.bt_bc_Kho);
			this.pn_bao_cao.Controls.Add(this.bt_bc_xuat_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_nhap_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_loai_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_hang_hoa);
			this.pn_bao_cao.Controls.Add(this.bt_bc_Nha_cung_cap);
			this.pn_bao_cao.Controls.Add(this.bt_bc_Khach_hang);
			this.pn_bao_cao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_bao_cao.Location = new System.Drawing.Point(0, 461);
			this.pn_bao_cao.Name = "pn_bao_cao";
			this.pn_bao_cao.Size = new System.Drawing.Size(232, 290);
			this.pn_bao_cao.TabIndex = 20;
			this.pn_bao_cao.Visible = false;
			// 
			// bt_bc_Kho
			// 
			this.bt_bc_Kho.BackColor = System.Drawing.Color.White;
			this.bt_bc_Kho.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Kho.FlatAppearance.BorderSize = 0;
			this.bt_bc_Kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Kho.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_Kho.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_Kho.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Kho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Kho.IconSize = 35;
			this.bt_bc_Kho.Location = new System.Drawing.Point(0, 246);
			this.bt_bc_Kho.Name = "bt_bc_Kho";
			this.bt_bc_Kho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_Kho.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_Kho.TabIndex = 19;
			this.bt_bc_Kho.Text = "báo cáo kho";
			this.bt_bc_Kho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Kho.UseVisualStyleBackColor = false;
			// 
			// bt_bc_xuat_hang
			// 
			this.bt_bc_xuat_hang.BackColor = System.Drawing.Color.White;
			this.bt_bc_xuat_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_xuat_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_xuat_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_xuat_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_xuat_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_xuat_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_xuat_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_xuat_hang.IconSize = 35;
			this.bt_bc_xuat_hang.Location = new System.Drawing.Point(0, 205);
			this.bt_bc_xuat_hang.Name = "bt_bc_xuat_hang";
			this.bt_bc_xuat_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_xuat_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_xuat_hang.TabIndex = 18;
			this.bt_bc_xuat_hang.Text = "Báo cáo xuất hàng";
			this.bt_bc_xuat_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_xuat_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_nhap_hang
			// 
			this.bt_bc_nhap_hang.BackColor = System.Drawing.Color.White;
			this.bt_bc_nhap_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_nhap_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_nhap_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_nhap_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_nhap_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_nhap_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_nhap_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_nhap_hang.IconSize = 35;
			this.bt_bc_nhap_hang.Location = new System.Drawing.Point(0, 164);
			this.bt_bc_nhap_hang.Name = "bt_bc_nhap_hang";
			this.bt_bc_nhap_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_nhap_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_nhap_hang.TabIndex = 17;
			this.bt_bc_nhap_hang.Text = "Báo cáo nhập hàng";
			this.bt_bc_nhap_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_nhap_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_loai_hang
			// 
			this.bt_bc_loai_hang.BackColor = System.Drawing.Color.White;
			this.bt_bc_loai_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_loai_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_loai_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_loai_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_loai_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_loai_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_loai_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_loai_hang.IconSize = 35;
			this.bt_bc_loai_hang.Location = new System.Drawing.Point(0, 123);
			this.bt_bc_loai_hang.Name = "bt_bc_loai_hang";
			this.bt_bc_loai_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_loai_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_loai_hang.TabIndex = 16;
			this.bt_bc_loai_hang.Text = "Danh sách loại hàng";
			this.bt_bc_loai_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_loai_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_hang_hoa
			// 
			this.bt_bc_hang_hoa.BackColor = System.Drawing.Color.White;
			this.bt_bc_hang_hoa.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_hang_hoa.FlatAppearance.BorderSize = 0;
			this.bt_bc_hang_hoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_hang_hoa.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_hang_hoa.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_hang_hoa.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_hang_hoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_hang_hoa.IconSize = 35;
			this.bt_bc_hang_hoa.Location = new System.Drawing.Point(0, 82);
			this.bt_bc_hang_hoa.Name = "bt_bc_hang_hoa";
			this.bt_bc_hang_hoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_hang_hoa.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_hang_hoa.TabIndex = 15;
			this.bt_bc_hang_hoa.Text = "Danh sách hàng hóa";
			this.bt_bc_hang_hoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_hang_hoa.UseVisualStyleBackColor = false;
			// 
			// bt_bc_Nha_cung_cap
			// 
			this.bt_bc_Nha_cung_cap.BackColor = System.Drawing.Color.White;
			this.bt_bc_Nha_cung_cap.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Nha_cung_cap.FlatAppearance.BorderSize = 0;
			this.bt_bc_Nha_cung_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Nha_cung_cap.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_Nha_cung_cap.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_Nha_cung_cap.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Nha_cung_cap.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Nha_cung_cap.IconSize = 35;
			this.bt_bc_Nha_cung_cap.Location = new System.Drawing.Point(0, 41);
			this.bt_bc_Nha_cung_cap.Name = "bt_bc_Nha_cung_cap";
			this.bt_bc_Nha_cung_cap.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_Nha_cung_cap.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_Nha_cung_cap.TabIndex = 14;
			this.bt_bc_Nha_cung_cap.Text = "Danh sách nhà cung cấp";
			this.bt_bc_Nha_cung_cap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Nha_cung_cap.UseVisualStyleBackColor = false;
			// 
			// bt_bc_Khach_hang
			// 
			this.bt_bc_Khach_hang.BackColor = System.Drawing.Color.White;
			this.bt_bc_Khach_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Khach_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_Khach_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Khach_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_bc_Khach_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_bc_Khach_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Khach_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Khach_hang.IconSize = 35;
			this.bt_bc_Khach_hang.Location = new System.Drawing.Point(0, 0);
			this.bt_bc_Khach_hang.Name = "bt_bc_Khach_hang";
			this.bt_bc_Khach_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_Khach_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_bc_Khach_hang.TabIndex = 13;
			this.bt_bc_Khach_hang.Text = "Danh sách khách hàng";
			this.bt_bc_Khach_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Khach_hang.UseVisualStyleBackColor = false;
			// 
			// icbt_baocao
			// 
			this.icbt_baocao.BackColor = System.Drawing.Color.White;
			this.icbt_baocao.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_baocao.FlatAppearance.BorderSize = 0;
			this.icbt_baocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_baocao.ForeColor = System.Drawing.SystemColors.GrayText;
			this.icbt_baocao.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
			this.icbt_baocao.IconColor = System.Drawing.Color.Gray;
			this.icbt_baocao.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_baocao.IconSize = 35;
			this.icbt_baocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_baocao.Location = new System.Drawing.Point(0, 404);
			this.icbt_baocao.Name = "icbt_baocao";
			this.icbt_baocao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_baocao.Size = new System.Drawing.Size(232, 57);
			this.icbt_baocao.TabIndex = 9;
			this.icbt_baocao.Text = "Báo cáo-Thống kê";
			this.icbt_baocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_baocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_baocao.UseVisualStyleBackColor = false;
			this.icbt_baocao.Click += new System.EventHandler(this.icbt_baocao_Click);
			// 
			// pn_danh_muc
			// 
			this.pn_danh_muc.BackColor = System.Drawing.Color.White;
			this.pn_danh_muc.Controls.Add(this.bt_Kho);
			this.pn_danh_muc.Controls.Add(this.bt_xuat_hang);
			this.pn_danh_muc.Controls.Add(this.bt_nhap_hang);
			this.pn_danh_muc.Controls.Add(this.bt_loai_hang);
			this.pn_danh_muc.Controls.Add(this.bt_hang_hoa);
			this.pn_danh_muc.Controls.Add(this.bt_Nha_cung_cap);
			this.pn_danh_muc.Controls.Add(this.bt_Khach_hang);
			this.pn_danh_muc.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_danh_muc.Location = new System.Drawing.Point(0, 114);
			this.pn_danh_muc.Name = "pn_danh_muc";
			this.pn_danh_muc.Size = new System.Drawing.Size(232, 290);
			this.pn_danh_muc.TabIndex = 3;
			this.pn_danh_muc.Visible = false;
			// 
			// bt_Kho
			// 
			this.bt_Kho.BackColor = System.Drawing.Color.White;
			this.bt_Kho.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Kho.FlatAppearance.BorderSize = 0;
			this.bt_Kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Kho.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_Kho.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_Kho.IconColor = System.Drawing.Color.Gray;
			this.bt_Kho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Kho.IconSize = 35;
			this.bt_Kho.Location = new System.Drawing.Point(0, 246);
			this.bt_Kho.Name = "bt_Kho";
			this.bt_Kho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_Kho.Size = new System.Drawing.Size(232, 41);
			this.bt_Kho.TabIndex = 19;
			this.bt_Kho.Text = "Kho";
			this.bt_Kho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Kho.UseVisualStyleBackColor = false;
			// 
			// bt_xuat_hang
			// 
			this.bt_xuat_hang.BackColor = System.Drawing.Color.White;
			this.bt_xuat_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_xuat_hang.FlatAppearance.BorderSize = 0;
			this.bt_xuat_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_xuat_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_xuat_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_xuat_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_xuat_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_xuat_hang.IconSize = 35;
			this.bt_xuat_hang.Location = new System.Drawing.Point(0, 205);
			this.bt_xuat_hang.Name = "bt_xuat_hang";
			this.bt_xuat_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_xuat_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_xuat_hang.TabIndex = 18;
			this.bt_xuat_hang.Text = "Xuất Hàng";
			this.bt_xuat_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_xuat_hang.UseVisualStyleBackColor = false;
			// 
			// bt_nhap_hang
			// 
			this.bt_nhap_hang.BackColor = System.Drawing.Color.White;
			this.bt_nhap_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_nhap_hang.FlatAppearance.BorderSize = 0;
			this.bt_nhap_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_nhap_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_nhap_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_nhap_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_nhap_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_nhap_hang.IconSize = 35;
			this.bt_nhap_hang.Location = new System.Drawing.Point(0, 164);
			this.bt_nhap_hang.Name = "bt_nhap_hang";
			this.bt_nhap_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_nhap_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_nhap_hang.TabIndex = 17;
			this.bt_nhap_hang.Text = "Nhập Hàng";
			this.bt_nhap_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_nhap_hang.UseVisualStyleBackColor = false;
			// 
			// bt_loai_hang
			// 
			this.bt_loai_hang.BackColor = System.Drawing.Color.White;
			this.bt_loai_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_loai_hang.FlatAppearance.BorderSize = 0;
			this.bt_loai_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_loai_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_loai_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_loai_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_loai_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_loai_hang.IconSize = 35;
			this.bt_loai_hang.Location = new System.Drawing.Point(0, 123);
			this.bt_loai_hang.Name = "bt_loai_hang";
			this.bt_loai_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_loai_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_loai_hang.TabIndex = 16;
			this.bt_loai_hang.Text = "Loại hàng";
			this.bt_loai_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_loai_hang.UseVisualStyleBackColor = false;
			// 
			// bt_hang_hoa
			// 
			this.bt_hang_hoa.BackColor = System.Drawing.Color.White;
			this.bt_hang_hoa.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_hang_hoa.FlatAppearance.BorderSize = 0;
			this.bt_hang_hoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_hang_hoa.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_hang_hoa.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_hang_hoa.IconColor = System.Drawing.Color.Gray;
			this.bt_hang_hoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_hang_hoa.IconSize = 35;
			this.bt_hang_hoa.Location = new System.Drawing.Point(0, 82);
			this.bt_hang_hoa.Name = "bt_hang_hoa";
			this.bt_hang_hoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_hang_hoa.Size = new System.Drawing.Size(232, 41);
			this.bt_hang_hoa.TabIndex = 15;
			this.bt_hang_hoa.Text = "Hàng hóa";
			this.bt_hang_hoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_hang_hoa.UseVisualStyleBackColor = false;
			// 
			// bt_Nha_cung_cap
			// 
			this.bt_Nha_cung_cap.BackColor = System.Drawing.Color.White;
			this.bt_Nha_cung_cap.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Nha_cung_cap.FlatAppearance.BorderSize = 0;
			this.bt_Nha_cung_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Nha_cung_cap.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_Nha_cung_cap.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_Nha_cung_cap.IconColor = System.Drawing.Color.Gray;
			this.bt_Nha_cung_cap.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Nha_cung_cap.IconSize = 35;
			this.bt_Nha_cung_cap.Location = new System.Drawing.Point(0, 41);
			this.bt_Nha_cung_cap.Name = "bt_Nha_cung_cap";
			this.bt_Nha_cung_cap.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_Nha_cung_cap.Size = new System.Drawing.Size(232, 41);
			this.bt_Nha_cung_cap.TabIndex = 14;
			this.bt_Nha_cung_cap.Text = "Nhà cung cấp";
			this.bt_Nha_cung_cap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Nha_cung_cap.UseVisualStyleBackColor = false;
			// 
			// bt_Khach_hang
			// 
			this.bt_Khach_hang.BackColor = System.Drawing.Color.White;
			this.bt_Khach_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Khach_hang.FlatAppearance.BorderSize = 0;
			this.bt_Khach_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Khach_hang.ForeColor = System.Drawing.SystemColors.GrayText;
			this.bt_Khach_hang.IconChar = FontAwesome.Sharp.IconChar.None;
			this.bt_Khach_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_Khach_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Khach_hang.IconSize = 35;
			this.bt_Khach_hang.Location = new System.Drawing.Point(0, 0);
			this.bt_Khach_hang.Name = "bt_Khach_hang";
			this.bt_Khach_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_Khach_hang.Size = new System.Drawing.Size(232, 41);
			this.bt_Khach_hang.TabIndex = 13;
			this.bt_Khach_hang.Text = "Khách hàng";
			this.bt_Khach_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Khach_hang.UseVisualStyleBackColor = false;
			// 
			// icbt_Danhmuc
			// 
			this.icbt_Danhmuc.BackColor = System.Drawing.Color.White;
			this.icbt_Danhmuc.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_Danhmuc.FlatAppearance.BorderSize = 0;
			this.icbt_Danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_Danhmuc.ForeColor = System.Drawing.SystemColors.GrayText;
			this.icbt_Danhmuc.IconChar = FontAwesome.Sharp.IconChar.List;
			this.icbt_Danhmuc.IconColor = System.Drawing.Color.Gray;
			this.icbt_Danhmuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_Danhmuc.IconSize = 35;
			this.icbt_Danhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_Danhmuc.Location = new System.Drawing.Point(0, 57);
			this.icbt_Danhmuc.Name = "icbt_Danhmuc";
			this.icbt_Danhmuc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_Danhmuc.Size = new System.Drawing.Size(232, 57);
			this.icbt_Danhmuc.TabIndex = 10;
			this.icbt_Danhmuc.Text = "Danh mục";
			this.icbt_Danhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_Danhmuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_Danhmuc.UseVisualStyleBackColor = false;
			this.icbt_Danhmuc.Click += new System.EventHandler(this.icbt_Danhmuc_Click);
			// 
			// icbt_trangchu
			// 
			this.icbt_trangchu.BackColor = System.Drawing.Color.White;
			this.icbt_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_trangchu.FlatAppearance.BorderSize = 0;
			this.icbt_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_trangchu.ForeColor = System.Drawing.SystemColors.GrayText;
			this.icbt_trangchu.IconChar = FontAwesome.Sharp.IconChar.House;
			this.icbt_trangchu.IconColor = System.Drawing.Color.Gray;
			this.icbt_trangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_trangchu.IconSize = 35;
			this.icbt_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_trangchu.Location = new System.Drawing.Point(0, 0);
			this.icbt_trangchu.Name = "icbt_trangchu";
			this.icbt_trangchu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_trangchu.Size = new System.Drawing.Size(232, 57);
			this.icbt_trangchu.TabIndex = 7;
			this.icbt_trangchu.Text = "Trang chủ";
			this.icbt_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_trangchu.UseVisualStyleBackColor = false;
			this.icbt_trangchu.Click += new System.EventHandler(this.icbt_trangchu_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(232, 108);
			this.panel3.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(113, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 32);
			this.label1.TabIndex = 12;
			this.label1.Text = "Vật liệu";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 70);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.panel_search);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(232, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1101, 74);
			this.panel2.TabIndex = 1;
			// 
			// panel_search
			// 
			this.panel_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_search.Controls.Add(this.textBox1);
			this.panel_search.Controls.Add(this.iconPictureBox1);
			this.panel_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel_search.Location = new System.Drawing.Point(168, 12);
			this.panel_search.Name = "panel_search";
			this.panel_search.Size = new System.Drawing.Size(734, 45);
			this.panel_search.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(695, 43);
			this.textBox1.TabIndex = 1;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.White;
			this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
			this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
			this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconPictureBox1.IconSize = 37;
			this.iconPictureBox1.Location = new System.Drawing.Point(695, 0);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(37, 43);
			this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.iconPictureBox1.TabIndex = 0;
			this.iconPictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(1333, 861);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel_menu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel_menu.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.pn_bao_cao.ResumeLayout(false);
			this.pn_danh_muc.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel_search.ResumeLayout(false);
			this.panel_search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_menu;
		private System.Windows.Forms.Panel panel2;
		private FontAwesome.Sharp.IconButton icbt_trangchu;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private FontAwesome.Sharp.IconButton icbt_Danhmuc;
		private FontAwesome.Sharp.IconButton icbt_baocao;
		private FontAwesome.Sharp.IconButton icbt_huongdan;
		private System.Windows.Forms.Panel panel_search;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pn_danh_muc;
		private FontAwesome.Sharp.IconButton bt_Khach_hang;
		private FontAwesome.Sharp.IconButton bt_Nha_cung_cap;
		private FontAwesome.Sharp.IconButton bt_Kho;
		private FontAwesome.Sharp.IconButton bt_xuat_hang;
		private FontAwesome.Sharp.IconButton bt_nhap_hang;
		private FontAwesome.Sharp.IconButton bt_loai_hang;
		private FontAwesome.Sharp.IconButton bt_hang_hoa;
		private System.Windows.Forms.Panel pn_bao_cao;
		private FontAwesome.Sharp.IconButton bt_bc_Kho;
		private FontAwesome.Sharp.IconButton bt_bc_xuat_hang;
		private FontAwesome.Sharp.IconButton bt_bc_nhap_hang;
		private FontAwesome.Sharp.IconButton bt_bc_loai_hang;
		private FontAwesome.Sharp.IconButton bt_bc_hang_hoa;
		private FontAwesome.Sharp.IconButton bt_bc_Nha_cung_cap;
		private FontAwesome.Sharp.IconButton bt_bc_Khach_hang;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
	}
}

