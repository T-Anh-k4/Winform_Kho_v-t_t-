using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class USER_DTO
	{
		private string _PassWord;
		private string _UserName;
		private string _Active;
		private int _Loai;

		public USER_DTO(string userName, string passWord, string active, int  loai)
		{
			UserName = userName;
			PassWord = passWord;
			Active = active;
			Loai = loai;
		}
		public USER_DTO(DataRow row) 
		{
			UserName = row["USERNAME"].ToString();
			PassWord = row["PASSWORD"].ToString();
			Active = row["ACTIVE"].ToString();
			Loai = (int)row["LOAI"];

		}
		public string PassWord { get => _PassWord; set => _PassWord = value; }
		public string UserName { get => _UserName; set => _UserName = value; }
		public string Active { get => _Active; set => _Active = value; }
		public int Loai { get => _Loai; set => _Loai = value; }
	}
}
