using System;
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

namespace Quiz_Project
{
    public partial class InitRoom : Form
    {

        private ConnectServer clientInitRoom;
        private IPAddress[] host;
        public static string IDRoom { get; set; }
        public InitRoom()
        {
            InitializeComponent();
            
        }

        private void btn_CreateRoom_Click(object sender, EventArgs e)
        {
            int check = 0;
            IDRoom = IDRoom.Substring(0, IDRoom.IndexOf('\0'));
            if (string.IsNullOrEmpty(txt_CategoryRoom.Text) || string.IsNullOrEmpty(txt_QuantityMember.Text))
            {
                MessageBox.Show("Có vị trí bị bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!int.TryParse(txt_QuantityMember.Text,out check))
            {
                MessageBox.Show("Vui lòng nhập số cho số lượng thành viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!txt_RoomID.Text.Contains(IDRoom))
            {
                MessageBox.Show("Đã nói là đừng có sửa ID của người ta rồi mà. Lỳ vậy :((!","Cảnh cáo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string request = "update userDetail set isManager = 'True' where(username='"+ Home.Username+ "'); insert into manager(userName,roomID) values ('"
                    + Home.Username+"','"+ IDRoom +"');" + "insert into room (roomID,countMember,categoryRoom,maxMember) values ('" + IDRoom + "','0',N'" 
                    + txt_CategoryRoom.Text + "','" + txt_QuantityMember.Text + "')" + "--1119";
                clientInitRoom.SendDataToServer(request);
                MessageBox.Show("Tạo phòng thành công. Bạn sẽ bắt đầu tạo câu hỏi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                InitQuest form = new InitQuest();
                form.Show();
            }         
        }

        private void InitRoom_Load(object sender, EventArgs e)
        {
            host = Dns.GetHostAddresses("vpswindow10.ddns.net");
            clientInitRoom = new ConnectServer();
            clientInitRoom.StartConnect(host[0], 8888);
            clientInitRoom.SendDataToServer("--1118");
            Thread.Sleep(1000);
        }

        private void InitRoom_Activated(object sender, EventArgs e)
        {
            IDRoom = clientInitRoom.getDataReceive;
            txt_RoomID.Text = "<Note: Không Được Sửa ID> Your ID Room is " + IDRoom ;
        }

        private void InitRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientInitRoom.Disconnect();
        }
    }
}
