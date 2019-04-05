namespace GameCatalog
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBox_games = new System.Windows.Forms.ListBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.btn_clearFilter = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.comboBox_developer = new System.Windows.Forms.ComboBox();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.lb_game_title = new System.Windows.Forms.Label();
            this.lb_game_description = new System.Windows.Forms.Label();
            this.lb_game_release_date = new System.Windows.Forms.Label();
            this.lb_game_developer = new System.Windows.Forms.Label();
            this.lb_game_genre = new System.Windows.Forms.Label();
            this.lb_game_link = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_games
            // 
            this.listBox_games.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBox_games.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.listBox_games.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_games.Font = new System.Drawing.Font("Tahoma", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_games.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.listBox_games.FormattingEnabled = true;
            this.listBox_games.ItemHeight = 18;
            this.listBox_games.Location = new System.Drawing.Point(5, 92);
            this.listBox_games.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_games.Name = "listBox_games";
            this.listBox_games.Size = new System.Drawing.Size(180, 414);
            this.listBox_games.TabIndex = 2;
            this.listBox_games.SelectedIndexChanged += new System.EventHandler(this.listBox_games_SelectedIndexChanged);
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_filter.Location = new System.Drawing.Point(8, 46);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(81, 28);
            this.btn_filter.TabIndex = 6;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(8, 14);
            this.comboBox_genre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(81, 24);
            this.comboBox_genre.TabIndex = 7;
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btn_clearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clearFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clearFilter.Location = new System.Drawing.Point(94, 46);
            this.btn_clearFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Size = new System.Drawing.Size(81, 28);
            this.btn_clearFilter.TabIndex = 8;
            this.btn_clearFilter.Text = "Clear";
            this.btn_clearFilter.UseVisualStyleBackColor = false;
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.panel_left.Controls.Add(this.listBox_games);
            this.panel_left.Controls.Add(this.comboBox_developer);
            this.panel_left.Controls.Add(this.btn_filter);
            this.panel_left.Controls.Add(this.comboBox_genre);
            this.panel_left.Controls.Add(this.btn_clearFilter);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(186, 506);
            this.panel_left.TabIndex = 9;
            // 
            // comboBox_developer
            // 
            this.comboBox_developer.FormattingEnabled = true;
            this.comboBox_developer.Location = new System.Drawing.Point(94, 14);
            this.comboBox_developer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_developer.Name = "comboBox_developer";
            this.comboBox_developer.Size = new System.Drawing.Size(81, 24);
            this.comboBox_developer.TabIndex = 9;
            // 
            // pb_picture
            // 
            this.pb_picture.Location = new System.Drawing.Point(195, 55);
            this.pb_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(460, 215);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 0;
            this.pb_picture.TabStop = false;
            // 
            // lb_game_title
            // 
            this.lb_game_title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_game_title.AutoSize = true;
            this.lb_game_title.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_game_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_title.Location = new System.Drawing.Point(191, 12);
            this.lb_game_title.Name = "lb_game_title";
            this.lb_game_title.Size = new System.Drawing.Size(66, 33);
            this.lb_game_title.TabIndex = 10;
            this.lb_game_title.Text = "Title";
            // 
            // lb_game_description
            // 
            this.lb_game_description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_game_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_description.Location = new System.Drawing.Point(191, 285);
            this.lb_game_description.Name = "lb_game_description";
            this.lb_game_description.Size = new System.Drawing.Size(460, 130);
            this.lb_game_description.TabIndex = 11;
            this.lb_game_description.Text = "Description";
            // 
            // lb_game_release_date
            // 
            this.lb_game_release_date.AutoSize = true;
            this.lb_game_release_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_release_date.Location = new System.Drawing.Point(192, 457);
            this.lb_game_release_date.Name = "lb_game_release_date";
            this.lb_game_release_date.Size = new System.Drawing.Size(88, 16);
            this.lb_game_release_date.TabIndex = 12;
            this.lb_game_release_date.Text = "Release Date:";
            // 
            // lb_game_developer
            // 
            this.lb_game_developer.AutoSize = true;
            this.lb_game_developer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_developer.Location = new System.Drawing.Point(192, 425);
            this.lb_game_developer.Name = "lb_game_developer";
            this.lb_game_developer.Size = new System.Drawing.Size(70, 16);
            this.lb_game_developer.TabIndex = 13;
            this.lb_game_developer.Text = "Developer:";
            // 
            // lb_game_genre
            // 
            this.lb_game_genre.AutoSize = true;
            this.lb_game_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_genre.Location = new System.Drawing.Point(192, 441);
            this.lb_game_genre.Name = "lb_game_genre";
            this.lb_game_genre.Size = new System.Drawing.Size(47, 16);
            this.lb_game_genre.TabIndex = 14;
            this.lb_game_genre.Text = "Genre:";
            // 
            // lb_game_link
            // 
            this.lb_game_link.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lb_game_link.AutoSize = true;
            this.lb_game_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            this.lb_game_link.Location = new System.Drawing.Point(192, 473);
            this.lb_game_link.Name = "lb_game_link";
            this.lb_game_link.Size = new System.Drawing.Size(91, 16);
            this.lb_game_link.TabIndex = 16;
            this.lb_game_link.TabStop = true;
            this.lb_game_link.Text = "Official Webite";
            this.lb_game_link.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            this.lb_game_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_game_link_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 506);
            this.panel1.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(669, 506);
            this.Controls.Add(this.lb_game_link);
            this.Controls.Add(this.lb_game_genre);
            this.Controls.Add(this.lb_game_developer);
            this.Controls.Add(this.lb_game_release_date);
            this.Controls.Add(this.lb_game_description);
            this.Controls.Add(this.lb_game_title);
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Game Catalog";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_games;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.Button btn_clearFilter;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.ComboBox comboBox_developer;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label lb_game_title;
        private System.Windows.Forms.Label lb_game_description;
        private System.Windows.Forms.Label lb_game_release_date;
        private System.Windows.Forms.Label lb_game_developer;
        private System.Windows.Forms.Label lb_game_genre;
        private System.Windows.Forms.LinkLabel lb_game_link;
        private System.Windows.Forms.Panel panel1;
    }
}