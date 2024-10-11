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
		USER_DAL userDTO = new USER_DAL();
		public DataTable GetDataUserName()
		{
			return userDTO.GetDataUserName();
		}

	}
}
