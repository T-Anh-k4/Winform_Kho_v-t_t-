using ComponentFactory.Krypton.Toolkit;

namespace GUI
{
    partial class NHACUNGCAP_GUI : KryptonForm
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

    

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txb_MaNCC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_TenNCC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_DiaChi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.txb_TimKiem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
			this.kbtn_ThemSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kbtn_Sua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.kbtn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.k_datagrview_nhacungcap = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
			this.cbx_LoaiNCC = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
			this.pn_nhap = new System.Windows.Forms.Panel();
			this.pn_data = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_nhacungcap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cbx_LoaiNCC)).BeginInit();
			this.pn_nhap.SuspendLayout();
			this.pn_data.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(341, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "2dawng";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txb_MaNCC
			// 
			this.txb_MaNCC.Location = new System.Drawing.Point(20, 20);
			this.txb_MaNCC.Name = "txb_MaNCC";
			this.txb_MaNCC.Size = new System.Drawing.Size(200, 23);
			this.txb_MaNCC.TabIndex = 1;
			// 
			// txb_TenNCC
			// 
			this.txb_TenNCC.Location = new System.Drawing.Point(20, 60);
			this.txb_TenNCC.Name = "txb_TenNCC";
			this.txb_TenNCC.Size = new System.Drawing.Size(200, 23);
			this.txb_TenNCC.TabIndex = 2;
			// 
			// txb_DiaChi
			// 
			this.txb_DiaChi.Location = new System.Drawing.Point(20, 100);
			this.txb_DiaChi.Name = "txb_DiaChi";
			this.txb_DiaChi.Size = new System.Drawing.Size(200, 23);
			this.txb_DiaChi.TabIndex = 3;
			// 
			// txb_TimKiem
			// 
			this.txb_TimKiem.Location = new System.Drawing.Point(20, 140);
			this.txb_TimKiem.Name = "txb_TimKiem";
			this.txb_TimKiem.Size = new System.Drawing.Size(200, 23);
			this.txb_TimKiem.TabIndex = 4;
			this.txb_TimKiem.TextChanged += new System.EventHandler(this.txb_TimKiem_TextChanged);
			// 
			// kbtn_ThemSua
			// 
			this.kbtn_ThemSua.Location = new System.Drawing.Point(20, 180);
			this.kbtn_ThemSua.Name = "kbtn_ThemSua";
			this.kbtn_ThemSua.Size = new System.Drawing.Size(90, 25);
			this.kbtn_ThemSua.TabIndex = 5;
			this.kbtn_ThemSua.Values.Text = "Thêm/Sửa";
			this.kbtn_ThemSua.Click += new System.EventHandler(this.kbtn_ThemSua_Click);
			// 
			// kbtn_Sua
			// 
			this.kbtn_Sua.Location = new System.Drawing.Point(130, 180);
			this.kbtn_Sua.Name = "kbtn_Sua";
			this.kbtn_Sua.Size = new System.Drawing.Size(90, 25);
			this.kbtn_Sua.TabIndex = 6;
			this.kbtn_Sua.Values.Text = "Sửa";
			this.kbtn_Sua.Click += new System.EventHandler(this.kbtn_Sua_Click);
			// 
			// kbtn_Cancel
			// 
			this.kbtn_Cancel.Location = new System.Drawing.Point(240, 180);
			this.kbtn_Cancel.Name = "kbtn_Cancel";
			this.kbtn_Cancel.Size = new System.Drawing.Size(90, 25);
			this.kbtn_Cancel.TabIndex = 7;
			this.kbtn_Cancel.Values.Text = "Hủy";
			this.kbtn_Cancel.Click += new System.EventHandler(this.kbtn_Cancel_Click);
			// 
			// k_datagrview_nhacungcap
			// 
			this.k_datagrview_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.k_datagrview_nhacungcap.Location = new System.Drawing.Point(20, 20);
			this.k_datagrview_nhacungcap.Name = "k_datagrview_nhacungcap";
			this.k_datagrview_nhacungcap.Size = new System.Drawing.Size(760, 400);
			this.k_datagrview_nhacungcap.TabIndex = 8;
			this.k_datagrview_nhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrview_nhacungcap_CellClick);
			this.k_datagrview_nhacungcap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.k_datagrview_nhacungcap_CellContentClick);
			// 
			// cbx_LoaiNCC
			// 
			this.cbx_LoaiNCC.DropDownWidth = 200;
			this.cbx_LoaiNCC.Location = new System.Drawing.Point(240, 20);
			this.cbx_LoaiNCC.Name = "cbx_LoaiNCC";
			this.cbx_LoaiNCC.Size = new System.Drawing.Size(200, 21);
			this.cbx_LoaiNCC.TabIndex = 9;
			this.cbx_LoaiNCC.DropDown += new System.EventHandler(this.cbx_LoaiNCC_DropDown);
			// 
			// pn_nhap
			// 
			this.pn_nhap.Controls.Add(this.txb_MaNCC);
			this.pn_nhap.Controls.Add(this.cbx_LoaiNCC);
			this.pn_nhap.Controls.Add(this.txb_TenNCC);
			this.pn_nhap.Controls.Add(this.kbtn_Cancel);
			this.pn_nhap.Controls.Add(this.txb_DiaChi);
			this.pn_nhap.Controls.Add(this.kbtn_Sua);
			this.pn_nhap.Controls.Add(this.txb_TimKiem);
			this.pn_nhap.Controls.Add(this.kbtn_ThemSua);
			this.pn_nhap.Location = new System.Drawing.Point(12, 12);
			this.pn_nhap.Name = "pn_nhap";
			this.pn_nhap.Size = new System.Drawing.Size(760, 220);
			this.pn_nhap.TabIndex = 10;
			// 
			// pn_data
			// 
			this.pn_data.Controls.Add(this.k_datagrview_nhacungcap);
			this.pn_data.Location = new System.Drawing.Point(12, 238);
			this.pn_data.Name = "pn_data";
			this.pn_data.Size = new System.Drawing.Size(800, 450);
			this.pn_data.TabIndex = 11;
			// 
			// NHACUNGCAP_GUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 700);
			this.Controls.Add(this.pn_data);
			this.Controls.Add(this.pn_nhap);
			this.Controls.Add(this.label1);
			this.Name = "NHACUNGCAP_GUI";
			this.Text = "NHACUNGCAP_GUI";
			this.Load += new System.EventHandler(this.NHACUNGCAP_GUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.k_datagrview_nhacungcap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cbx_LoaiNCC)).EndInit();
			this.pn_nhap.ResumeLayout(false);
			this.pn_nhap.PerformLayout();
			this.pn_data.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_MaNCC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_TenNCC;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_DiaChi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_TimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_ThemSua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Sua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kbtn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_nhacungcap;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbx_LoaiNCC;
        private System.Windows.Forms.Panel pn_nhap;
        private System.Windows.Forms.Panel pn_data;
    }
}