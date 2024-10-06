namespace wfHome
{
	partial class HangHoaGui
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangHoaGui));
			this.panel1 = new System.Windows.Forms.Panel();
			this.k_datagrview_hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.b_btn_form_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.k_datagrview_hang_hoa);
			this.panel1.Controls.Add(this.b_btn_form_them);
			this.panel1.Location = new System.Drawing.Point(246, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1072, 757);
			this.panel1.TabIndex = 2;
			// 
			// k_datagrview_hang_hoa
			// 
			this.k_datagrview_hang_hoa.AllowUserToResizeColumns = false;
			this.k_datagrview_hang_hoa.AllowUserToResizeRows = false;
			this.k_datagrview_hang_hoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.k_datagrview_hang_hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.k_datagrview_hang_hoa.Location = new System.Drawing.Point(18, 57);
			this.k_datagrview_hang_hoa.Name = "k_datagrview_hang_hoa";
			this.k_datagrview_hang_hoa.Size = new System.Drawing.Size(1038, 687);
			this.k_datagrview_hang_hoa.TabIndex = 2;
			// 
			// b_btn_form_them
			// 
			this.b_btn_form_them.Location = new System.Drawing.Point(984, 5);
			this.b_btn_form_them.Name = "b_btn_form_them";
			this.b_btn_form_them.Size = new System.Drawing.Size(46, 46);
			this.b_btn_form_them.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("b_btn_form_them.StateCommon.Back.Image")));
			this.b_btn_form_them.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
			this.b_btn_form_them.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.b_btn_form_them.StateCommon.Border.Rounding = 50;
			this.b_btn_form_them.StateCommon.Border.Width = 1;
			this.b_btn_form_them.TabIndex = 1;
			this.b_btn_form_them.Values.Text = "";
			this.b_btn_form_them.Click += new System.EventHandler(this.b_btn_form_them_Click);
			// 
			// HangHoaGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.ClientSize = new System.Drawing.Size(1333, 861);
			this.Controls.Add(this.panel1);
			this.Name = "HangHoaGui";
			this.Text = "HangHoaGui";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ComponentFactory.Krypton.Toolkit.KryptonButton b_btn_form_them;
		private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_hang_hoa;
	}
}