using System;
using Business;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace GameCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
            UsernameExists()
        }

        private void lbl_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* string username = "name";
            string password = "password";*/

            /*if (UsernameCorrect(tb_username.Text) && PasswordCorrect(tb_password.Text))
            {
                this.Hide();
                Main main = new Main();
                main.Show();
                main.Focus();

            }
            else
            {
                tb_username.Clear();
                tb_password.Clear();
                MessageBox.Show("Please enter valid username and password");
            }*/
        }
    }
}
