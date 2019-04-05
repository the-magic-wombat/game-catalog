namespace GameCatalog
{
    partial class AdminSettings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_game_title = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_image = new System.Windows.Forms.Label();
            this.lb_genre = new System.Windows.Forms.Label();
            this.lb_developer = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_link = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_developer = new System.Windows.Forms.TextBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lb_game_title);
            this.panel1.Location = new System.Drawing.Point(77, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 83);
            this.panel1.TabIndex = 13;
            // 
            // lb_game_title
            // 
            this.lb_game_title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_game_title.AutoSize = true;
            this.lb_game_title.Font = new System.Drawing.Font("Tahoma", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_game_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_title.Location = new System.Drawing.Point(17, 18);
            this.lb_game_title.Name = "lb_game_title";
            this.lb_game_title.Size = new System.Drawing.Size(242, 43);
            this.lb_game_title.TabIndex = 11;
            this.lb_game_title.Text = "Game Catalog";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(12, 102);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Game";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(154, 102);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 28);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete Game";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(297, 102);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 28);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Game";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(297, 402);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 28);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(12, 402);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 28);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_name.Location = new System.Drawing.Point(8, 147);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(66, 23);
            this.lb_name.TabIndex = 19;
            this.lb_name.Text = "Name:";
            // 
            // lb_description
            // 
            this.lb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_description.AutoSize = true;
            this.lb_description.BackColor = System.Drawing.Color.Transparent;
            this.lb_description.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_description.Location = new System.Drawing.Point(8, 170);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(110, 23);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "Description:";
            // 
            // lb_image
            // 
            this.lb_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_image.AutoSize = true;
            this.lb_image.BackColor = System.Drawing.Color.Transparent;
            this.lb_image.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_image.Location = new System.Drawing.Point(8, 361);
            this.lb_image.Name = "lb_image";
            this.lb_image.Size = new System.Drawing.Size(71, 23);
            this.lb_image.TabIndex = 21;
            this.lb_image.Text = "Image:";
            // 
            // lb_genre
            // 
            this.lb_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_genre.AutoSize = true;
            this.lb_genre.BackColor = System.Drawing.Color.Transparent;
            this.lb_genre.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_genre.Location = new System.Drawing.Point(8, 334);
            this.lb_genre.Name = "lb_genre";
            this.lb_genre.Size = new System.Drawing.Size(68, 23);
            this.lb_genre.TabIndex = 22;
            this.lb_genre.Text = "Genre:";
            // 
            // lb_developer
            // 
            this.lb_developer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_developer.AutoSize = true;
            this.lb_developer.BackColor = System.Drawing.Color.Transparent;
            this.lb_developer.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_developer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_developer.Location = new System.Drawing.Point(8, 305);
            this.lb_developer.Name = "lb_developer";
            this.lb_developer.Size = new System.Drawing.Size(101, 23);
            this.lb_developer.TabIndex = 23;
            this.lb_developer.Text = "Developer:";
            // 
            // lb_date
            // 
            this.lb_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_date.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_date.Location = new System.Drawing.Point(8, 279);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(56, 23);
            this.lb_date.TabIndex = 24;
            this.lb_date.Text = "Date:";
            this.lb_date.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_link
            // 
            this.lb_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_link.AutoSize = true;
            this.lb_link.BackColor = System.Drawing.Color.Transparent;
            this.lb_link.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lb_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_link.Location = new System.Drawing.Point(8, 253);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(50, 23);
            this.lb_link.TabIndex = 25;
            this.lb_link.Text = "Link:";
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.Enabled = false;
            this.tb_name.Location = new System.Drawing.Point(77, 150);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(337, 20);
            this.tb_name.TabIndex = 26;
            // 
            // txt_link
            // 
            this.txt_link.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_link.Enabled = false;
            this.txt_link.Location = new System.Drawing.Point(64, 253);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(350, 20);
            this.txt_link.TabIndex = 27;
            // 
            // txt_date
            // 
            this.txt_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_date.Enabled = false;
            this.txt_date.Location = new System.Drawing.Point(64, 282);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(350, 20);
            this.txt_date.TabIndex = 28;
            // 
            // txt_developer
            // 
            this.txt_developer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_developer.Enabled = false;
            this.txt_developer.Location = new System.Drawing.Point(115, 308);
            this.txt_developer.Name = "txt_developer";
            this.txt_developer.Size = new System.Drawing.Size(299, 20);
            this.txt_developer.TabIndex = 29;
            // 
            // txt_genre
            // 
            this.txt_genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_genre.Enabled = false;
            this.txt_genre.Location = new System.Drawing.Point(82, 334);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(332, 20);
            this.txt_genre.TabIndex = 30;
            // 
            // txt_image
            // 
            this.txt_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_image.Enabled = false;
            this.txt_image.Location = new System.Drawing.Point(82, 364);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(332, 20);
            this.txt_image.TabIndex = 31;
            // 
            // txt_description
            // 
            this.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_description.Enabled = false;
            this.txt_description.Location = new System.Drawing.Point(115, 176);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(299, 71);
            this.txt_description.TabIndex = 32;
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(426, 434);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_image);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.txt_developer);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_link);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_developer);
            this.Controls.Add(this.lb_genre);
            this.Controls.Add(this.lb_image);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "AdminSettings";
            this.Text = "Admin Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_game_title;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_image;
        private System.Windows.Forms.Label lb_genre;
        private System.Windows.Forms.Label lb_developer;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_link;
        public System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_developer;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.TextBox txt_description;
    }
}