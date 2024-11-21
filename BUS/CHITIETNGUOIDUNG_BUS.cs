using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class CHITIETNGUOIDUNG_BUS
    {
        private CHITIETNGUOIDUNG_DAL nguoiDungDAL = new CHITIETNGUOIDUNG_DAL();

        public CHITIETNGUOIDUNG_DTO GetUserDetails(string username)
        {
            return nguoiDungDAL.GetUserDetails(username);
        }
    }
}
