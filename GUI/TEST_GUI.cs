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

		private bool BaoCaoExplore = true;
		public TEST_GUI()
		{
			InitializeComponent();
			Init();
		}
		public void Init()
		{
			//palDoanhMuc.Visible = false;
			panelDoanhMuc.Height = 60;
			palHangHoa.Height = 0;
		}

		private void Danh_muc_Transition_Tick(object sender, EventArgs e)
		{
			if (danhMucExplore)
			{
				panelDoanhMuc.Height -= 10;
				if (panelDoanhMuc.Height <= 50)
				{
					Danh_muc_Transition.Stop();
					danhMucExplore = false;
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

		private void kryBtDoanhMuc_MouseEnter(object sender, EventArgs e)
		{
			kryBtDoanhMuc.StateCommon.Back.Color1 = Color.MediumPurple;
			kryBtDoanhMuc.StateCommon.Back.Color2 = Color.MediumSlateBlue;
			kryBtDoanhMuc.StateCommon.Content.ShortText.Color1 = Color.White;
		}

		private void kryBtDoanhMuc_MouseLeave(object sender, EventArgs e)
		{

			kryBtDoanhMuc.StateCommon.Content.ShortText.Color1 = Color.Black;
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
				if (palHangHoa.Height >= 180)
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
			Danh_muc_Transition.Start();
		}

		private void kryBtHangHoa_Click(object sender, EventArgs e)
		{
			HangHoa_Transition.Start();
		}
	}
}
