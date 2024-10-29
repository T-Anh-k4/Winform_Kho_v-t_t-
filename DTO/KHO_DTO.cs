using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHO_DTO
    {
        public int IDKho { get; set; }
        public string MAHH { get; set; }
        public int soluong { get; set; }
        public KHO_DTO() { }
        public KHO_DTO(int iDKho, string mAHH, int soluong)
        {
            IDKho = iDKho;
            MAHH = mAHH;
            this.soluong = soluong;
        }
    }
}
