using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class LOAIHANG_DTO
	{
		public string MALOAI { get; set; }
		public string TENLOAI { get; set; }
		public string DIENGIAI { get; set; }
		public int FLAG { get; set; }
		public LOAIHANG_DTO() { }
		public LOAIHANG_DTO(string MALOAI, string TENLOAI, string DIENGIAI, int FLAG)
		{
			this.MALOAI = MALOAI;
			this.TENLOAI = TENLOAI;
			this.DIENGIAI = DIENGIAI;
		    this.FLAG = FLAG;
		}
	}
}
