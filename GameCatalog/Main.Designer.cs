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
            this.pb_test = new System.Windows.Forms.PictureBox();
            this.listBox_games = new System.Windows.Forms.ListBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.btn_clearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_test)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_test
            // 
            this.pb_test.Location = new System.Drawing.Point(147, 167);
            this.pb_test.Name = "pb_test";
            this.pb_test.Size = new System.Drawing.Size(618, 231);
            this.pb_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_test.TabIndex = 0;
            this.pb_test.TabStop = false;
            // 
            // listBox_games
            // 
            this.listBox_games.FormattingEnabled = true;
            this.listBox_games.Location = new System.Drawing.Point(1, 9);
            this.listBox_games.Name = "listBox_games";
            this.listBox_games.Size = new System.Drawing.Size(131, 498);
            this.listBox_games.TabIndex = 2;
            this.listBox_games.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(274, 10);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 6;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(147, 12);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(121, 21);
            this.comboBox_genre.TabIndex = 7;
            // 
            // btn_clearFilter
            // 
            this.btn_clearFilter.Location = new System.Drawing.Point(355, 10);
            this.btn_clearFilter.Name = "btn_clearFilter";
            this.btn_clearFilter.Size = new System.Drawing.Size(75, 23);
            this.btn_clearFilter.TabIndex = 8;
            this.btn_clearFilter.Text = "Clear";
            this.btn_clearFilter.UseVisualStyleBackColor = true;
            this.btn_clearFilter.Click += new System.EventHandler(this.btn_clearFilter_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 519);
            this.Controls.Add(this.btn_clearFilter);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.listBox_games);
            this.Controls.Add(this.pb_test);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_test;
        private System.Windows.Forms.ListBox listBox_games;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.Button btn_clearFilter;
    }
}