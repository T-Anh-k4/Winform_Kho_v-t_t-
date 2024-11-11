﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Input;
namespace GUI
{
    public partial class HOADONXUAT_GUI : KryptonForm
    {
        NHANVIEN_BUS nhanVienBUS = new NHANVIEN_BUS();
        bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1;//so trang can tao


        public HOADONXUAT_GUI()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            initUser();
            panel2_nv.Height = 0;
            soluong.Text = "Nhân viên (" + Convert.ToString(nhanVienBUS.GetSLSinhVien()) + ")";
            dataViewHDX.CellFormatting += dataViewHDX_CellFormatting;

        }
        public void initUser()
        {
            loadDt_NhanVien();
            kryTbSearch.Enter += kryTbSearch_Enter;
            kryTbSearch.Leave += kryTbSearch_Leave;
            kryTx_Id.Enter += kryTbSearch_Enter;
            kryTx_Id.Leave += kryTbSearch_Leave;
            kryTb_Name.Enter += kryTbSearch_Enter;
            kryTb_Name.Leave += kryTbSearch_Leave;
            kryTb_Number.Enter += kryTbSearch_Enter;
            kryTb_Number.Leave += kryTbSearch_Leave;
            kryTx_Address.Enter += kryTbSearch_Enter;
            kryTx_Address.Leave += kryTbSearch_Leave;
            SetPlaceholder(kryTbSearch, "Tìm kiếm");
            SetPlaceholder(kryTx_Id, "Nhập mã nhân viên");
            SetPlaceholder(kryTb_Name, "Nhập tên nhân viên");
            SetPlaceholder(kryTb_Number, "Nhập số điện thoại");
            SetPlaceholder(kryTx_Address, "Nhập địa chỉ");

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
            dt = nhanVienBUS.GetDanhSachNhanVienPage(limit, curentPage);
            //3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
            dataViewHDX.DataSource = dt;
            totalPage = nhanVienBUS.GetSLSinhVien() / limit;
            if (totalPage * limit < nhanVienBUS.GetSLSinhVien()) totalPage++;
            EnsureButtonColumnsVisible();
        }
 
        //Xóa các ô khi thoát chỉnh sửa
        public void clear()
        {
            kryTx_Id.Text = "";
            kryTb_Name.Text = "";
            kryTx_Address.Text = "";
            kryTb_Number.Text = "";
        }

