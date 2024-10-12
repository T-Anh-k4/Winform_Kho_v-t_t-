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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pn_Home_search = new System.Windows.Forms.Panel();
			this.iblformtitle = new System.Windows.Forms.Label();
			this.iconcurrenform = new FontAwesome.Sharp.IconPictureBox();
			this.txb_tim_kiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.Danh_muc_Transition = new System.Windows.Forms.Timer(this.components);
			this.Bao_cao_Transition = new System.Windows.Forms.Timer(this.components);
			this.artanPanel1_right = new wfHome.ArtanPanel();
			this.pn_menu = new wfHome.ArtanPanel();
			this.icbt_huongdan = new FontAwesome.Sharp.IconButton();
			this.pn_bao_cao = new wfHome.ArtanPanel();
			this.bt_bc_Kho = new FontAwesome.Sharp.IconButton();
			this.bt_bc_Nha_cung_cap = new FontAwesome.Sharp.IconButton();
			this.bt_bc_xuat_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_Khach_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_nhap_hang = new FontAwesome.Sharp.IconButton();
			this.bt_bc_hang_hoa = new FontAwesome.Sharp.IconButton();
			this.bt_bc_loai_hang = new FontAwesome.Sharp.IconButton();
			this.icbt_baocao = new FontAwesome.Sharp.IconButton();
			this.pn_danh_muc = new wfHome.ArtanPanel();
			this.bt_Kho = new FontAwesome.Sharp.IconButton();
			this.bt_Nha_cung_cap = new FontAwesome.Sharp.IconButton();
			this.bt_xuat_hang = new FontAwesome.Sharp.IconButton();
			this.bt_Khach_hang = new FontAwesome.Sharp.IconButton();
			this.bt_nhap_hang = new FontAwesome.Sharp.IconButton();
			this.bt_hang_hoa = new FontAwesome.Sharp.IconButton();
			this.bt_loai_hang = new FontAwesome.Sharp.IconButton();
			this.icbt_Danhmuc = new FontAwesome.Sharp.IconButton();
			this.icbt_trangchu = new FontAwesome.Sharp.IconButton();
			this.pn_logo = new wfHome.ArtanPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.artanPanel1_left = new wfHome.ArtanPanel();
			this.pn_Home_search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconcurrenform)).BeginInit();
			this.pn_menu.SuspendLayout();
			this.pn_bao_cao.SuspendLayout();
			this.pn_danh_muc.SuspendLayout();
			this.pn_logo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_Home_search
			// 
			this.pn_Home_search.BackColor = System.Drawing.Color.White;
			this.pn_Home_search.Controls.Add(this.iblformtitle);
			this.pn_Home_search.Controls.Add(this.iconcurrenform);
			this.pn_Home_search.Controls.Add(this.txb_tim_kiem);
			this.pn_Home_search.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_Home_search.Location = new System.Drawing.Point(278, 0);
			this.pn_Home_search.Margin = new System.Windows.Forms.Padding(2);
			this.pn_Home_search.Name = "pn_Home_search";
			this.pn_Home_search.Size = new System.Drawing.Size(1005, 74);
			this.pn_Home_search.TabIndex = 1;
			// 
			// iblformtitle
			// 
			this.iblformtitle.AutoSize = true;
			this.iblformtitle.BackColor = System.Drawing.SystemColors.Window;
			this.iblformtitle.ForeColor = System.Drawing.Color.Gray;
			this.iblformtitle.Location = new System.Drawing.Point(64, 30);
			this.iblformtitle.Name = "iblformtitle";
			this.iblformtitle.Size = new System.Drawing.Size(56, 13);
			this.iblformtitle.TabIndex = 2;
			this.iblformtitle.Text = "Trang chủ";
			// 
			// iconcurrenform
			// 
			this.iconcurrenform.BackColor = System.Drawing.Color.White;
			this.iconcurrenform.ForeColor = System.Drawing.Color.Gray;
			this.iconcurrenform.IconChar = FontAwesome.Sharp.IconChar.House;
			this.iconcurrenform.IconColor = System.Drawing.Color.Gray;
			this.iconcurrenform.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconcurrenform.IconSize = 39;
			this.iconcurrenform.Location = new System.Drawing.Point(18, 18);
			this.iconcurrenform.Name = "iconcurrenform";
			this.iconcurrenform.Size = new System.Drawing.Size(40, 39);
			this.iconcurrenform.TabIndex = 1;
			this.iconcurrenform.TabStop = false;
			// 
			// txb_tim_kiem
			// 
			this.txb_tim_kiem.Location = new System.Drawing.Point(208, 12);
			this.txb_tim_kiem.Multiline = true;
			this.txb_tim_kiem.Name = "txb_tim_kiem";
			this.txb_tim_kiem.Size = new System.Drawing.Size(558, 45);
			this.txb_tim_kiem.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.txb_tim_kiem.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_tim_kiem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txb_tim_kiem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_tim_kiem.StateCommon.Border.Rounding = 20;
			this.txb_tim_kiem.StateCommon.Border.Width = 1;
			this.txb_tim_kiem.StateCommon.Content.Color1 = System.Drawing.Color.DarkGray;
			this.txb_tim_kiem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 7, 10, 0);
			this.txb_tim_kiem.TabIndex = 0;
			this.txb_tim_kiem.Text = "Tìm kiếm";
			// 
			// kryptonPalette1
			// 
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 12;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
			// 
			// Danh_muc_Transition
			// 
			this.Danh_muc_Transition.Enabled = true;
			this.Danh_muc_Transition.Interval = 10;
			this.Danh_muc_Transition.Tick += new System.EventHandler(this.Danh_muc_Transition_Tick);
			// 
			// Bao_cao_Transition
			// 
			this.Bao_cao_Transition.Enabled = true;
			this.Bao_cao_Transition.Interval = 10;
			this.Bao_cao_Transition.Tick += new System.EventHandler(this.Bao_cao_Transition_Tick);
			// 
			// artanPanel1_right
			// 
			this.artanPanel1_right.BackColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_right.BorderRadius = 0;
			this.artanPanel1_right.Dock = System.Windows.Forms.DockStyle.Left;
			this.artanPanel1_right.ForeColor = System.Drawing.Color.Black;
			this.artanPanel1_right.GradientAngle = 90F;
			this.artanPanel1_right.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_right.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_right.Location = new System.Drawing.Point(268, 0);
			this.artanPanel1_right.Name = "artanPanel1_right";
			this.artanPanel1_right.Size = new System.Drawing.Size(10, 1061);
			this.artanPanel1_right.TabIndex = 23;
			// 
			// pn_menu
			// 
			this.pn_menu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pn_menu.BorderRadius = 20;
			this.pn_menu.Controls.Add(this.icbt_huongdan);
			this.pn_menu.Controls.Add(this.pn_bao_cao);
			this.pn_menu.Controls.Add(this.icbt_baocao);
			this.pn_menu.Controls.Add(this.pn_danh_muc);
			this.pn_menu.Controls.Add(this.icbt_Danhmuc);
			this.pn_menu.Controls.Add(this.icbt_trangchu);
			this.pn_menu.Controls.Add(this.pn_logo);
			this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pn_menu.ForeColor = System.Drawing.Color.Black;
			this.pn_menu.GradientAngle = 90F;
			this.pn_menu.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.pn_menu.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.pn_menu.Location = new System.Drawing.Point(10, 0);
			this.pn_menu.Name = "pn_menu";
			this.pn_menu.Size = new System.Drawing.Size(258, 1061);
			this.pn_menu.TabIndex = 21;
			// 
			// icbt_huongdan
			// 
			this.icbt_huongdan.BackColor = System.Drawing.Color.WhiteSmoke;
			this.icbt_huongdan.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_huongdan.FlatAppearance.BorderSize = 0;
			this.icbt_huongdan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_huongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.icbt_huongdan.ForeColor = System.Drawing.Color.DimGray;
			this.icbt_huongdan.IconChar = FontAwesome.Sharp.IconChar.Book;
			this.icbt_huongdan.IconColor = System.Drawing.Color.DimGray;
			this.icbt_huongdan.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_huongdan.IconSize = 35;
			this.icbt_huongdan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_huongdan.Location = new System.Drawing.Point(0, 881);
			this.icbt_huongdan.Name = "icbt_huongdan";
			this.icbt_huongdan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_huongdan.Size = new System.Drawing.Size(258, 57);
			this.icbt_huongdan.TabIndex = 8;
			this.icbt_huongdan.Text = "Hướng dẫn";
			this.icbt_huongdan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_huongdan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_huongdan.UseVisualStyleBackColor = false;
			this.icbt_huongdan.Click += new System.EventHandler(this.icbt_huongdan_Click);
			// 
			// pn_bao_cao
			// 
			this.pn_bao_cao.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pn_bao_cao.BorderRadius = 0;
			this.pn_bao_cao.Controls.Add(this.bt_bc_Kho);
			this.pn_bao_cao.Controls.Add(this.bt_bc_Nha_cung_cap);
			this.pn_bao_cao.Controls.Add(this.bt_bc_xuat_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_Khach_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_nhap_hang);
			this.pn_bao_cao.Controls.Add(this.bt_bc_hang_hoa);
			this.pn_bao_cao.Controls.Add(this.bt_bc_loai_hang);
			this.pn_bao_cao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_bao_cao.ForeColor = System.Drawing.Color.Black;
			this.pn_bao_cao.GradientAngle = 90F;
			this.pn_bao_cao.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.pn_bao_cao.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.pn_bao_cao.Location = new System.Drawing.Point(0, 593);
			this.pn_bao_cao.Name = "pn_bao_cao";
			this.pn_bao_cao.Size = new System.Drawing.Size(258, 288);
			this.pn_bao_cao.TabIndex = 22;
			// 
			// bt_bc_Kho
			// 
			this.bt_bc_Kho.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_Kho.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Kho.FlatAppearance.BorderSize = 0;
			this.bt_bc_Kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_Kho.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_Kho.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_Kho.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Kho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Kho.IconSize = 25;
			this.bt_bc_Kho.Location = new System.Drawing.Point(0, 246);
			this.bt_bc_Kho.Name = "bt_bc_Kho";
			this.bt_bc_Kho.Padding = new System.Windows.Forms.Padding(0, 0, 42, 0);
			this.bt_bc_Kho.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_Kho.TabIndex = 19;
			this.bt_bc_Kho.Text = "Báo cáo kho";
			this.bt_bc_Kho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Kho.UseVisualStyleBackColor = false;
			// 
			// bt_bc_Nha_cung_cap
			// 
			this.bt_bc_Nha_cung_cap.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_Nha_cung_cap.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Nha_cung_cap.FlatAppearance.BorderSize = 0;
			this.bt_bc_Nha_cung_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Nha_cung_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_Nha_cung_cap.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_Nha_cung_cap.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_Nha_cung_cap.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Nha_cung_cap.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Nha_cung_cap.IconSize = 25;
			this.bt_bc_Nha_cung_cap.Location = new System.Drawing.Point(0, 205);
			this.bt_bc_Nha_cung_cap.Name = "bt_bc_Nha_cung_cap";
			this.bt_bc_Nha_cung_cap.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
			this.bt_bc_Nha_cung_cap.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_Nha_cung_cap.TabIndex = 14;
			this.bt_bc_Nha_cung_cap.Text = "Danh sách nhà cung cấp";
			this.bt_bc_Nha_cung_cap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Nha_cung_cap.UseVisualStyleBackColor = false;
			// 
			// bt_bc_xuat_hang
			// 
			this.bt_bc_xuat_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_xuat_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_xuat_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_xuat_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_xuat_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_xuat_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_xuat_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_xuat_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_xuat_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_xuat_hang.IconSize = 25;
			this.bt_bc_xuat_hang.Location = new System.Drawing.Point(0, 164);
			this.bt_bc_xuat_hang.Name = "bt_bc_xuat_hang";
			this.bt_bc_xuat_hang.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.bt_bc_xuat_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_xuat_hang.TabIndex = 18;
			this.bt_bc_xuat_hang.Text = "Báo cáo xuất hàng";
			this.bt_bc_xuat_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_xuat_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_Khach_hang
			// 
			this.bt_bc_Khach_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_Khach_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_Khach_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_Khach_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_Khach_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_Khach_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_Khach_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_Khach_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_Khach_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_Khach_hang.IconSize = 25;
			this.bt_bc_Khach_hang.Location = new System.Drawing.Point(0, 123);
			this.bt_bc_Khach_hang.Name = "bt_bc_Khach_hang";
			this.bt_bc_Khach_hang.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.bt_bc_Khach_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_Khach_hang.TabIndex = 13;
			this.bt_bc_Khach_hang.Text = "Danh sách khách hàng";
			this.bt_bc_Khach_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_Khach_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_nhap_hang
			// 
			this.bt_bc_nhap_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_nhap_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_nhap_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_nhap_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_nhap_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_nhap_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_nhap_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_nhap_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_nhap_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_nhap_hang.IconSize = 25;
			this.bt_bc_nhap_hang.Location = new System.Drawing.Point(0, 82);
			this.bt_bc_nhap_hang.Name = "bt_bc_nhap_hang";
			this.bt_bc_nhap_hang.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.bt_bc_nhap_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_nhap_hang.TabIndex = 17;
			this.bt_bc_nhap_hang.Text = "Báo cáo nhập hàng";
			this.bt_bc_nhap_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_nhap_hang.UseVisualStyleBackColor = false;
			// 
			// bt_bc_hang_hoa
			// 
			this.bt_bc_hang_hoa.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_hang_hoa.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_hang_hoa.FlatAppearance.BorderSize = 0;
			this.bt_bc_hang_hoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_hang_hoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_hang_hoa.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_hang_hoa.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_hang_hoa.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_hang_hoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_hang_hoa.IconSize = 25;
			this.bt_bc_hang_hoa.Location = new System.Drawing.Point(0, 41);
			this.bt_bc_hang_hoa.Name = "bt_bc_hang_hoa";
			this.bt_bc_hang_hoa.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_hang_hoa.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_hang_hoa.TabIndex = 15;
			this.bt_bc_hang_hoa.Text = "Danh sách hàng hóa";
			this.bt_bc_hang_hoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_hang_hoa.UseVisualStyleBackColor = false;
			// 
			// bt_bc_loai_hang
			// 
			this.bt_bc_loai_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_bc_loai_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_bc_loai_hang.FlatAppearance.BorderSize = 0;
			this.bt_bc_loai_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bc_loai_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bc_loai_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_bc_loai_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_bc_loai_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_bc_loai_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_bc_loai_hang.IconSize = 25;
			this.bt_bc_loai_hang.Location = new System.Drawing.Point(0, 0);
			this.bt_bc_loai_hang.Name = "bt_bc_loai_hang";
			this.bt_bc_loai_hang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.bt_bc_loai_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_bc_loai_hang.TabIndex = 16;
			this.bt_bc_loai_hang.Text = "Danh sách loại hàng";
			this.bt_bc_loai_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_bc_loai_hang.UseVisualStyleBackColor = false;
			// 
			// icbt_baocao
			// 
			this.icbt_baocao.BackColor = System.Drawing.Color.WhiteSmoke;
			this.icbt_baocao.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_baocao.FlatAppearance.BorderSize = 0;
			this.icbt_baocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_baocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.icbt_baocao.ForeColor = System.Drawing.Color.DimGray;
			this.icbt_baocao.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
			this.icbt_baocao.IconColor = System.Drawing.Color.DimGray;
			this.icbt_baocao.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_baocao.IconSize = 35;
			this.icbt_baocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_baocao.Location = new System.Drawing.Point(0, 536);
			this.icbt_baocao.Name = "icbt_baocao";
			this.icbt_baocao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_baocao.Size = new System.Drawing.Size(258, 57);
			this.icbt_baocao.TabIndex = 9;
			this.icbt_baocao.Text = "Báo cáo-Thống kê";
			this.icbt_baocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_baocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_baocao.UseVisualStyleBackColor = false;
			this.icbt_baocao.Click += new System.EventHandler(this.icbt_baocao_Click);
			// 
			// pn_danh_muc
			// 
			this.pn_danh_muc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pn_danh_muc.BorderRadius = 0;
			this.pn_danh_muc.Controls.Add(this.bt_Kho);
			this.pn_danh_muc.Controls.Add(this.bt_Nha_cung_cap);
			this.pn_danh_muc.Controls.Add(this.bt_xuat_hang);
			this.pn_danh_muc.Controls.Add(this.bt_Khach_hang);
			this.pn_danh_muc.Controls.Add(this.bt_nhap_hang);
			this.pn_danh_muc.Controls.Add(this.bt_hang_hoa);
			this.pn_danh_muc.Controls.Add(this.bt_loai_hang);
			this.pn_danh_muc.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_danh_muc.ForeColor = System.Drawing.Color.Black;
			this.pn_danh_muc.GradientAngle = 90F;
			this.pn_danh_muc.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.pn_danh_muc.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.pn_danh_muc.Location = new System.Drawing.Point(0, 248);
			this.pn_danh_muc.Name = "pn_danh_muc";
			this.pn_danh_muc.Size = new System.Drawing.Size(258, 288);
			this.pn_danh_muc.TabIndex = 22;
			// 
			// bt_Kho
			// 
			this.bt_Kho.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_Kho.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Kho.FlatAppearance.BorderSize = 0;
			this.bt_Kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Kho.ForeColor = System.Drawing.Color.DimGray;
			this.bt_Kho.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_Kho.IconColor = System.Drawing.Color.Gray;
			this.bt_Kho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Kho.IconSize = 25;
			this.bt_Kho.Location = new System.Drawing.Point(0, 246);
			this.bt_Kho.Name = "bt_Kho";
			this.bt_Kho.Padding = new System.Windows.Forms.Padding(0, 0, 88, 0);
			this.bt_Kho.Size = new System.Drawing.Size(258, 41);
			this.bt_Kho.TabIndex = 19;
			this.bt_Kho.Text = "Kho";
			this.bt_Kho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_Kho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Kho.UseVisualStyleBackColor = false;
			// 
			// bt_Nha_cung_cap
			// 
			this.bt_Nha_cung_cap.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_Nha_cung_cap.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Nha_cung_cap.FlatAppearance.BorderSize = 0;
			this.bt_Nha_cung_cap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Nha_cung_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Nha_cung_cap.ForeColor = System.Drawing.Color.DimGray;
			this.bt_Nha_cung_cap.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_Nha_cung_cap.IconColor = System.Drawing.Color.Gray;
			this.bt_Nha_cung_cap.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Nha_cung_cap.IconSize = 25;
			this.bt_Nha_cung_cap.Location = new System.Drawing.Point(0, 205);
			this.bt_Nha_cung_cap.Name = "bt_Nha_cung_cap";
			this.bt_Nha_cung_cap.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
			this.bt_Nha_cung_cap.Size = new System.Drawing.Size(258, 41);
			this.bt_Nha_cung_cap.TabIndex = 14;
			this.bt_Nha_cung_cap.Text = "Nhà cung cấp";
			this.bt_Nha_cung_cap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_Nha_cung_cap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Nha_cung_cap.UseVisualStyleBackColor = false;
			// 
			// bt_xuat_hang
			// 
			this.bt_xuat_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_xuat_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_xuat_hang.FlatAppearance.BorderSize = 0;
			this.bt_xuat_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_xuat_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_xuat_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_xuat_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_xuat_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_xuat_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_xuat_hang.IconSize = 25;
			this.bt_xuat_hang.Location = new System.Drawing.Point(0, 164);
			this.bt_xuat_hang.Name = "bt_xuat_hang";
			this.bt_xuat_hang.Padding = new System.Windows.Forms.Padding(0, 0, 48, 0);
			this.bt_xuat_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_xuat_hang.TabIndex = 18;
			this.bt_xuat_hang.Text = "Xuất Hàng";
			this.bt_xuat_hang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_xuat_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_xuat_hang.UseVisualStyleBackColor = false;
			// 
			// bt_Khach_hang
			// 
			this.bt_Khach_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_Khach_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_Khach_hang.FlatAppearance.BorderSize = 0;
			this.bt_Khach_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_Khach_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Khach_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_Khach_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_Khach_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_Khach_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_Khach_hang.IconSize = 25;
			this.bt_Khach_hang.Location = new System.Drawing.Point(0, 123);
			this.bt_Khach_hang.Name = "bt_Khach_hang";
			this.bt_Khach_hang.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
			this.bt_Khach_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_Khach_hang.TabIndex = 13;
			this.bt_Khach_hang.Text = "Khách hàng";
			this.bt_Khach_hang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_Khach_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_Khach_hang.UseVisualStyleBackColor = false;
			// 
			// bt_nhap_hang
			// 
			this.bt_nhap_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_nhap_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_nhap_hang.FlatAppearance.BorderSize = 0;
			this.bt_nhap_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_nhap_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_nhap_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_nhap_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_nhap_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_nhap_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_nhap_hang.IconSize = 25;
			this.bt_nhap_hang.Location = new System.Drawing.Point(0, 82);
			this.bt_nhap_hang.Name = "bt_nhap_hang";
			this.bt_nhap_hang.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
			this.bt_nhap_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_nhap_hang.TabIndex = 17;
			this.bt_nhap_hang.Text = "Nhập Hàng";
			this.bt_nhap_hang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_nhap_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_nhap_hang.UseVisualStyleBackColor = false;
			// 
			// bt_hang_hoa
			// 
			this.bt_hang_hoa.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_hang_hoa.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_hang_hoa.FlatAppearance.BorderSize = 0;
			this.bt_hang_hoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_hang_hoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_hang_hoa.ForeColor = System.Drawing.Color.DimGray;
			this.bt_hang_hoa.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_hang_hoa.IconColor = System.Drawing.Color.Gray;
			this.bt_hang_hoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_hang_hoa.IconSize = 25;
			this.bt_hang_hoa.Location = new System.Drawing.Point(0, 41);
			this.bt_hang_hoa.Name = "bt_hang_hoa";
			this.bt_hang_hoa.Padding = new System.Windows.Forms.Padding(10, 0, 85, 0);
			this.bt_hang_hoa.Size = new System.Drawing.Size(258, 41);
			this.bt_hang_hoa.TabIndex = 15;
			this.bt_hang_hoa.Text = "Hàng hóa";
			this.bt_hang_hoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_hang_hoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_hang_hoa.UseVisualStyleBackColor = false;
			// 
			// bt_loai_hang
			// 
			this.bt_loai_hang.BackColor = System.Drawing.Color.WhiteSmoke;
			this.bt_loai_hang.Dock = System.Windows.Forms.DockStyle.Top;
			this.bt_loai_hang.FlatAppearance.BorderSize = 0;
			this.bt_loai_hang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_loai_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_loai_hang.ForeColor = System.Drawing.Color.DimGray;
			this.bt_loai_hang.IconChar = FontAwesome.Sharp.IconChar.Minus;
			this.bt_loai_hang.IconColor = System.Drawing.Color.Gray;
			this.bt_loai_hang.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.bt_loai_hang.IconSize = 25;
			this.bt_loai_hang.Location = new System.Drawing.Point(0, 0);
			this.bt_loai_hang.Name = "bt_loai_hang";
			this.bt_loai_hang.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
			this.bt_loai_hang.Size = new System.Drawing.Size(258, 41);
			this.bt_loai_hang.TabIndex = 16;
			this.bt_loai_hang.Text = "Loại hàng";
			this.bt_loai_hang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_loai_hang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bt_loai_hang.UseVisualStyleBackColor = false;
			// 
			// icbt_Danhmuc
			// 
			this.icbt_Danhmuc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.icbt_Danhmuc.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_Danhmuc.FlatAppearance.BorderSize = 0;
			this.icbt_Danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_Danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.icbt_Danhmuc.ForeColor = System.Drawing.Color.DimGray;
			this.icbt_Danhmuc.IconChar = FontAwesome.Sharp.IconChar.List;
			this.icbt_Danhmuc.IconColor = System.Drawing.Color.DimGray;
			this.icbt_Danhmuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_Danhmuc.IconSize = 35;
			this.icbt_Danhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_Danhmuc.Location = new System.Drawing.Point(0, 191);
			this.icbt_Danhmuc.Name = "icbt_Danhmuc";
			this.icbt_Danhmuc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_Danhmuc.Size = new System.Drawing.Size(258, 57);
			this.icbt_Danhmuc.TabIndex = 10;
			this.icbt_Danhmuc.Text = "Danh mục";
			this.icbt_Danhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_Danhmuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_Danhmuc.UseVisualStyleBackColor = false;
			this.icbt_Danhmuc.Click += new System.EventHandler(this.icbt_Danhmuc_Click);
			// 
			// icbt_trangchu
			// 
			this.icbt_trangchu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.icbt_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
			this.icbt_trangchu.FlatAppearance.BorderSize = 0;
			this.icbt_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.icbt_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.icbt_trangchu.ForeColor = System.Drawing.Color.DimGray;
			this.icbt_trangchu.IconChar = FontAwesome.Sharp.IconChar.House;
			this.icbt_trangchu.IconColor = System.Drawing.Color.DimGray;
			this.icbt_trangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icbt_trangchu.IconSize = 35;
			this.icbt_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_trangchu.Location = new System.Drawing.Point(0, 134);
			this.icbt_trangchu.Name = "icbt_trangchu";
			this.icbt_trangchu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.icbt_trangchu.Size = new System.Drawing.Size(258, 57);
			this.icbt_trangchu.TabIndex = 7;
			this.icbt_trangchu.Text = "Trang chủ";
			this.icbt_trangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.icbt_trangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.icbt_trangchu.UseVisualStyleBackColor = false;
			this.icbt_trangchu.Click += new System.EventHandler(this.icbt_trangchu_Click);
			// 
			// pn_logo
			// 
			this.pn_logo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.pn_logo.BorderRadius = 0;
			this.pn_logo.Controls.Add(this.pictureBox1);
			this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_logo.ForeColor = System.Drawing.Color.Black;
			this.pn_logo.GradientAngle = 90F;
			this.pn_logo.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.pn_logo.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.pn_logo.Location = new System.Drawing.Point(0, 0);
			this.pn_logo.Name = "pn_logo";
			this.pn_logo.Size = new System.Drawing.Size(258, 134);
			this.pn_logo.TabIndex = 22;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(56, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(136, 106);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// artanPanel1_left
			// 
			this.artanPanel1_left.BackColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_left.BorderRadius = 0;
			this.artanPanel1_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.artanPanel1_left.ForeColor = System.Drawing.Color.Black;
			this.artanPanel1_left.GradientAngle = 90F;
			this.artanPanel1_left.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_left.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel1_left.Location = new System.Drawing.Point(0, 0);
			this.artanPanel1_left.Name = "artanPanel1_left";
			this.artanPanel1_left.Size = new System.Drawing.Size(10, 1061);
			this.artanPanel1_left.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1283, 1061);
			this.Controls.Add(this.pn_Home_search);
			this.Controls.Add(this.artanPanel1_right);
			this.Controls.Add(this.pn_menu);
			this.Controls.Add(this.artanPanel1_left);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Palette = this.kryptonPalette1;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pn_Home_search.ResumeLayout(false);
			this.pn_Home_search.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconcurrenform)).EndInit();
			this.pn_menu.ResumeLayout(false);
			this.pn_bao_cao.ResumeLayout(false);
			this.pn_danh_muc.ResumeLayout(false);
			this.pn_logo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pn_Home_search;
		private FontAwesome.Sharp.IconButton icbt_trangchu;
		private FontAwesome.Sharp.IconButton icbt_Danhmuc;
		private FontAwesome.Sharp.IconButton icbt_baocao;
		private FontAwesome.Sharp.IconButton bt_Khach_hang;
		private FontAwesome.Sharp.IconButton bt_Nha_cung_cap;
		private FontAwesome.Sharp.IconButton bt_Kho;
		private FontAwesome.Sharp.IconButton bt_xuat_hang;
		private FontAwesome.Sharp.IconButton bt_nhap_hang;
		private FontAwesome.Sharp.IconButton bt_loai_hang;
		private FontAwesome.Sharp.IconButton bt_hang_hoa;
		private FontAwesome.Sharp.IconButton bt_bc_Kho;
		private FontAwesome.Sharp.IconButton bt_bc_xuat_hang;
		private FontAwesome.Sharp.IconButton bt_bc_nhap_hang;
		private FontAwesome.Sharp.IconButton bt_bc_loai_hang;
		private FontAwesome.Sharp.IconButton bt_bc_hang_hoa;
		private FontAwesome.Sharp.IconButton bt_bc_Nha_cung_cap;
		private FontAwesome.Sharp.IconButton bt_bc_Khach_hang;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem;
		private System.Windows.Forms.Label iblformtitle;
		private FontAwesome.Sharp.IconPictureBox iconcurrenform;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private FontAwesome.Sharp.IconButton icbt_huongdan;
		private ArtanPanel pn_menu;
		private ArtanPanel pn_logo;
		private ArtanPanel pn_bao_cao;
		private ArtanPanel pn_danh_muc;
		private ArtanPanel artanPanel1_left;
		private ArtanPanel artanPanel1_right;
		private System.Windows.Forms.Timer Danh_muc_Transition;
		private System.Windows.Forms.Timer Bao_cao_Transition;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

