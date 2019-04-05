using System;
using Business;
using Data.Models;
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
    public partial class AdminSettings : Form
    {
        Random random = new Random();
        private GameBusiness gameBusiness = new GameBusiness();
        private Game game = new Game();
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.btnAdmin.Visible = true;
            main.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            tb_name.Enabled = true;
            txt_description.Enabled = true;
            txt_link.Enabled = true;
            txt_date.Enabled = true;
            txt_developer.Enabled = true;
            txt_genre.Enabled = true;
            txt_image.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            tb_name.Enabled = true;
            lb_description.Visible = false;
            txt_description.Visible = false;
            lb_link.Visible = false;
            txt_link.Visible = false;
            lb_date.Visible = false;
            txt_date.Visible = false;
            lb_developer.Visible = false;
            txt_developer.Visible = false;
            lb_genre.Visible = false;
            txt_genre.Visible = false;
            lb_image.Visible = false;
            txt_image.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            tb_name.Enabled = true;
            txt_description.Enabled = true;
            txt_link.Enabled = true;
            txt_date.Enabled = true;
            txt_developer.Enabled = true;
            txt_genre.Enabled = true;
            txt_image.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled == false && btnUpdate.Enabled == false)
            {
                game.Id = random.Next(4, 2147483647);
                game.Name = tb_name.Text;
                game.Description = txt_description.Text;
                game.Link = txt_link.Text;
                game.Date = txt_date.Text;
                game.Developer = txt_developer.Text;
                game.Genre = txt_genre.Text;
                game.Image = txt_image.Text;
                gameBusiness.Add(game);
            }
            else if (btnAdd.Enabled == false && btnUpdate.Enabled == false)
            {
                gameBusiness.Delete(tb_name.Text);
            }
            else
            {
                game.Id = random.Next(4, 2147483647);
                game.Name = tb_name.Text;
                game.Description = txt_description.Text;
                game.Link = txt_link.Text;
                game.Date = txt_date.Text;
                game.Developer = txt_developer.Text;
                game.Genre = txt_genre.Text;
                game.Image = txt_image.Text;
                gameBusiness.Update(game);
            }
            lb_description.Visible = true;
            txt_description.Visible = true;
            lb_link.Visible = true;
            txt_link.Visible = true;
            lb_date.Visible = true;
            txt_date.Visible = true;
            lb_developer.Visible = true;
            txt_developer.Visible = true;
            lb_genre.Visible = true;
            txt_genre.Visible = true;
            lb_image.Visible = true;
            txt_image.Visible = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
        }
    }
}
