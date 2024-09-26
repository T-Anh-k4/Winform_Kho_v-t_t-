using QLVTXD;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QLVLXD
{
	public partial class Create : Form
	{
		private Form1 objectfrom1;
		private DataProvider dataProvider; 

		public Create(Form1 objectfrom1)
		{
			InitializeComponent();
			this.objectfrom1 = objectfrom1;
			this.dataProvider = new DataProvider(); 
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbx_DVT_DropDown(object sender, EventArgs e)
		{
			cbx_DVT.Items.Clear();
			cbx_DVT.Items.Add("Kg");
			cbx_DVT.Items.Add("Thùng");
			cbx_DVT.Items.Add("Cái");
		}

		// Thêm dữ liệu vào bảng hàng hóa
		private void btn_Create_Click(object sender, EventArgs e)
		{
			bool isValid = true;

			// Kiểm tra các trường nhập liệu
			if (string.IsNullOrWhiteSpace(txb_Mhh.Text))
			{
				MessageBox.Show("Vui lòng nhập mã hàng hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}

			if (string.IsNullOrWhiteSpace(txb_TenHang.Text))
			{
				MessageBox.Show("Vui lòng nhập tên hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}

			if (string.IsNullOrWhiteSpace(txb_MaLH.Text))
			{
				MessageBox.Show("Vui lòng nhập mã loại hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}

			if (cbx_DVT.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}

			if (string.IsNullOrWhiteSpace(txb_XuatXu.Text))
			{
				MessageBox.Show("Vui lòng nhập xuất xứ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				isValid = false;
			}


			if (isValid)
			{
				// Kiểm tra loại hàng đã tồn tại hay chưa
				string checkQuery = "SELECT COUNT(*) FROM LOAIHANG WHERE MALOAI = @MALOAI";
				int count = (int)dataProvider.execScalar(checkQuery, new SqlParameter("@MALOAI", txb_MaLH.Text));

				// Nếu loại hàng chưa tồn tại, thêm vào bảng LOAIHANG
				if (count == 0)
				{
					string insertLoaiHangQuery = "INSERT INTO LOAIHANG (MALOAI, TENLOAI) VALUES (@MALOAI, @TENLOAI)";
					dataProvider.execNonQuery(insertLoaiHangQuery,
						new SqlParameter("@MALOAI", txb_MaLH.Text),
						new SqlParameter("@TENLOAI", txb_TenHang.Text));
				}

				// Thêm hàng hóa vào bảng HangHoa
				StringBuilder insertHangHoaQuery = new StringBuilder("INSERT INTO HangHoa (MAHH, MALOAI, TENHH, DONVI_TINH, XUATXU) " +
					"                                                VALUES (@maHangHoa, @maLoaiHang, @tenHang, @donViTinh, @xuatXu)");

				int rowsAffected = dataProvider.execNonQuery(insertHangHoaQuery.ToString(),
					new SqlParameter("@maHangHoa", txb_Mhh.Text),
					new SqlParameter("@tenHang", txb_TenHang.Text),
					new SqlParameter("@maLoaiHang", txb_MaLH.Text),
					new SqlParameter("@xuatXu", txb_XuatXu.Text),
					new SqlParameter("@donViTinh", cbx_DVT.SelectedItem.ToString()));

				if (rowsAffected > 0)
				{
					MessageBox.Show("Thêm dữ liệu thành công!");
					objectfrom1.loadDt_user();
				}
				else
				{
					MessageBox.Show("Thêm dữ liệu thất bại!");
				}
			}
		}
	}
}
