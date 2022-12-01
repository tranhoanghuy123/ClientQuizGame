namespace Quiz_Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.Container = new System.Windows.Forms.Panel();
            this.btn_getCaptcha = new Quiz_Project.CustomButton();
            this.btn_Register = new Quiz_Project.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.inform_email = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.captcha = new Quiz_Project.LoginControl();
            this.email = new Quiz_Project.LoginControl();
            this.confirmPassword = new Quiz_Project.LoginControl();
            this.username = new Quiz_Project.LoginControl();
            this.password = new Quiz_Project.LoginControl();
            this.fullname = new Quiz_Project.LoginControl();
            this.inform_username = new System.Windows.Forms.Label();
            this.inform_password = new System.Windows.Forms.Label();
            this.inform_fullname = new System.Windows.Forms.Label();
            this.inform_confirmPass = new System.Windows.Forms.Label();
            this.lb_Inform = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Container.Controls.Add(this.btn_getCaptcha);
            this.Container.Controls.Add(this.btn_Register);
            this.Container.Controls.Add(this.pictureBox1);
            this.Container.Controls.Add(this.pictureBox4);
            this.Container.Controls.Add(this.inform_email);
            this.Container.Controls.Add(this.label7);
            this.Container.Controls.Add(this.captcha);
            this.Container.Controls.Add(this.email);
            this.Container.Controls.Add(this.confirmPassword);
            this.Container.Controls.Add(this.username);
            this.Container.Controls.Add(this.password);
            this.Container.Controls.Add(this.fullname);
            this.Container.Controls.Add(this.inform_username);
            this.Container.Controls.Add(this.inform_password);
            this.Container.Controls.Add(this.inform_fullname);
            this.Container.Controls.Add(this.inform_confirmPass);
            this.Container.Controls.Add(this.lb_Inform);
            this.Container.Controls.Add(this.label5);
            this.Container.Controls.Add(this.label4);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.label3);
            this.Container.Controls.Add(this.label6);
            this.Container.Controls.Add(this.label1);
            this.Container.Location = new System.Drawing.Point(12, 12);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(626, 606);
            this.Container.TabIndex = 0;
            // 
            // btn_getCaptcha
            // 
            this.btn_getCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_getCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_getCaptcha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_getCaptcha.BorderRadius = 20;
            this.btn_getCaptcha.BorderSize = 0;
            this.btn_getCaptcha.FlatAppearance.BorderSize = 0;
            this.btn_getCaptcha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_getCaptcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_getCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_getCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_getCaptcha.ForeColor = System.Drawing.Color.Purple;
            this.btn_getCaptcha.Location = new System.Drawing.Point(472, 381);
            this.btn_getCaptcha.Name = "btn_getCaptcha";
            this.btn_getCaptcha.Size = new System.Drawing.Size(74, 43);
            this.btn_getCaptcha.TabIndex = 6;
            this.btn_getCaptcha.Text = "Lấy mã";
            this.btn_getCaptcha.UseVisualStyleBackColor = false;
            this.btn_getCaptcha.Click += new System.EventHandler(this.btn_getCaptcha_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Register.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Register.BorderRadius = 20;
            this.btn_Register.BorderSize = 0;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.Purple;
            this.btn_Register.Location = new System.Drawing.Point(215, 519);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(250, 47);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Đăng Ký";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox1.BackgroundImage = global::Quiz_Project.Properties.Resources.eye;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(442, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox4.BackgroundImage = global::Quiz_Project.Properties.Resources.eye;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(442, 333);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // inform_email
            // 
            this.inform_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform_email.AutoSize = true;
            this.inform_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform_email.ForeColor = System.Drawing.Color.LimeGreen;
            this.inform_email.Location = new System.Drawing.Point(212, 442);
            this.inform_email.Name = "inform_email";
            this.inform_email.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.inform_email.Size = new System.Drawing.Size(4, 16);
            this.inform_email.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(170, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 37);
            this.label7.TabIndex = 69;
            this.label7.Text = "Đăng Ký Tài Khoản";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // captcha
            // 
            this.captcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.captcha.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.captcha.BoderColor = System.Drawing.Color.Lavender;
            this.captcha.BoderFocusColor = System.Drawing.Color.HotPink;
            this.captcha.BoderSize = 2;
            this.captcha.BorderRadius = 0;
            this.captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captcha.Location = new System.Drawing.Point(215, 462);
            this.captcha.Margin = new System.Windows.Forms.Padding(4);
            this.captcha.Multiline = false;
            this.captcha.Name = "captcha";
            this.captcha.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.captcha.PasswordChar = false;
            this.captcha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.captcha.PlaceholderText = "";
            this.captcha.Size = new System.Drawing.Size(250, 43);
            this.captcha.TabIndex = 7;
            this.captcha.UderlinedStyle = true;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.email.BoderColor = System.Drawing.Color.Lavender;
            this.email.BoderFocusColor = System.Drawing.Color.HotPink;
            this.email.BoderSize = 2;
            this.email.BorderRadius = 0;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(215, 390);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "";
            this.email.Size = new System.Drawing.Size(250, 43);
            this.email.TabIndex = 5;
            this.email.UderlinedStyle = true;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.confirmPassword.BoderColor = System.Drawing.Color.Lavender;
            this.confirmPassword.BoderFocusColor = System.Drawing.Color.HotPink;
            this.confirmPassword.BoderSize = 2;
            this.confirmPassword.BorderRadius = 0;
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.Location = new System.Drawing.Point(215, 319);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPassword.Multiline = false;
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.confirmPassword.PasswordChar = true;
            this.confirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.confirmPassword.PlaceholderText = "";
            this.confirmPassword.Size = new System.Drawing.Size(250, 43);
            this.confirmPassword.TabIndex = 4;
            this.confirmPassword.UderlinedStyle = true;
            this.confirmPassword.Leave += new System.EventHandler(this.confirmPassword_Leave);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.username.BoderColor = System.Drawing.Color.Lavender;
            this.username.BoderFocusColor = System.Drawing.Color.HotPink;
            this.username.BoderSize = 2;
            this.username.BorderRadius = 0;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(215, 172);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "";
            this.username.Size = new System.Drawing.Size(250, 43);
            this.username.TabIndex = 2;
            this.username.UderlinedStyle = true;
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.password.BoderColor = System.Drawing.Color.Lavender;
            this.password.BoderFocusColor = System.Drawing.Color.HotPink;
            this.password.BoderSize = 2;
            this.password.BorderRadius = 0;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(215, 253);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.password.PasswordChar = true;
            this.password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.password.PlaceholderText = "";
            this.password.Size = new System.Drawing.Size(250, 43);
            this.password.TabIndex = 3;
            this.password.UderlinedStyle = true;
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // fullname
            // 
            this.fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullname.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.fullname.BoderColor = System.Drawing.Color.Lavender;
            this.fullname.BoderFocusColor = System.Drawing.Color.HotPink;
            this.fullname.BoderSize = 2;
            this.fullname.BorderRadius = 0;
            this.fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(215, 106);
            this.fullname.Margin = new System.Windows.Forms.Padding(4);
            this.fullname.Multiline = false;
            this.fullname.Name = "fullname";
            this.fullname.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.fullname.PasswordChar = false;
            this.fullname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fullname.PlaceholderText = "";
            this.fullname.Size = new System.Drawing.Size(250, 43);
            this.fullname.TabIndex = 1;
            this.fullname.UderlinedStyle = true;
            this.fullname.Leave += new System.EventHandler(this.fullname_Leave);
            // 
            // inform_username
            // 
            this.inform_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform_username.AutoSize = true;
            this.inform_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform_username.ForeColor = System.Drawing.Color.LimeGreen;
            this.inform_username.Location = new System.Drawing.Point(212, 234);
            this.inform_username.Name = "inform_username";
            this.inform_username.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.inform_username.Size = new System.Drawing.Size(4, 15);
            this.inform_username.TabIndex = 62;
            // 
            // inform_password
            // 
            this.inform_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform_password.AutoSize = true;
            this.inform_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform_password.ForeColor = System.Drawing.Color.LimeGreen;
            this.inform_password.Location = new System.Drawing.Point(212, 300);
            this.inform_password.Name = "inform_password";
            this.inform_password.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.inform_password.Size = new System.Drawing.Size(4, 15);
            this.inform_password.TabIndex = 61;
            // 
            // inform_fullname
            // 
            this.inform_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform_fullname.AutoSize = true;
            this.inform_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform_fullname.ForeColor = System.Drawing.Color.DarkRed;
            this.inform_fullname.Location = new System.Drawing.Point(212, 153);
            this.inform_fullname.Name = "inform_fullname";
            this.inform_fullname.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.inform_fullname.Size = new System.Drawing.Size(4, 15);
            this.inform_fullname.TabIndex = 60;
            // 
            // inform_confirmPass
            // 
            this.inform_confirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inform_confirmPass.AutoSize = true;
            this.inform_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform_confirmPass.ForeColor = System.Drawing.Color.LimeGreen;
            this.inform_confirmPass.Location = new System.Drawing.Point(212, 370);
            this.inform_confirmPass.Name = "inform_confirmPass";
            this.inform_confirmPass.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.inform_confirmPass.Size = new System.Drawing.Size(4, 16);
            this.inform_confirmPass.TabIndex = 59;
            // 
            // lb_Inform
            // 
            this.lb_Inform.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Inform.AutoSize = true;
            this.lb_Inform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inform.ForeColor = System.Drawing.Color.LimeGreen;
            this.lb_Inform.Location = new System.Drawing.Point(212, 519);
            this.lb_Inform.Name = "lb_Inform";
            this.lb_Inform.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lb_Inform.Size = new System.Drawing.Size(4, 16);
            this.lb_Inform.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Location = new System.Drawing.Point(49, 485);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Mã Xác Nhận";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(49, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(49, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(49, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(49, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(49, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tài Khoản";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(650, 630);
            this.Controls.Add(this.Container);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(666, 669);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Tài Khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label inform_email;
        private System.Windows.Forms.Label label7;
        private LoginControl captcha;
        private LoginControl email;
        private LoginControl confirmPassword;
        private LoginControl username;
        private LoginControl password;
        private LoginControl fullname;
        private System.Windows.Forms.Label inform_username;
        private System.Windows.Forms.Label inform_password;
        private System.Windows.Forms.Label inform_fullname;
        private System.Windows.Forms.Label inform_confirmPass;
        private System.Windows.Forms.Label lb_Inform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private CustomButton btn_Register;
        private CustomButton btn_getCaptcha;
    }
}