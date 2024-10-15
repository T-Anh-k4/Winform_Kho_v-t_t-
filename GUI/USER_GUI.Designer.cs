﻿namespace GUI
{
	partial class USER_GUI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_GUI));
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.createTransition_User = new System.Windows.Forms.Timer(this.components);
			this.kryBtShowCreate_User = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kry_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryBt_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryBt_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryTb_Pass = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryTb_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.kryTbSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryStatus = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kryCb_Loai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.artanPanel1 = new ArtanComponent.ArtanPanel();
			this.panel0_nv = new ArtanComponent.ArtanPanel();
			this.artanPanel2 = new ArtanComponent.ArtanPanel();
			this.dataViewUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.panel2_nv = new System.Windows.Forms.Panel();
			this.kryTbManv = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.kryTb_Pass1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.artanPanel3 = new ArtanComponent.ArtanPanel();
			this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.kryBt_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.labelSoTrang = new System.Windows.Forms.Label();
			this.kryBtPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			((System.ComponentModel.ISupportInitialize)(this.kryCb_Loai)).BeginInit();
			this.artanPanel1.SuspendLayout();
			this.panel0_nv.SuspendLayout();
			this.artanPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViewUser)).BeginInit();
			this.panel2_nv.SuspendLayout();
			this.artanPanel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// createTransition_User
			// 
			this.createTransition_User.Enabled = true;
			this.createTransition_User.Interval = 10;
			this.createTransition_User.Tick += new System.EventHandler(this.createTransition_Tick);
			// 
			// kryBtShowCreate_User
			// 
			this.kryBtShowCreate_User.Location = new System.Drawing.Point(1291, 16);
			this.kryBtShowCreate_User.Margin = new System.Windows.Forms.Padding(4);
			this.kryBtShowCreate_User.Name = "kryBtShowCreate_User";
			this.kryBtShowCreate_User.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.OverrideDefault.Back.ColorAngle = 45F;
			this.kryBtShowCreate_User.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.OverrideDefault.Border.ColorAngle = 45F;
			this.kryBtShowCreate_User.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtShowCreate_User.OverrideDefault.Border.Rounding = 20;
			this.kryBtShowCreate_User.OverrideDefault.Border.Width = 1;
			this.kryBtShowCreate_User.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryBtShowCreate_User.Size = new System.Drawing.Size(75, 42);
			this.kryBtShowCreate_User.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateCommon.Border.ColorAngle = 45F;
			this.kryBtShowCreate_User.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtShowCreate_User.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtShowCreate_User.StateCommon.Border.Rounding = 25;
			this.kryBtShowCreate_User.StateCommon.Border.Width = 1;
			this.kryBtShowCreate_User.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kryBtShowCreate_User.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kryBtShowCreate_User.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryBtShowCreate_User.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StatePressed.Back.ColorAngle = 135F;
			this.kryBtShowCreate_User.StatePressed.Border.ColorAngle = 135F;
			this.kryBtShowCreate_User.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtShowCreate_User.StatePressed.Border.Rounding = 25;
			this.kryBtShowCreate_User.StatePressed.Border.Width = 1;
			this.kryBtShowCreate_User.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateTracking.Back.ColorAngle = 45F;
			this.kryBtShowCreate_User.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtShowCreate_User.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtShowCreate_User.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtShowCreate_User.StateTracking.Border.Rounding = 25;
			this.kryBtShowCreate_User.StateTracking.Border.Width = 1;
			this.kryBtShowCreate_User.TabIndex = 27;
			this.kryBtShowCreate_User.Values.Text = "+";
			this.kryBtShowCreate_User.Click += new System.EventHandler(this.kryBtShowCreate_User_Click);
			// 
			// kry_Clear
			// 
			this.kry_Clear.Location = new System.Drawing.Point(976, 151);
			this.kry_Clear.Margin = new System.Windows.Forms.Padding(4);
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
			this.kry_Clear.Size = new System.Drawing.Size(93, 42);
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
			this.kry_Clear.Values.Text = "Làm mới";
			this.kry_Clear.Click += new System.EventHandler(this.kry_Clear_Click);
			// 
			// kryBt_Edit
			// 
			this.kryBt_Edit.Location = new System.Drawing.Point(218, 151);
			this.kryBt_Edit.Margin = new System.Windows.Forms.Padding(4);
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
			this.kryBt_Edit.Size = new System.Drawing.Size(75, 42);
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
			this.kryBt_Add.Location = new System.Drawing.Point(218, 152);
			this.kryBt_Add.Margin = new System.Windows.Forms.Padding(4);
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
			this.kryBt_Add.Size = new System.Drawing.Size(75, 42);
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
			// kryTb_Pass
			// 
			this.kryTb_Pass.Location = new System.Drawing.Point(548, 36);
			this.kryTb_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTb_Pass.Name = "kryTb_Pass";
			this.kryTb_Pass.Size = new System.Drawing.Size(200, 30);
			this.kryTb_Pass.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTb_Pass.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTb_Pass.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryTb_Pass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTb_Pass.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTb_Pass.StateCommon.Border.Rounding = 20;
			this.kryTb_Pass.StateCommon.Border.Width = 1;
			this.kryTb_Pass.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.kryTb_Pass.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTb_Pass.TabIndex = 22;
			// 
			// kryTb_Name
			// 
			this.kryTb_Name.Location = new System.Drawing.Point(218, 36);
			this.kryTb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
			this.kryTb_Name.StateCommon.Content.Color1 = System.Drawing.Color.Red;
			this.kryTb_Name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTb_Name.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(866, 84);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Trạng thái";
			// 
			// kryTbSearch
			// 
			this.kryTbSearch.Location = new System.Drawing.Point(435, 16);
			this.kryTbSearch.Name = "kryTbSearch";
			this.kryTbSearch.Size = new System.Drawing.Size(433, 33);
			this.kryTbSearch.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTbSearch.StateCommon.Border.Color2 = System.Drawing.Color.White;
			this.kryTbSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTbSearch.StateCommon.Border.Rounding = 15;
			this.kryTbSearch.StateCommon.Content.Color1 = System.Drawing.Color.LightGray;
			this.kryTbSearch.TabIndex = 28;
			this.kryTbSearch.TextChanged += new System.EventHandler(this.kryTbSearch_TextChanged);
			// 
			// kryStatus
			// 
			this.kryStatus.Location = new System.Drawing.Point(882, 118);
			this.kryStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryStatus.Name = "kryStatus";
			this.kryStatus.Size = new System.Drawing.Size(19, 13);
			this.kryStatus.TabIndex = 15;
			this.kryStatus.Values.Text = "";
			this.kryStatus.CheckedChanged += new System.EventHandler(this.kryStatus_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(216, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Loại người dùng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(546, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mật khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(216, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên đăng nhập";
			// 
			// kryCb_Loai
			// 
			this.kryCb_Loai.DropDownWidth = 184;
			this.kryCb_Loai.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
			this.kryCb_Loai.Location = new System.Drawing.Point(219, 107);
			this.kryCb_Loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryCb_Loai.Name = "kryCb_Loai";
			this.kryCb_Loai.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryCb_Loai.Size = new System.Drawing.Size(200, 33);
			this.kryCb_Loai.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
			this.kryCb_Loai.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
			this.kryCb_Loai.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.kryCb_Loai.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryCb_Loai.StateCommon.ComboBox.Border.Rounding = 18;
			this.kryCb_Loai.StateCommon.ComboBox.Border.Width = 1;
			this.kryCb_Loai.TabIndex = 1;
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
			this.artanPanel1.Location = new System.Drawing.Point(13, 116);
			this.artanPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.artanPanel1.Name = "artanPanel1";
			this.artanPanel1.Size = new System.Drawing.Size(1392, 734);
			this.artanPanel1.TabIndex = 4;
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
			this.panel0_nv.Location = new System.Drawing.Point(47, 30);
			this.panel0_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel0_nv.Name = "panel0_nv";
			this.panel0_nv.Size = new System.Drawing.Size(1297, 673);
			this.panel0_nv.TabIndex = 0;
			// 
			// artanPanel2
			// 
			this.artanPanel2.BackColor = System.Drawing.Color.White;
			this.artanPanel2.BorderRadius = 25;
			this.artanPanel2.Controls.Add(this.dataViewUser);
			this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.artanPanel2.ForeColor = System.Drawing.Color.Black;
			this.artanPanel2.GradientAngle = 90F;
			this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
			this.artanPanel2.GradientTopColor = System.Drawing.Color.White;
			this.artanPanel2.Location = new System.Drawing.Point(0, 199);
			this.artanPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.artanPanel2.Name = "artanPanel2";
			this.artanPanel2.Size = new System.Drawing.Size(1297, 408);
			this.artanPanel2.TabIndex = 4;
			// 
			// dataViewUser
			// 
			this.dataViewUser.AllowUserToAddRows = false;
			this.dataViewUser.AllowUserToResizeColumns = false;
			this.dataViewUser.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			this.dataViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataViewUser.Location = new System.Drawing.Point(0, 0);
			this.dataViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataViewUser.Name = "dataViewUser";
			this.dataViewUser.RowHeadersVisible = false;
			this.dataViewUser.RowHeadersWidth = 51;
			this.dataViewUser.RowTemplate.Height = 24;
			this.dataViewUser.Size = new System.Drawing.Size(1297, 408);
			this.dataViewUser.StateCommon.Background.Color1 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.Background.Color2 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
			this.dataViewUser.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.dataViewUser.StateCommon.DataCell.Border.Width = 0;
			this.dataViewUser.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
			this.dataViewUser.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
			this.dataViewUser.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.dataViewUser.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
			this.dataViewUser.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
			this.dataViewUser.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.dataViewUser.StateCommon.HeaderColumn.Border.Width = 0;
			this.dataViewUser.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.dataViewUser.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
			this.dataViewUser.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
			this.dataViewUser.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
			this.dataViewUser.TabIndex = 0;
			this.dataViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewUser_CellClick);
			// 
			// panel2_nv
			// 
			this.panel2_nv.Controls.Add(this.kryTbManv);
			this.panel2_nv.Controls.Add(this.label4);
			this.panel2_nv.Controls.Add(this.kry_Clear);
			this.panel2_nv.Controls.Add(this.kryBt_Edit);
			this.panel2_nv.Controls.Add(this.kryBt_Add);
			this.panel2_nv.Controls.Add(this.kryTb_Pass1);
			this.panel2_nv.Controls.Add(this.kryTb_Pass);
			this.panel2_nv.Controls.Add(this.kryTb_Name);
			this.panel2_nv.Controls.Add(this.label7);
			this.panel2_nv.Controls.Add(this.kryStatus);
			this.panel2_nv.Controls.Add(this.label5);
			this.panel2_nv.Controls.Add(this.label3);
			this.panel2_nv.Controls.Add(this.label2);
			this.panel2_nv.Controls.Add(this.label1);
			this.panel2_nv.Controls.Add(this.kryCb_Loai);
			this.panel2_nv.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2_nv.Location = new System.Drawing.Point(0, 0);
			this.panel2_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2_nv.Name = "panel2_nv";
			this.panel2_nv.Size = new System.Drawing.Size(1297, 199);
			this.panel2_nv.TabIndex = 1;
			// 
			// kryTbManv
			// 
			this.kryTbManv.Location = new System.Drawing.Point(548, 107);
			this.kryTbManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTbManv.Name = "kryTbManv";
			this.kryTbManv.Size = new System.Drawing.Size(200, 30);
			this.kryTbManv.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTbManv.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTbManv.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryTbManv.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTbManv.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTbManv.StateCommon.Border.Rounding = 20;
			this.kryTbManv.StateCommon.Border.Width = 1;
			this.kryTbManv.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.kryTbManv.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTbManv.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(546, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 16);
			this.label4.TabIndex = 31;
			this.label4.Text = "Mã nhân viên";
			// 
			// kryTb_Pass1
			// 
			this.kryTb_Pass1.Location = new System.Drawing.Point(869, 36);
			this.kryTb_Pass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTb_Pass1.Name = "kryTb_Pass1";
			this.kryTb_Pass1.Size = new System.Drawing.Size(200, 30);
			this.kryTb_Pass1.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTb_Pass1.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTb_Pass1.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryTb_Pass1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTb_Pass1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTb_Pass1.StateCommon.Border.Rounding = 20;
			this.kryTb_Pass1.StateCommon.Border.Width = 1;
			this.kryTb_Pass1.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.kryTb_Pass1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTb_Pass1.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(866, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nhập lại mật khẩu";
			// 
			// artanPanel3
			// 
			this.artanPanel3.BackColor = System.Drawing.Color.White;
			this.artanPanel3.BorderRadius = 25;
			this.artanPanel3.Controls.Add(this.kryptonLabel1);
			this.artanPanel3.Controls.Add(this.kryBtShowCreate_User);
			this.artanPanel3.Controls.Add(this.kryTbSearch);
			this.artanPanel3.ForeColor = System.Drawing.Color.Black;
			this.artanPanel3.GradientAngle = 90F;
			this.artanPanel3.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel3.GradientTopColor = System.Drawing.Color.WhiteSmoke;
			this.artanPanel3.Location = new System.Drawing.Point(13, 13);
			this.artanPanel3.Name = "artanPanel3";
			this.artanPanel3.Size = new System.Drawing.Size(1392, 78);
			this.artanPanel3.TabIndex = 5;
			// 
			// kryptonLabel1
			// 
			this.kryptonLabel1.Location = new System.Drawing.Point(21, 25);
			this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
			this.kryptonLabel1.Name = "kryptonLabel1";
			this.kryptonLabel1.Size = new System.Drawing.Size(143, 26);
			this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
			this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryptonLabel1.TabIndex = 29;
			this.kryptonLabel1.Values.Text = "Tài khoản (99)";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.kryBt_Next);
			this.panel4.Controls.Add(this.labelSoTrang);
			this.panel4.Controls.Add(this.kryBtPre);
			this.panel4.Location = new System.Drawing.Point(1195, 628);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(85, 31);
			this.panel4.TabIndex = 30;
			// 
			// kryBt_Next
			// 
			this.kryBt_Next.Location = new System.Drawing.Point(55, 4);
			this.kryBt_Next.Margin = new System.Windows.Forms.Padding(4);
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
			this.kryBt_Next.Size = new System.Drawing.Size(27, 25);
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
			// 
			// labelSoTrang
			// 
			this.labelSoTrang.AutoSize = true;
			this.labelSoTrang.Location = new System.Drawing.Point(31, 7);
			this.labelSoTrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelSoTrang.Name = "labelSoTrang";
			this.labelSoTrang.Size = new System.Drawing.Size(14, 16);
			this.labelSoTrang.TabIndex = 5;
			this.labelSoTrang.Text = "1";
			// 
			// kryBtPre
			// 
			this.kryBtPre.Location = new System.Drawing.Point(0, 4);
			this.kryBtPre.Margin = new System.Windows.Forms.Padding(4);
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
			this.kryBtPre.Size = new System.Drawing.Size(27, 25);
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
			// 
			// USER_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1424, 861);
			this.Controls.Add(this.artanPanel3);
			this.Controls.Add(this.artanPanel1);
			this.Name = "USER_GUI";
			this.Text = "CREATEUSER_GUI";
			((System.ComponentModel.ISupportInitialize)(this.kryCb_Loai)).EndInit();
			this.artanPanel1.ResumeLayout(false);
			this.panel0_nv.ResumeLayout(false);
			this.artanPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViewUser)).EndInit();
			this.panel2_nv.ResumeLayout(false);
			this.panel2_nv.PerformLayout();
			this.artanPanel3.ResumeLayout(false);
			this.artanPanel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
		private System.Windows.Forms.Timer createTransition_User;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtShowCreate_User;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kry_Clear;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Edit;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Add;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Pass;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Name;
		private System.Windows.Forms.Label label7;
		private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryCb_Loai;
		private ArtanComponent.ArtanPanel artanPanel1;
		private ArtanComponent.ArtanPanel panel0_nv;
		private ArtanComponent.ArtanPanel artanPanel2;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewUser;
		private System.Windows.Forms.Panel panel2_nv;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Pass1;
		private System.Windows.Forms.Label label3;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTbSearch;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTbManv;
		private System.Windows.Forms.Label label4;
		private ArtanComponent.ArtanPanel artanPanel3;
		private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
		private System.Windows.Forms.Panel panel4;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Next;
		private System.Windows.Forms.Label labelSoTrang;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtPre;
	}
}