namespace GameCatalog
{
    partial class LogInWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sign_in = new System.Windows.Forms.LinkLabel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_game_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(20, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(21, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // lbl_sign_in
            // 
            this.lbl_sign_in.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lbl_sign_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sign_in.AutoSize = true;
            this.lbl_sign_in.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sign_in.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sign_in.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            this.lbl_sign_in.Location = new System.Drawing.Point(52, 245);
            this.lbl_sign_in.Name = "lbl_sign_in";
            this.lbl_sign_in.Size = new System.Drawing.Size(68, 23);
            this.lbl_sign_in.TabIndex = 2;
            this.lbl_sign_in.TabStop = true;
            this.lbl_sign_in.Text = "Sign in";
            this.lbl_sign_in.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            this.lbl_sign_in.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_sign_in_LinkClicked);
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_username.Location = new System.Drawing.Point(122, 139);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(162, 20);
            this.tb_username.TabIndex = 6;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.Location = new System.Drawing.Point(122, 188);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(162, 20);
            this.tb_password.TabIndex = 7;
            // 
            // lb_game_title
            // 
            this.lb_game_title.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_game_title.AutoSize = true;
            this.lb_game_title.Font = new System.Drawing.Font("Tahoma", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_game_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.lb_game_title.Location = new System.Drawing.Point(19, 20);
            this.lb_game_title.Name = "lb_game_title";
            this.lb_game_title.Size = new System.Drawing.Size(242, 43);
            this.lb_game_title.TabIndex = 11;
            this.lb_game_title.Text = "Game Catalog";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lb_game_title);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 83);
            this.panel1.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            this.linkLabel1.Location = new System.Drawing.Point(174, 245);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 23);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(193)))), ((int)(((byte)(242)))));
            // 
            // LogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(300, 301);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_sign_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogInWindow";
            this.Text = "Game Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbl_sign_in;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_game_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

