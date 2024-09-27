namespace QLVLXD
{
	partial class Edit
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_Cancel_edit = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.txb_TenHang_edit = new System.Windows.Forms.TextBox();
			this.cbx_DVT_edit = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txb_XuatXu_edit = new System.Windows.Forms.TextBox();
			this.txb_MaLH_edit = new System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_Cancel_edit);
			this.panel2.Controls.Add(this.btn_edit);
			this.panel2.Location = new System.Drawing.Point(3, 299);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(621, 97);
			this.panel2.TabIndex = 3;
			// 
			// btn_Cancel_edit
			// 
			this.btn_Cancel_edit.Location = new System.Drawing.Point(464, 29);
			this.btn_Cancel_edit.Name = "btn_Cancel_edit";
			this.btn_Cancel_edit.Size = new System.Drawing.Size(117, 43);
			this.btn_Cancel_edit.TabIndex = 1;
			this.btn_Cancel_edit.Text = "Cancel";
			this.btn_Cancel_edit.UseVisualStyleBackColor = true;
			this.btn_Cancel_edit.Click += new System.EventHandler(this.btn_Cancel_edit_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(293, 29);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(117, 43);
			this.btn_edit.TabIndex = 0;
			this.btn_edit.Text = "Edit";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txb_TenHang_edit);
			this.panel1.Controls.Add(this.cbx_DVT_edit);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txb_XuatXu_edit);
			this.panel1.Controls.Add(this.txb_MaLH_edit);
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(621, 291);
			this.panel1.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Tên Hàng";
			// 
			// txb_TenHang_edit
			// 
			this.txb_TenHang_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_TenHang_edit.Location = new System.Drawing.Point(114, 111);
			this.txb_TenHang_edit.Multiline = true;
			this.txb_TenHang_edit.Name = "txb_TenHang_edit";
			this.txb_TenHang_edit.Size = new System.Drawing.Size(317, 40);
			this.txb_TenHang_edit.TabIndex = 9;
			// 
			// cbx_DVT_edit
			// 
			this.cbx_DVT_edit.FormattingEnabled = true;
			this.cbx_DVT_edit.Location = new System.Drawing.Point(114, 197);
			this.cbx_DVT_edit.Name = "cbx_DVT_edit";
			this.cbx_DVT_edit.Size = new System.Drawing.Size(275, 24);
			this.cbx_DVT_edit.TabIndex = 8;
			this.cbx_DVT_edit.DropDown += new System.EventHandler(this.cbx_DVT_edit_DropDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(317, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Mã Loại Hàng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Đơn Vị Tính";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Xuất Xứ";
			// 
			// txb_XuatXu_edit
			// 
			this.txb_XuatXu_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_XuatXu_edit.Location = new System.Drawing.Point(114, 33);
			this.txb_XuatXu_edit.Multiline = true;
			this.txb_XuatXu_edit.Name = "txb_XuatXu_edit";
			this.txb_XuatXu_edit.Size = new System.Drawing.Size(167, 40);
			this.txb_XuatXu_edit.TabIndex = 3;
			// 
			// txb_MaLH_edit
			// 
			this.txb_MaLH_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_MaLH_edit.Location = new System.Drawing.Point(429, 33);
			this.txb_MaLH_edit.Multiline = true;
			this.txb_MaLH_edit.Name = "txb_MaLH_edit";
			this.txb_MaLH_edit.Size = new System.Drawing.Size(168, 40);
			this.txb_MaLH_edit.TabIndex = 2;
			// 
			// Edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 400);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Edit";
			this.Text = "Edit";
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_Cancel_edit;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txb_TenHang_edit;
		private System.Windows.Forms.ComboBox cbx_DVT_edit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txb_XuatXu_edit;
		private System.Windows.Forms.TextBox txb_MaLH_edit;
	}
}