using QLVTXD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLVLXD
{
	internal class SearchHandler
	{
		private DataProvider dataProvider;
		private DataGridView grview_hang;
		private Form1 form1;

		public SearchHandler(DataProvider provider, DataGridView dataGridView, Form1 form)
		{
			this.dataProvider = provider;
			this.grview_hang = dataGridView;
			this.form1 = form; 
		}

		public void Search(string searchTerm)
		{
			if (string.IsNullOrEmpty(searchTerm))
			{
				form1.loadDt_user(); 
				return;
			}

			// Thực hiện tìm kiếm
			string query = "SELECT * FROM HangHoa WHERE TENHH LIKE @TENHH + '%'";
			DataTable resultTable = dataProvider.execQuery(query, new SqlParameter("@TENHH", searchTerm));

			if (resultTable.Rows.Count > 0)
			{
				grview_hang.DataSource = resultTable;
				grview_hang.Columns["checkBoxColumn"].Visible = true; 
			}
			else
			{
				grview_hang.DataSource = null;
				grview_hang.BackgroundColor = Color.WhiteSmoke;
				grview_hang.Columns["checkBoxColumn"].Visible = false; 
			}
		}
	}
}
