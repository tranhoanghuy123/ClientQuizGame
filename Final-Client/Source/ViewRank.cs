using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project
{
    public partial class ViewRank : Form
    {
        public ViewRank()
        {
            InitializeComponent();
        }
        private List<RankUser> rankUsers = new List<RankUser>();
        private int length = 0;
        List<CustomButton> Items = new List<CustomButton>();
        private void ShowInfor(CustomButton item,int index)
        {
            item.Text = "Player: " +rankUsers[index].Fullname + "\r\n Score: " + rankUsers[index].Score;
        }
        private void ViewRank_Load(object sender, EventArgs e)
        {
            rankUsers = MenuPlayer.RankUsers;
            length = rankUsers.Count;
            MessageBox.Show(length.ToString());
            Items.Add(InforTop1);
            Items.Add(InforTop2);
            Items.Add(InforTop3);
            Items.Add(InforTop4);
            Items.Add(InforTop5);
            Items.Add(InforTop6);
            Items.Add(InforTop7);
            Items.Add(InforTop8);
            Items.Add(InforTop9);
            Items.Add(InforTop10);
            for (int i = 0; i < length; i++) 
            {
                ShowInfor(Items[i], i);
            }
        }
    }
}
