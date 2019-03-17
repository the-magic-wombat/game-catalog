using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void lbl_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = "name";
            string password = "password";

            if (tb_username.Text == username && tb_password.Text == password)
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
            }
        }
    }
}
