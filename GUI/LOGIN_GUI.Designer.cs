namespace GUI
{
	partial class LOGIN_GUI
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
			this.artanPanel1 = new ArtanComponent.ArtanPanel();
			this.kryBtExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.kryBtLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryTbMatKhau = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kryTbTaiKhoan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.artanPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// artanPanel1
			// 
			this.artanPanel1.BackColor = System.Drawing.Color.Transparent;
			this.artanPanel1.BorderRadius = 25;
			this.artanPanel1.Controls.Add(this.kryBtExit);
			this.artanPanel1.Controls.Add(this.panel2);
			this.artanPanel1.Controls.Add(this.panel1);
			this.artanPanel1.Controls.Add(this.kryBtLogin);
			this.artanPanel1.Controls.Add(this.kryTbMatKhau);
			this.artanPanel1.Controls.Add(this.kryTbTaiKhoan);
			this.artanPanel1.Controls.Add(this.label2);
			this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.artanPanel1.ForeColor = System.Drawing.Color.Black;
			this.artanPanel1.GradientAngle = 90F;
			this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.artanPanel1.Location = new System.Drawing.Point(0, 0);
			this.artanPanel1.Name = "artanPanel1";
			this.artanPanel1.Size = new System.Drawing.Size(404, 419);
			this.artanPanel1.TabIndex = 1;
			this.artanPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.artanPanel1_Paint);
			// 
			// kryBtExit
			// 
			this.kryBtExit.Location = new System.Drawing.Point(220, 321);
			this.kryBtExit.Name = "kryBtExit";
			this.kryBtExit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.OverrideDefault.Back.ColorAngle = 45F;
			this.kryBtExit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.OverrideDefault.Border.ColorAngle = 45F;
			this.kryBtExit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtExit.OverrideDefault.Border.Rounding = 20;
			this.kryBtExit.OverrideDefault.Border.Width = 1;
			this.kryBtExit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryBtExit.Size = new System.Drawing.Size(108, 39);
			this.kryBtExit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateCommon.Border.ColorAngle = 45F;
			this.kryBtExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtExit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtExit.StateCommon.Border.Rounding = 25;
			this.kryBtExit.StateCommon.Border.Width = 1;
			this.kryBtExit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kryBtExit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kryBtExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryBtExit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.StatePressed.Back.ColorAngle = 135F;
			this.kryBtExit.StatePressed.Border.ColorAngle = 135F;
			this.kryBtExit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtExit.StatePressed.Border.Rounding = 25;
			this.kryBtExit.StatePressed.Border.Width = 1;
			this.kryBtExit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateTracking.Back.ColorAngle = 45F;
			this.kryBtExit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtExit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtExit.StateTracking.Border.Rounding = 25;
			this.kryBtExit.StateTracking.Border.Width = 1;
			this.kryBtExit.TabIndex = 33;
			this.kryBtExit.Values.Text = "Thoát";
			this.kryBtExit.Click += new System.EventHandler(this.kryBtExit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(1, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(403, 1);
			this.panel2.TabIndex = 31;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 419);
			this.panel1.TabIndex = 30;
			// 
			// kryBtLogin
			// 
			this.kryBtLogin.Location = new System.Drawing.Point(71, 321);
			this.kryBtLogin.Name = "kryBtLogin";
			this.kryBtLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.OverrideDefault.Back.ColorAngle = 45F;
			this.kryBtLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.OverrideDefault.Border.ColorAngle = 45F;
			this.kryBtLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtLogin.OverrideDefault.Border.Rounding = 20;
			this.kryBtLogin.OverrideDefault.Border.Width = 1;
			this.kryBtLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryBtLogin.Size = new System.Drawing.Size(108, 39);
			this.kryBtLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateCommon.Border.ColorAngle = 45F;
			this.kryBtLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtLogin.StateCommon.Border.Rounding = 25;
			this.kryBtLogin.StateCommon.Border.Width = 1;
			this.kryBtLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kryBtLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kryBtLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kryBtLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StatePressed.Back.ColorAngle = 135F;
			this.kryBtLogin.StatePressed.Border.ColorAngle = 135F;
			this.kryBtLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtLogin.StatePressed.Border.Rounding = 25;
			this.kryBtLogin.StatePressed.Border.Width = 1;
			this.kryBtLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateTracking.Back.ColorAngle = 45F;
			this.kryBtLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryBtLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBtLogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBtLogin.StateTracking.Border.Rounding = 25;
			this.kryBtLogin.StateTracking.Border.Width = 1;
			this.kryBtLogin.TabIndex = 28;
			this.kryBtLogin.Values.Text = "Đăng nhập";
			this.kryBtLogin.Click += new System.EventHandler(this.kryBtLogin_Click);
			// 
			// kryTbMatKhau
			// 
			this.kryTbMatKhau.Location = new System.Drawing.Point(71, 240);
			this.kryTbMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.kryTbMatKhau.Name = "kryTbMatKhau";
			this.kryTbMatKhau.Size = new System.Drawing.Size(257, 44);
			this.kryTbMatKhau.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryTbMatKhau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryTbMatKhau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryTbMatKhau.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTbMatKhau.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTbMatKhau.StateCommon.Border.Rounding = 40;
			this.kryTbMatKhau.StateCommon.Border.Width = 1;
			this.kryTbMatKhau.StateCommon.Content.Color1 = System.Drawing.Color.White;
			this.kryTbMatKhau.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTbMatKhau.TabIndex = 23;
			this.kryTbMatKhau.TextChanged += new System.EventHandler(this.kryBtMatKhau_TextChanged);
			// 
			// kryTbTaiKhoan
			// 
			this.kryTbTaiKhoan.Location = new System.Drawing.Point(71, 176);
			this.kryTbTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.kryTbTaiKhoan.Name = "kryTbTaiKhoan";
			this.kryTbTaiKhoan.Size = new System.Drawing.Size(257, 44);
			this.kryTbTaiKhoan.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryTbTaiKhoan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryTbTaiKhoan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryTbTaiKhoan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTbTaiKhoan.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTbTaiKhoan.StateCommon.Border.Rounding = 40;
			this.kryTbTaiKhoan.StateCommon.Border.Width = 1;
			this.kryTbTaiKhoan.StateCommon.Content.Color1 = System.Drawing.Color.White;
			this.kryTbTaiKhoan.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.kryTbTaiKhoan.TabIndex = 22;
			this.kryTbTaiKhoan.TextChanged += new System.EventHandler(this.kryTbTaiKhoan_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(139, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 48);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			// 
			// kryptonPalette1
			// 
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
			this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
			this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
			// 
			// LOGIN_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(404, 419);
			this.Controls.Add(this.artanPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "LOGIN_GUI";
			this.Palette = this.kryptonPalette1;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN_GUI";
			this.artanPanel1.ResumeLayout(false);
			this.artanPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private ArtanComponent.ArtanPanel artanPanel1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtLogin;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTbMatKhau;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTbTaiKhoan;
		private System.Windows.Forms.Label label2;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtExit;
	}
}