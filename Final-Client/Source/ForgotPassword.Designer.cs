namespace Quiz_Project
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.Container = new System.Windows.Forms.Panel();
            this.btn_GetCaptcha = new Quiz_Project.CustomButton();
            this.btn_Submit = new Quiz_Project.CustomButton();
            this.PasswordChar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Captcha = new Quiz_Project.LoginControl();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPass = new Quiz_Project.LoginControl();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassword = new Quiz_Project.LoginControl();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new Quiz_Project.LoginControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Controls.Add(this.btn_GetCaptcha);
            this.Container.Controls.Add(this.btn_Submit);
            this.Container.Controls.Add(this.PasswordChar);
            this.Container.Controls.Add(this.pictureBox4);
            this.Container.Controls.Add(this.Captcha);
            this.Container.Controls.Add(this.label4);
            this.Container.Controls.Add(this.ConfirmPass);
            this.Container.Controls.Add(this.label3);
            this.Container.Controls.Add(this.newPassword);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.username);
            this.Container.Controls.Add(this.label1);
            this.Container.Location = new System.Drawing.Point(12, 47);
            this.Container.MinimumSize = new System.Drawing.Size(500, 310);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(500, 310);
            this.Container.TabIndex = 0;
            // 
            // btn_GetCaptcha
            // 
            this.btn_GetCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_GetCaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_GetCaptcha.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_GetCaptcha.BorderRadius = 20;
            this.btn_GetCaptcha.BorderSize = 0;
            this.btn_GetCaptcha.FlatAppearance.BorderSize = 0;
            this.btn_GetCaptcha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_GetCaptcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_GetCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetCaptcha.ForeColor = System.Drawing.Color.Purple;
            this.btn_GetCaptcha.Location = new System.Drawing.Point(373, 168);
            this.btn_GetCaptcha.Name = "btn_GetCaptcha";
            this.btn_GetCaptcha.Size = new System.Drawing.Size(72, 37);
            this.btn_GetCaptcha.TabIndex = 5;
            this.btn_GetCaptcha.Text = "Lấy Mã";
            this.btn_GetCaptcha.UseVisualStyleBackColor = false;
            this.btn_GetCaptcha.Click += new System.EventHandler(this.btn_GetCaptcha_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Submit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Submit.BorderRadius = 20;
            this.btn_Submit.BorderSize = 0;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Purple;
            this.btn_Submit.Location = new System.Drawing.Point(206, 232);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(191, 47);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Xác Nhận";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // PasswordChar
            // 
            this.PasswordChar.BackgroundImage = global::Quiz_Project.Properties.Resources.eye;
            this.PasswordChar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordChar.Location = new System.Drawing.Point(422, 129);
            this.PasswordChar.Name = "PasswordChar";
            this.PasswordChar.Size = new System.Drawing.Size(23, 20);
            this.PasswordChar.TabIndex = 32;
            this.PasswordChar.TabStop = false;
            this.PasswordChar.Click += new System.EventHandler(this.PasswordChar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox4.BackgroundImage = global::Quiz_Project.Properties.Resources.eye;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(422, 77);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 20);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Captcha
            // 
            this.Captcha.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Captcha.BoderColor = System.Drawing.Color.Lavender;
            this.Captcha.BoderFocusColor = System.Drawing.Color.HotPink;
            this.Captcha.BoderSize = 2;
            this.Captcha.BorderRadius = 0;
            this.Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Captcha.Location = new System.Drawing.Point(172, 168);
            this.Captcha.Margin = new System.Windows.Forms.Padding(4);
            this.Captcha.Multiline = false;
            this.Captcha.Name = "Captcha";
            this.Captcha.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Captcha.PasswordChar = false;
            this.Captcha.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Captcha.PlaceholderText = "";
            this.Captcha.Size = new System.Drawing.Size(273, 43);
            this.Captcha.TabIndex = 4;
            this.Captcha.UderlinedStyle = true;
            this.Captcha._TextChanged += new System.EventHandler(this.loginControl1__TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Xác Thực";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ConfirmPass.BoderColor = System.Drawing.Color.Lavender;
            this.ConfirmPass.BoderFocusColor = System.Drawing.Color.HotPink;
            this.ConfirmPass.BoderSize = 2;
            this.ConfirmPass.BorderRadius = 0;
            this.ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPass.Location = new System.Drawing.Point(172, 117);
            this.ConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmPass.Multiline = false;
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.ConfirmPass.PasswordChar = true;
            this.ConfirmPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ConfirmPass.PlaceholderText = "";
            this.ConfirmPass.Size = new System.Drawing.Size(273, 43);
            this.ConfirmPass.TabIndex = 3;
            this.ConfirmPass.UderlinedStyle = true;
            this.ConfirmPass._TextChanged += new System.EventHandler(this.loginControl1__TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // newPassword
            // 
            this.newPassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.newPassword.BoderColor = System.Drawing.Color.Lavender;
            this.newPassword.BoderFocusColor = System.Drawing.Color.HotPink;
            this.newPassword.BoderSize = 2;
            this.newPassword.BorderRadius = 0;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.Location = new System.Drawing.Point(172, 66);
            this.newPassword.Margin = new System.Windows.Forms.Padding(4);
            this.newPassword.Multiline = false;
            this.newPassword.Name = "newPassword";
            this.newPassword.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.newPassword.PasswordChar = true;
            this.newPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.newPassword.PlaceholderText = "";
            this.newPassword.Size = new System.Drawing.Size(273, 43);
            this.newPassword.TabIndex = 2;
            this.newPassword.UderlinedStyle = true;
            this.newPassword._TextChanged += new System.EventHandler(this.loginControl1__TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu Mới";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.username.BoderColor = System.Drawing.Color.Lavender;
            this.username.BoderFocusColor = System.Drawing.Color.HotPink;
            this.username.BoderSize = 2;
            this.username.BorderRadius = 0;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(172, 15);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.username.PasswordChar = false;
            this.username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.username.PlaceholderText = "";
            this.username.Size = new System.Drawing.Size(273, 43);
            this.username.TabIndex = 1;
            this.username.UderlinedStyle = true;
            this.username._TextChanged += new System.EventHandler(this.loginControl1__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(525, 393);
            this.Controls.Add(this.Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassword_FormClosed);
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private LoginControl username;
        private System.Windows.Forms.Label label1;
        private LoginControl Captcha;
        private System.Windows.Forms.Label label4;
        private LoginControl ConfirmPass;
        private System.Windows.Forms.Label label3;
        private LoginControl newPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox PasswordChar;
        private CustomButton btn_GetCaptcha;
        private CustomButton btn_Submit;
    }
}