using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace DAL
{
	public class LOGIN_DAL : DataProvider
	{
		public string CheckLogin(USER_DTO userDTO)
		{
			string info = CheckLoginDTO(userDTO);
			return info;
		}
	}
}
