using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	internal class DataProvider
	{

		// Thực hiện truy vấn SELECT và trả về kết quả dưới dạng DataTable
		public DataTable execQuery(string query, params SqlParameter[] parameters)
		{
			DataTable data = new DataTable();
			using (SqlConnection con = new SqlConnection(@"Data Source=NQH\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True"))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				if (parameters != null)
				{
					cmd.Parameters.AddRange(parameters);
				}
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(data);
				con.Close();
			}
			return data;
		}

		// Thực hiện các câu lệnh INSERT, UPDATE, DELETE và trả về số dòng bị tác động
		public int execNonQuery(string query, params SqlParameter[] parameters)
		{
			int data = 0;
			using (SqlConnection con = new SqlConnection(@"Data Source=NQH\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True"))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddRange(parameters);
				data = cmd.ExecuteNonQuery();
			}
			return data;
		}

		public object execScalar(string query, params SqlParameter[] parameters)
		{
			object data = null;
			using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T4N0A0R\SQLEXPRESS;Initial Catalog=QLVATLIEUXD;Integrated Security=True"))
			{
				con.Open();
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddRange(parameters);
				data = cmd.ExecuteScalar();
			}
			return data;
		}
	}
}
