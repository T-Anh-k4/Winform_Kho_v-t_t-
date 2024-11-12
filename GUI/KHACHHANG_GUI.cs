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
	public partial class KHACHHANG_GUI : KryptonForm
    {
		public KHACHHANG_GUI()
		{
			InitializeComponent();
            init();
		}


        KHACHHANG_BUS nhanVienBUS = new KHACHHANG_BUS();
        bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1;//so trang can tao
        public void init()
        {
            initUser();
            panel2_nv.Height = 0;
            soluong.Text = "Khách hàng (" + Convert.ToString(nhanVienBUS.GetSoLuongKhachHang()) + ")";
        }
        public void initUser()
        {
            loadDt_NhanVien();
            txb_DIACHI.Enter += kryTbSearch_Enter;
            txb_DIACHI.Leave += kryTbSearch_Leave;
            txb_MAKH.Enter += kryTbSearch_Enter;
            txb_MAKH.Leave += kryTbSearch_Leave;
            txb_SDT.Enter += kryTbSearch_Enter;
            txb_SDT.Leave += kryTbSearch_Leave;
            txb_TEN.Enter += kryTbSearch_Enter;
            txb_TEN.Leave += kryTbSearch_Leave;
            SetPlaceholder(txb_TEN, "Nhập tên khách hàng");
            SetPlaceholder(txb_SDT, "Nhập số điện thoại");
            SetPlaceholder(txb_MAKH, "Nhập mã khách hàng");
            SetPlaceholder(txb_DIACHI, "Nhập địa chỉ");
        }
        public bool IsPressAdd()
        {
            kryBt_Add.Visible = true;
            return kryBt_Add.Visible;
        }
        public bool IsPressEdit()
        {
            kryBt_Edit.Visible = true;
            return kryBt_Edit.Visible;
        }
        //load data và combobox
        public void loadDt_NhanVien()
        {
            DataTable dt = new DataTable();
            dt = nhanVienBUS.GetDanhSachKhachHangPage(limit, curentPage);
            //3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
            dataViewKH.DataSource = dt;
            totalPage = nhanVienBUS.GetSoLuongKhachHang() / limit;
            if (totalPage * limit < nhanVienBUS.GetSoLuongKhachHang()) totalPage++;
            EnsureButtonColumnsVisible();
        }
        //Xóa các ô khi thoát chỉnh sửa
        public void clear()
        {
            txb_DIACHI.Text = "";
            txb_MAKH.Text = "";
            txb_SDT.Text = "";
            txb_TEN.Text = "";
               }

        // Thêm cột chứa nút vào DataGridView
        private void DelButtonColumn()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewKH.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewKH.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewKH.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewKH.Columns["imgDelete"].DisplayIndex = dataViewKH.Columns.Count - 1;

        }
        private void AddButtonColumn_Edit()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewKH.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Chỉnh sửa";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewKH.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewKH.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewKH.Columns["imgEdit"].DisplayIndex = dataViewKH.Columns.Count - 2;

        }
        //end

        //Chỉnh phần trượt giao diện tạo
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
                if (panel2_nv.Height >= 180)
                {
                    createTransition.Stop();
                    createExplore = true;
                }
            }

        }
        //Sự kiên database
        private void dataViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewKH.Rows[e.RowIndex];
                if (e.ColumnIndex == dataViewKH.Columns["imgEdit"].Index)
                {
                    txb_MAKH.ReadOnly = true;
                    txb_MAKH.Text = row.Cells[2].Value.ToString();
                    txb_TEN.Text = row.Cells[3].Value.ToString();
                    txb_SDT.Text = row.Cells[4].Value.ToString();
                    txb_DIACHI.Text = row.Cells[5].Value.ToString();
                    IsPressEdit();
                    createTransition.Start();
                    if (panel2_nv.Height >= 180)
                    {
                        createTransition.Stop();
                    }
                    if (kryBt_Add.Visible)
                    {
                        kryBt_Add.Visible = false;
                    }

                }
                if (e.ColumnIndex == dataViewKH.Columns["imgDelete"].Index)
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn xóa khách hàng nay không ?" ,"Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (check == DialogResult.Yes)
                    {
                        bool result = nhanVienBUS.DeleteKhachHang(row.Cells[2].Value.ToString());
                        if (result)
                        {
                            loadDt_NhanVien();
                            MessageBox.Show("Xóa thông tin nhân viên thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin Khách hàng không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    clear();
                    soluong.Text = "Khách hàng (" + Convert.ToString(nhanVienBUS.GetSoLuongKhachHang()) + ")";
                }
            }
        }

        //Sự kiện click
        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txb_MAKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã Khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra định dạng mã Khách hàng (phải bắt đầu bằng NV và theo sau là số nguyên)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txb_MAKH.Text, @"^KH\d+$"))
            {
                MessageBox.Show("Mã Khách hàng không hợp lệ. Vui lòng nhập mã theo định dạng KH+Số nguyên.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txb_TEN.Text))
            {
                MessageBox.Show("Vui lòng nhập tên Khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra tên không chứa số
            if (System.Text.RegularExpressions.Regex.IsMatch(txb_TEN.Text, @"\d"))
            {
                MessageBox.Show("Tên Khách hàng không hợp lệ. Vui lòng không nhập số trong tên.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txb_DIACHI.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txb_SDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra số điện thoại: không được chứa chữ và không quá 10 ký tự
            if (!System.Text.RegularExpressions.Regex.IsMatch(txb_SDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = nhanVienBUS.InsertKhachHang(txb_MAKH.Text, txb_TEN.Text, txb_DIACHI.Text,txb_SDT.Text);

            if (result)
            {
                loadDt_NhanVien(); // Gọi lại để tải lại danh sách

                MessageBox.Show("Thêm Khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm Khách hàng không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            soluong.Text = "Khách hàng (" + Convert.ToString(nhanVienBUS.GetSoLuongKhachHang()) + ")";

        }

        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            bool result = nhanVienBUS.UpdateKhachHang(txb_MAKH.Text, txb_TEN.Text, txb_DIACHI.Text, txb_SDT.Text);

            if (result)
            {
                MessageBox.Show("Sửa Khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDt_NhanVien(); // Gọi lại để tải lại danh sách
            }
            else
            {
                MessageBox.Show("Sửa Khách hàng không thành công! Kiểm tra lại tên người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kry_Clear_Click(object sender, EventArgs e)
        {
            ResetForeText();

            createTransition.Start();

        }

        //End
        //Làm mất chữ khi di chuột vào ô
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
                case "txb_MAKH":
                    return "Nhập mã khách hàng";
                case "txb_TEN":
                    return "Nhập tên khách hàng";
                case "txb_SDT":
                    return "Nhập số điện thoại";
                case "txb_DIACHI":
                    return "Nhập địa chỉ";
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
        // reset chữ mặc định
        private void ResetForeText()
        {
            SetPlaceholder(txb_MAKH, GetPlaceholder(txb_MAKH));
            SetPlaceholder(txb_TEN, GetPlaceholder(txb_TEN));
            SetPlaceholder(txb_SDT, GetPlaceholder(txb_SDT));
            SetPlaceholder(txb_DIACHI, GetPlaceholder(txb_DIACHI));
 

        }
        //end
        private void kryBtPredious_Click(object sender, EventArgs e)
        {
            curentPage--;
            loadDt_NhanVien();
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
            loadDt_NhanVien();
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
            txb_MAKH.ReadOnly = false;
            createTransition.Start();
            if (kryBt_Edit.Visible)
            {
                kryBt_Edit.Visible = false;
            }
            if (panel2_nv.Height >= 180)
            {
                createTransition.Stop();

            }
            ResetForeText();
        }
        // tìm kiếm Khách hàng
        private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txb_tim_kiem_nv.Text.Trim();
            DataTable result = nhanVienBUS.SearchKhachHang(keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                loadDt_NhanVien();
                return;
            }

            else if (keyword == "Tìm kiếm")
            {
                return;
            }
            else
            {
                dataViewKH.DataSource = result;
                EnsureButtonColumnsVisible();
            }

        }
        private void EnsureButtonColumnsVisible()
        {
            // Kiểm tra và thêm cột nếu cần
            DelButtonColumn();
            AddButtonColumn_Edit();

            // Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
            dataViewKH.Columns["imgEdit"].DisplayIndex = dataViewKH.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
            dataViewKH.Columns["imgDelete"].DisplayIndex = dataViewKH.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

            // Đặt lại DisplayIndex cho các cột còn lại nếu cần
            int index = 0;
            foreach (DataGridViewColumn column in dataViewKH.Columns)
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
      
    }
}

