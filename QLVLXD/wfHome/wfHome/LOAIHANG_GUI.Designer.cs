﻿namespace wfHome
{
	partial class LOAIHANG_GUI
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
			this.pn_bong = new wfHome.ArtanPanel();
			this.pn_chua_du_lieu = new wfHome.ArtanPanel();
			this.pn_tab_trang = new wfHome.ArtanPanel();
			this.pn_data = new wfHome.ArtanPanel();
			this.k_datagrview_Loai_hang = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.pn_nhap = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.check_trang_thai = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
			this.kbtn_Cancle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kbtn_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.txb_Ten_loai_hang = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Malh = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_Dien_giai = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kbtn_Them_sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.pn_nut_tao = new wfHome.ArtanPanel();
			this.txb_tim_kiem_LH = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kbtn_themSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.createTransition = new System.Windows.Forms.Timer(this.components);
			this.pn_bong.SuspendLayout();
			this.pn_chua_du_lieu.SuspendLayout();
			this.pn_data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_Loai_hang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pn_nhap)).BeginInit();
			this.pn_nhap.SuspendLayout();
			this.pn_nut_tao.SuspendLayout();
			this.SuspendLayout();
			// 
			// pn_bong
			// 
			this.pn_bong.BackColor = System.Drawing.Color.White;
			this.pn_bong.BorderRadius = 25;
			this.pn_bong.Controls.Add(this.pn_chua_du_lieu);
			this.pn_bong.ForeColor = System.Drawing.Color.Black;
			this.pn_bong.GradientAngle = 90F;
			this.pn_bong.GradientBottomColor = System.Drawing.Color.Gainsboro;
			this.pn_bong.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.pn_bong.Location = new System.Drawing.Point(284, 90);
			this.pn_bong.Name = "pn_bong";
			this.pn_bong.Size = new System.Drawing.Size(1049, 800);
			this.pn_bong.TabIndex = 27;
			// 
			// pn_chua_du_lieu
			// 
			this.pn_chua_du_lieu.BackColor = System.Drawing.Color.White;
			this.pn_chua_du_lieu.BorderRadius = 25;
			this.pn_chua_du_lieu.Controls.Add(this.pn_tab_trang);
			this.pn_chua_du_lieu.Controls.Add(this.pn_data);
			this.pn_chua_du_lieu.Controls.Add(this.pn_nhap);
			this.pn_chua_du_lieu.Controls.Add(this.pn_nut_tao);
			this.pn_chua_du_lieu.ForeColor = System.Drawing.Color.Black;
			this.pn_chua_du_lieu.GradientAngle = 90F;
			this.pn_chua_du_lieu.GradientBottomColor = System.Drawing.Color.White;
			this.pn_chua_du_lieu.GradientTopColor = System.Drawing.Color.White;
			this.pn_chua_du_lieu.Location = new System.Drawing.Point(24, 26);
			this.pn_chua_du_lieu.Name = "pn_chua_du_lieu";
			this.pn_chua_du_lieu.Size = new System.Drawing.Size(1002, 733);
			this.pn_chua_du_lieu.TabIndex = 0;
			// 
			// pn_tab_trang
			// 
			this.pn_tab_trang.BackColor = System.Drawing.Color.White;
			this.pn_tab_trang.BorderRadius = 0;
			this.pn_tab_trang.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pn_tab_trang.ForeColor = System.Drawing.Color.Black;
			this.pn_tab_trang.GradientAngle = 90F;
			this.pn_tab_trang.GradientBottomColor = System.Drawing.Color.White;
			this.pn_tab_trang.GradientTopColor = System.Drawing.Color.White;
			this.pn_tab_trang.Location = new System.Drawing.Point(0, 680);
			this.pn_tab_trang.Name = "pn_tab_trang";
			this.pn_tab_trang.Size = new System.Drawing.Size(1002, 53);
			this.pn_tab_trang.TabIndex = 3;
			// 
			// pn_data
			// 
			this.pn_data.BackColor = System.Drawing.Color.White;
			this.pn_data.BorderRadius = 0;
			this.pn_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pn_data.Controls.Add(this.k_datagrview_Loai_hang);
			this.pn_data.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_data.ForeColor = System.Drawing.Color.Black;
			this.pn_data.GradientAngle = 90F;
			this.pn_data.GradientBottomColor = System.Drawing.Color.White;
			this.pn_data.GradientTopColor = System.Drawing.Color.White;
			this.pn_data.Location = new System.Drawing.Point(0, 298);
			this.pn_data.Name = "pn_data";
			this.pn_data.Size = new System.Drawing.Size(1002, 348);
			this.pn_data.TabIndex = 2;
			// 
			// k_datagrview_Loai_hang
			// 
			this.k_datagrview_Loai_hang.AllowUserToAddRows = false;
			this.k_datagrview_Loai_hang.AllowUserToResizeColumns = false;
			this.k_datagrview_Loai_hang.AllowUserToResizeRows = false;
			this.k_datagrview_Loai_hang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.k_datagrview_Loai_hang.ColumnHeadersHeight = 50;
			this.k_datagrview_Loai_hang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.k_datagrview_Loai_hang.Location = new System.Drawing.Point(0, 0);
			this.k_datagrview_Loai_hang.Name = "k_datagrview_Loai_hang";
			this.k_datagrview_Loai_hang.ReadOnly = true;
			this.k_datagrview_Loai_hang.RowHeadersVisible = false;
			this.k_datagrview_Loai_hang.RowTemplate.Height = 40;
			this.k_datagrview_Loai_hang.Size = new System.Drawing.Size(1000, 346);
			this.k_datagrview_Loai_hang.StateCommon.Background.Color1 = System.Drawing.Color.White;
			this.k_datagrview_Loai_hang.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
			this.k_datagrview_Loai_hang.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.OldLace;
			this.k_datagrview_Loai_hang.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Orange;
			this.k_datagrview_Loai_hang.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Orange;
			this.k_datagrview_Loai_hang.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.k_datagrview_Loai_hang.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.k_datagrview_Loai_hang.StateCommon.HeaderRow.Border.Width = 1;
			this.k_datagrview_Loai_hang.TabIndex = 0;
			this.k_datagrview_Loai_hang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.k_datagrview_Loai_hang_CellClick);
			// 
			// pn_nhap
			// 
			this.pn_nhap.Controls.Add(this.label4);
			this.pn_nhap.Controls.Add(this.check_trang_thai);
			this.pn_nhap.Controls.Add(this.kbtn_Cancle);
			this.pn_nhap.Controls.Add(this.kbtn_sua);
			this.pn_nhap.Controls.Add(this.txb_Ten_loai_hang);
			this.pn_nhap.Controls.Add(this.txb_Malh);
			this.pn_nhap.Controls.Add(this.txb_Dien_giai);
			this.pn_nhap.Controls.Add(this.label3);
			this.pn_nhap.Controls.Add(this.label2);
			this.pn_nhap.Controls.Add(this.label1);
			this.pn_nhap.Controls.Add(this.kbtn_Them_sua);
			this.pn_nhap.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_nhap.Location = new System.Drawing.Point(0, 66);
			this.pn_nhap.Name = "pn_nhap";
			this.pn_nhap.Size = new System.Drawing.Size(1002, 232);
			this.pn_nhap.StateCommon.Color1 = System.Drawing.Color.White;
			this.pn_nhap.StateCommon.Color2 = System.Drawing.Color.White;
			this.pn_nhap.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(630, 23);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 60;
			this.label4.Text = "Trạng thái";
			// 
			// check_trang_thai
			// 
			this.check_trang_thai.Location = new System.Drawing.Point(633, 44);
			this.check_trang_thai.Name = "check_trang_thai";
			this.check_trang_thai.Size = new System.Drawing.Size(110, 20);
			this.check_trang_thai.TabIndex = 59;
			this.check_trang_thai.Values.Text = "Còn kinh doanh";
			// 
			// kbtn_Cancle
			// 
			this.kbtn_Cancle.Location = new System.Drawing.Point(744, 176);
			this.kbtn_Cancle.Name = "kbtn_Cancle";
			this.kbtn_Cancle.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.OverrideDefault.Back.ColorAngle = 45F;
			this.kbtn_Cancle.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.OverrideDefault.Border.ColorAngle = 45F;
			this.kbtn_Cancle.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Cancle.OverrideDefault.Border.Rounding = 20;
			this.kbtn_Cancle.OverrideDefault.Border.Width = 1;
			this.kbtn_Cancle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kbtn_Cancle.Size = new System.Drawing.Size(98, 46);
			this.kbtn_Cancle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateCommon.Border.ColorAngle = 45F;
			this.kbtn_Cancle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Cancle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_Cancle.StateCommon.Border.Rounding = 25;
			this.kbtn_Cancle.StateCommon.Border.Width = 1;
			this.kbtn_Cancle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kbtn_Cancle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kbtn_Cancle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kbtn_Cancle.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StatePressed.Back.ColorAngle = 135F;
			this.kbtn_Cancle.StatePressed.Border.ColorAngle = 135F;
			this.kbtn_Cancle.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Cancle.StatePressed.Border.Rounding = 25;
			this.kbtn_Cancle.StatePressed.Border.Width = 1;
			this.kbtn_Cancle.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateTracking.Back.ColorAngle = 45F;
			this.kbtn_Cancle.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Cancle.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Cancle.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_Cancle.StateTracking.Border.Rounding = 25;
			this.kbtn_Cancle.StateTracking.Border.Width = 1;
			this.kbtn_Cancle.TabIndex = 58;
			this.kbtn_Cancle.Values.Text = "Trở lại";
			this.kbtn_Cancle.Click += new System.EventHandler(this.kbtn_Cancle_Click);
			// 
			// kbtn_sua
			// 
			this.kbtn_sua.Location = new System.Drawing.Point(868, 176);
			this.kbtn_sua.Name = "kbtn_sua";
			this.kbtn_sua.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.OverrideDefault.Back.ColorAngle = 45F;
			this.kbtn_sua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.OverrideDefault.Border.ColorAngle = 45F;
			this.kbtn_sua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_sua.OverrideDefault.Border.Rounding = 20;
			this.kbtn_sua.OverrideDefault.Border.Width = 1;
			this.kbtn_sua.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kbtn_sua.Size = new System.Drawing.Size(98, 46);
			this.kbtn_sua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateCommon.Border.ColorAngle = 45F;
			this.kbtn_sua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_sua.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_sua.StateCommon.Border.Rounding = 25;
			this.kbtn_sua.StateCommon.Border.Width = 1;
			this.kbtn_sua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kbtn_sua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kbtn_sua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kbtn_sua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StatePressed.Back.ColorAngle = 135F;
			this.kbtn_sua.StatePressed.Border.ColorAngle = 135F;
			this.kbtn_sua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_sua.StatePressed.Border.Rounding = 25;
			this.kbtn_sua.StatePressed.Border.Width = 1;
			this.kbtn_sua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateTracking.Back.ColorAngle = 45F;
			this.kbtn_sua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_sua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_sua.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_sua.StateTracking.Border.Rounding = 25;
			this.kbtn_sua.StateTracking.Border.Width = 1;
			this.kbtn_sua.TabIndex = 57;
			this.kbtn_sua.Values.Text = "Sửa";
			this.kbtn_sua.Click += new System.EventHandler(this.kbtn_sua_Click);
			// 
			// txb_Ten_loai_hang
			// 
			this.txb_Ten_loai_hang.Location = new System.Drawing.Point(344, 44);
			this.txb_Ten_loai_hang.Margin = new System.Windows.Forms.Padding(2);
			this.txb_Ten_loai_hang.Name = "txb_Ten_loai_hang";
			this.txb_Ten_loai_hang.Size = new System.Drawing.Size(217, 30);
			this.txb_Ten_loai_hang.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Ten_loai_hang.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Ten_loai_hang.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txb_Ten_loai_hang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Ten_loai_hang.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.txb_Ten_loai_hang.StateCommon.Border.Rounding = 20;
			this.txb_Ten_loai_hang.StateCommon.Border.Width = 1;
			this.txb_Ten_loai_hang.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.txb_Ten_loai_hang.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.txb_Ten_loai_hang.TabIndex = 54;
			// 
			// txb_Malh
			// 
			this.txb_Malh.Location = new System.Drawing.Point(74, 44);
			this.txb_Malh.Margin = new System.Windows.Forms.Padding(2);
			this.txb_Malh.Name = "txb_Malh";
			this.txb_Malh.Size = new System.Drawing.Size(217, 30);
			this.txb_Malh.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Malh.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Malh.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txb_Malh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Malh.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.txb_Malh.StateCommon.Border.Rounding = 20;
			this.txb_Malh.StateCommon.Border.Width = 1;
			this.txb_Malh.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.txb_Malh.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.txb_Malh.TabIndex = 53;
			// 
			// txb_Dien_giai
			// 
			this.txb_Dien_giai.Location = new System.Drawing.Point(74, 131);
			this.txb_Dien_giai.Margin = new System.Windows.Forms.Padding(2);
			this.txb_Dien_giai.Name = "txb_Dien_giai";
			this.txb_Dien_giai.Size = new System.Drawing.Size(488, 30);
			this.txb_Dien_giai.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.txb_Dien_giai.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.txb_Dien_giai.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.txb_Dien_giai.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.txb_Dien_giai.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.txb_Dien_giai.StateCommon.Border.Rounding = 20;
			this.txb_Dien_giai.StateCommon.Border.Width = 1;
			this.txb_Dien_giai.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
			this.txb_Dien_giai.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.txb_Dien_giai.StateDisabled.Content.Color1 = System.Drawing.Color.Red;
			this.txb_Dien_giai.TabIndex = 52;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(342, 23);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 45;
			this.label3.Text = "Tên loại hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 23);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 44;
			this.label2.Text = "Mã loại hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 110);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 43;
			this.label1.Text = "Diễn giải";
			// 
			// kbtn_Them_sua
			// 
			this.kbtn_Them_sua.Location = new System.Drawing.Point(868, 176);
			this.kbtn_Them_sua.Name = "kbtn_Them_sua";
			this.kbtn_Them_sua.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.OverrideDefault.Back.ColorAngle = 45F;
			this.kbtn_Them_sua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.OverrideDefault.Border.ColorAngle = 45F;
			this.kbtn_Them_sua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.OverrideDefault.Border.Rounding = 20;
			this.kbtn_Them_sua.OverrideDefault.Border.Width = 1;
			this.kbtn_Them_sua.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kbtn_Them_sua.Size = new System.Drawing.Size(98, 46);
			this.kbtn_Them_sua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateCommon.Border.ColorAngle = 45F;
			this.kbtn_Them_sua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_Them_sua.StateCommon.Border.Rounding = 25;
			this.kbtn_Them_sua.StateCommon.Border.Width = 1;
			this.kbtn_Them_sua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kbtn_Them_sua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kbtn_Them_sua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kbtn_Them_sua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StatePressed.Back.ColorAngle = 135F;
			this.kbtn_Them_sua.StatePressed.Border.ColorAngle = 135F;
			this.kbtn_Them_sua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.StatePressed.Border.Rounding = 25;
			this.kbtn_Them_sua.StatePressed.Border.Width = 1;
			this.kbtn_Them_sua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateTracking.Back.ColorAngle = 45F;
			this.kbtn_Them_sua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_Them_sua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_Them_sua.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_Them_sua.StateTracking.Border.Rounding = 25;
			this.kbtn_Them_sua.StateTracking.Border.Width = 1;
			this.kbtn_Them_sua.TabIndex = 35;
			this.kbtn_Them_sua.Values.Text = "Thêm";
			this.kbtn_Them_sua.Click += new System.EventHandler(this.kbtn_Them_sua_Click);
			// 
			// pn_nut_tao
			// 
			this.pn_nut_tao.BackColor = System.Drawing.Color.White;
			this.pn_nut_tao.BorderRadius = 0;
			this.pn_nut_tao.Controls.Add(this.txb_tim_kiem_LH);
			this.pn_nut_tao.Controls.Add(this.kbtn_themSua);
			this.pn_nut_tao.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_nut_tao.ForeColor = System.Drawing.Color.Black;
			this.pn_nut_tao.GradientAngle = 90F;
			this.pn_nut_tao.GradientBottomColor = System.Drawing.Color.White;
			this.pn_nut_tao.GradientTopColor = System.Drawing.Color.White;
			this.pn_nut_tao.Location = new System.Drawing.Point(0, 0);
			this.pn_nut_tao.Name = "pn_nut_tao";
			this.pn_nut_tao.Size = new System.Drawing.Size(1002, 66);
			this.pn_nut_tao.TabIndex = 0;
			// 
			// txb_tim_kiem_LH
			// 
			this.txb_tim_kiem_LH.Location = new System.Drawing.Point(88, 16);
			this.txb_tim_kiem_LH.Multiline = true;
			this.txb_tim_kiem_LH.Name = "txb_tim_kiem_LH";
			this.txb_tim_kiem_LH.Size = new System.Drawing.Size(547, 34);
			this.txb_tim_kiem_LH.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
			this.txb_tim_kiem_LH.TabIndex = 29;
			this.txb_tim_kiem_LH.TextChanged += new System.EventHandler(this.txb_tim_kiem_LH_TextChanged);
			// 
			// kbtn_themSua
			// 
			this.kbtn_themSua.Location = new System.Drawing.Point(889, 11);
			this.kbtn_themSua.Name = "kbtn_themSua";
			this.kbtn_themSua.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.OverrideDefault.Back.ColorAngle = 45F;
			this.kbtn_themSua.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.OverrideDefault.Border.ColorAngle = 45F;
			this.kbtn_themSua.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_themSua.OverrideDefault.Border.Rounding = 20;
			this.kbtn_themSua.OverrideDefault.Border.Width = 1;
			this.kbtn_themSua.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kbtn_themSua.Size = new System.Drawing.Size(77, 44);
			this.kbtn_themSua.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateCommon.Border.ColorAngle = 45F;
			this.kbtn_themSua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_themSua.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_themSua.StateCommon.Border.Rounding = 25;
			this.kbtn_themSua.StateCommon.Border.Width = 1;
			this.kbtn_themSua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kbtn_themSua.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kbtn_themSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kbtn_themSua.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StatePressed.Back.ColorAngle = 135F;
			this.kbtn_themSua.StatePressed.Border.ColorAngle = 135F;
			this.kbtn_themSua.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_themSua.StatePressed.Border.Rounding = 25;
			this.kbtn_themSua.StatePressed.Border.Width = 1;
			this.kbtn_themSua.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateTracking.Back.ColorAngle = 45F;
			this.kbtn_themSua.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kbtn_themSua.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kbtn_themSua.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kbtn_themSua.StateTracking.Border.Rounding = 25;
			this.kbtn_themSua.StateTracking.Border.Width = 1;
			this.kbtn_themSua.TabIndex = 28;
			this.kbtn_themSua.Values.Text = "+";
			this.kbtn_themSua.Click += new System.EventHandler(this.kbtn_themSua_Click);
			// 
			// createTransition
			// 
			this.createTransition.Enabled = true;
			this.createTransition.Interval = 10;
			this.createTransition.Tick += new System.EventHandler(this.createTransition_Tick_1);
			// 
			// LOAIHANG_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 861);
			this.Controls.Add(this.pn_bong);
			this.Name = "LOAIHANG_GUI";
			this.Text = "LOAIHANG_GUI";
			this.Controls.SetChildIndex(this.pn_bong, 0);
			this.pn_bong.ResumeLayout(false);
			this.pn_chua_du_lieu.ResumeLayout(false);
			this.pn_data.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_Loai_hang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pn_nhap)).EndInit();
			this.pn_nhap.ResumeLayout(false);
			this.pn_nhap.PerformLayout();
			this.pn_nut_tao.ResumeLayout(false);
			this.pn_nut_tao.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ArtanPanel pn_bong;
		private ArtanPanel pn_chua_du_lieu;
		private ArtanPanel pn_tab_trang;
		private ArtanPanel pn_data;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_Loai_hang;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel pn_nhap;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Cancle;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_sua;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Ten_loai_hang;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Malh;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_Dien_giai;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Them_sua;
		private ArtanPanel pn_nut_tao;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_LH;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_themSua;
		private System.Windows.Forms.Label label4;
		private ComponentFactory.Krypton.Toolkit.KryptonCheckBox check_trang_thai;
		private System.Windows.Forms.Timer createTransition;
	}
}