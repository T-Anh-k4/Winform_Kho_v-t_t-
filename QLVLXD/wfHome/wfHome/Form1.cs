using FontAwesome.Sharp;
using System;
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
        private Timer showTimer;
        private int targetHeight;

        public Form1()
        {
            InitializeComponent();
			this.DoubleBuffered = true;
			leftboderbtn = new Panel();
            leftboderbtn.Size = new Size(7, 57);
            leftboderbtn.Location = new Point(0, icbt_trangchu.Location.Y);
            leftboderbtn.BackColor = Color.Red;
            leftboderbtn.Visible = true;
            panel_menu.Controls.Add(leftboderbtn);

            showTimer = new Timer();
            showTimer.Interval = 1; // Thay đổi giá trị này để điều chỉnh tốc độ
            showTimer.Tick += new EventHandler(ShowTimer_Tick);

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

		private void ShowTimer_Tick(object sender, EventArgs e)
		{
			// Tăng hoặc giảm chiều cao của panel dựa trên targetHeight
			if (pn_danh_muc.Height < targetHeight)
			{
				pn_danh_muc.Height += 15; // Tăng chiều cao
			}
			else if (pn_danh_muc.Height > targetHeight)
			{
				pn_danh_muc.Height -= 15; // Giảm chiều cao
			}

			// Kiểm tra nếu chiều cao đạt mục tiêu thì dừng timer
			if (pn_danh_muc.Height == targetHeight)
			{
				showTimer.Stop();
				if (targetHeight == 0)
				{
					pn_danh_muc.Visible = false; // Ẩn panel khi chiều cao đạt 0
				}
			}

			// Tương tự cho panel báo cáo
			if (pn_bao_cao.Height < targetHeight)
			{
				pn_bao_cao.Height += 15; // Tăng chiều cao
			}
			else if (pn_bao_cao.Height > targetHeight)
			{
				pn_bao_cao.Height -= 15; // Giảm chiều cao
			}

			// Kiểm tra nếu chiều cao đạt mục tiêu thì dừng timer
			if (pn_bao_cao.Height == targetHeight)
			{
				showTimer.Stop();
				if (targetHeight == 0)
				{
					pn_bao_cao.Visible = false; 
				}
			}
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
                currentBtn.BackColor = Color.LightGray;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftboderbtn.BackColor = Color.Red;
                leftboderbtn.Location = new Point(0, currentBtn.Location.Y);
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
            targetHeight = isDanhMucVisible ? 436 : 0; 

            if (isDanhMucVisible)
            {
                pn_bao_cao.Visible = false; 
                isBaoCaoVisible = false; 
                pn_danh_muc.Visible = true; 
            }
            showTimer.Start(); 
        }

        private void icbt_baocao_Click(object sender, EventArgs e)
        {
   
            isBaoCaoVisible = !isBaoCaoVisible;
            targetHeight = isBaoCaoVisible ? 436 : 0; 

            if (isBaoCaoVisible)
            {
                pn_danh_muc.Visible = false; 
                isDanhMucVisible = false; 
                pn_bao_cao.Visible = true; 
            }
            showTimer.Start(); 
        }

		private void icbt_huongdan_Click(object sender, EventArgs e)
        {
        ActivateButton(sender, Color.Gray);
        }
    }
}
