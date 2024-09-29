﻿namespace QLVLXD
{
	public class Product
	{
		public string Mahh { get; set; }
		public string TenHang { get; set; }
		public string Malh { get; set; }
		public string XuatXu { get; set; }
		public string Dvt { get; set; }

		public Product() { }
		public Product(string mahh, string tenHang, string malh, string xuatXu, string dvt)
		{
			this.Mahh = mahh;
			this.TenHang = tenHang;
			this.Malh = malh;
			this.XuatXu = xuatXu;
			this.Dvt = dvt;
		}
	}
}
