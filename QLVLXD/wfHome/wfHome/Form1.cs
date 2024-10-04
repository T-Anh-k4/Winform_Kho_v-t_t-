using FontAwesome.Sharp;
using GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace wfHome
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftboderbtn;
        private bool isDanhMucVisible = false; 
        private bool isBaoCaoVisible = false;
		private ElipseControl elipseControl;


		public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            leftboderbtn = new Panel();
            leftboderbtn.Size = new Size(5, 57);
            leftboderbtn.Location = new Point(0, icbt_trangchu.Location.Y);
            leftboderbtn.BackColor = Color.Red;
            leftboderbtn.Visible = true;
            panel_menu.Controls.Add(leftboderbtn);
            Button_Event();
            graphics();

		}
        private void graphics()
        {
			List<Control> buttons = new List<Control>()
			{
				icbt_trangchu, icbt_Danhmuc, icbt_huongdan, icbt_baocao,
				bt_Khach_hang, bt_hang_hoa, bt_Kho, bt_loai_hang,
				bt_nhap_hang, bt_xuat_hang, bt_Nha_cung_cap,
				bt_bc_Khach_hang, bt_bc_hang_hoa, bt_bc_Kho,
				bt_bc_loai_hang, bt_bc_nhap_hang, bt_bc_xuat_hang,
				bt_bc_Nha_cung_cap
			};

			foreach (Control btn in buttons)
			{
				ElipseControl elipse = new ElipseControl();
				elipse.TargetControl = btn;
				elipse.CornerRadius = 30;
			}
		}

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
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.LightGray;
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
                btn.BackColor = Color.White;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                Disablebutton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.LightBlue;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftboderbtn.BackColor = Color.Red;
                leftboderbtn.Location = new Point(0, currentBtn.Location.Y+143);
                leftboderbtn.Visible = true;
                leftboderbtn.BringToFront();
            }
        }

        private void Disablebutton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
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

        private void icbt_Danhmuc_Click(object sender, EventArgs e)
        {
            isDanhMucVisible = !isDanhMucVisible;
            pn_danh_muc.Visible = isDanhMucVisible;
            if (isDanhMucVisible)
            {
                pn_bao_cao.Visible = false;
                isBaoCaoVisible = false;
            }
        }

        private void icbt_baocao_Click(object sender, EventArgs e)
        {
            isBaoCaoVisible = !isBaoCaoVisible;
            pn_bao_cao.Visible = isBaoCaoVisible;
            if (isBaoCaoVisible)
            {
                pn_danh_muc.Visible = false;
                isDanhMucVisible = false;
            }
        }

        private void icbt_huongdan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Gray);
        }
	}
}
