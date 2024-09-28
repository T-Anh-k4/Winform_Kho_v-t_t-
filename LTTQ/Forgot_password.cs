using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ
{
    public partial class Forgot_password : Form
    {
        private Login _loginForm;
        public Forgot_password(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(textBox2.Text))
                { 
                label2.Text= $"A recovery email has been sent to \n{textBox2.Text} !";
                label2.Visible = true;       
                label5.Visible = false;
            }
            else 
                {
                label5.Visible = true;
                label2.Visible = false;
            }
        }


        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            return Regex.IsMatch(email, pattern);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
