using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project
{
    public class ConnectServer
    {

        // Fields ... 
        private SimpleTcpClient client;
        private string ipPort;
        private string dataReceived;
        private byte[] byteDataReceived;
        // Using Class Quest And Answer to get data
        private  List<QuestAndAnswer> questAndAnswers;
        private int lengthQuests;
        public int LengthQuests { get { return lengthQuests; } set { lengthQuests = value; } }
        // Property Get Data
        public   List<QuestAndAnswer> GetQuestAndAnswers
        {
            get { return questAndAnswers; }
            set { questAndAnswers = value; }
        }
        // Using Class RankUser to get data
        private  List<RankUser> rankUsers = new List<RankUser>();
        public  List<RankUser> GetRankUsers { get { return rankUsers; } }


        // Properties ... 
        public SimpleTcpClient Client { get => client; set => client = value; }
        public string getIpPort { get { return ipPort; } }
        public string getDataReceive { get { return dataReceived; } }
        public byte[] getByteDataReceived { get { return byteDataReceived; } }
        // Constructor ...
        public ConnectServer()
        {
            this.client = null;
            this.ipPort = null;
            //client.Settings.UseAsyncDataReceivedEvents = true;
        }
        public ConnectServer(SimpleTcpClient client, string ipPort, string dataReceived)
        {
            this.client = client;
            this.ipPort = ipPort;
            this.dataReceived = dataReceived;
        }

        // Methods         
        public void StartConnect(IPAddress host,int port)
        {
            client = new SimpleTcpClient(host, port);
            client.Events.DataReceived += Events_DataReceived; // Create An Event to get Data From Server... 
            client.Connect();           
        }
        public void SendDataToServerAndReceiveQuests(string request)
        {
            
            questAndAnswers = new List<QuestAndAnswer>();
            lengthQuests = 0;
            client.SendAsync(request);
            client.Events.DataReceived += Events_DataReceivedQuests;
        }
        public void SendRequestAndReceivedRankUsers(string request)
        {
            client.SendAsync(request);
            client.Events.DataReceived += Events_DataReceivedRankUsers;
        }

        private void Events_DataReceivedRankUsers(object sender, DataReceivedEventArgs e)
        {
            RankUser rankUser = new RankUser();
            rankUser = RankUser.getObjectFromBytes(e.Data.Array);
            rankUsers.Add(rankUser);
        }

        private string statusRoom;
        public string GetStatusRoom { get { return statusRoom; } }
        private void Events_DataReceivedQuests(object sender, DataReceivedEventArgs e)
        {
            statusRoom = Encoding.UTF8.GetString(e.Data.Array);
            QuestAndAnswer quest = new QuestAndAnswer();
            quest = QuestAndAnswer.GetObjectFromBytes(e.Data.Array);
            questAndAnswers.Insert(lengthQuests, quest);
            lengthQuests++;
        }
        public void  SendDataToServer(string data)
        {
            client.SendAsync(data);        
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            byteDataReceived = e.Data.Array;          
            this.dataReceived = Encoding.UTF8.GetString(e.Data.Array);
        }
        public void Disconnect()
        {
            client.DisconnectAsync();
        }
    }
}
