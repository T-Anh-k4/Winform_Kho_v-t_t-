﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class HANGHOA_DTO
	{
		public string Mahh { get; set; }
		public string TenHang { get; set; }
		public string Malh { get; set; }
		public string XuatXu { get; set; }
		public string Dvt { get; set; }

		public HANGHOA_DTO() { }
		public HANGHOA_DTO(string mahh, string tenHang, string malh, string xuatXu, string dvt)
		{
			this.Mahh = mahh;
			this.TenHang = tenHang;
			this.Malh = malh;
			this.XuatXu = xuatXu;
			this.Dvt = dvt;
		}
	}
}
