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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtgrview_hang_hoa = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrview_hang_hoa)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.dtgrview_hang_hoa);
			this.panel1.Location = new System.Drawing.Point(246, 89);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1072, 757);
			this.panel1.TabIndex = 2;
			// 
			// dtgrview_hang_hoa
			// 
			this.dtgrview_hang_hoa.AllowUserToResizeColumns = false;
			this.dtgrview_hang_hoa.AllowUserToResizeRows = false;
			this.dtgrview_hang_hoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgrview_hang_hoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
			this.dtgrview_hang_hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrview_hang_hoa.Location = new System.Drawing.Point(18, 55);
			this.dtgrview_hang_hoa.Name = "dtgrview_hang_hoa";
			this.dtgrview_hang_hoa.Size = new System.Drawing.Size(1038, 687);
			this.dtgrview_hang_hoa.TabIndex = 0;
			this.dtgrview_hang_hoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrview_hang_hoa_CellClick);
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
			((System.ComponentModel.ISupportInitialize)(this.dtgrview_hang_hoa)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dtgrview_hang_hoa;
	}
}