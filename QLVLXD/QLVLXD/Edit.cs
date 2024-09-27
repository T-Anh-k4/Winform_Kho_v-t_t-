using QLVTXD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLVLXD
{
	public partial class Edit : Form
	{
		private string Mahh, TenHang, Malh, XuatXu, Dvt;
		private Form1 form1;
		private DataProvider dataProvider;

		public Edit(string mahh, string tenHang, string malh, string xuatXu, string dvt, Form1 form1)
		{
			InitializeComponent();
			this.Mahh = mahh;
			this.TenHang = tenHang;
			this.Malh = malh;
			this.XuatXu = xuatXu;
			this.Dvt = dvt;
			DisplayData();
			this.form1 = form1;
			this.dataProvider = new DataProvider(); 
		}

		private void DisplayData()
		{
			txb_TenHang_edit.Text = TenHang;
			txb_MaLH_edit.Text = Malh;
			txb_XuatXu_edit.Text = XuatXu;

			if (!cbx_DVT_edit.Items.Contains(Dvt))
			{
				cbx_DVT_edit.Items.Add(Dvt);
			}
			cbx_DVT_edit.SelectedItem = Dvt;
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			string tenHang = txb_TenHang_edit.Text;
			string malh = txb_MaLH_edit.Text;
			string xuatxu = txb_XuatXu_edit.Text;
			string dvt = cbx_DVT_edit.SelectedItem?.ToString();

			if (string.IsNullOrEmpty(tenHang) || string.IsNullOrEmpty(dvt) || string.IsNullOrEmpty(malh) || string.IsNullOrEmpty(xuatxu))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
				return;
			}

			// Câu lệnh SQL để cập nhật dữ liệu
			string query = "UPDATE HangHoa SET TENHH = @TenHang, MALOAI = @Malh, XUATXU = @XuatXu, DONVI_TINH = @DVT WHERE MAHH = @Mahh";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenHang", tenHang),
				new SqlParameter("@Malh", malh),
				new SqlParameter("@XuatXu", xuatxu),
				new SqlParameter("@DVT", dvt),
				new SqlParameter("@Mahh", Mahh) 
            };

			try
			{
				int rowsAffected = dataProvider.execNonQuery(query, parameters);
				if (rowsAffected > 0)
				{
					MessageBox.Show("Sửa dữ liệu thành công!");
					form1.loadDt_user();
				}
				else
				{
					MessageBox.Show("Không tìm thấy sản phẩm cần sửa hoặc không có thay đổi nào.");
				}
			}
			catch (SqlException sqlEx)
			{
				MessageBox.Show("Có lỗi xảy ra với SQL: " + sqlEx.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
			}
		}

		private void btn_Cancel_edit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbx_DVT_edit_DropDown(object sender, EventArgs e)
		{
			cbx_DVT_edit.Items.Clear();
			cbx_DVT_edit.Items.Add("Kg");
			cbx_DVT_edit.Items.Add("Thùng");
			cbx_DVT_edit.Items.Add("Cái");
		}
	}
}
