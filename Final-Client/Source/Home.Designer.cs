namespace Quiz_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Login = new Quiz_Project.CustomButton();
            this.lb_informLogin = new System.Windows.Forms.Label();
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.password = new Quiz_Project.LoginControl();
            this.username = new Quiz_Project.LoginControl();
            this.registerNow = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(128, 815);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bạn Chưa Có Tài Khoản?";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(724, 294);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(4, 16);
            this.label5.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.lb_informLogin);
            this.panel1.Controls.Add(this.forgotPass);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.registerNow);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(493, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 554);
            this.panel1.TabIndex = 30;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Login.BorderRadius = 20;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Purple;
            this.btn_Login.Location = new System.Drawing.Point(141, 331);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(260, 47);
            this.btn_Login.TabIndex = 42;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lb_informLogin
            // 
            this.lb_informLogin.AutoSize = true;
            this.lb_informLogin.Location = new System.Drawing.Point(138, 311);
            this.lb_informLogin.Name = "lb_informLogin";
            this.lb_informLogin.Size = new System.Drawing.Size(0, 13);
            this.lb_informLogin.TabIndex = 41;
            // 
            // forgotPass
            // 
            this.forgotPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.forgotPass.AutoSize = true;
            this.forgotPass.BackColor = System.Drawing.Color.Transparent;
            this.forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.forgotPass.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.forgotPass.Location = new System.Drawing.Point(281, 448);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(120, 20);
            this.forgotPass.TabIndex = 40;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Quên Mật Khẩu";
            this.forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPass_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox4.BackgroundImage = global::Quiz_Project.Properties.Resources.eye;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(378, 271);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.password.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.password.BoderColor = System.Drawing.Color.Lavender;
            this.password.BoderFocusColor = System.Drawing.Color.HotPink;
            this.password.BoderSize = 2;
            this.password.BorderRadius = 0;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(138, 260);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.password.PasswordChar = true;
            this.password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password.PlaceholderText = "";
            this.password.Size = new System.Drawing.Size(263, 43);
            this.password.TabIndex = 38;
            this.password.UderlinedStyle = true;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.username.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.username.BoderColor = System.Drawing.Color.Lavender;
            this.username.BoderFocusColor = System.Drawing.Color.HotPink;
            this.username.BoderSize = 2;
            this.username.BorderRadius = 0;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(138, 197);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "";
            this.username.Size = new System.Drawing.Size(263, 43);
            this.username.TabIndex = 37;
            this.username.UderlinedStyle = true;
            // 
            // registerNow
            // 
            this.registerNow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.registerNow.AutoSize = true;
            this.registerNow.BackColor = System.Drawing.Color.Transparent;
            this.registerNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerNow.DisabledLinkColor = System.Drawing.Color.LightBlue;
            this.registerNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerNow.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.registerNow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerNow.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.registerNow.Location = new System.Drawing.Point(134, 448);
            this.registerNow.Name = "registerNow";
            this.registerNow.Size = new System.Drawing.Size(109, 20);
            this.registerNow.TabIndex = 36;
            this.registerNow.TabStop = true;
            this.registerNow.Text = "Đăng Ký Ngay";
            this.registerNow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerNow_LinkClicked);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(32, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mật Khẩu";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(32, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tài Khoản";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightBlue;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(150, 120);
            this.label9.MaximumSize = new System.Drawing.Size(225, 73);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(48, 24, 48, 24);
            this.label9.Size = new System.Drawing.Size(225, 73);
            this.label9.TabIndex = 32;
            this.label9.Text = "Đăng Nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Quiz_Project.Properties.Resources.terporaryPicture;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 554);
            this.panel2.TabIndex = 31;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BackgroundImage = global::Quiz_Project.Properties.Resources.HomeBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1001, 593);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.PictureBox pictureBox4;
        private LoginControl password;
        private LoginControl username;
        private System.Windows.Forms.LinkLabel registerNow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_informLogin;
        private CustomButton btn_Login;      
    }
}

