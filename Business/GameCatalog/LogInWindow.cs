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
using Data.Models;
namespace GameCatalog
{
    public partial class LogInWindow : Form
    {
        private GameBusiness gameBusiness = new GameBusiness();
        private AccountBusiness accountBusiness = new AccountBusiness();

        public LogInWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void lbl_sign_in_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (accountBusiness.UsernameCorrect(tb_username.Text) && accountBusiness.PasswordCorrect(tb_password.Text, tb_username.Text))
            {                       
                Main main = new Main();
                this.Hide();
                if(accountBusiness.IsAdmin(tb_username.Text))
                {
                    main.btnAdmin.Visible = true;
                }
                main.ShowDialog();
                this.Close();
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
