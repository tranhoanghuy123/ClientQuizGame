using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project
{
    public partial class QuizGame : Form
    {
        public QuizGame()
        {
            InitializeComponent();
            index = 0;
            userScore = 0;
            //data = MenuPlayer.QuestAndAnswers;
            //lenght = MenuPlayer.GetLengthQuests;

        }
        private ConnectServer quizGameClient;
        private int index;
        private int lenght = 0;
        List<QuestAndAnswer> data ;
        private void QuizGame_Load(object sender, EventArgs e)
        {
            quizGameClient = new ConnectServer();
            IPAddress[] host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            quizGameClient.StartConnect(host[0], 8888);
            quizGameClient.SendDataToServerAndReceiveQuests("Select quesID,ques,answerOption,optionA,optionB,optionC,optionD from question where(quesID LIKE '"+MenuPlayer.RoomID +"%') --1117");
            Thread.Sleep(3000);
            data = quizGameClient.GetQuestAndAnswers;
            lenght = quizGameClient.LengthQuests;
            //MessageBox.Show(lenght.ToString());
            ConfigDisplay(0);
        }
        private void ShowQuestsAndOptions(int index)
        {           
            txt_Question.Text = data[index].Question;
            btnOptionA.Text = data[index].OptionA;
            btnOptionB.Text = data[index].OptionB;
            btnOptionC.Text = data[index].OptionC;
            btnOptionD.Text = data[index].OptionD;
        }
        private void ConfigDisplay(int index)
        {
            CtrTimeLeft.Value = 0;
            countTimeLeft.Start();
            if (index < lenght)
            {
                ShowQuestsAndOptions(index);
            }
            else
            {
                txt_Question.Hide();
                btnOptionA.Hide();
                btnOptionB.Hide();
                btnOptionC.Hide();
                btnOptionD.Hide();
                CtrTimeLeft.Hide();
                //355, 156
                //Point centerPoint = new Point(355, 166);
                //txtUserScore.Location = centerPoint;
                string request = "update userDetail set score = score+"+ userScore +"where(userName ='"+Home.Username+"')--1121";
                quizGameClient.SendDataToServer(request);
                //MenuPlayer.QuestAndAnswers.Clear();
            }
            txtUserScore.Text = "Điểm của bạn: " + userScore.ToString();
            
        }
        private static int userScore;
        public static int UserScore { get { return userScore; } set { userScore = value; } }   
        public string GetAnswer(string keyAnswer)
        {
            switch (keyAnswer)
            {
                case "OptionA": return btnOptionA.Text;
                case "OptionB": return btnOptionB.Text;
                case "OptionC": return btnOptionC.Text;
                case "OptionD": return btnOptionD.Text;
                default:
                    return "";
            }
        }
        public bool CheckAnswer(CustomButton option,string answer)
        {
            return option.Text.Equals(answer);
        }
        private void countTimeLeft_Tick(object sender, EventArgs e)
        {
            if(CtrTimeLeft.Value < CtrTimeLeft.Maximum)
            {
                CtrTimeLeft.Value++;            
            }
            else
            {
                index++;
                ConfigDisplay(index);
            }          
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(btnOptionA, GetAnswer(data[index].Answer)) && CtrTimeLeft.Value <= CtrTimeLeft.Maximum && index <lenght)
            {
                userScore += 20;
            }
            else if(index >=lenght)
            {
                return;
            }
            ++index;
            ConfigDisplay(index);
        }

        private void btnOptionB_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(btnOptionB, GetAnswer(data[index].Answer)) && CtrTimeLeft.Value <= CtrTimeLeft.Maximum)
            {
                userScore += 20;
            }
            else if (index >= lenght)
            {
                return;
            }
            ++index;
            ConfigDisplay(index);
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(btnOptionC, GetAnswer(data[index].Answer)) && CtrTimeLeft.Value <= CtrTimeLeft.Maximum)
            {
                userScore += 20;
            }
            else if (index >= lenght)
            {
                return;
            }
            ++index;
            ConfigDisplay(index);
        }

        private void btnOptionD_Click(object sender, EventArgs e)
        {
            if (CheckAnswer(btnOptionD, GetAnswer(data[index].Answer)) && CtrTimeLeft.Value <= CtrTimeLeft.Maximum)
            {
                userScore += 20;
            }
            else if (index >= lenght)
            {
                return;
            }
            ++index;
            ConfigDisplay(index);
        }

        private void QuizGame_Activated(object sender, EventArgs e)
        {
            if(index >= lenght)
            {
                return;
            }
            //index++;
            //ConfigDisplay(index);
        }

        private void QuizGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            data = new List<QuestAndAnswer>();
            MenuPlayer.ContentClient.GetQuestAndAnswers = null;
            quizGameClient.Disconnect();
        }
    }
}
