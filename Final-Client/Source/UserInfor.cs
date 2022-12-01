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
    public partial class UserInfor : Form
    {
        public UserInfor()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UserInfor_Load(object sender, EventArgs e)
        {
            txt_Username.Text = MenuPlayer.Username;
            txt_Fullname.Text = MenuPlayer.Fullname;
            txt_Password.Text = MenuPlayer.Password;
            txt_Email.Text = MenuPlayer.Email;
        }

        private void UserInfor_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
