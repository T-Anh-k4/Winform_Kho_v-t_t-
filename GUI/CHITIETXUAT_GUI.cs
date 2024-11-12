using BUS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GUI
{
    public partial class CHITIETXUAT_GUI : KryptonForm
    {
        private string maHDX;
        CHITIETXUAT_BUS chiTietXuatBUS = new CHITIETXUAT_BUS();
        TEST_GUI testGui = new TEST_GUI();
        bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1; //so trang can tao

        public CHITIETXUAT_GUI(string _maHDX, TEST_GUI testGui)
        {
            InitializeComponent();
            maHDX = _maHDX;
            this.testGui = testGui;
            PopulateComboBox();
            initUser();
            panel2_nv.Height = 0;
            fillHDXLabel();
            dataViewNv.CellFormatting += dataViewNv_CellFormatting;
        }

        public void initUser()
        {
            loadDt_ChiTietXuat();

            txb_tim_kiem_nv.Enter += kryTbSearch_Enter;
            txb_tim_kiem_nv.Leave += kryTbSearch_Leave;
            kryTb_SLNhap.Enter += kryTbSearch_Enter;
            kryTb_SLNhap.Leave += kryTbSearch_Leave;
            kryTb_DGNhap.Enter += kryTbSearch_Enter;
            kryTb_DGNhap.Leave += kryTbSearch_Leave;
            SetPlaceholder(txb_tim_kiem_nv, "Tìm kiếm");
            SetPlaceholder(kryTb_SLNhap, "Nhập số lượng xuất");
            SetPlaceholder(kryTb_DGNhap, "Nhập đơn giá xuất");
        }

        public void IsPressAdd()
        {
            clear();
            kryBt_Add.Visible = true;
            kryTb_DGNhap.Enabled = true;
        }

        public void IsPressEdit()
        {
            kryBt_Edit.Visible = true;
            kryTb_DGNhap.Enabled = true;
        }

        public void loadDt_ChiTietXuat()
        {
            DataTable dt = chiTietXuatBUS.GetDanhSachChiTietXuatPage(maHDX, limit, curentPage);
            dataViewNv.DataSource = dt;
            dataViewNv.Columns["Mã chi tiết xuất"].Visible = false;
            dataViewNv.Columns["Mã hàng hóa"].Visible = false;
            totalPage = chiTietXuatBUS.GetSLChiTietXuat(maHDX) / limit;
            if (totalPage * limit < chiTietXuatBUS.GetSLChiTietXuat(maHDX)) totalPage++;
            EnsureButtonColumnsVisible();
            label11.Text = chiTietXuatBUS.getTotalCost(maHDX).ToString();
        }

        public void clear()
        {
            kryTb_DGNhap.Text = "";
            kryTb_SLNhap.Text = "";
            kryCb_HangHoa.SelectedIndex = -1;
        }

        private void DelButtonColumn()
        {
            if (!dataViewNv.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgColumn.Width = 20;
                dataViewNv.Columns.Add(imgColumn);
            }
            dataViewNv.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1;
        }

        private void AddButtonColumn_Edit()
        {
            if (!dataViewNv.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Edit";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgColumn.Width = 20;
                dataViewNv.Columns.Add(imgColumn);
            }
            dataViewNv.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewNv.Columns["imgEdit"].DisplayIndex = dataViewNv.Columns.Count - 2;
        }

        private void createTransition_Tick(object sender, EventArgs e)
        {
            if (createExplore)
            {
                panel2_nv.Height -= 10;
                if (panel2_nv.Height <= 0)
                {
                    createTransition.Stop();
                    createExplore = false;
                }
            }
            else
            {
                panel2_nv.Height += 10;
                if (panel2_nv.Height >= 125)
                {
                    createTransition.Stop();
                    createExplore = true;
                }
            }
        }

        private void dataViewNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewNv.Rows[e.RowIndex];
                if (e.ColumnIndex == dataViewNv.Columns["imgEdit"].Index)
                {
                    kryCb_HangHoa.SelectedValue = row.Cells["Mã hàng hóa"].Value.ToString();
                    kryTb_SLNhap.Text = row.Cells["Số lượng xuất"].Value.ToString();
                    kryTb_DGNhap.Text = row.Cells["Đơn giá xuất"].Value.ToString();
                    IsPressEdit();
                    createTransition.Start();
                    if (panel2_nv.Height >= 125)
                    {
                        createTransition.Stop();
                    }
                    if (kryBt_Add.Visible)
                    {
                        kryBt_Add.Visible = false;
                    }
                }
                if (e.ColumnIndex == dataViewNv.Columns["imgDelete"].Index)
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn xóa chi tiết xuất này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            bool result = chiTietXuatBUS.DeleteChiTietXuat(Convert.ToInt32(row.Cells["Mã chi tiết xuất"].Value));
                            if (result)
                            {
                                loadDt_ChiTietXuat();
                                MessageBox.Show("Xóa chi tiết xuất thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Xóa chi tiết xuất không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Xóa chi tiết xuất không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    clear();
                }
            }
        }

        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(kryTb_SLNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_DGNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool result = chiTietXuatBUS.InsertChiTietXuat(kryCb_HangHoa.SelectedValue.ToString(), maHDX, Convert.ToInt32(kryTb_SLNhap.Text), Convert.ToInt32(kryTb_DGNhap.Text));
                if (result)
                {
                    loadDt_ChiTietXuat();
                    MessageBox.Show("Thêm chi tiết xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                Console.WriteLine("Error");
                Console.WriteLine(kryCb_HangHoa.SelectedValue.ToString());
                Console.WriteLine(maHDX);
                Console.WriteLine(kryTb_SLNhap.Text);
                Console.WriteLine(kryTb_DGNhap.Text);
                MessageBox.Show("Thêm chi tiết xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            IsPressAdd();
        }

        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = chiTietXuatBUS.UpdateChiTietXuat(Convert.ToInt32(dataViewNv.CurrentRow.Cells["Mã chi tiết xuất"].Value), kryCb_HangHoa.SelectedValue.ToString(), maHDX, Convert.ToInt32(kryTb_SLNhap.Text), Convert.ToInt32(kryTb_DGNhap.Text));


                if (result)
                {
                    MessageBox.Show("Sửa chi tiết xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadDt_ChiTietXuat();
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Sửa chi tiết xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kry_Clear_Click(object sender, EventArgs e)
        {
            ResetForeText();
            createTransition.Start();
        }

        private void kryTbSearch_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null)
            {
                if (textBox.Text == GetPlaceholder(textBox))
                {
                    textBox.Text = "";
                    textBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
                }
            }
        }

        private string GetPlaceholder(KryptonTextBox textBox)
        {
            switch (textBox.Name)
            {
                case "kryTbSearch":
                    return "Tìm kiếm...";
                case "kryTb_Name":
                    return "Nhập tên hàng hóa";
                case "kryTb_Number":
                    return "Nhập số lượng xuất";
                case "kryTx_Address":
                    return "Nhập đơn giá xuất";
                case "kryTb_Pos":
                    return "Nhập số hóa đơn xuất";
                default:
                    return string.Empty;
            }
        }

        private void kryTbSearch_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox = sender as KryptonTextBox;
            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == GetPlaceholder(textBox))
                {
                    SetPlaceholder(textBox, GetPlaceholder(textBox));
                }
                else
                {
                    textBox.StateCommon.Content.Color1 = System.Drawing.Color.Black;
                }
            }
        }

        private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
        }

        private void ResetForeText()
        {
            SetPlaceholder(kryTb_SLNhap, GetPlaceholder(kryTb_SLNhap));
            SetPlaceholder(kryTb_DGNhap, GetPlaceholder(kryTb_DGNhap));
        }

        private void kryBtPrevious_Click(object sender, EventArgs e)
        {
            curentPage--;
            loadDt_ChiTietXuat();
            kryBt_Next.Enabled = true;
            if (curentPage == 1)
            {
                kryBtPre.Enabled = false;
            }
            labelSoTrang.Text = Convert.ToString(curentPage);
        }

        private void kryBtNext_Click(object sender, EventArgs e)
        {
            curentPage++;
            loadDt_ChiTietXuat();
            kryBtPre.Enabled = true;
            if (curentPage == totalPage)
            {
                kryBt_Next.Enabled = false;
            }
            labelSoTrang.Text = Convert.ToString(curentPage);
        }

        private void kryBtShowCreate_NV_Click(object sender, EventArgs e)
        {
            kryBt_Add.Visible = true;
            createTransition.Start();
            if (kryBt_Edit.Visible)
            {
                kryBt_Edit.Visible = false;
            }
            if (panel2_nv.Height >= 125)
            {
                createTransition.Stop();
            }
        }

        private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txb_tim_kiem_nv.Text.Trim();
            DataTable result = chiTietXuatBUS.SearchChiTietXuat(maHDX, keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                loadDt_ChiTietXuat();
                return;
            }
            else if (keyword == "Tìm kiếm")
            {
                return;
            }
            else
            {
                dataViewNv.DataSource = result;
                EnsureButtonColumnsVisible();
            }
        }

        private void EnsureButtonColumnsVisible()
        {
            DelButtonColumn();
            AddButtonColumn_Edit();

            dataViewNv.Columns["imgEdit"].DisplayIndex = dataViewNv.Columns.Count - 2;
            dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1;

            int index = 0;
            foreach (DataGridViewColumn column in dataViewNv.Columns)
            {
                if (column.Name != "imgEdit" && column.Name != "imgDelete")
                {
                    column.DisplayIndex = index++;
                }
            }
        }

        private void txb_tim_kiem_LH_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void dataViewNv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            testGui.eventHangXuat();
        }

        private void PopulateComboBox()
        {
            DataTable hangHoaTable = chiTietXuatBUS.getMaVaTenHH();
            List<ComboItem> comboItems = new List<ComboItem>();

            foreach (DataRow row in hangHoaTable.Rows)
            {
                comboItems.Add(new ComboItem
                {
                    ID = row["Mã hàng hóa"].ToString(),
                    Text = row["Tên hàng hóa"].ToString()
                });
            }
            kryCb_HangHoa.DataSource = comboItems;
            kryCb_HangHoa.DisplayMember = "Text";
            kryCb_HangHoa.ValueMember = "ID";
        }

        private void fillHDXLabel()
        {
            DataTable dt = chiTietXuatBUS.getHoaDonXuatDetail(maHDX);
            if (dt.Rows.Count > 0)
            {
                lbSoHDX.Text = dt.Rows[0]["Số hóa đơn xuất"].ToString();
                lbKH.Text = dt.Rows[0]["Tên khách hàng"].ToString();
                lbNhanVien.Text = dt.Rows[0]["Tên nhân viên"].ToString();
                lbNgayLap.Text = dt.Rows[0]["Ngày lập hóa đơn"].ToString();
            }
        }

        private void kryInBaoCao_Click(object sender, EventArgs e)
        {
            testGui.btInBaoCao_Click(maHDX);
        }
    }

}
