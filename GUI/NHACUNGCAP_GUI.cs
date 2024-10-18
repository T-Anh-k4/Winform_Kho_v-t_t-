using System;
using System.Data;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using BUS;

namespace GUI
{
    public partial class NHACUNGCAP_GUI : KryptonForm
    {
        private NHACUNGCAP_BUS nhacungcap_bus;

        public NHACUNGCAP_GUI()
        {
            InitializeComponent();
            nhacungcap_bus = new NHACUNGCAP_BUS();
            init();
        }

        public void init()
        {
            initUser();
            NHACUNGCAP_GUI_Load();
            AddButtonColumn();
            AddButtonColumn_Edit();
        }

        // Initial setup of the form
        public void initUser()
        {
            pn_nhap.Height = 0;
            pn_data.Height = 620;

            txb_MaNCC.Enter += TextBox_Enter;
            txb_MaNCC.Leave += TextBox_Leave;

            txb_TenNCC.Enter += TextBox_Enter;
            txb_TenNCC.Leave += TextBox_Leave;

            txb_DiaChi.Enter += TextBox_Enter;
            txb_DiaChi.Leave += TextBox_Leave;

            txb_TimKiem.Enter += TextBox_Enter;
            txb_TimKiem.Leave += TextBox_Leave;

            SetPlaceholder(txb_MaNCC, "Enter supplier code");
            SetPlaceholder(txb_TenNCC, "Enter supplier name");
            SetPlaceholder(txb_DiaChi, "Enter address");
            SetPlaceholder(txb_TimKiem, "Search");
        }

        public bool IsPressAdd()
        {
            kbtn_ThemSua.Visible = true;
            return kbtn_ThemSua.Visible;
        }

        public bool IsPressEdit()
        {
            kbtn_Sua.Visible = true;
            return kbtn_Sua.Visible;
        }

        // Add values to the combobox
        private void cbx_LoaiNCC_DropDown(object sender, EventArgs e)
        {
            cbx_LoaiNCC.Items.Clear();
            cbx_LoaiNCC.Items.Add("Type 1");
            cbx_LoaiNCC.Items.Add("Type 2");
            cbx_LoaiNCC.Items.Add("Type 3");
        }

        // Add edit and delete buttons to the DataGridView
        private void AddButtonColumn()
        {
            if (!k_datagrview_nhacungcap.Columns.Contains("btnDelete"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();

                btnColumn.HeaderText = "Delete";
                btnColumn.Name = "btnDelete";
                btnColumn.Text = "Delete";
                btnColumn.UseColumnTextForButtonValue = true;

                k_datagrview_nhacungcap.Columns.Add(btnColumn);
            }
            k_datagrview_nhacungcap.Columns["btnDelete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AddButtonColumn_Edit()
        {
            if (!k_datagrview_nhacungcap.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Edit";
                btnColumn.Name = "btnEdit";
                btnColumn.Text = "Edit";
                btnColumn.UseColumnTextForButtonValue = true;
                k_datagrview_nhacungcap.Columns.Add(btnColumn);
            }
            k_datagrview_nhacungcap.Columns["btnEdit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Event handlers for text box placeholders
        private void TextBox_Enter(object sender, EventArgs e)
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

        private void TextBox_Leave(object sender, EventArgs e)
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

        private string GetPlaceholder(KryptonTextBox textBox)
        {
            switch (textBox.Name)
            {
                case "txb_MaNCC":
                    return "Enter supplier code";
                case "txb_TenNCC":
                    return "Enter supplier name";
                case "txb_DiaChi":
                    return "Enter address";
                case "txb_TimKiem":
                    return "Search";
                default:
                    return string.Empty;
            }
        }

        // Reset default text
        private void ResetForeText()
        {
            SetPlaceholder(txb_MaNCC, GetPlaceholder(txb_MaNCC));
            SetPlaceholder(txb_TenNCC, GetPlaceholder(txb_TenNCC));
            SetPlaceholder(txb_DiaChi, GetPlaceholder(txb_DiaChi));
        }

        // Load DataGridView
        private void NHACUNGCAP_GUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nhacungcap_bus.GetDanhSachNhaCungCap();
            k_datagrview_nhacungcap.DataSource = dt;
        }

        private void kbtn_ThemSua_Click(object sender, EventArgs e)
        {
            // Add event handler code here
        }

        private void kbtn_Sua_Click(object sender, EventArgs e)
        {
            // Add event handler code here
        }

        private void kbtn_Cancle_Click(object sender, EventArgs e)
        {
            // Add event handler code here
        }

        private void dtgrview_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add event handler code here
        }

        private void txb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            // Add event handler code here
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Add event handler code here
        }
        private void k_datagrview_nhacungcap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
        }

        private void kbtn_Cancel_Click(object sender, EventArgs e)
        {
            // Add event handler code here
        }
    }
}