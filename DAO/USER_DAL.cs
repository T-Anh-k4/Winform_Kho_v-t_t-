using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class USER_DAL
	{
		DataProvider instance = new DataProvider();
		public DataTable GetDataUserName()
		{
			string query = "SELECT USERNAME AS [Tên người dùng], PASSWORD AS [Mật khẩu], LOAI AS [Loại người dùng],ACTIVE AS [Trạng thái] FROM NGUOIDUNG";
			return instance.execQuery(query);
		}
	}
}
