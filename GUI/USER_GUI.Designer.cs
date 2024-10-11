namespace GUI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.createTransition_User = new System.Windows.Forms.Timer(this.components);
			this.kryBtShowCreate_User = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kry_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryBt_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryBt_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryTb_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryTx_Id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.kryCheckBox_Status = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.kryCb_Gender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.artanPanel1 = new ArtanComponent.ArtanPanel();
			this.panel0_nv = new ArtanComponent.ArtanPanel();
			this.artanPanel2 = new ArtanComponent.ArtanPanel();
			this.dataViewUser = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.panel2_nv = new System.Windows.Forms.Panel();
			this.kryTb_Number = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.kryCb_Gender)).BeginInit();
			this.artanPanel1.SuspendLayout();
			this.panel0_nv.SuspendLayout();
			this.artanPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataViewUser)).BeginInit();
			this.panel2_nv.SuspendLayout();
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
			this.kryBtShowCreate_User.Location = new System.Drawing.Point(936, 10);
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
			this.kry_Clear.Location = new System.Drawing.Point(753, 145);
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
			// 
			// kryBt_Edit
			// 
			this.kryBt_Edit.Location = new System.Drawing.Point(175, 145);
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
			// 
			// kryBt_Add
			// 
			this.kryBt_Add.Location = new System.Drawing.Point(175, 146);
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
			// 
			// kryTb_Name
			// 
			this.kryTb_Name.Location = new System.Drawing.Point(409, 30);
			this.kryTb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTb_Name.Name = "kryTb_Name";
			this.kryTb_Name.Size = new System.Drawing.Size(200, 34);
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
			this.kryTb_Name.TabIndex = 22;
			// 
			// kryTx_Id
			// 
			this.kryTx_Id.Location = new System.Drawing.Point(175, 30);
			this.kryTx_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTx_Id.Name = "kryTx_Id";
			this.kryTx_Id.Size = new System.Drawing.Size(200, 34);
			this.kryTx_Id.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTx_Id.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTx_Id.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryTx_Id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTx_Id.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTx_Id.StateCommon.Border.Rounding = 20;
			this.kryTx_Id.StateCommon.Border.Width = 1;
			this.kryTx_Id.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.kryTx_Id.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTx_Id.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(407, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 16);
			this.label7.TabIndex = 16;
			this.label7.Text = "Trạng thái";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.kryBtShowCreate_User);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1025, 58);
			this.panel1.TabIndex = 3;
			// 
			// kryCheckBox_Status
			// 
			this.kryCheckBox_Status.Location = new System.Drawing.Point(425, 105);
			this.kryCheckBox_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryCheckBox_Status.Name = "kryCheckBox_Status";
			this.kryCheckBox_Status.Size = new System.Drawing.Size(19, 13);
			this.kryCheckBox_Status.TabIndex = 15;
			this.kryCheckBox_Status.Values.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(172, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Loại người dùng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(407, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mật khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(173, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên đăng nhập";
			// 
			// kryCb_Gender
			// 
			this.kryCb_Gender.DropDownWidth = 184;
			this.kryCb_Gender.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
			this.kryCb_Gender.Location = new System.Drawing.Point(175, 92);
			this.kryCb_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryCb_Gender.Name = "kryCb_Gender";
			this.kryCb_Gender.Size = new System.Drawing.Size(200, 37);
			this.kryCb_Gender.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
			this.kryCb_Gender.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Gray;
			this.kryCb_Gender.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.kryCb_Gender.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryCb_Gender.StateCommon.ComboBox.Border.Rounding = 20;
			this.kryCb_Gender.StateCommon.ComboBox.Border.Width = 1;
			this.kryCb_Gender.TabIndex = 1;
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
			this.artanPanel1.Location = new System.Drawing.Point(283, 98);
			this.artanPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.artanPanel1.Name = "artanPanel1";
			this.artanPanel1.Size = new System.Drawing.Size(1087, 622);
			this.artanPanel1.TabIndex = 4;
			// 
			// panel0_nv
			// 
			this.panel0_nv.BackColor = System.Drawing.Color.White;
			this.panel0_nv.BorderRadius = 25;
			this.panel0_nv.Controls.Add(this.artanPanel2);
			this.panel0_nv.Controls.Add(this.panel2_nv);
			this.panel0_nv.Controls.Add(this.panel1);
			this.panel0_nv.ForeColor = System.Drawing.Color.Black;
			this.panel0_nv.GradientAngle = 90F;
			this.panel0_nv.GradientBottomColor = System.Drawing.Color.White;
			this.panel0_nv.GradientTopColor = System.Drawing.Color.White;
			this.panel0_nv.Location = new System.Drawing.Point(32, 31);
			this.panel0_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel0_nv.Name = "panel0_nv";
			this.panel0_nv.Size = new System.Drawing.Size(1025, 565);
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
			this.artanPanel2.Location = new System.Drawing.Point(0, 257);
			this.artanPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.artanPanel2.Name = "artanPanel2";
			this.artanPanel2.Size = new System.Drawing.Size(1025, 246);
			this.artanPanel2.TabIndex = 4;
			// 
			// dataViewUser
			// 
			this.dataViewUser.AllowUserToAddRows = false;
			this.dataViewUser.AllowUserToResizeColumns = false;
			this.dataViewUser.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			this.dataViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataViewUser.Location = new System.Drawing.Point(0, 0);
			this.dataViewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataViewUser.Name = "dataViewUser";
			this.dataViewUser.RowHeadersVisible = false;
			this.dataViewUser.RowHeadersWidth = 51;
			this.dataViewUser.RowTemplate.Height = 24;
			this.dataViewUser.Size = new System.Drawing.Size(1025, 246);
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
			this.panel2_nv.Controls.Add(this.kry_Clear);
			this.panel2_nv.Controls.Add(this.kryBt_Edit);
			this.panel2_nv.Controls.Add(this.kryBt_Add);
			this.panel2_nv.Controls.Add(this.kryTb_Number);
			this.panel2_nv.Controls.Add(this.kryTb_Name);
			this.panel2_nv.Controls.Add(this.kryTx_Id);
			this.panel2_nv.Controls.Add(this.label7);
			this.panel2_nv.Controls.Add(this.kryCheckBox_Status);
			this.panel2_nv.Controls.Add(this.label5);
			this.panel2_nv.Controls.Add(this.label3);
			this.panel2_nv.Controls.Add(this.label2);
			this.panel2_nv.Controls.Add(this.label1);
			this.panel2_nv.Controls.Add(this.kryCb_Gender);
			this.panel2_nv.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2_nv.Location = new System.Drawing.Point(0, 58);
			this.panel2_nv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2_nv.Name = "panel2_nv";
			this.panel2_nv.Size = new System.Drawing.Size(1025, 199);
			this.panel2_nv.TabIndex = 1;
			// 
			// kryTb_Number
			// 
			this.kryTb_Number.Location = new System.Drawing.Point(646, 30);
			this.kryTb_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.kryTb_Number.Name = "kryTb_Number";
			this.kryTb_Number.Size = new System.Drawing.Size(200, 34);
			this.kryTb_Number.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTb_Number.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
			this.kryTb_Number.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
			this.kryTb_Number.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTb_Number.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTb_Number.StateCommon.Border.Rounding = 20;
			this.kryTb_Number.StateCommon.Border.Width = 1;
			this.kryTb_Number.StateCommon.Content.Color1 = System.Drawing.Color.Black;
			this.kryTb_Number.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTb_Number.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(643, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nhập lại mật khẩu";
			// 
			// USER_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1381, 753);
			this.Controls.Add(this.artanPanel1);
			this.Name = "USER_GUI";
			this.Text = "CREATEUSER_GUI";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.kryCb_Gender)).EndInit();
			this.artanPanel1.ResumeLayout(false);
			this.panel0_nv.ResumeLayout(false);
			this.artanPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataViewUser)).EndInit();
			this.panel2_nv.ResumeLayout(false);
			this.panel2_nv.PerformLayout();
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
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Name;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTx_Id;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryCheckBox_Status;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryCb_Gender;
		private ArtanComponent.ArtanPanel artanPanel1;
		private ArtanComponent.ArtanPanel panel0_nv;
		private ArtanComponent.ArtanPanel artanPanel2;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewUser;
		private System.Windows.Forms.Panel panel2_nv;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Number;
		private System.Windows.Forms.Label label3;
	}
}