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
using BUS;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace GUI
{
    public partial class CHITIETNGUOIDUNG_GUI : KryptonForm
    {
        CHITIETNGUOIDUNG_BUS nguoiDungBUS = new CHITIETNGUOIDUNG_BUS();
        public CHITIETNGUOIDUNG_GUI(string name)
        {
            InitializeComponent();
            LoadUserDetails(name);
        }
        //public CHITIETNGUOIDUNG_GUI(string image)
        //{
        //    InitializeComponent();
        //    LoadUserDetails(userDTO.UserName);
        //    panel1.BackgroundImage = Image.FromFile(image);
        //  // Text = image.Substring(image.LastIndexOf('\\') + 1);
        //    panel1.BackgroundImageLayout = ImageLayout.Stretch;
        //}
        private void LoadUserDetails(string username)
        {
            CHITIETNGUOIDUNG_DTO user = nguoiDungBUS.GetUserDetails(username);

            if (user != null)
            {
                txtUserName.Text = user.UserName;
                txtTenNV.Text = user.TenNV;
                txtLoai.Text = user.Loai;
                txtDiaChi.Text = user.DiaChi;
                txtSoDT.Text = user.SoDT;
                txtDienGiai.Text = user.DienGia;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBG_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Png File|*.png|Jpg File|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Update the background image of the current form
                panel1.BackgroundImage = Image.FromFile(ofd.FileName);
                Text = ofd.FileName.Substring(ofd.FileName.LastIndexOf('\\') + 1);
                panel1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
