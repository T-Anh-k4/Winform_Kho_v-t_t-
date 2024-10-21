using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class KHO_GUI : Form
    {
        KHO_BUS kHOBUS;
        public KHO_GUI()
        {
            kHOBUS = new KHO_BUS();
            InitializeComponent();
            loadKho();
        }
        public void loadKho()
        {
            DataTable dt = new DataTable();
            dt = kHOBUS.GetDanhSachHangHoa();
            k_datagrview_hang_hoa.DataSource = dt;
        }
    }
}
