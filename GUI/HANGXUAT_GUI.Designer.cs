namespace GUI
{
	partial class HANGXUAT_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.soluong = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txb_tim_kiem_nv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryBtShowCreate_NV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.panel0_nv = new ArtanComponent.ArtanPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryBt_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelSoTrang = new System.Windows.Forms.Label();
            this.kryBtPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.dataViewHNhap = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2_nv = new System.Windows.Forms.Panel();
            this.kry_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryTb_eID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryTb_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryTx_Id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kry_Datetime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.createTransition = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.panel0_nv.SuspendLayout();
            this.panel4.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHNhap)).BeginInit();
            this.panel2_nv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.soluong);
            this.panel3.Controls.Add(this.txb_tim_kiem_nv);
            this.panel3.Controls.Add(this.kryBtShowCreate_NV);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2088, 121);
            this.panel3.TabIndex = 6;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(32, 38);
            this.soluong.Margin = new System.Windows.Forms.Padding(6);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(300, 50);
            this.soluong.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.soluong.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.TabIndex = 6;
            this.soluong.Values.Text = "Hàng nhập (99)";
            // 
            // txb_tim_kiem_nv
            // 
            this.txb_tim_kiem_nv.Location = new System.Drawing.Point(664, 25);
            this.txb_tim_kiem_nv.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tim_kiem_nv.Name = "txb_tim_kiem_nv";
            this.txb_tim_kiem_nv.Size = new System.Drawing.Size(650, 49);
            this.txb_tim_kiem_nv.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_tim_kiem_nv.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txb_tim_kiem_nv.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_tim_kiem_nv.StateCommon.Border.Rounding = 15;
            this.txb_tim_kiem_nv.StateCommon.Content.Color1 = System.Drawing.Color.LightGray;
            this.txb_tim_kiem_nv.TabIndex = 28;
            this.txb_tim_kiem_nv.TextChanged += new System.EventHandler(this.txb_tim_kiem_HNhap_TextChanged);
            this.txb_tim_kiem_nv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_tim_kiem_HNhap_KeyDown);
            // 
            // kryBtShowCreate_NV
            // 
            this.kryBtShowCreate_NV.Location = new System.Drawing.Point(1936, 25);
            this.kryBtShowCreate_NV.Margin = new System.Windows.Forms.Padding(6);
            this.kryBtShowCreate_NV.Name = "kryBtShowCreate_NV";
            this.kryBtShowCreate_NV.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBtShowCreate_NV.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBtShowCreate_NV.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NV.OverrideDefault.Border.Rounding = 20;
            this.kryBtShowCreate_NV.OverrideDefault.Border.Width = 1;
            this.kryBtShowCreate_NV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBtShowCreate_NV.Size = new System.Drawing.Size(112, 65);
            this.kryBtShowCreate_NV.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateCommon.Border.ColorAngle = 45F;
            this.kryBtShowCreate_NV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NV.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBtShowCreate_NV.StateCommon.Border.Rounding = 25;
            this.kryBtShowCreate_NV.StateCommon.Border.Width = 1;
            this.kryBtShowCreate_NV.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBtShowCreate_NV.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBtShowCreate_NV.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBtShowCreate_NV.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StatePressed.Back.ColorAngle = 135F;
            this.kryBtShowCreate_NV.StatePressed.Border.ColorAngle = 135F;
            this.kryBtShowCreate_NV.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NV.StatePressed.Border.Rounding = 25;
            this.kryBtShowCreate_NV.StatePressed.Border.Width = 1;
            this.kryBtShowCreate_NV.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateTracking.Back.ColorAngle = 45F;
            this.kryBtShowCreate_NV.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NV.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NV.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBtShowCreate_NV.StateTracking.Border.Rounding = 25;
            this.kryBtShowCreate_NV.StateTracking.Border.Width = 1;
            this.kryBtShowCreate_NV.TabIndex = 27;
            this.kryBtShowCreate_NV.Values.Text = "+";
            this.kryBtShowCreate_NV.Click += new System.EventHandler(this.kryBtShowCreate_HNhap_Click);
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 25;
            this.artanPanel1.Controls.Add(this.panel0_nv);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Gainsboro;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel1.Location = new System.Drawing.Point(8, 163);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(2088, 1146);
            this.artanPanel1.TabIndex = 7;
            // 
            // panel0_nv
            // 
            this.panel0_nv.BackColor = System.Drawing.Color.White;
            this.panel0_nv.BorderRadius = 25;
            this.panel0_nv.Controls.Add(this.panel4);
            this.panel0_nv.Controls.Add(this.artanPanel2);
            this.panel0_nv.Controls.Add(this.panel2_nv);
            this.panel0_nv.ForeColor = System.Drawing.Color.Black;
            this.panel0_nv.GradientAngle = 90F;
            this.panel0_nv.GradientBottomColor = System.Drawing.Color.White;
            this.panel0_nv.GradientTopColor = System.Drawing.Color.White;
            this.panel0_nv.Location = new System.Drawing.Point(70, 46);
            this.panel0_nv.Margin = new System.Windows.Forms.Padding(4);
            this.panel0_nv.Name = "panel0_nv";
            this.panel0_nv.Size = new System.Drawing.Size(1946, 1052);
            this.panel0_nv.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kryBt_Next);
            this.panel4.Controls.Add(this.labelSoTrang);
            this.panel4.Controls.Add(this.kryBtPre);
            this.panel4.Location = new System.Drawing.Point(1796, 977);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 48);
            this.panel4.TabIndex = 6;
            // 
            // kryBt_Next
            // 
            this.kryBt_Next.Location = new System.Drawing.Point(82, 6);
            this.kryBt_Next.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Next.Name = "kryBt_Next";
            this.kryBt_Next.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Next.OverrideDefault.Border.Width = 1;
            this.kryBt_Next.Size = new System.Drawing.Size(40, 38);
            this.kryBt_Next.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryBt_Next.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StateCommon.Border.Rounding = 20;
            this.kryBt_Next.StateCommon.Border.Width = 1;
            this.kryBt_Next.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Next.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Next.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBt_Next.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StatePressed.Border.Rounding = 20;
            this.kryBt_Next.StatePressed.Border.Width = 0;
            this.kryBt_Next.TabIndex = 6;
            this.kryBt_Next.Values.Text = "kryptonButton2";
            this.kryBt_Next.Click += new System.EventHandler(this.kryBtNext_Click);
            // 
            // labelSoTrang
            // 
            this.labelSoTrang.AutoSize = true;
            this.labelSoTrang.Location = new System.Drawing.Point(46, 12);
            this.labelSoTrang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSoTrang.Name = "labelSoTrang";
            this.labelSoTrang.Size = new System.Drawing.Size(24, 25);
            this.labelSoTrang.TabIndex = 5;
            this.labelSoTrang.Text = "1";
            // 
            // kryBtPre
            // 
            this.kryBtPre.Location = new System.Drawing.Point(0, 6);
            this.kryBtPre.Margin = new System.Windows.Forms.Padding(6);
            this.kryBtPre.Name = "kryBtPre";
            this.kryBtPre.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.OverrideDefault.Border.Rounding = 20;
            this.kryBtPre.OverrideDefault.Border.Width = 1;
            this.kryBtPre.Size = new System.Drawing.Size(40, 38);
            this.kryBtPre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPre.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StateCommon.Border.Rounding = 20;
            this.kryBtPre.StateCommon.Border.Width = 1;
            this.kryBtPre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtPre.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtPre.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPre.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StatePressed.Border.Rounding = 20;
            this.kryBtPre.StatePressed.Border.Width = 0;
            this.kryBtPre.TabIndex = 3;
            this.kryBtPre.Values.Text = "kryptonButton1";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 25;
            this.artanPanel2.Controls.Add(this.dataViewHNhap);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel2.Location = new System.Drawing.Point(0, 240);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(1946, 579);
            this.artanPanel2.TabIndex = 4;
            // 
            // dataViewHNhap
            // 
            this.dataViewHNhap.AllowUserToAddRows = false;
            this.dataViewHNhap.AllowUserToResizeColumns = false;
            this.dataViewHNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            this.dataViewHNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataViewHNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewHNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewHNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewHNhap.Location = new System.Drawing.Point(0, 0);
            this.dataViewHNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dataViewHNhap.Name = "dataViewHNhap";
            this.dataViewHNhap.RowHeadersVisible = false;
            this.dataViewHNhap.RowHeadersWidth = 51;
            this.dataViewHNhap.RowTemplate.Height = 24;
            this.dataViewHNhap.Size = new System.Drawing.Size(1946, 579);
            this.dataViewHNhap.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataViewHNhap.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewHNhap.StateCommon.DataCell.Border.Width = 0;
            this.dataViewHNhap.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dataViewHNhap.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dataViewHNhap.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dataViewHNhap.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dataViewHNhap.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dataViewHNhap.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewHNhap.StateCommon.HeaderColumn.Border.Width = 0;
            this.dataViewHNhap.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewHNhap.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
            this.dataViewHNhap.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.dataViewHNhap.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewHNhap.TabIndex = 0;
            this.dataViewHNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewHNhap_CellClick);
            // 
            // panel2_nv
            // 
            this.panel2_nv.Controls.Add(this.kry_Clear);
            this.panel2_nv.Controls.Add(this.kryBt_Edit);
            this.panel2_nv.Controls.Add(this.kryBt_Add);
            this.panel2_nv.Controls.Add(this.kryTb_eID);
            this.panel2_nv.Controls.Add(this.kryTb_Name);
            this.panel2_nv.Controls.Add(this.kryTx_Id);
            this.panel2_nv.Controls.Add(this.label6);
            this.panel2_nv.Controls.Add(this.label3);
            this.panel2_nv.Controls.Add(this.label2);
            this.panel2_nv.Controls.Add(this.label1);
            this.panel2_nv.Controls.Add(this.kry_Datetime);
            this.panel2_nv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_nv.Location = new System.Drawing.Point(0, 0);
            this.panel2_nv.Margin = new System.Windows.Forms.Padding(4);
            this.panel2_nv.Name = "panel2_nv";
            this.panel2_nv.Size = new System.Drawing.Size(1946, 240);
            this.panel2_nv.TabIndex = 1;
            // 
            // kry_Clear
            // 
            this.kry_Clear.Location = new System.Drawing.Point(1700, 152);
            this.kry_Clear.Margin = new System.Windows.Forms.Padding(6);
            this.kry_Clear.Name = "kry_Clear";
            this.kry_Clear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Back.ColorAngle = 45F;
            this.kry_Clear.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Border.ColorAngle = 45F;
            this.kry_Clear.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.OverrideDefault.Border.Rounding = 20;
            this.kry_Clear.OverrideDefault.Border.Width = 1;
            this.kry_Clear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kry_Clear.Size = new System.Drawing.Size(112, 65);
            this.kry_Clear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.ColorAngle = 45F;
            this.kry_Clear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kry_Clear.StateCommon.Border.Rounding = 25;
            this.kry_Clear.StateCommon.Border.Width = 1;
            this.kry_Clear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kry_Clear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kry_Clear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kry_Clear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StatePressed.Back.ColorAngle = 135F;
            this.kry_Clear.StatePressed.Border.ColorAngle = 135F;
            this.kry_Clear.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StatePressed.Border.Rounding = 25;
            this.kry_Clear.StatePressed.Border.Width = 1;
            this.kry_Clear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Back.ColorAngle = 45F;
            this.kry_Clear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kry_Clear.StateTracking.Border.Rounding = 25;
            this.kry_Clear.StateTracking.Border.Width = 1;
            this.kry_Clear.TabIndex = 30;
            this.kry_Clear.Values.Text = "Thoát";
            this.kry_Clear.Click += new System.EventHandler(this.kry_Clear_Click);
            // 
            // kryBt_Edit
            // 
            this.kryBt_Edit.Location = new System.Drawing.Point(52, 152);
            this.kryBt_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Edit.Name = "kryBt_Edit";
            this.kryBt_Edit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBt_Edit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBt_Edit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Edit.OverrideDefault.Border.Width = 1;
            this.kryBt_Edit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBt_Edit.Size = new System.Drawing.Size(112, 65);
            this.kryBt_Edit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.ColorAngle = 45F;
            this.kryBt_Edit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Edit.StateCommon.Border.Rounding = 25;
            this.kryBt_Edit.StateCommon.Border.Width = 1;
            this.kryBt_Edit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBt_Edit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBt_Edit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBt_Edit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StatePressed.Back.ColorAngle = 135F;
            this.kryBt_Edit.StatePressed.Border.ColorAngle = 135F;
            this.kryBt_Edit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StatePressed.Border.Rounding = 25;
            this.kryBt_Edit.StatePressed.Border.Width = 1;
            this.kryBt_Edit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Back.ColorAngle = 45F;
            this.kryBt_Edit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Edit.StateTracking.Border.Rounding = 25;
            this.kryBt_Edit.StateTracking.Border.Width = 1;
            this.kryBt_Edit.TabIndex = 29;
            this.kryBt_Edit.Values.Text = "Sửa";
            this.kryBt_Edit.Click += new System.EventHandler(this.kryBt_Edit_Click);
            // 
            // kryBt_Add
            // 
            this.kryBt_Add.Location = new System.Drawing.Point(52, 152);
            this.kryBt_Add.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Add.Name = "kryBt_Add";
            this.kryBt_Add.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBt_Add.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBt_Add.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Add.OverrideDefault.Border.Width = 1;
            this.kryBt_Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBt_Add.Size = new System.Drawing.Size(112, 65);
            this.kryBt_Add.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.ColorAngle = 45F;
            this.kryBt_Add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Add.StateCommon.Border.Rounding = 25;
            this.kryBt_Add.StateCommon.Border.Width = 1;
            this.kryBt_Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBt_Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBt_Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBt_Add.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StatePressed.Back.ColorAngle = 135F;
            this.kryBt_Add.StatePressed.Border.ColorAngle = 135F;
            this.kryBt_Add.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StatePressed.Border.Rounding = 25;
            this.kryBt_Add.StatePressed.Border.Width = 1;
            this.kryBt_Add.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Back.ColorAngle = 45F;
            this.kryBt_Add.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Add.StateTracking.Border.Rounding = 25;
            this.kryBt_Add.StateTracking.Border.Width = 1;
            this.kryBt_Add.TabIndex = 28;
            this.kryBt_Add.Values.Text = "Thêm";
            this.kryBt_Add.Click += new System.EventHandler(this.kryBt_Add_Click);
            // 
            // kryTb_eID
            // 
            this.kryTb_eID.Location = new System.Drawing.Point(984, 65);
            this.kryTb_eID.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_eID.Name = "kryTb_eID";
            this.kryTb_eID.Size = new System.Drawing.Size(400, 46);
            this.kryTb_eID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_eID.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_eID.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_eID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_eID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_eID.StateCommon.Border.Rounding = 20;
            this.kryTb_eID.StateCommon.Border.Width = 1;
            this.kryTb_eID.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryTb_eID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_eID.TabIndex = 3;
            // 
            // kryTb_Name
            // 
            this.kryTb_Name.Location = new System.Drawing.Point(518, 65);
            this.kryTb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_Name.Name = "kryTb_Name";
            this.kryTb_Name.Size = new System.Drawing.Size(400, 46);
            this.kryTb_Name.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_Name.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_Name.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_Name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_Name.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_Name.StateCommon.Border.Rounding = 20;
            this.kryTb_Name.StateCommon.Border.Width = 1;
            this.kryTb_Name.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryTb_Name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_Name.TabIndex = 2;
            // 
            // kryTx_Id
            // 
            this.kryTx_Id.Location = new System.Drawing.Point(52, 65);
            this.kryTx_Id.Margin = new System.Windows.Forms.Padding(4);
            this.kryTx_Id.Name = "kryTx_Id";
            this.kryTx_Id.Size = new System.Drawing.Size(400, 46);
            this.kryTx_Id.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTx_Id.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTx_Id.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTx_Id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTx_Id.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTx_Id.StateCommon.Border.Rounding = 20;
            this.kryTx_Id.StateCommon.Border.Width = 1;
            this.kryTx_Id.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.kryTx_Id.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTx_Id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1464, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(980, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn xuất";
            // 
            // kry_Datetime
            // 
            this.kry_Datetime.AllowDrop = true;
            this.kry_Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kry_Datetime.Location = new System.Drawing.Point(1468, 60);
            this.kry_Datetime.Margin = new System.Windows.Forms.Padding(4);
            this.kry_Datetime.Name = "kry_Datetime";
            this.kry_Datetime.Size = new System.Drawing.Size(400, 49);
            this.kry_Datetime.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kry_Datetime.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kry_Datetime.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kry_Datetime.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Datetime.StateCommon.Border.Rounding = 20;
            this.kry_Datetime.StateCommon.Border.Width = 1;
            this.kry_Datetime.TabIndex = 4;
            // 
            // createTransition
            // 
            this.createTransition.Enabled = true;
            this.createTransition.Interval = 10;
            this.createTransition.Tick += new System.EventHandler(this.createTransition_Tick);
            // 
            // HANGXUAT_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2104, 1346);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HANGXUAT_GUI";
            this.Text = "HANGXUAT_GUI";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.artanPanel1.ResumeLayout(false);
            this.panel0_nv.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHNhap)).EndInit();
            this.panel2_nv.ResumeLayout(false);
            this.panel2_nv.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel soluong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_nv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtShowCreate_NV;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel panel0_nv;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Next;
        private System.Windows.Forms.Label labelSoTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtPre;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewHNhap;
        private System.Windows.Forms.Panel panel2_nv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kry_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_eID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTx_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker kry_Datetime;
        private System.Windows.Forms.Timer createTransition;
    }
}