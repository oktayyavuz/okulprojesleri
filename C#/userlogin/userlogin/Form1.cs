using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace userlogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                if (username.Text == "nisa" && password.Text == "nisa123")
                {
                    Form2 ac = new Form2();
                    ac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı kulalnıcı adı veya şifre", "Hatalı Giriş Denemesi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    username.Text = "";
                    password.Text = "";
                    username.Focus();
                }
            }
            else
            {
                MessageBox.Show("Eksik Kullanıcı adı veya şifre girişi", "Eksik bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
                username.Focus();
            }
            
        }




    }
}
