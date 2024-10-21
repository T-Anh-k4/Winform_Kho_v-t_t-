using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using DAL;
namespace BUS
{
	public class LOGIN_BUS
	{
		LOGIN_DAL loginDAL = new LOGIN_DAL();
		public string CheckLogin(USER_DTO userDTO)
		{
			if (userDTO.UserName == "") { return "required_tk"; }
			if (userDTO.UserName == "") { return "required_mk"; }

			string info = loginDAL.CheckLogin(userDTO);
			return info;
		}
	}
}
