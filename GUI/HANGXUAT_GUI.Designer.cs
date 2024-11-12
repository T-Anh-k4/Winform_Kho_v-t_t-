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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HANGXUAT_GUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.soluong = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txb_tim_kiem_nv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryBtShowCreate_NV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.panel0_nv = new ArtanComponent.ArtanPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryBtNext = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelSoTrang = new System.Windows.Forms.Label();
            this.kryBtPrevious = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.dataViewHNhap = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2_nv = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.artanPanel1.SuspendLayout();
            this.panel0_nv.SuspendLayout();
            this.panel4.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHNhap)).BeginInit();
            this.panel2_nv.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(26, 19);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(153, 26);
            this.soluong.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.soluong.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.TabIndex = 6;
            this.soluong.Values.Text = "Hàng nhập (99)";
            // 
            // txb_tim_kiem_nv
            // 
            this.txb_tim_kiem_nv.Location = new System.Drawing.Point(342, 12);
            this.txb_tim_kiem_nv.Margin = new System.Windows.Forms.Padding(2);
            this.txb_tim_kiem_nv.Name = "txb_tim_kiem_nv";
            this.txb_tim_kiem_nv.Size = new System.Drawing.Size(325, 33);
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
            this.kryBtShowCreate_NV.Location = new System.Drawing.Point(978, 12);
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
            this.kryBtShowCreate_NV.Size = new System.Drawing.Size(56, 34);
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
            this.artanPanel1.Location = new System.Drawing.Point(4, 85);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1052, 596);
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
            this.panel0_nv.Location = new System.Drawing.Point(41, 24);
            this.panel0_nv.Margin = new System.Windows.Forms.Padding(2);
            this.panel0_nv.Name = "panel0_nv";
            this.panel0_nv.Size = new System.Drawing.Size(973, 547);
            this.panel0_nv.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.kryBtNext);
            this.panel4.Controls.Add(this.labelSoTrang);
            this.panel4.Controls.Add(this.kryBtPrevious);
            this.panel4.Location = new System.Drawing.Point(897, 509);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 25);
            this.panel4.TabIndex = 7;
            // 
            // kryBtNext
            // 
            this.kryBtNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryBtNext.Location = new System.Drawing.Point(44, 0);
            this.kryBtNext.Name = "kryBtNext";
            this.kryBtNext.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBtNext.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBtNext.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBtNext.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBtNext.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtNext.OverrideDefault.Border.Rounding = 20;
            this.kryBtNext.OverrideDefault.Border.Width = 1;
            this.kryBtNext.Size = new System.Drawing.Size(20, 25);
            this.kryBtNext.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBtNext.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBtNext.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryBtNext.StateCommon.Back.Image")));
            this.kryBtNext.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryBtNext.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBtNext.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBtNext.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtNext.StateCommon.Border.Rounding = 20;
            this.kryBtNext.StateCommon.Border.Width = 1;
            this.kryBtNext.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtNext.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtNext.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtNext.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtNext.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtNext.StatePressed.Border.Rounding = 20;
            this.kryBtNext.StatePressed.Border.Width = 0;
            this.kryBtNext.TabIndex = 6;
            this.kryBtNext.Values.Text = "kryptonButton2";
            this.kryBtNext.Click += new System.EventHandler(this.kryBtNext_Click);
            // 
            // labelSoTrang
            // 
            this.labelSoTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoTrang.AutoSize = true;
            this.labelSoTrang.Location = new System.Drawing.Point(23, 6);
            this.labelSoTrang.Name = "labelSoTrang";
            this.labelSoTrang.Size = new System.Drawing.Size(13, 13);
            this.labelSoTrang.TabIndex = 5;
            this.labelSoTrang.Text = "1";
            // 
            // kryBtPrevious
            // 
            this.kryBtPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryBtPrevious.Location = new System.Drawing.Point(0, 0);
            this.kryBtPrevious.Name = "kryBtPrevious";
            this.kryBtPrevious.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPrevious.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPrevious.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPrevious.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPrevious.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPrevious.OverrideDefault.Border.Rounding = 20;
            this.kryBtPrevious.OverrideDefault.Border.Width = 1;
            this.kryBtPrevious.Size = new System.Drawing.Size(20, 25);
            this.kryBtPrevious.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPrevious.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPrevious.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryBtPrevious.StateCommon.Back.Image")));
            this.kryBtPrevious.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPrevious.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPrevious.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPrevious.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPrevious.StateCommon.Border.Rounding = 20;
            this.kryBtPrevious.StateCommon.Border.Width = 1;
            this.kryBtPrevious.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPrevious.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtPrevious.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtPrevious.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPrevious.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPrevious.StatePressed.Border.Rounding = 20;
            this.kryBtPrevious.StatePressed.Border.Width = 0;
            this.kryBtPrevious.TabIndex = 3;
            this.kryBtPrevious.Values.Text = "kryptonButton1";
            this.kryBtPrevious.Click += new System.EventHandler(this.kryBtPrevious_Click);
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
            this.artanPanel2.Location = new System.Drawing.Point(0, 125);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(973, 301);
            this.artanPanel2.TabIndex = 4;
            // 
            // dataViewHNhap
            // 
            this.dataViewHNhap.AllowUserToAddRows = false;
            this.dataViewHNhap.AllowUserToResizeColumns = false;
            this.dataViewHNhap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataViewHNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewHNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewHNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewHNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewHNhap.Location = new System.Drawing.Point(0, 0);
            this.dataViewHNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dataViewHNhap.Name = "dataViewHNhap";
            this.dataViewHNhap.RowHeadersVisible = false;
            this.dataViewHNhap.RowHeadersWidth = 51;
            this.dataViewHNhap.RowTemplate.Height = 24;
            this.dataViewHNhap.Size = new System.Drawing.Size(973, 301);
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
            this.panel2_nv.Controls.Add(this.kryptonButton1);
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
            this.panel2_nv.Margin = new System.Windows.Forms.Padding(2);
            this.panel2_nv.Name = "panel2_nv";
            this.panel2_nv.Size = new System.Drawing.Size(973, 125);
            this.panel2_nv.TabIndex = 1;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(474, 110);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.Rounding = 20;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(25, 15);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.StateCommon.Back.Image")));
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopMiddle;
            this.kryptonButton1.StateCommon.Border.Rounding = 50;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 25;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 25;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.TabIndex = 36;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kry_Clear_Click);
            // 
            // kryBt_Edit
            // 
            this.kryBt_Edit.Location = new System.Drawing.Point(26, 79);
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
            this.kryBt_Edit.Size = new System.Drawing.Size(56, 34);
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
            this.kryBt_Add.Location = new System.Drawing.Point(26, 79);
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
            this.kryBt_Add.Size = new System.Drawing.Size(56, 34);
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
            this.kryTb_eID.Location = new System.Drawing.Point(492, 34);
            this.kryTb_eID.Margin = new System.Windows.Forms.Padding(2);
            this.kryTb_eID.Name = "kryTb_eID";
            this.kryTb_eID.Size = new System.Drawing.Size(200, 30);
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
            this.kryTb_Name.Location = new System.Drawing.Point(259, 34);
            this.kryTb_Name.Margin = new System.Windows.Forms.Padding(2);
            this.kryTb_Name.Name = "kryTb_Name";
            this.kryTb_Name.Size = new System.Drawing.Size(200, 30);
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
            this.kryTx_Id.Location = new System.Drawing.Point(26, 34);
            this.kryTx_Id.Margin = new System.Windows.Forms.Padding(2);
            this.kryTx_Id.Name = "kryTx_Id";
            this.kryTx_Id.Size = new System.Drawing.Size(200, 30);
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
            this.label6.Location = new System.Drawing.Point(732, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã hóa đơn xuất";
            // 
            // kry_Datetime
            // 
            this.kry_Datetime.AllowDrop = true;
            this.kry_Datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kry_Datetime.Location = new System.Drawing.Point(734, 31);
            this.kry_Datetime.Margin = new System.Windows.Forms.Padding(2);
            this.kry_Datetime.Name = "kry_Datetime";
            this.kry_Datetime.Size = new System.Drawing.Size(200, 33);
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
            // artanPanel3
            // 
            this.artanPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 25;
            this.artanPanel3.Controls.Add(this.soluong);
            this.artanPanel3.Controls.Add(this.kryBtShowCreate_NV);
            this.artanPanel3.Controls.Add(this.txb_tim_kiem_nv);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel3.Location = new System.Drawing.Point(4, 10);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1052, 63);
            this.artanPanel3.TabIndex = 8;
            // 
            // HANGXUAT_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.artanPanel3);
            this.Controls.Add(this.artanPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HANGXUAT_GUI";
            this.Text = "HANGXUAT_GUI";
            this.artanPanel1.ResumeLayout(false);
            this.panel0_nv.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewHNhap)).EndInit();
            this.panel2_nv.ResumeLayout(false);
            this.panel2_nv.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel3.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel soluong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_nv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtShowCreate_NV;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel panel0_nv;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewHNhap;
        private System.Windows.Forms.Panel panel2_nv;
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
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtNext;
        private System.Windows.Forms.Label labelSoTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtPrevious;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ArtanComponent.ArtanPanel artanPanel3;
    }
}