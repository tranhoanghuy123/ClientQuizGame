using SuperSimpleTcp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_Project
{
    public partial class MenuPlayer : Form
    {
        public MenuPlayer()
        {
            InitializeComponent();
            customizeDesign();           
        }

        // ....
        private void customizeDesign()
        {
            SubMenuDiscovery.Visible = false;
            SubMenuInfor.Visible = false;
            //...
        }
         
        //
        private void hiddenSubMenu()
        {
            if (SubMenuDiscovery.Visible == true)
                SubMenuDiscovery.Visible = false;
            if (SubMenuInfor.Visible == true)
                SubMenuInfor.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hiddenSubMenu();
                subMenu.Visible = true;
            }    
            else
            {
                subMenu.Visible = false;
            }
        }
        private int countTextHeader = 0;
        private int length = 0;
        private string txt = null;
        private static ConnectServer contentClient;
        private IPAddress[] host;
        private void Content_Load(object sender, EventArgs e)
        {
            txt = lbIntro.Text;
            length = txt.Length;
            lbIntro.Text = "";
            countText.Start();
            host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            contentClient = new ConnectServer();
            contentClient.StartConnect(host[0], 8888);
        }
        private void countText_Tick(object sender, EventArgs e)
        {
            countTextHeader++;
            if (countTextHeader > length)
            {
                countTextHeader = 0;
                txt = lbIntro.Text;
            }
            else
                lbIntro.Text = txt.Substring(0, countTextHeader);

        }

        // List  Methods Join  Room ....
        private void btn_InforUser_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuInfor);          
        }

        private void btn_Discovery_Click(object sender, EventArgs e)
        {
            showSubMenu(SubMenuDiscovery);

        }

        public static string Username { get; set; }
        public static string Password { get ;set; }
        public static string Email { get; set ; }
        public static string Fullname { get; set ; }
        public static string RoomID { get; set; }

        private void btn_ShowFullInfor_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...       
            Username = Home.Username;
            Password = Home.Password;
            string Query = "Select fullName,email From userDetail Where(username = '" + Username + "')--1116";
            contentClient.SendDataToServer(Query);
            Thread.Sleep(1000);
            string data = contentClient.getDataReceive;
            int lengthFullname = data.IndexOf('<');
            Fullname = data.Substring(0, lengthFullname);
            Email = data.Substring(lengthFullname + 3);
            UserInfor form = new UserInfor();
            form.Show();
            hiddenSubMenu();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...
            ForgotPassword form = new ForgotPassword();
            form.Show();
            hiddenSubMenu();
        }
        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...
            contentClient.Disconnect();
            this.Close();
            Home form = new Home();
            form.Show();
            hiddenSubMenu();
        }

        private void btn_InitRoom_Click(object sender, EventArgs e)
        {           
            InitRoom form = new InitRoom();
            form.Show();
        }

        private void btn_searchUser_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...

            hiddenSubMenu();
        }

        private static List<RankUser> rankUsers = new List<RankUser>();
        public static List<RankUser>RankUsers
        {
            get { return rankUsers; }
            set { rankUsers = value; }
        }
        private void btn_ViewRank_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...
            string request = "Select fullName,userName,score from userDetail Order by score Desc --1122";
            contentClient.SendRequestAndReceivedRankUsers(request);
            Thread.Sleep(1000);
            rankUsers = contentClient.GetRankUsers;
            hiddenSubMenu();
            ViewRank form = new ViewRank();
            form.Show();
        }

        private void btn_Donate_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...

            hiddenSubMenu();
        }

        private void btn_ViewFanpage_Click(object sender, EventArgs e)
        {
            //Your Code
            // ...

            hiddenSubMenu();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {

        }

        private void linkMyFB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkMyFB.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/huytran9191/");
        }
        private static List<QuestAndAnswer> questAndAnswers;
        public static List<QuestAndAnswer> QuestAndAnswers { get { return questAndAnswers; } set { questAndAnswers = value; } }
        public static int GetLengthQuests { get { return contentClient.LengthQuests; } }
        public static ConnectServer ContentClient { get { return contentClient; } set { contentClient = value; }  }
        private void JoinRoom(string roomId)
        {
            string request = "Select quesID from question where(quesID LIKE '" + roomId + "%') --1123";
            contentClient.SendDataToServer(request);
            Thread.Sleep(100);
            if(contentClient.getDataReceive.Contains("Successfully"))
            {
                QuizGame form = new QuizGame();
                form.ShowDialog();
            }
            else if(contentClient.getDataReceive.Contains("Fail"))
            {
                MessageBox.Show("Phòng Không Tồn Tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }
        private  void btn_JoinRoom_Click(object sender, EventArgs e)
        {
            RoomID = txt_RoomId.Text;
            JoinRoom(RoomID);           
        }
        private void btn_FunnyRoom_Click(object sender, EventArgs e)
        {
            RoomID = "110001";
            JoinRoom(RoomID);
        }

        private void btn_ITRoom_Click(object sender, EventArgs e)
        {
            RoomID = "110002";
            JoinRoom(RoomID);
        }
    }
}
