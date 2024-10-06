namespace GUI
{
	partial class NHANVIEN_GUI
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
			this.kryDataView_NhanVien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.kryBt_Function = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
			this.kryTb_Seach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			((System.ComponentModel.ISupportInitialize)(this.kryDataView_NhanVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
			this.kryptonPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// kryDataView_NhanVien
			// 
			this.kryDataView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.kryDataView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kryDataView_NhanVien.Location = new System.Drawing.Point(166, 150);
			this.kryDataView_NhanVien.Name = "kryDataView_NhanVien";
			this.kryDataView_NhanVien.RowHeadersWidth = 51;
			this.kryDataView_NhanVien.RowTemplate.Height = 24;
			this.kryDataView_NhanVien.Size = new System.Drawing.Size(952, 426);
			this.kryDataView_NhanVien.TabIndex = 0;
			this.kryDataView_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryDataView_NhanVien_CellClick);
			// 
			// kryBt_Function
			// 
			this.kryBt_Function.Location = new System.Drawing.Point(1048, 100);
			this.kryBt_Function.Name = "kryBt_Function";
			this.kryBt_Function.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.kryBt_Function.Size = new System.Drawing.Size(70, 44);
			this.kryBt_Function.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
			this.kryBt_Function.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
			this.kryBt_Function.StateCommon.Back.ColorAngle = 45F;
			this.kryBt_Function.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
			this.kryBt_Function.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
			this.kryBt_Function.StateCommon.Border.ColorAngle = 45F;
			this.kryBt_Function.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryBt_Function.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryBt_Function.StateCommon.Border.Rounding = 20;
			this.kryBt_Function.StateCommon.Border.Width = 1;
			this.kryBt_Function.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.kryBt_Function.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.kryBt_Function.StateTracking.Back.Color1 = System.Drawing.Color.White;
			this.kryBt_Function.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
			this.kryBt_Function.TabIndex = 26;
			this.kryBt_Function.Values.Text = "+";
			this.kryBt_Function.Click += new System.EventHandler(this.kryBt_Function_Click);
			// 
			// kryptonPanel1
			// 
			this.kryptonPanel1.Controls.Add(this.kryTb_Seach);
			this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
			this.kryptonPanel1.Name = "kryptonPanel1";
			this.kryptonPanel1.Size = new System.Drawing.Size(1130, 56);
			this.kryptonPanel1.TabIndex = 27;
			// 
			// kryTb_Seach
			// 
			this.kryTb_Seach.Location = new System.Drawing.Point(447, 9);
			this.kryTb_Seach.Name = "kryTb_Seach";
			this.kryTb_Seach.Size = new System.Drawing.Size(236, 39);
			this.kryTb_Seach.StateCommon.Back.Color1 = System.Drawing.Color.White;
			this.kryTb_Seach.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.kryTb_Seach.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.kryTb_Seach.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.kryTb_Seach.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.kryTb_Seach.StateCommon.Border.Rounding = 20;
			this.kryTb_Seach.StateCommon.Border.Width = 1;
			this.kryTb_Seach.TabIndex = 9;
			// 
			// NHANVIEN_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(1130, 588);
			this.Controls.Add(this.kryptonPanel1);
			this.Controls.Add(this.kryBt_Function);
			this.Controls.Add(this.kryDataView_NhanVien);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "NHANVIEN_GUI";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.kryDataView_NhanVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
			this.kryptonPanel1.ResumeLayout(false);
			this.kryptonPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryDataView_NhanVien;
		private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Function;
		private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
		private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Seach;
	}
}

