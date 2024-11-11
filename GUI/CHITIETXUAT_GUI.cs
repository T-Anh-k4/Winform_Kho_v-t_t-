using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CHITIETXUAT_GUI : KryptonForm
    {
        private string maHDN;
        CHITIETXUAT_BUS chiTietNhapBUS = new CHITIETXUAT_BUS();
        TEST_GUI testGui = new TEST_GUI();
        bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1; //so trang can tao

        public CHITIETXUAT_GUI(string _maHDN, TEST_GUI testGui)
        {
            InitializeComponent();
            maHDN = _maHDN;
            this.testGui = testGui;
            init();
        }

        public void init()
        {
            initUser();
            panel2_nv.Height = 0;
            dataViewNv.CellFormatting += dataViewNv_CellFormatting;
        }

        public void initUser()
        {
            loadDt_ChiTietNhap();

            // Create a list of key-value pairs for gender options


            txb_tim_kiem_nv.Enter += kryTbSearch_Enter;
            txb_tim_kiem_nv.Leave += kryTbSearch_Leave;
            kryTb_SLNhap.Enter += kryTbSearch_Enter;
            kryTb_SLNhap.Leave += kryTbSearch_Leave;
            kryTb_DGNhap.Enter += kryTbSearch_Enter;
            kryTb_DGNhap.Leave += kryTbSearch_Leave;
            SetPlaceholder(txb_tim_kiem_nv, "Tìm kiếm");
            SetPlaceholder(kryTb_SLNhap, "Nhập số lượng Xuất");
            SetPlaceholder(kryTb_DGNhap, "Nhập đơn giá Xuất");
        }

        public bool IsPressAdd()
        {
            clear();
            kryBt_Add.Visible = true;
            kryTb_DGNhap.Enabled = true;
            return kryBt_Add.Visible;
        }

        public bool IsPressEdit()
        {
            kryBt_Edit.Visible = true;
            kryTb_DGNhap.Enabled = false;

            return kryBt_Edit.Visible;
        }

        public void loadDt_ChiTietNhap()
        {
            DataTable dt = new DataTable();
            dt = chiTietNhapBUS.GetDanhSachChiTietXuatPage(maHDN, limit, curentPage);
            dataViewNv.DataSource = dt;
            totalPage = chiTietNhapBUS.GetSLChiTietXuat(maHDN) / limit;
            if (totalPage * limit < chiTietNhapBUS.GetSLChiTietXuat(maHDN)) totalPage++;
            EnsureButtonColumnsVisible();
        }

        public void clear()
        {
            kryTb_DGNhap.Text = "";
            kryTb_SLNhap.Text = "";
        }

        private void DelButtonColumn()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewNv.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewNv.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewNv.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1;
        }

        private void AddButtonColumn_Edit()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewNv.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Edit";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewNv.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
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
                    kryCb_HangHoa.SelectedItem = row.Cells[2].Value.ToString();
                    kryTb_SLNhap.Text = row.Cells[3].Value.ToString();
                    kryTb_DGNhap.Text = row.Cells[4].Value.ToString();
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
                    DialogResult check = MessageBox.Show("Bạn có muốn xóa chi tiết Xuất này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            bool result = chiTietNhapBUS.DeleteChiTietXuat(row.Cells[2].Value.ToString(), maHDN, Convert.ToInt32(row.Cells[4].Value));
                            if (result)
                            {
                                loadDt_ChiTietNhap();
                                MessageBox.Show("Xóa chi tiết Xuất thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                MessageBox.Show("Xóa chi tiết Xuất không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Xóa chi tiết Xuất không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    clear();
                    createTransition_Tick(sender, e);
                    //soluong.Text = "Chi tiết nhập (" + Convert.ToString(chiTietNhapBUS.GetSLChiTietNhap(maHDN)) + ")";
                }
            }
        }

        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra trường số lượng
            if (string.IsNullOrWhiteSpace(kryTb_SLNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng Xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trường đơn giá
            if (string.IsNullOrWhiteSpace(kryTb_DGNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá Xuất.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra giá trị số lượng và đơn giá hợp lệ
                int soLuong;decimal donGia;
                bool isValidSL = int.TryParse(kryTb_SLNhap.Text, out soLuong);
                bool isValidDG = decimal.TryParse(kryTb_DGNhap.Text, out donGia);

                if (!isValidSL || !isValidDG || soLuong <= 0 || donGia <= 0)
                {
                    MessageBox.Show("Số lượng hoặc đơn giá không hợp lệ! Số lượng và đơn giá phải là số dương.");
                    return;
                }

                // Lấy mã hàng hóa từ ComboBox (đảm bảo đã chọn mục hợp lệ)
                if (kryCb_HangHoa.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn mã hàng hóa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maHangHoa = kryCb_HangHoa.SelectedItem.ToString();

                // Kiểm tra mã hóa đơn
                if (string.IsNullOrWhiteSpace(maHDN))
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi phương thức InsertChiTietXuat để thêm chi tiết xuất
                bool result = chiTietNhapBUS.InsertChiTietXuat(maHangHoa, maHDN, soLuong, donGia);

                if (result)
                {
                    loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
                    MessageBox.Show("Thêm chi tiết Xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear(); // Xóa dữ liệu input sau khi thêm thành công
                }
                else
                {
                    MessageBox.Show("Thêm chi tiết Xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // In ra lỗi chi tiết để tiện cho việc gỡ lỗi
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Mã hàng hóa: " + kryCb_HangHoa.SelectedItem);
                Console.WriteLine("Mã hóa đơn: " + maHDN);
                Console.WriteLine("Số lượng: " + kryTb_SLNhap.Text);
                Console.WriteLine("Đơn giá: " + kryTb_DGNhap.Text);

                MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết Xuất. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Gọi hàm xử lý sau khi nhấn nút Add
            IsPressAdd();
        }


        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã hàng hóa
                string maHH = kryCb_HangHoa.SelectedValue?.ToString();
                //if (string.IsNullOrEmpty(maHH))
                //{
                //    MessageBox.Show("Vui lòng chọn mã hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                // Kiểm tra số lượng nhập
                int soLuongXuat;
                if (!int.TryParse(kryTb_SLNhap.Text, out soLuongXuat))
                {
                    MessageBox.Show("Số lượng xuất không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra đơn giá nhập
                decimal donGiaXuat;
                if (!decimal.TryParse(kryTb_DGNhap.Text, out donGiaXuat))
                {
                    MessageBox.Show("Đơn giá xuất không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật chi tiết xuất
                bool result = chiTietNhapBUS.UpdateChiTietXuat(maHH, maHDN, soLuongXuat, donGiaXuat);

                if (result)
                {
                    MessageBox.Show("Sửa chi tiết xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    loadDt_ChiTietNhap(); // Gọi lại để tải lại danh sách
                }
                else
                {
                    MessageBox.Show("Sửa chi tiết xuất không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    return "Nhập số lượng Xuất";
                case "kryTx_Address":
                    return "Nhập đơn giá Xuất";
                case "kryTb_Pos":
                    return "Nhập số hóa đơn Xuất";
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
            loadDt_ChiTietNhap();
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
            loadDt_ChiTietNhap();
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
            DataTable result = chiTietNhapBUS.SearchChiTietXuat(maHDN, keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                loadDt_ChiTietNhap();
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
            // Kiểm tra và thêm cột nếu cần
            DelButtonColumn();
            AddButtonColumn_Edit();

            // Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
            dataViewNv.Columns["imgEdit"].DisplayIndex = dataViewNv.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
            dataViewNv.Columns["imgDelete"].DisplayIndex = dataViewNv.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

            // Đặt lại DisplayIndex cho các cột còn lại nếu cần
            int index = 0;
            foreach (DataGridViewColumn column in dataViewNv.Columns)
            {
                if (column.Name != "imgEdit" && column.Name != "imgDelete") // Bỏ qua các cột nút
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

        //nếu Username rỗng
        private void dataViewNv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột USERNAME (giả sử cột này là cột thứ 8 trong DataGridView)
            //if (dataViewNv.Columns[e.ColumnIndex].Name == "Tên tài khoản" || txtTenNguoiDung.Text == "") // Thay đổi tên cột nếu cần
            //{
            //    // Kiểm tra xem giá trị có phải là DBNull hay không
            //    if (e.Value == DBNull.Value)
            //    {
            //        e.Value = "null"; // Đặt giá trị hiển thị là "null"
            //        e.FormattingApplied = true; // Đánh dấu là đã áp dụng định dạng
            //    }
            //}

        }

        private void label5_Click(object sender, EventArgs e)
        {
            testGui.eventHangNhap();
        }

        private void kryCb_HangHoa_DropDown(object sender, EventArgs e)
        {
            kryCb_HangHoa.Items.Clear();
            DataTable dtLoaiHang = chiTietNhapBUS.getMaVaTenHH();
            foreach (DataRow row in dtLoaiHang.Rows)
            {
                kryCb_HangHoa.Items.Add(row["Mã hàng hóa"].ToString()); 
            }
        }
    }
}

