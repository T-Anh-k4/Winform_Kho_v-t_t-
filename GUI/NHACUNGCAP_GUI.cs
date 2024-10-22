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
    public partial class NHACUNGCAP_GUI : KryptonForm
    {
        NHACUNGCAP_BUS nhaCungCapBUS = new NHACUNGCAP_BUS();
        bool createExplore = true;
        int limit = 10;
        int curentPage = 1;
        int totalPage = 1;//so trang can tao


        public NHACUNGCAP_GUI()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            initUser();
            panel2_ncc .Height = 0;
        }
        public void initUser()
        {
            loadDt_NhaCungCap();
            kryTbSearch.Enter += kryTbSearch_Enter;
            kryTbSearch.Leave += kryTbSearch_Leave;
            kryTb_Id.Enter += kryTbSearch_Enter;
            kryTb_Id.Leave += kryTbSearch_Leave;
            kryTb_Name.Enter += kryTbSearch_Enter;
            kryTb_Name.Leave += kryTbSearch_Leave;
            kryTb_Number.Enter += kryTbSearch_Enter;
            kryTb_Number.Leave += kryTbSearch_Leave;
            kryTb_Address.Enter += kryTbSearch_Enter;
            kryTb_Address.Leave += kryTbSearch_Leave;
            SetPlaceholder(kryTbSearch, "Tìm kiếm");
            SetPlaceholder(kryTb_Id, "Nhập mã nhà cung cấp");
            SetPlaceholder(kryTb_Name, "Nhập tên nhà cung cấp");
            SetPlaceholder(kryTb_Number, "Nhập số điện thoại");
            SetPlaceholder(kryTb_Address, "Nhập địa chỉ");
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
        public void loadDt_NhaCungCap()
        {
            DataTable dt = new DataTable();
            dt = nhaCungCapBUS.GetDanhSachNhaCungCapPage(limit, curentPage);
            //3dt_nhanvien.ColumnHeadersVisible = false;//ẩn header datagridview
            dataViewNcc.DataSource = dt;
            totalPage = nhaCungCapBUS.GetSLNhaCungCap() / limit;
            if (totalPage * limit < nhaCungCapBUS.GetSLNhaCungCap()) totalPage++;
            EnsureButtonColumnsVisible();
        }
        //Xóa các ô khi thoát chỉnh sửa
        public void clear()
        {
            kryTb_Id.Text = "";
            kryTb_Name.Text = "";
            kryTb_Address.Text = "";
            kryTb_Number.Text = "";
        }

        // Thêm cột chứa nút vào DataGridView
        private void DelButtonColumn()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewNcc.Columns.Contains("imgDelete"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Xóa";
                imgColumn.Name = "imgDelete";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-delete.png")); // Đường dẫn đến hình ảnh
                imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                imgColumn.Width = 20;
                // Thêm cột hình ảnh vào DataGridView
                dataViewNcc.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewNcc.Columns["imgDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewNcc.Columns["imgDelete"].DisplayIndex = dataViewNcc.Columns.Count - 1;

        }
        private void AddButtonColumn_Edit()
        {
            // Tạo một cột hình ảnh mới
            if (!dataViewNcc.Columns.Contains("imgEdit"))
            {
                DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                imgColumn.HeaderText = "Edit";
                imgColumn.Name = "imgEdit";
                imgColumn.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Images\icon-edit.png"));
                //imgColumn.Image = Image.FromFile(@"E:\\CODE\\LapTrinhTrucQuan\\Winform_Kho_v-t_t-\\Images\\icon-edit.png"); // Đường dẫn đến hình ảnh
                //imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Chỉnh cách hiển thị hình ảnh (căn giữa, zoom,...)
                // Thêm cột hình ảnh vào DataGridView
                dataViewNcc.Columns.Add(imgColumn);
            }
            // Căn giữa header của cột hình ảnh
            dataViewNcc.Columns["imgEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataViewNcc.Columns["imgEdit"].DisplayIndex = dataViewNcc.Columns.Count - 2;

        }
        //end

        //Chỉnh phần trượt giao diện tạo
        private void createTransition_Tick(object sender, EventArgs e)
        {
            if (createExplore)
            {
                panel2_ncc.Height -= 10;
                if (panel2_ncc.Height <= 0)
                {
                    createTransition.Stop();
                    createExplore = false;
                }
            }
            else
            {
                panel2_ncc.Height += 10;
                if (panel2_ncc.Height >= 120)
                {
                    createTransition.Stop();
                    createExplore = true;
                }
            }

        }
        //Sự kiên database
        private void dataViewNcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataViewNcc.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataViewNcc.Columns["imgEdit"].Index)
                {
                    kryTb_Id.ReadOnly = true;
                    kryTb_Id.Text = row.Cells[2].Value.ToString();
                    kryTb_Name.Text = row.Cells[3].Value.ToString();
                    kryTb_Address.Text = row.Cells[4].Value.ToString();
                    kryTb_Number.Text = row.Cells[5].Value.ToString();
                    IsPressEdit();
                    createTransition.Start();
                    if (panel2_ncc.Height >= 120)
                    {
                        createTransition.Stop();
                    }
                    if (kryBt_Add.Visible)
                    {
                        kryBt_Add.Visible = false;
                    }

                }
            }
            if (e.ColumnIndex == dataViewNcc.Columns["imgDelete"].Index)
            {
                DialogResult check = MessageBox.Show("Bạn có muốn xóa nhà cung cấp nay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (check == DialogResult.Yes)
                {
                    bool result = nhaCungCapBUS.DeleteNhaCungCap(row.Cells[2].Value.ToString());
                    if (result)
                    {
                        loadDt_NhaCungCap();
                        MessageBox.Show("Xóa thông tin nhà cung cấp thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin nhà cung cấp không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        //Sự kiện click
        private void kryBt_Add_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(kryTb_Id.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_Name.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_Address.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(kryTb_Number.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result = nhaCungCapBUS.InsertNhaCungCap(kryTb_Id.Text, kryTb_Name.Text, kryTb_Address.Text, kryTb_Number.Text);

            if (result)
            {
                loadDt_NhaCungCap(); // Gọi lại để tải lại danh sách

                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void kryBt_Edit_Click(object sender, EventArgs e)
        {
            bool result = nhaCungCapBUS.UpdateNhaCungCap(kryTb_Id.Text, kryTb_Name.Text, kryTb_Address.Text, kryTb_Number.Text);

            if (result)
            {
                MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDt_NhaCungCap(); // Gọi lại để tải lại danh sách
            }
            else
            {
                MessageBox.Show("Sửa nhà cung cấp không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                case "kryTb_Id":
                    return "Nhập mã nhà cung cấp";
                case "kryTb_Name":
                    return "Nhập tên nhà cung cấp";
                case "kryTb_Number":
                    return "Nhập số điện thoại";
                case "kryTb_Address":
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
            SetPlaceholder(kryTb_Id, GetPlaceholder(kryTb_Id));
            SetPlaceholder(kryTb_Name, GetPlaceholder(kryTb_Name));
            SetPlaceholder(kryTb_Number, GetPlaceholder(kryTb_Number));
            SetPlaceholder(kryTb_Address, GetPlaceholder(kryTb_Address));

        }
        //end
        private void kryBtPrevious_Click(object sender, EventArgs e)
        {
            curentPage--;
            loadDt_NhaCungCap();
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
            loadDt_NhaCungCap();
            kryBtPre.Enabled = true;
            if (curentPage == totalPage)
            {
                kryBt_Next.Enabled = false;
            }
            labelSoTrang.Text = Convert.ToString(curentPage);

        }

        private void kryBtShowCreate_NCC_Click(object sender, EventArgs e)
        {
            kryBt_Add.Visible = true;
            kryTb_Id.ReadOnly = false;
            createTransition.Start();
            if (kryBt_Edit.Visible)
            {
                kryBt_Edit.Visible = false;
            }
            if (panel2_ncc.Height >= 170)
            {
                createTransition.Stop();

            }
        }
        // tìm kiếm nhà cung cấp
        private void txb_tim_kiem_NCC_TextChanged(object sender, EventArgs e)
        {
            string keyword = txb_tim_kiem_ncc.Text.Trim();
            DataTable result = nhaCungCapBUS.SearchNCC(keyword);
            if (string.IsNullOrEmpty(keyword))
            {
                loadDt_NhaCungCap();
                return;
            }

            else if (keyword == "Tìm kiếm")
            {
                return;
            }
            else
            {
                dataViewNcc.DataSource = result;
                EnsureButtonColumnsVisible();
            }

        }
        private void EnsureButtonColumnsVisible()
        {
            // Kiểm tra và thêm cột nếu cần
            DelButtonColumn();
            AddButtonColumn_Edit();

            // Đặt DisplayIndex cho cột "Chỉnh sửa" và "Xóa"
            dataViewNcc.Columns["imgEdit"].DisplayIndex = dataViewNcc.Columns.Count - 2; // Đặt "Chỉnh sửa" ở vị trí thứ hai từ cuối
            dataViewNcc.Columns["imgDelete"].DisplayIndex = dataViewNcc.Columns.Count - 1; // Đặt "Xóa" ở vị trí cuối cùng

            // Đặt lại DisplayIndex cho các cột còn lại nếu cần
            int index = 0;
            foreach (DataGridViewColumn column in dataViewNcc.Columns)
            {
                if (column.Name != "imgEdit" && column.Name != "imgDelete") // Bỏ qua các cột nút
                {
                    column.DisplayIndex = index++;
                }
            }
        }

        // private void txb_tim_kiem_LH_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        // {
        //     if (e.KeyCode == Keys.Enter)
        //     {
        //         e.SuppressKeyPress = true;
        //     }
        // }
    }
}


