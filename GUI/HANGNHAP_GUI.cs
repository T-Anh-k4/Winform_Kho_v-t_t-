using BUS;
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
    public partial class HANGNHAP_GUI : KryptonForm
    {
        HANGNHAP_BUS hangNhapBUS = new HANGNHAP_BUS();
        bool createExplore = true;
        int limit = 5;
        int curentPage = 1;
        int totalPage = 1;//so trang can tao


        public HANGNHAP_GUI()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            initUser();
            panel2_nv.Height = 0;
            soluong.Text = "Hàng nhập (" + Convert.ToString(hangNhapBUS.GetSLNhaCungCap()) + ")";
            dataViewHNhap.CellFormatting += dataViewNv_CellFormatting;

        }
        public void initUser()
        {
            loadDt_HangNhap();
            kryTbSearch.Enter += kryTbSearch_Enter;
            kryTbSearch.Leave += kryTbSearch_Leave;
            kryTx_Id.Enter += kryTbSearch_Enter;
            kryTx_Id.Leave += kryTbSearch_Leave;
            kryTb_Name.Enter += kryTbSearch_Enter;
            kryTb_Name.Leave += kryTbSearch_Leave;
            kryTb_eID.Enter += kryTbSearch_Enter;
            kryTb_eID.Leave += kryTbSearch_Leave;
            SetPlaceholder(kryTbSearch, "Tìm kiếm");
            SetPlaceholder(kryTx_Id, "Nhập mã hàng nhập");
            SetPlaceholder(kryTb_Name, "Nhập tên hàng nhập");
            SetPlaceholder(kryTb_eID, "Nhập mã nhân viên");
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
        public void loadDt_HangNhap()
        {
            DataTable dt = new DataTable();
            dt = hangNhapBUS.GetDanhSachNhaCungCapPage(limit, curentPage);
            //3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
            dataViewHNhap.DataSource = dt;
            totalPage = hangNhapBUS.GetSLNhaCungCap() / limit;
            if (totalPage * limit < hangNhapBUS.GetSLNhaCungCap()) totalPage++;
            EnsureButtonColumnsVisible();
        }

        //Xóa các ô khi thoát chỉnh sửa
        public void clear()
        {
            kryTx_Id.Text = "";
            kryTb_Name.Text = "";
            kryTb_eID.Text = "";
        }

        // Thêm cột chứa nút vào DataGridView



        // private void infoButtonColumn()
        // {
        //     // Tạo một cột hình ảnh mới
        //     if (!dataViewHNhap.Columns.Contains("imgInfo"))
        //     {
        //         DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
        //         imgColumn.HeaderText = "Chi tiết";
        //         imgColumn.Name = "imgInfo";
        //         imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
        //         imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
        //         imgColumn.Width = 20;
        //         // Thêm cột hình ảnh vào DataGridView
        //         dataViewHNhap.Columns.Add(imgColumn);
        //     }
        //     // Căn giữa header của cột hình ảnh
        //     dataViewHNhap.Columns["imgInfo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //     dataViewHNhap.Columns["imgInfo"].DisplayIndex = dataViewHNhap.Columns.Count - 1;

        // }
        private void DelButtonColumn()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewHNhap.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewHNhap.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewHNhap.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewHNhap.Columns["imgDelete"].DisplayIndex = dataViewHNhap.Columns.Count - 1;

        }
        private void AddButtonColumn_Edit()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewHNhap.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Edit";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                                                                          // Thêm cột hình ảnh vào DataGridView
                dataViewHNhap.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewHNhap.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewHNhap.Columns["imgEdit"].DisplayIndex = dataViewHNhap.Columns.Count - 2;

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
                if (panel2_nv.Height >= 125)
                {
                    createTransition.Stop();
                    createExplore = true;
                }
            }

        }
        //Sự kiên database
        private void dataViewHNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataViewHNhap.Rows[e.RowIndex];
                if (e.ColumnIndex == dataViewHNhap.Columns["imgEdit"].Index)
                {
                    kryTx_Id.ReadOnly = true;
                    kryTx_Id.Text = row.Cells[2].Value.ToString();
                    kryTb_Name.Text = row.Cells[3].Value.ToString();
                    kryTb_eID.Text = row.Cells[4].Value.ToString();
                    kry_Datetime.Value = Convert.ToDateTime(row.Cells[5].Value);

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
                if (e.ColumnIndex == dataViewHNhap.Columns["imgDelete"].Index)
                {
                    DialogResult check = MessageBox.Show("Bạn có muốn xóa hàng nhập này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (check == DialogResult.Yes)
                    {
                        bool result = hangNhapBUS.DeleteHoaDonNhap(row.Cells[2].Value.ToString());
                        if (result)
                        {
                            loadDt_HangNhap();
                            MessageBox.Show("Xóa thông tin hàng nhập thành công", "Thanhcong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thông tin hàng nhập không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    clear();
                    soluong.Text = "Hàng nhập (" + Convert.ToString(hangNhapBUS.GetSLNhaCungCap()) + ")";
                }
                //if (e.ColumnIndex == dataViewHNhap.Columns["imgInfo"].Index)
                //{

                //}
            }
        }

        //Sự kiện click
        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(kryTx_Id.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hàng nhập.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_eID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result = hangNhapBUS.InsertHoaDonNhap(kryTx_Id.Text, kryTb_Name.Text, kryTb_eID.Text, kry_Datetime.Value, 1);

            if (result)
            {
                loadDt_HangNhap(); // Gọi lại để tải lại danh sách

                MessageBox.Show("Thêm hàng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm hàng nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            soluong.Text = "Hàng nhập (" + Convert.ToString(hangNhapBUS.GetSLNhaCungCap()) + ")";

        }

        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            bool result = hangNhapBUS.UpdateHoaDonNhap(kryTx_Id.Text, kryTb_Name.Text, kryTb_eID.Text, kry_Datetime.Value, 1);

            if (result)
            {
                MessageBox.Show("Sửa hàng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDt_HangNhap(); // Gọi lại để tải lại danh sách
            }
            else
            {
                MessageBox.Show("Sửa hàng nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kry_Clear_Click(object sender, EventArgs e)
        {
            clear();
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
                    return "Nhập mã hàng nhập";
                case "kryTb_Name":
                    return "Nhập tên hàng nhập";
                case "kryTb_eID":
                    return "Nhập mã người dùng";
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
            SetPlaceholder(kryTb_eID, GetPlaceholder(kryTb_eID));
        }
        //end
        private void kryBtPrevious_Click(object sender, EventArgs e)
        {
            curentPage--;
            loadDt_HangNhap();
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
            loadDt_HangNhap();
            kryBtPre.Enabled = true;
            if (curentPage == totalPage)
            {
                kryBt_Next.Enabled = false;
            }
            labelSoTrang.Text = Convert.ToString(curentPage);

        }


        private void kryBtShowCreate_HNhap_Click(object sender, EventArgs e)
        {
            kryBt_Add.Visible = true;
            kryTx_Id.ReadOnly = false;
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
        // tìm kiếm hàng nhập
        private void txb_tim_kiem_HNhap_TextChanged(object sender, EventArgs e)
        {
            string keyword = txb_tim_kiem_nv.Text.Trim();
            DataTable result = hangNhapBUS.SearchNCC(keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                loadDt_HangNhap();
                return;
            }

            else if (keyword == "Tìm kiếm")
            {
                return;
            }
            else
            {
                dataViewHNhap.DataSource = result;
                EnsureButtonColumnsVisible();
            }

        }
        private void EnsureButtonColumnsVisible()
        {
            // Kiểm tra và thêm cột nếu cần
            DelButtonColumn();
            // infoButtonColumn();
            AddButtonColumn_Edit();

            // Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
            dataViewHNhap.Columns["imgEdit"].DisplayIndex = dataViewHNhap.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
            dataViewHNhap.Columns["imgDelete"].DisplayIndex = dataViewHNhap.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

            // Đặt lại DisplayIndex cho các cột còn lại nếu cần
            int index = 0;
            foreach (DataGridViewColumn column in dataViewHNhap.Columns)
            {
                if (column.Name != "imgEdit" && column.Name != "imgDelete") // Bỏ qua các cột nút
                {
                    column.DisplayIndex = index++;
                }
            }
        }

        private void txb_tim_kiem_HNhap_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
        //nếu Username rỗng
        private void dataViewNv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataViewHNhap.Columns[e.ColumnIndex].Name == "") // Thay đổi tên cột nếu cần
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


