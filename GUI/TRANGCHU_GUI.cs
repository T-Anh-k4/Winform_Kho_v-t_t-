using BUS;
using ComponentFactory.Krypton.Toolkit;
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
    public partial class TRANGCHU_GUI : KryptonForm
    {
        TRANGCHU_BUS homeBUS = new TRANGCHU_BUS();
        public TRANGCHU_GUI()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            int month = DateTime.Now.Month - 1;
            lbtongtiennhap.Text = Convert.ToString(homeBUS.TongTienNhap(month));
            lbtonghangnhap.Text = Convert.ToString(homeBUS.TongHangNhap(month));
            lbtonghangton.Text = Convert.ToString(homeBUS.TongHangTon(month));

            DataTable dt = new DataTable();

        }
        public void CartesianChart(DataTable dt)
        {

        }

    }
}
