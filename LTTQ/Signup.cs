using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ.Resources
{
    public partial class Signup : Form
    {
        private Login _loginForm;

        public Signup(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Close();
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!_loginForm.Visible)
                _loginForm.Close();
        }
    }
}