        // Thêm cột chứa nút vào DataGridView
        private void DelButtonColumn()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewHDX.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewHDX.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewHDX.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewHDX.Columns["imgDelete"].DisplayIndex = dataViewHDX.Columns.Count - 1;

        }
        private void AddButtonColumn_Edit()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewHDX.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Edit";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewHDX.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewHDX.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewHDX.Columns["imgEdit"].DisplayIndex = dataViewHDX.Columns.Count - 2;

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
        private void dataViewHDX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewHDX.Rows[e.RowIndex];
                if (e.ColumnIndex == dataViewHDX.Columns["imgEdit"].Index)
                {
                    kryTx_Id.ReadOnly = true;
                    kryTx_Id.Text = row.Cells[2].Value.ToString();
                    kryTb_Name.Text = row.Cells[3].Value.ToString();
                    kry_Datetime.Value = Convert.ToDateTime(row.Cells[5].Value); // Đảm bảo kiểu dữ liệu là DateTime
                    kryTx_Address.Text = row.Cells[6].Value.ToString();
                    kryTb_Number.Text = row.Cells[7].Value.ToString();
                    if (Convert.ToInt32(row.Cells[9].Value) == 1)
                    {
                        kryCheckBox_Status.Checked = true;  // Đánh dấu checkbox
                    }
                    else
                    {
                        kryCheckBox_Status.Checked = false; // Bỏ đánh dấu checkbox
                    }
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
                if (e.ColumnIndex == dataViewHDX.Columns["imgDelete"].Index)
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn xóa nhân viên nay không ?" + "Tài khoản đăng nhập của nhân viên này sẽ bị xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (check == DialogResult.Yes)
                    {
                        bool result = nhanVienBUS.DeleteNhanVien(row.Cells[2].Value.ToString());
                        if (result)
                        {
                            loadDt_NhanVien();
                            MessageBox.Show("Xóa thông tin nhân viên thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin nhân viên không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    clear();
                    soluong.Text = "Nhân viên (" + Convert.ToString(nhanVienBUS.GetSLSinhVien()) + ")";
                }
            }
        }

        //Sự kiện click
        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(kryTx_Id.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(kryTb_Number.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //bool result = nhanVienBUS.InsertNhanVien(kryTx_Id.Text, kryTb_Name.Text, kryCb_Gender.SelectedValue.ToString(), kry_Datetime.Value.ToString("yyyy-MM-dd"), kryTx_Address.Text, kryTb_Number.Text, kryTb_Pos.Text, kryCheckBox_Status.Checked ? 1 : 0, txtTenNguoiDung.Text);

            //if (result)
            //{
            //    loadDt_NhanVien(); // Gọi lại để tải lại danh sách

            //    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    MessageBox.Show("Thêm nhân viên không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //soluong.Text = "Nhân viên (" + Convert.ToString(nhanVienBUS.GetSLSinhVien()) + ")";

        }

        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            //if (nhanVienBUS.CheckUserName(txtTenNguoiDung.Text))
            //{
            //    MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên người dùng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return; // Ngăn không cho tiếp tục thực hiện cập nhật
            //}
            //bool result = nhanVienBUS.UpdateNhanVien(kryTx_Id.Text, kryTb_Name.Text, kryCb_Gender.SelectedValue.ToString(), kry_Datetime.Value.ToString("yyyy-MM-dd"), kryTx_Address.Text, kryTb_Number.Text, kryTb_Pos.Text, kryCheckBox_Status.Checked ? 1 : 0, txtTenNguoiDung.Text);

            //if (result)
            //{
            //    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    loadDt_NhanVien(); // Gọi lại để tải lại danh sách
            //}
            //else
            //{
            //    MessageBox.Show("Sửa nhân viên không thành công! Kiểm tra lại tên người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                case "kryTx_Id":
                    return "Nhập mã nhân viên";
                case "kryTb_Name":
                    return "Nhập tên nhân viên";
                case "kryTb_Number":
                    return "Nhập số điện thoại";
                case "kryTx_Address":
                    return "Nhập địa chỉ";
                case "kryTb_Pos":
                    return "Nhập chức vụ";
                case "txtTenNguoiDung":
                    return "Nhập tên tài khoản";
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
            SetPlaceholder(kryTx_Id, GetPlaceholder(kryTx_Id));
            SetPlaceholder(kryTb_Name, GetPlaceholder(kryTb_Name));
            SetPlaceholder(kryTb_Number, GetPlaceholder(kryTb_Number));
            SetPlaceholder(kryTx_Address, GetPlaceholder(kryTx_Address));


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

        private void kryCheckBox_Status_CheckedChanged(object sender, EventArgs e)
        {
            if (kryCheckBox_Status.Checked == true)
            {
                kryCheckBox_Status.Text = "Đang hoạt động";
            }
            else
            {
                kryCheckBox_Status.Text = "Không hoạt động";

            }
        }

        private void kryBtShowCreate_NV_Click(object sender, EventArgs e)
        {
            kryBt_Add.Visible = true;
            kryTx_Id.ReadOnly = false;
            createTransition.Start();
            if (kryBt_Edit.Visible)
            {
                kryBt_Edit.Visible = false;
            }
            if (panel2_nv.Height >= 180)
            {
                createTransition.Stop();

            }
        }
        // tìm kiếm nhân viên
        private void txb_tim_kiem_LH_TextChanged(object sender, EventArgs e)
        {
            string keyword = txb_tim_kiem_nv.Text.Trim();
            DataTable result = nhanVienBUS.SearchNV(keyword);
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
                dataViewHDX.DataSource = result;
                EnsureButtonColumnsVisible();
            }

        }
        private void EnsureButtonColumnsVisible()
        {
            // Kiểm tra và thêm cột nếu cần
            DelButtonColumn();
            AddButtonColumn_Edit();

            // Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
            dataViewHDX.Columns["imgEdit"].DisplayIndex = dataViewHDX.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
            dataViewHDX.Columns["imgDelete"].DisplayIndex = dataViewHDX.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

            // Đặt lại DisplayIndex cho các cột còn lại nếu cần
            int index = 0;
            foreach (DataGridViewColumn column in dataViewHDX.Columns)
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
        private void dataViewHDX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra cột USERNAME (giả sử cột này là cột thứ 8 trong DataGridView)
            if (dataViewHDX.Columns[e.ColumnIndex].Name == "") // Thay đổi tên cột nếu cần
            {
                // Kiểm tra xem giá trị có phải là DBNull hay không
                if (e.Value == DBNull.Value)
                {
                    e.Value = "null"; // Đặt giá trị hiển thị là "null"
                    e.FormattingApplied = true; // Đánh dấu là đã áp dụng định dạng
                }
            }
        }
    }
}

