using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project
{
    public partial class InitQuest : Form
    {
        public InitQuest()
        {
            InitializeComponent();
        }
        private static int countQuest = 0;
        public static int CountQuest 
        { 
            get
            {
                return countQuest;
            }
            set
            {
                countQuest = value;
            }
        }

        private ConnectServer initQuestClient;
        private void InitRoom_Load(object sender, EventArgs e)
        {
            //txt_Question.Text = "Type your question here...";
            IPAddress[] host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            initQuestClient = new ConnectServer();
            initQuestClient.StartConnect(host[0],8888);         
        }

        private void btn_InsertQuest_Click(object sender, EventArgs e)
        {                
            if (string.IsNullOrEmpty(txt_Question.Text)  || string.IsNullOrEmpty(txt_OptionA.Text) || string.IsNullOrEmpty(txt_OptionB.Text) || string.IsNullOrEmpty(txt_OptionC.Text) || string.IsNullOrEmpty(txt_OptionD.Text))
            {
                MessageBox.Show("Có vị trí chưa điền dữ liệu!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(!checkAnswerA.Checked && !checkAnswerB.Checked && !checkAnswerC.Checked && !checkAnswerD.Checked)
            {
                MessageBox.Show("Vui lòng tích chọn vào câu trả lời là đáp án!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
               ++countQuest;        
                string roomID = InitRoom.IDRoom;
                string questID = roomID.Substring(0, roomID.IndexOf('\0')) + countQuest.ToString(); 
                string request = @"insert into question (quesID,userName,ques,answerOption,optionA,optionB,optionC,optionD) values('" + questID + "','"+ Home.Username +"',N'" + txt_Question.Text
                    + "',N'" + (checkAnswerA.Checked ? "OptionA" : checkAnswerB.Checked ? "OptionB" : checkAnswerC.Checked ? "OptionC" : "OptionD") + "',N'" + txt_OptionA.Text + "',N'" + txt_OptionB.Text
                    + "',N'" + txt_OptionC.Text + "',N'" + txt_OptionD.Text + "')--1120";
                initQuestClient.SendDataToServer(request);
                
                checkAnswerA.Checked = false;
                checkAnswerB.Checked = false;
                checkAnswerC.Checked = false;
                checkAnswerD.Checked = false;
                MessageBox.Show("Thêm câu hỏi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            initQuestClient.Disconnect();
            this.Close();
        }

        private void InitQuest_Activated(object sender, EventArgs e)
        {
            txt_Question.PlaceholderText = "Type your question here...";
            txt_OptionA.PlaceholderText = "Type your an answer here...";
            txt_OptionB.PlaceholderText = "Type your an answer here...";
            txt_OptionC.PlaceholderText = "Type your an answer here...";
            txt_OptionD.PlaceholderText = "Type your an answer here...";
            lb_DisplayCountQuest.Text = "Số Câu Hỏi Đã Thêm: " + CountQuest.ToString();
        }

        private void InitQuest_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
