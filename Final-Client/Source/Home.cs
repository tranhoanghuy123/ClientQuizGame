using Microsoft.Win32;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quiz_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public static string Username { get; set; }
        public static  string Password { get; set; }
        
        ConnectServer homeClient;
        private void Home_Load(object sender, EventArgs e)
        {
            IPAddress[] host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            homeClient = new ConnectServer();
            homeClient.StartConnect(host[0],8888);           
        }
        private  void btn_Login_Click(object sender, EventArgs e)
        {
            
            EncryptPassword encoded = new EncryptPassword(password.Text);
            string EncodedPassword = encoded.EnCryptText(); // MD5
            
            try
            {
                string Query = "Select * From userDetail Where (userName = '" + username.Text.ToLower() + "' and userPass = '" + EncodedPassword + "')" + "--1110";
                homeClient.SendDataToServer(Query);
                Thread.Sleep(1000);
                if (homeClient.getDataReceive.Contains("Fail"))
                {
                    ChangeFontLabel(lb_informLogin, "Sai Tài Khoản Hoặc Mật Khẩu!", "LightSkyBlue");
                    return;
                }
                else if(homeClient.getDataReceive.Contains("Successfully"))
                {
                    Username = username.Text;
                    Password = password.Text; 
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MenuPlayer form = new MenuPlayer();
                    form.ShowDialog();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        
        public void ChangeFontLabel(Label label, string meesage, string color)
        {
            
            label.Font = new Font(label.Font, FontStyle.Italic);
            label.ForeColor = Color.FromName(color);
            label.Text = meesage;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            password.PasswordChar = !password.PasswordChar;
            this.pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            this.pictureBox4.BackgroundImage = !password.PasswordChar ? 
                Properties.Resources.hiddenEye : Properties.Resources.eye;           
        }
        private void registerNow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.ShowDialog();
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void forgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword form = new ForgotPassword();
            form.ShowDialog();
        }      
    }
}
