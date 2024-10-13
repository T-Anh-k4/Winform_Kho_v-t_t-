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
		private string _Loai;
		private int _Active;
		public USER_DTO(string userName, string passWord, string loai, int active)
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
			Loai = row["LOAI"].ToString();
			Active = (int)row["ACTIVE"];

		}
		public string PassWord { get => _PassWord; set => _PassWord = value; }
		public string UserName { get => _UserName; set => _UserName = value; }
		public int Active { get => _Active; set => _Active = value; }
		public string Loai { get => _Loai; set => _Loai = value; }
	}
}
