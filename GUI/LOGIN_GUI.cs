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
using DTO;
using BUS;
namespace GUI
{
	public partial class LOGIN_GUI : KryptonForm
	{
		USER_DTO userDTO = new USER_DTO();
		LOGIN_BUS loginBUS = new LOGIN_BUS();
		//TEST_GUI menuGUi = new TEST_GUI();
		public LOGIN_GUI()
		{
			InitializeComponent();
            init();

        }
		public void init()
		{
         //   kryTbMatKhau.PasswordChar = "Maatj";
            SetPlaceholder(kryTbTaiKhoan, "Tài khoản...");
            SetPlaceholder(kryTbMatKhau, "Mật khẩu...");
            kryTbTaiKhoan.Enter += kryTbTaiKhoan_Enter;
            kryTbTaiKhoan.Leave += kryTbTaiKhoan_Leave;
            kryTbMatKhau.Enter += kryTbTaiKhoan_Enter;
            kryTbMatKhau.Leave += kryTbTaiKhoan_Leave;

        }
		private void kryBtLogin_Click(object sender, EventArgs e)
		{
			userDTO.UserName = kryTbTaiKhoan.Text;
			userDTO.PassWord = kryTbMatKhau.Text;
			string getUser = loginBUS.CheckLogin(userDTO);
			switch (getUser) {
				case "required_tk": MessageBox.Show("Tài khoản không được bỏ trống");
					return;
				case "required_mk":
					MessageBox.Show("Mật khẩu không được bỏ trống");
					return;
				case "Tai khoan mat khau khong chinh xac":
					MessageBox.Show("Tài khoản mật khẩu không chính xác");
					return;
			}
			MessageBox.Show("Đăng nhập thành công.");
            bool isAdmin = getUser == "Admin";
            TEST_GUI menuGui = new TEST_GUI(isAdmin);
            this.Hide();
            menuGui.ShowDialog();
			this.Close();
		}
        private void SetPlaceholder(KryptonTextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
        }
        private void ResetForeText()
        {
            SetPlaceholder(kryTbTaiKhoan, GetPlaceholder(kryTbTaiKhoan));
            SetPlaceholder(kryTbMatKhau, GetPlaceholder(kryTbMatKhau));

        }
        private string GetPlaceholder(KryptonTextBox textBox)
        {
            switch (textBox.Name)
            {
                case "kryTbTaiKhoan":
                    return "Tài khoản...";
                case "kryTbMatKhau":
                    return "Mật khẩu...";
                default:
                    return string.Empty;
            }
        }
        private void kryBtExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void kryTbTaiKhoan_TextChanged(object sender, EventArgs e)
		{

		}

		private void kryBtMatKhau_TextChanged(object sender, EventArgs e)
		{

		}

        private void kryTbTaiKhoan_Enter(object sender, EventArgs e)
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

        private void kryTbTaiKhoan_Leave(object sender, EventArgs e)
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
    }
}
