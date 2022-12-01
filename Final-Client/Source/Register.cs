using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Quiz_Project
{
    public partial class Register : Form
    {
        string localCaptcha = null;
        ConnectServer registerClient;
        public Register()
        {
            InitializeComponent();          
        }
        private void Register_Load(object sender, EventArgs e)
        {
            IPAddress[] host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            registerClient = new ConnectServer();
            registerClient.StartConnect(host[0], 8888);
        }
        public void ChangeFontLabel(Label label, string meesage, string color)
        {
            label.Font = new Font(label.Font, FontStyle.Italic);
            label.ForeColor = Color.FromName(color);
            label.Text = meesage;
        }      
        private void btn_getCaptcha_Click(object sender, EventArgs e)
        {
            string request = email.Text + "--1115";
            registerClient.SendDataToServer(request);
            MessageBox.Show("Kiểm Tra Email Để Lấy Mã Xác Nhận!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            localCaptcha = registerClient.getDataReceive;
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            EncryptPassword encoded = new EncryptPassword(password.Text);
            string pass = encoded.EnCryptText();         
            if (localCaptcha.Contains(captcha.Text)) 
            {
                ChangeFontLabel(lb_Inform, "Mã Xác Nhận Hợp Lệ!", "LimeGreen");
                try
                {
                    string Query = "insert into userDetail (userName,userPass,fullName,email,score,usRank,isManager)" +
                        "values('" + this.username.Text + "','" + pass + "',N'" + this.fullname.Text + "','" + this.email.Text + "','0','0','False')" + "--1114";
                    registerClient.SendDataToServer(Query );
                    Thread.Sleep(1000);
                    if(registerClient.getDataReceive.Contains("Successfully"))
                    {
                        MessageBox.Show("Đăng Ký Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng Ký Thất Bại!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                ChangeFontLabel(lb_Inform, "Sai Mã Xác Nhận!", "Red");
            }
            return;
        }
        public bool checkInfor(Label label,LoginControl textBox)
        {
            if(string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BoderColor = Color.Red;
                ChangeFontLabel(label, "Thông Tin Này Không Hợp Lệ", "DarkRed");
                return false;
            }
            textBox.BoderColor = Color.LimeGreen;
            ChangeFontLabel(label, "Thông Tin Hợp Lệ", "LimeGreen");
            return true;
        }
        private void email_Leave(object sender, EventArgs e)
        {
            checkInfor(inform_email, email);
            if(!email.Text.Contains("@"))
            {
                email.BoderColor = Color.Red;
                ChangeFontLabel(inform_email, "Thông Tin Này Không Hợp Lệ", "DarkRed");
            }
            else
            {
                email.BoderColor = Color.LimeGreen;
                ChangeFontLabel(inform_email, "Thông Tin Hợp Lệ", "LimeGreen");
            }
        }

        private void fullname_Leave(object sender, EventArgs e)
        {
            checkInfor(inform_fullname, fullname);
        }

        private void username_Leave(object sender, EventArgs e)
        {
            int check = 0;
            checkInfor(inform_username, username);
            if(int.TryParse(username.Text[0].ToString(), out check))
            {
                username.BoderColor = Color.Red;
                ChangeFontLabel(inform_username, "Thông Tin Này Không Hợp Lệ", "DarkRed");
                return;
            }
            string Query = "Select fullName From userDetail where (userName = '" + username.Text + "')" + "--1113";
            registerClient.SendDataToServer(Query);
            Thread.Sleep(500);
            if (registerClient.getDataReceive.Contains("Successfully"))
            {
                username.BoderColor = Color.Red;
                ChangeFontLabel(inform_username, "Tài Khoản Đã Tồn Tại", "DarkRed");
                return;
            }
            else
            {
                username.BoderColor = Color.LimeGreen;
                ChangeFontLabel(inform_username, "Thông Tin Hợp Lệ", "LimeGreen");
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            checkInfor(inform_password, password);
        }

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            if(confirmPassword.Text != password.Text || string.IsNullOrEmpty(confirmPassword.Text))
            {
                confirmPassword.BoderColor = Color.Red;
                ChangeFontLabel(inform_confirmPass, "Thông Tin Này Không Hợp Lệ", "DarkRed");
            }
            else
            {
                confirmPassword.BoderColor = Color.LimeGreen;
                ChangeFontLabel(inform_confirmPass, "Thông Tin Hợp Lệ", "LimeGreen");
            }
        }
        public void HideOrShowPassword(PictureBox pictureBox,LoginControl textBox)
        {
            textBox.PasswordChar = !textBox.PasswordChar;
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.BackgroundImage = !textBox.PasswordChar ?
                Properties.Resources.hiddenEye : Properties.Resources.eye;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HideOrShowPassword(pictureBox1, password);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HideOrShowPassword(pictureBox4, confirmPassword);
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            registerClient.Disconnect();
        }
    }
}
