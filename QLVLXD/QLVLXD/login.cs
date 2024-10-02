using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVLXD
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}
		user1 admin = new user1("admin", "admin123", "active", "Admin");

		user1 normalUser = new user1("user", "user123", "active", "User");
		private void bt_login_Click(object sender, EventArgs e)
		{
			string taikhoan = tx_tk.Text;
			string matkhau = tx_mk.Text;

			if (taikhoan == admin.Username && matkhau == admin.Password)
			{
				user1.CurrentUser = admin;
			}
			else if (taikhoan == normalUser.Username && matkhau == normalUser.Password)
			{
				user1.CurrentUser = normalUser;
			}
			else
			{
				MessageBox.Show("Đăng nhập thất bại.");
				return; 
			}

			Form1 form1 = new Form1(); 
			form1.ShowDialog();
			this.Close();
		}

	}
}
