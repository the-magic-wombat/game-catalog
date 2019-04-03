using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using Data.Models;

namespace GameCatalog
{
    public partial class Main : Form
    {
        private GameBusiness gameBusiness = new GameBusiness();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string absolutePath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath))), @"Images\", gameBusiness.FindByName("Team Fortress 2").Image);
            pb_test.Image = Image.FromFile(absolutePath);

            List<Game> games = gameBusiness.GetAll();

            foreach(var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }

            foreach(var item in games)
            {
                bool genreExists = false;
           
                foreach (var genre in comboBox_genre.Items)
                {
                    if((string)genre == item.Genre)
                    {
                        genreExists = true;
                    }                
                }

                if (!genreExists)
                {
                    comboBox_genre.Items.Add(item.Genre);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox_games.SelectedItem.ToString();

            string absolutePath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath))), @"Images\", gameBusiness.FindByName(selectedItem).Image);
            pb_test.Image = Image.FromFile(absolutePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox_games.SelectedItem.ToString();

            string absolutePath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath))), @"Images\", gameBusiness.FindByName(selectedItem).Image);
            pb_test.Image = Image.FromFile(absolutePath);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            listBox_games.Items.Clear();

            List<Game> games = gameBusiness.FindByGenre(comboBox_genre.Text);

            foreach (var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            comboBox_genre.Text = "";
            listBox_games.Items.Clear();

            List<Game> games = gameBusiness.GetAll();

            foreach (var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }
        }
    }
}
