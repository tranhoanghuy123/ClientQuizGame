using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace Quiz_Project
{
    public partial class ForgotPassword : Form
    {
        string localCaptcha = null;
        ConnectServer fotgotPassClient;
        public ForgotPassword()
        {
            InitializeComponent();          
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            IPAddress[] host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            fotgotPassClient = new ConnectServer();
            fotgotPassClient.StartConnect(host[0], 8888);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loginControl1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_GetCaptcha_Click(object sender, EventArgs e)
        {
            string Query = "Select email From userDetail Where(userName = '" + username.Text + "')" + "--1111";

            if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(ConfirmPass.Text) && !string.IsNullOrEmpty(newPassword.Text) && newPassword.Text == ConfirmPass.Text)
            {
                fotgotPassClient.SendDataToServer(Query);
                MessageBox.Show("Kiểm Tra Email Để Lấy Mã Xác Nhận!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                localCaptcha = fotgotPassClient.getDataReceive;
            }
            else
            {
                MessageBox.Show("Thông Tin Nhập Vào Không Hợp Lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
            if (localCaptcha.Contains("Fail"))
            {
                MessageBox.Show("Tài Khoản Chưa Được Đăng Ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            
            if (localCaptcha.Contains(Captcha.Text))
            {               
                //This is my insert query in which i am taking input from the user through windows forms
                EncryptPassword encryptPass = new EncryptPassword(newPassword.Text);
                string newPass = encryptPass.EnCryptText();
                string Query = "UPDATE userDetail SET userPass = '" + newPass + "' WHERE userName = '" + username.Text + "';" + "--1112";
                fotgotPassClient.SendDataToServer(Query);
                Thread.Sleep(1000);
                if (fotgotPassClient.getDataReceive.Contains("Successfully"))
                {
                    MessageBox.Show("Đổi Mật Khẩu Thành Công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đổi Mật Khẩu Thất Bại! Vui Lòng Kiểm Tra Lại Thông Tin", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã Xác Nhận Bị Sai!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }       
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            newPassword.PasswordChar = !newPassword.PasswordChar;
            this.pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBox4.BackgroundImage = !newPassword.PasswordChar ?
                Properties.Resources.hiddenEye : Properties.Resources.eye;
        }

        private void PasswordChar_Click(object sender, EventArgs e)
        {
            ConfirmPass.PasswordChar = !ConfirmPass.PasswordChar;
            this.PasswordChar.BackgroundImageLayout = ImageLayout.Zoom;
            this.PasswordChar.BackgroundImage = !ConfirmPass.PasswordChar ?
                Properties.Resources.hiddenEye : Properties.Resources.eye;
        }

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            fotgotPassClient.Disconnect();
        }
    }
}
