<<<<<<< HEAD:GameCatalog/LogInWindow.cs
<<<<<<< HEAD:GameCatalog/Form1.cs
﻿using System;
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
    public partial class Form1 : Form
    {
        private GameBusiness gameBusiness = new GameBusiness();
        private AccountBusiness accountBusiness = new AccountBusiness();

        public Form1()
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
                //this.Hide();              
                Main main = new Main();
                if(accountBusiness.IsAdmin(tb_username.Text))
                {
                    main.btnAdmin.Visible = true;
                }
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
=======
﻿using System;
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
>>>>>>> 703a38a770507cefcdf7d8d0ee0c09674e8580bf:GameCatalog/LogInWindow.cs
=======
﻿using System;
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
    public partial class Form1 : Form
    {
        private GameBusiness gameBusiness = new GameBusiness();
        private AccountBusiness accountBusiness = new AccountBusiness();

        public Form1()
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
                //this.Hide();              
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
>>>>>>> parent of 703a38a... Made a better log in window:GameCatalog/Form1.cs
