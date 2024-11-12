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
	public partial class FORMLOAD_GUI : Form
	{
		public FORMLOAD_GUI()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(progressBar1.Value < 100)
			{
				progressBar1.Value += 1;
				label4.Text = progressBar1.Value.ToString() + "%";
			}
			else
			{
				timer1.Stop();
				LOGIN_GUI newform = new LOGIN_GUI();
                this.Hide();
                newform.Show();
            }
        }

		private void FORMLOAD_GUI_Load(object sender, EventArgs e)
		{
			timer1.Start();

		}
	}
}
