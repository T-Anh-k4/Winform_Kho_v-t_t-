namespace GUI
{
	partial class KHACHHANG_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KHACHHANG_GUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.soluong = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txb_tim_kiem_nv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryBtShowCreate_NV = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txb_DIACHI = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txb_SDT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txb_TEN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txb_MAKH = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.createTransition = new System.Windows.Forms.Timer(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.panel0_nv = new ArtanComponent.ArtanPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryBt_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelSoTrang = new System.Windows.Forms.Label();
            this.kryBtPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.dataViewKH = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2_nv = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel3.SuspendLayout();
            this.panel0_nv.SuspendLayout();
            this.panel4.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKH)).BeginInit();
            this.panel2_nv.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(20, 18);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(146, 26);
            this.soluong.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.soluong.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.TabIndex = 6;
            this.soluong.Values.Text = "Nhân viên (99)";
            // 
            // txb_tim_kiem_nv
            // 
            this.txb_tim_kiem_nv.Location = new System.Drawing.Point(336, 11);
            this.txb_tim_kiem_nv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txb_tim_kiem_nv.TextChanged += new System.EventHandler(this.txb_tim_kiem_LH_TextChanged);
            // 
            // kryBtShowCreate_NV
            // 
            this.kryBtShowCreate_NV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryBtShowCreate_NV.Location = new System.Drawing.Point(933, 17);
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
            this.kryBtShowCreate_NV.Click += new System.EventHandler(this.kryBtShowCreate_NV_Click);
            // 
            // kryBt_Edit
            // 
            this.kryBt_Edit.Location = new System.Drawing.Point(108, 127);
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
            this.kryBt_Add.Location = new System.Drawing.Point(107, 126);
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
            // txb_DIACHI
            // 
            this.txb_DIACHI.Location = new System.Drawing.Point(677, 53);
            this.txb_DIACHI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_DIACHI.Name = "txb_DIACHI";
            this.txb_DIACHI.Size = new System.Drawing.Size(150, 30);
            this.txb_DIACHI.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txb_DIACHI.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_DIACHI.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txb_DIACHI.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_DIACHI.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txb_DIACHI.StateCommon.Border.Rounding = 20;
            this.txb_DIACHI.StateCommon.Border.Width = 1;
            this.txb_DIACHI.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txb_DIACHI.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txb_DIACHI.TabIndex = 24;
            // 
            // txb_SDT
            // 
            this.txb_SDT.Location = new System.Drawing.Point(483, 53);
            this.txb_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_SDT.Name = "txb_SDT";
            this.txb_SDT.Size = new System.Drawing.Size(150, 30);
            this.txb_SDT.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txb_SDT.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_SDT.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txb_SDT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_SDT.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txb_SDT.StateCommon.Border.Rounding = 20;
            this.txb_SDT.StateCommon.Border.Width = 1;
            this.txb_SDT.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txb_SDT.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txb_SDT.TabIndex = 23;
            // 
            // txb_TEN
            // 
            this.txb_TEN.Location = new System.Drawing.Point(295, 53);
            this.txb_TEN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_TEN.Name = "txb_TEN";
            this.txb_TEN.Size = new System.Drawing.Size(150, 30);
            this.txb_TEN.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txb_TEN.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_TEN.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txb_TEN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_TEN.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txb_TEN.StateCommon.Border.Rounding = 20;
            this.txb_TEN.StateCommon.Border.Width = 1;
            this.txb_TEN.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txb_TEN.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txb_TEN.TabIndex = 22;
            // 
            // txb_MAKH
            // 
            this.txb_MAKH.Location = new System.Drawing.Point(108, 53);
            this.txb_MAKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_MAKH.Name = "txb_MAKH";
            this.txb_MAKH.Size = new System.Drawing.Size(150, 30);
            this.txb_MAKH.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txb_MAKH.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_MAKH.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.txb_MAKH.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_MAKH.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txb_MAKH.StateCommon.Border.Rounding = 20;
            this.txb_MAKH.StateCommon.Border.Width = 1;
            this.txb_MAKH.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.txb_MAKH.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txb_MAKH.TabIndex = 21;
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
            this.artanPanel3.Controls.Add(this.txb_tim_kiem_nv);
            this.artanPanel3.Controls.Add(this.kryBtShowCreate_NV);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel3.Location = new System.Drawing.Point(9, 9);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1044, 63);
            this.artanPanel3.TabIndex = 11;
            // 
            // panel0_nv
            // 
            this.panel0_nv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel0_nv.BackColor = System.Drawing.Color.White;
            this.panel0_nv.BorderRadius = 25;
            this.panel0_nv.Controls.Add(this.panel4);
            this.panel0_nv.Controls.Add(this.artanPanel2);
            this.panel0_nv.Controls.Add(this.panel2_nv);
            this.panel0_nv.ForeColor = System.Drawing.Color.Black;
            this.panel0_nv.GradientAngle = 90F;
            this.panel0_nv.GradientBottomColor = System.Drawing.Color.White;
            this.panel0_nv.GradientTopColor = System.Drawing.Color.White;
            this.panel0_nv.Location = new System.Drawing.Point(35, 24);
            this.panel0_nv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel0_nv.Name = "panel0_nv";
            this.panel0_nv.Size = new System.Drawing.Size(973, 547);
            this.panel0_nv.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.kryBt_Next);
            this.panel4.Controls.Add(this.labelSoTrang);
            this.panel4.Controls.Add(this.kryBtPre);
            this.panel4.Location = new System.Drawing.Point(898, 508);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(64, 25);
            this.panel4.TabIndex = 6;
            // 
            // kryBt_Next
            // 
            this.kryBt_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryBt_Next.Location = new System.Drawing.Point(44, 0);
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
            this.kryBt_Next.Size = new System.Drawing.Size(20, 25);
            this.kryBt_Next.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryBt_Next.StateCommon.Back.Image")));
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
            this.labelSoTrang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoTrang.AutoSize = true;
            this.labelSoTrang.Location = new System.Drawing.Point(23, 6);
            this.labelSoTrang.Name = "labelSoTrang";
            this.labelSoTrang.Size = new System.Drawing.Size(13, 13);
            this.labelSoTrang.TabIndex = 5;
            this.labelSoTrang.Text = "1";
            // 
            // kryBtPre
            // 
            this.kryBtPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryBtPre.Location = new System.Drawing.Point(0, 0);
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
            this.kryBtPre.Size = new System.Drawing.Size(20, 25);
            this.kryBtPre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("kryBtPre.StateCommon.Back.Image")));
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
            this.kryBtPre.Click += new System.EventHandler(this.kryBtPredious_Click);
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 25;
            this.artanPanel2.Controls.Add(this.dataViewKH);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel2.Location = new System.Drawing.Point(0, 180);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(973, 301);
            this.artanPanel2.TabIndex = 4;
            // 
            // dataViewKH
            // 
            this.dataViewKH.AllowUserToAddRows = false;
            this.dataViewKH.AllowUserToResizeColumns = false;
            this.dataViewKH.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataViewKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewKH.Location = new System.Drawing.Point(0, 0);
            this.dataViewKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataViewKH.Name = "dataViewKH";
            this.dataViewKH.RowHeadersVisible = false;
            this.dataViewKH.RowHeadersWidth = 51;
            this.dataViewKH.RowTemplate.Height = 24;
            this.dataViewKH.Size = new System.Drawing.Size(973, 301);
            this.dataViewKH.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataViewKH.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewKH.StateCommon.DataCell.Border.Width = 0;
            this.dataViewKH.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dataViewKH.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dataViewKH.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dataViewKH.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dataViewKH.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dataViewKH.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewKH.StateCommon.HeaderColumn.Border.Width = 0;
            this.dataViewKH.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewKH.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
            this.dataViewKH.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.dataViewKH.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewKH.TabIndex = 0;
            this.dataViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewKH_CellClick);
            // 
            // panel2_nv
            // 
            this.panel2_nv.Controls.Add(this.kryptonButton1);
            this.panel2_nv.Controls.Add(this.kryBt_Edit);
            this.panel2_nv.Controls.Add(this.kryBt_Add);
            this.panel2_nv.Controls.Add(this.txb_DIACHI);
            this.panel2_nv.Controls.Add(this.txb_SDT);
            this.panel2_nv.Controls.Add(this.txb_TEN);
            this.panel2_nv.Controls.Add(this.txb_MAKH);
            this.panel2_nv.Controls.Add(this.label4);
            this.panel2_nv.Controls.Add(this.label3);
            this.panel2_nv.Controls.Add(this.label2);
            this.panel2_nv.Controls.Add(this.label1);
            this.panel2_nv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_nv.Location = new System.Drawing.Point(0, 0);
            this.panel2_nv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2_nv.Name = "panel2_nv";
            this.panel2_nv.Size = new System.Drawing.Size(973, 180);
            this.panel2_nv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(676, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã khách hàng";
            // 
            // artanPanel1
            // 
            this.artanPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 25;
            this.artanPanel1.Controls.Add(this.panel0_nv);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Gainsboro;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel1.Location = new System.Drawing.Point(8, 86);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1044, 596);
            this.artanPanel1.TabIndex = 9;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(470, 165);
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
            this.kryptonButton1.TabIndex = 82;
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kry_Clear_Click);
            // 
            // KHACHHANG_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 690);
            this.Controls.Add(this.artanPanel3);
            this.Controls.Add(this.artanPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KHACHHANG_GUI";
            this.Text = "KHACHHANG_GUI";
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel3.PerformLayout();
            this.panel0_nv.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKH)).EndInit();
            this.panel2_nv.ResumeLayout(false);
            this.panel2_nv.PerformLayout();
            this.artanPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonLabel soluong;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_nv;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtShowCreate_NV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_DIACHI;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_SDT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_TEN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_MAKH;
        private System.Windows.Forms.Timer createTransition;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ArtanComponent.ArtanPanel panel0_nv;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Next;
        private System.Windows.Forms.Label labelSoTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtPre;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewKH;
        private System.Windows.Forms.Panel panel2_nv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}