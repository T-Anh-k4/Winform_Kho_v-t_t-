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
		TEST_GUI menuGUi = new TEST_GUI();
		public LOGIN_GUI()
		{
			InitializeComponent();
		}

		private void artanPanel1_Paint(object sender, PaintEventArgs e)
		{

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
			this.Hide();
			menuGUi.ShowDialog();
			this.Close();

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
	}
}
