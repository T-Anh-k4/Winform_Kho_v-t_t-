namespace GUI
{
	partial class MENU_GUI
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
			this.doanhmucTransition = new System.Windows.Forms.Timer(this.components);
			this.bc_tkTransition = new System.Windows.Forms.Timer(this.components);
			this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
			this.SuspendLayout();
			// 
			// doanhmucTransition
			// 
			this.doanhmucTransition.Enabled = true;
			this.doanhmucTransition.Interval = 10;
			// 
			// bc_tkTransition
			// 
			this.bc_tkTransition.Enabled = true;
			this.bc_tkTransition.Interval = 10;
			// 
			// kryptonPalette1
			// 
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 15;
			this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Width = 0;
			this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
			this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
			this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.ButtonEdgeInset = 10;
			this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
			// 
			// MENU_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1382, 731);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MENU_GUI";
			this.Palette = this.kryptonPalette1;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.ShowIcon = false;
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer doanhmucTransition;
		private System.Windows.Forms.Timer bc_tkTransition;
		private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
	}
}