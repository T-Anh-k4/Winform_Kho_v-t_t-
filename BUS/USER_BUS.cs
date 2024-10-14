using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
	public class USER_BUS
	{
		USER_DAL userDAL = new USER_DAL();
		public DataTable GetDataUserName()
		{
			return userDAL.GetDataUserName();
		}
		public bool DeleteUser(string username)
		{
			return userDAL.DeleteUser(username);
		}
		public bool InsertUser(string username, string password, string loai, int trangthai)
		{
			return userDAL.InsertUser(username,password,loai,trangthai);
		}
		public bool UplateUser(string username, string password, string loai, int trangthai)
		{
			return userDAL.UpdateUser(username, password, loai, trangthai);
		}
		public DataTable SearchUser(string keyword)
		{
			return userDAL.SearchUser(keyword);
		}

	}
}
