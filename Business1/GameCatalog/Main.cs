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
            pb_picture.Image = Image.FromFile(absolutePath);

            List<Game> games = gameBusiness.GetAll();

            foreach(var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }

            listBox_games.SelectedItem = listBox_games.Items[0];    //sets default selected item of the listbox to the first one

            

            foreach (var item in games)
            {
                //fils genre filter
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

                //fills developer filter
                bool developerExists = false;

                foreach(var developer in comboBox_developer.Items)
                {
                    if((string)developer == item.Developer)
                    {
                        developerExists = true;
                    }
                }

                if(!developerExists)
                {
                    comboBox_developer.Items.Add(item.Developer);
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            listBox_games.Items.Clear();

            List<Game> games = GameFilter();
            
            foreach (var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }

            listBox_games.SelectedItem = listBox_games.Items[0];
        }

        private List<Game> GameFilter()
        {
            List<Game> games = gameBusiness.GetAll();
            List<Game> games_filtered = new List<Game>();
            
            if(comboBox_genre.Text == "" && comboBox_developer.Text == "")
            {
                return games;
            }
            else if(comboBox_genre.Text != "" && comboBox_developer.Text == "")
            {
                games = gameBusiness.FindByGenre(comboBox_genre.Text);
                return games;
            }
            else if(comboBox_genre.Text == "" && comboBox_developer.Text != "")
            {
                games = gameBusiness.FindByDeveloper(comboBox_developer.Text);
                return games;
            }
            else
            {
                foreach(var game in games)
                {
                    if(game.Genre == comboBox_genre.Text && game.Developer == comboBox_developer.Text)
                    {
                        games_filtered.Add(game);
                    }                  
                }
                return games_filtered;
            }
        }

        private void btn_clearFilter_Click(object sender, EventArgs e)
        {
            comboBox_genre.Text = "";
            comboBox_developer.Text = "";

            listBox_games.Items.Clear();

            List<Game> games = gameBusiness.GetAll();

            foreach (var item in games)
            {
                listBox_games.Items.Add(item.Name);
            }

            listBox_games.SelectedItem = listBox_games.Items[0];
        }

        private void listBox_games_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game selectedGame = gameBusiness.FindByName(listBox_games.SelectedItem.ToString());

            //changes items to the selected game's ones        
            string absolutePath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath))), @"Images\", selectedGame.Image);
            pb_picture.Image = Image.FromFile(absolutePath);
            lb_game_title.Text = selectedGame.Name;
            lb_game_description.Text = selectedGame.Description;
            lb_game_developer.Text = "Developer: " + selectedGame.Developer;
            lb_game_release_date.Text = "Release Date: " + selectedGame.Date;
            lb_game_genre.Text = "Genre: " + selectedGame.Genre;
        }

        private void lb_game_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Game selectedGame = gameBusiness.FindByName(listBox_games.SelectedItem.ToString());
            System.Diagnostics.Process.Start(selectedGame.Link);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminSettings adminSettings = new AdminSettings();
            this.Hide();
            adminSettings.ShowDialog();
            this.Close();
        }
    }
}
