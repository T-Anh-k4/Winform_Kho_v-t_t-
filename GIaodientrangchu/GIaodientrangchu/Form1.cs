using System;
using System.Drawing;
using System.Windows.Forms;

namespace GIaodientrangchu
{
    public partial class Form1 : Form
    {
        private Button selectedButton; //  lưu nút hiện tại đang được chọn
        private Panel selectedPanel;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        // Hàm xử lý sự kiện chung cho MouseEnter
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel pn = sender as Panel;
            if (btn != null && btn != selectedButton) // Kiểm tra nếu nút không phải nút hiện tại được chọn
            {
                btn.BackColor = Color.LightSkyBlue;
            }
            else if(pn != null && pn != selectedPanel)
            {
                pn.Size = new Size(50, 49);
            }    
        }

        // Hàm xử lý sự kiện chung cho MouseLeave
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Panel pn = sender as Panel;
            if (btn != null && btn != selectedButton) 
            {
                btn.BackColor = Color.White;
            }
            else if (pn!=null && pn != selectedPanel)
            {
                pn.Size = new Size(40, 39);
            }
        }

        // Hàm xử lý sự kiện Click để chọn nút
        private void Button_Click(object sender, EventArgs e)
        {
            // Reset màu của nút trước đó
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.White;
            }

            // Đặt nút hiện tại là nút được chọn và thay đổi màu
            selectedButton = sender as Button;
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.LightSkyBlue;
            }
        }

        private void init()
        {
            // chỉnh chữ
            btn_customer.Padding = new Padding(20, 5, 10, 5);
            btn_indeltails.Padding = new Padding(55, 5, 10, 5);
            btn_stockout.Padding = new Padding(17, 5, 10, 5);
            btn_outdetails.Padding = new Padding(65, 5, 10, 5);
            btn_Employees.Padding = new Padding(25, 5, 10, 5);
            // Gán sự kiện chung cho các button
            btn_customer.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_customer.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_material.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_material.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_StockIn.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_StockIn.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_indeltails.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_indeltails.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_stockout.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_stockout.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_outdetails.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_outdetails.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_Employees.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_Employees.MouseLeave += new EventHandler(Button_MouseLeave);
            btn_login.MouseEnter += new EventHandler(Button_MouseEnter);
            btn_login.MouseLeave += new EventHandler(Button_MouseLeave);
            pn_setting.MouseEnter += new EventHandler(Button_MouseEnter);
            pn_setting.MouseLeave += new EventHandler(Button_MouseLeave);
            pn_chat.MouseEnter += new EventHandler(Button_MouseEnter);
            pn_chat.MouseLeave += new EventHandler(Button_MouseLeave);
            // Gán sự kiện click để chọn nút
            btn_customer.Click += new EventHandler(Button_Click);
            btn_material.Click += new EventHandler(Button_Click);
            btn_StockIn.Click += new EventHandler(Button_Click);
            btn_indeltails.Click += new EventHandler(Button_Click);
            btn_stockout.Click += new EventHandler(Button_Click);
            btn_outdetails.Click += new EventHandler(Button_Click);
            btn_Employees.Click += new EventHandler(Button_Click);
            btn_login.Click += new EventHandler(Button_Click);
        }
    }
}
