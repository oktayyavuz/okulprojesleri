using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace restoranProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usertxt.Text != "" && passtxt.Text != "")
            {
                String adminuser, adminpass, user, pass;
                adminuser = "admin";
                adminpass = "admin";
                user = "kullanıcı";
                pass = "12345";

                if (usertxt.Text.Equals(adminuser) && passtxt.Text.Equals(adminpass))
                {
                    Form3 ac = new Form3();
                    ac.ShowDialog();
                }
                else if (usertxt.Text.Equals(user) && passtxt.Text.Equals(pass))
                {
                    Form4 ac = new Form4();
                    ac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli bir kullanıcı adı veya şifre giriniz.", "Hata",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm kutucukları doldurunuz.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
