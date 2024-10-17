using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GUI
{
	public partial class TEST_GUI : KryptonForm
	{
		private bool isDanhMucVisible = false;
		private bool isBaoCaoVisible = false;
		private bool danhMucExplore = true;
		private bool hangHoaExplore = true;
		private bool hethongExplore = true;
		private bool tkBcExplore = true;
		private KryptonForm currentChildForm;


		private bool BaoCaoExplore = true;
		public TEST_GUI()
		{
			InitializeComponent();
			Init();
		}
		public void Init()
		{
			panelDoanhMuc.Height = 43;
			palHangHoa.Height = 0;
			panelHeThong.Height = 0;
			panelHeThong.Location = new Point(0, 94);
			panelTk_Bc.Height = 43;
			AssignMouseEnterEvent(this); // Bắt đầu duyệt từ form
			AssignMouseEvents(this);
		}
		private void Danh_muc_Transition_Tick(object sender, EventArgs e)
		{
			if (danhMucExplore)
			{
				if (panelDoanhMuc.Height <= 43)
				{
					Danh_muc_Transition.Stop();
					danhMucExplore = false;
				}
				else {
					panelDoanhMuc.Height -= 10;
				}
				//khi nhan vao emnu to
				if (panelDoanhMuc.Height <= 250)
				{
					panelHeThong.Location = new Point(0, 94);
					palHangHoa.Height -= 15;
					if (palHangHoa.Height <= 0)
					{
						HangHoa_Transition.Stop();
						hangHoaExplore = false;
					}
				}
			}
			else
			{
				panelDoanhMuc.Height += 10;
				if (panelDoanhMuc.Height >= 250)
				{
					Danh_muc_Transition.Stop();
					danhMucExplore = true;
				}

			}
		}
		private void KryptonButton_MouseEnter(object sender, EventArgs e)
		{
			KryptonButton btn = (KryptonButton)sender; // Lấy nút Krypton được hover
			btn.StateCommon.Back.Color1 = Color.MediumPurple; // Màu đầu tiên của nền
			btn.StateCommon.Back.Color2 = Color.MediumSlateBlue; // Màu thứ hai của nền (gradient)
			btn.StateCommon.Content.ShortText.Color1 = Color.White; // Màu chữ
		}
		private void KryptonButton_MouseLeave(object sender, EventArgs e)
		{
			KryptonButton btn = (KryptonButton)sender; // Lấy nút Krypton khi chuột rời khỏi
			btn.StateCommon.Back.Color1 = Color.Empty; // Đặt lại màu nền về mặc định
			btn.StateCommon.Back.Color2 = Color.Empty; // Đặt lại màu nền về mặc định
			btn.StateCommon.Content.ShortText.Color1 = Color.Black; // Đặt lại màu chữ về màu đen
		}
		private void AssignMouseEnterEvent(Control parent)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is KryptonButton)
				{
					control.MouseEnter += KryptonButton_MouseEnter;
				}

				// Nếu control là một container (Panel, GroupBox, TabControl), gọi đệ quy để duyệt tiếp các control con
				if (control.Controls.Count > 0)
				{
					AssignMouseEnterEvent(control); // Đệ quy gọi lại chính nó với control hiện tại
				}
			}
		}
		private void AssignMouseEvents(Control parent)
		{
			foreach (Control control in parent.Controls)
			{
				if (control is KryptonButton)
				{
					control.MouseEnter += KryptonButton_MouseEnter;
					control.MouseLeave += KryptonButton_MouseLeave; // Gán sự kiện MouseLeave
				}

				// Nếu control là một container (Panel, GroupBox, TabControl), gọi đệ quy để duyệt tiếp các control con
				if (control.Controls.Count > 0)
				{
					AssignMouseEvents(control);
				}
			}
		}
		private void HangHoa_Transition_Tick(object sender, EventArgs e)
		{
			if (hangHoaExplore)
			{
				palHangHoa.Height -= 10;
				if (palHangHoa.Height <= 0)
				{
					HangHoa_Transition.Stop();
					hangHoaExplore = false;
				}
			}
			else
			{
				palHangHoa.Height += 10;
				if (palHangHoa.Height >= 200)
				{
					HangHoa_Transition.Stop();
					hangHoaExplore = true;
				}
			}
		}

		private void kryBtHangNhap_Click(object sender, EventArgs e)
		{

		}

		private void kryBtDoanhMuc_Click(object sender, EventArgs e)
		{
			panelHeThong.Location = new Point(0, 308);
			Danh_muc_Transition.Start();

		}
		private void HeThong_Transition_Tick(object sender, EventArgs e)
		{
			if (hethongExplore)
			{
				panelHeThong.Height -= 10;
				if (panelHeThong.Height <= 0)
				{
					HeThong_Transition.Stop();
					hethongExplore = false;
				}
			}
			else
			{
				panelHeThong.Height += 10;
				if (panelHeThong.Height >= 100)
				{
					HeThong_Transition.Stop();
					hethongExplore = true;
				}
			}
		}

		private void BtHeThong_Click(object sender, EventArgs e)
		{
			HeThong_Transition.Start();
		}

		private void BtTk_Bc_Click(object sender, EventArgs e)
		{
			Tk_Bc_Transition.Start();
		}

		private void Tk_Bc_Transition_Tick(object sender, EventArgs e)
		{
			if (tkBcExplore)
			{
				if (panelTk_Bc.Height <= 43)
				{
					Tk_Bc_Transition.Stop();
					tkBcExplore = false;
				}
				else
				{
					panelTk_Bc.Height -= 10;
				}
			}
			else
			{
				panelTk_Bc.Height += 10;
				if (panelTk_Bc.Height >= 250)
				{
					Tk_Bc_Transition.Stop();
					tkBcExplore = true;
				}
			}
		}
		private void OpenChildForm(KryptonForm childForm)
		{
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}

			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;

			panelLoadForm.Controls.Add(childForm);
			panelLoadForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		private void kryBtHangHoaContainer_Click(object sender, EventArgs e)
		{
			HangHoa_Transition.Start();
		}

		private void kryBtHangHoa_Click(object sender, EventArgs e)
		{
			OpenChildForm(new HANGHOA_GUI());

		}

		private void btNhanVien_Click(object sender, EventArgs e)
		{
			OpenChildForm(new NHANVIEN_GUI());

		}
	}
}
