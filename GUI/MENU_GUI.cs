using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	public partial class MENU_GUI : KryptonForm
	{
		private KryptonForm currentChildForm;
		private IconButton currentBtn;
		private bool isDanhMucVisible = false;
		private bool isBaoCaoVisible = false;
		private bool danhMucExplore = true;
		private bool BaoCaoExplore = true;
		public MENU_GUI()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			Button_Event();
			//graphics();
			init();
		}
		public void init()
		{
			pn_danh_muc.Visible = false;
			pn_danh_muc.Height = 0;
			pn_bao_cao.Visible = false;
			pn_bao_cao.Height = 0;
		}

		//private void graphics()
		//{
		//	List<Control> buttons = new List<Control>()
		//	{
		//		icbt_trangchu, icbt_Danhmuc, icbt_huongdan, icbt_baocao,
		//	};

		//	foreach (Control btn in buttons)
		//	{
		//		ElipseControl elipse = new ElipseControl();
		//		elipse.TargetControl = btn;
		//		elipse.CornerRadius = 30;
		//	}
		//}
		private void Button_Event()
		{

			icbt_trangchu.MouseEnter += new EventHandler(IconButton_MouseEnter);
			icbt_trangchu.MouseLeave += new EventHandler(IconButton_MouseLeave);
			icbt_Danhmuc.MouseEnter += new EventHandler(IconButton_MouseEnter);
			icbt_Danhmuc.MouseLeave += new EventHandler(IconButton_MouseLeave);
			icbt_baocao.MouseEnter += new EventHandler(IconButton_MouseEnter);
			icbt_baocao.MouseLeave += new EventHandler(IconButton_MouseLeave);
			icbt_huongdan.MouseEnter += new EventHandler(IconButton_MouseEnter);
			icbt_huongdan.MouseLeave += new EventHandler(IconButton_MouseLeave);

			bt_Khach_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_Khach_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_hang_hoa.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_hang_hoa.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_Kho.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_Kho.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_loai_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_loai_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_nhap_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_nhap_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_Nha_cung_cap.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_Nha_cung_cap.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_xuat_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_xuat_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);

			bt_bc_Khach_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_Khach_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_hang_hoa.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_hang_hoa.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_Kho.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_Kho.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_loai_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_loai_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_nhap_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_nhap_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_Nha_cung_cap.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_Nha_cung_cap.MouseLeave += new EventHandler(IconButton_MouseLeave);
			bt_bc_xuat_hang.MouseEnter += new EventHandler(IconButton_MouseEnter);
			bt_bc_xuat_hang.MouseLeave += new EventHandler(IconButton_MouseLeave);

		}
		private void IconButton_MouseEnter(object sender, EventArgs e)
		{
			IconButton btn = (IconButton)sender;
			btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size + 2);
			if (btn == icbt_trangchu || btn == icbt_Danhmuc || btn == icbt_baocao || btn == icbt_huongdan)
			{
				ActivateButton(sender, Color.Gray);
				btn.IconSize += 5;
			}
			else
			{
				btn.ForeColor = Color.DarkViolet;
				btn.BackColor = Color.WhiteSmoke;
			}
		}

		private void IconButton_MouseLeave(object sender, EventArgs e)
		{
			IconButton btn = (IconButton)sender;
			btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size - 2);
			if (btn == icbt_trangchu || btn == icbt_Danhmuc || btn == icbt_baocao || btn == icbt_huongdan)
			{
				Disablebutton();
				btn.IconSize -= 5;
			}
			else
			{
				btn.ForeColor = Color.Gray;
				btn.BackColor = Color.WhiteSmoke;
			}
		}

		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				Disablebutton();

				currentBtn = (IconButton)senderBtn;
				currentBtn.BackColor = Color.DarkViolet;
				currentBtn.ForeColor = Color.White;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = Color.White;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;

				iconcurrenform.IconChar = currentBtn.IconChar;
				iblformtitle.Text = currentBtn.Text;

			}
		}

		private void Disablebutton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.WhiteSmoke;
				currentBtn.ForeColor = Color.Gray;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Gray;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}
	

		private void icbt_trangchu_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.Gray);

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

			panel3.Controls.Add(childForm);
			panel3.Tag = childForm;
			childForm.BringToFront();
			childForm.Show(); 

	
		}

		private void icbt_Danhmuc_Click(object sender, EventArgs e)
		{
			isDanhMucVisible = !isDanhMucVisible;
			pn_danh_muc.Visible = true;
			Danh_muc_Transition.Start();
			if (isDanhMucVisible)
			{
				Bao_cao_Transition.Stop();
			}
		}

		private void icbt_baocao_Click(object sender, EventArgs e)
		{
			isBaoCaoVisible = !isBaoCaoVisible;
			pn_bao_cao.Visible = true;
			Bao_cao_Transition.Start();
			if (isBaoCaoVisible)
			{
				Danh_muc_Transition.Stop();
			}
		}


		private void icbt_huongdan_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.Gray);
			OpenChildForm(new HUONGDAN_GUI());
		}

		private void Danh_muc_Transition_Tick(object sender, EventArgs e)
		{
			if (danhMucExplore)
			{
				pn_danh_muc.Height -= 10;
				if (pn_danh_muc.Height <= 0)
				{
					pn_danh_muc.Visible = false;
					Danh_muc_Transition.Stop();
					danhMucExplore = false;
				}
			}
			else
			{
				pn_danh_muc.Height += 10;
				if (pn_danh_muc.Height >= 279)
				{
					Danh_muc_Transition.Stop();
					danhMucExplore = true;
				}
			}
		}

		private void Bao_cao_Transition_Tick(object sender, EventArgs e)
		{
			if (BaoCaoExplore)
			{
				pn_bao_cao.Height -= 10;
				if (pn_bao_cao.Height <= 0)
				{
					pn_bao_cao.Visible = false;
					Bao_cao_Transition.Stop();
					BaoCaoExplore = false;
				}
			}
			else
			{
				pn_bao_cao.Height += 10;
				if (pn_bao_cao.Height >= 210)
				{
					Bao_cao_Transition.Stop();
					BaoCaoExplore = true;
				}
			}
		}

		private void bt_loai_hang_Click(object sender, EventArgs e)
		{
			OpenChildForm(new LOAIHANG_GUI());
		}

		private void bt_hang_hoa_Click(object sender, EventArgs e)
		{
			OpenChildForm(new HANGHOA_GUI());

		}

		private void bt_Nhan_vien_Click(object sender, EventArgs e)
		{
			OpenChildForm(new NHANVIEN_GUI());

		}

		private void bt_tai_khoan_Click(object sender, EventArgs e)
		{
			OpenChildForm(new USER_GUI());

		}
	}
}
