using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace DAO
{
	public class LOGIN_DAL : USER_DAL
	{
		public string CheckLogin(USER_DTO userDTO)
		{
			string info = CheckLoginDTO(userDTO);
			return info;
		}
	}
}
