using System.Reflection;

namespace Quiz_Project
{
    partial class MenuPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPlayer));
            this.ListMenu = new System.Windows.Forms.Panel();
            this.MenuFooter = new System.Windows.Forms.Panel();
            this.MenuHelp = new System.Windows.Forms.Panel();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SubMenuDiscovery = new System.Windows.Forms.Panel();
            this.btn_ViewFanpage = new System.Windows.Forms.Button();
            this.btn_Donate = new System.Windows.Forms.Button();
            this.btn_ViewRank = new System.Windows.Forms.Button();
            this.btn_searchUser = new System.Windows.Forms.Button();
            this.MenuDiscovery = new System.Windows.Forms.Panel();
            this.btn_Discovery = new System.Windows.Forms.Button();
            this.MenuInitRoom = new System.Windows.Forms.Panel();
            this.btn_InitRoom = new System.Windows.Forms.Button();
            this.SubMenuInfor = new System.Windows.Forms.Panel();
            this.btn_SignOut = new System.Windows.Forms.Button();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.btn_ShowFullInfor = new System.Windows.Forms.Button();
            this.MenuInfor = new System.Windows.Forms.Panel();
            this.btn_InforUser = new System.Windows.Forms.Button();
            this.HeaderMenu = new System.Windows.Forms.Panel();
            this.PanelSlider = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_JoinRoom = new Quiz_Project.CustomButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_RoomId = new Quiz_Project.LoginControl();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Rank = new System.Windows.Forms.Button();
            this.btn_CreateRoom = new System.Windows.Forms.Button();
            this.btn_Events = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ITRoom = new System.Windows.Forms.Button();
            this.btn_FunnyRoom = new System.Windows.Forms.Button();
            this.btn_Donate2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.linkMyFB = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIntro = new System.Windows.Forms.Label();
            this.countText = new System.Windows.Forms.Timer(this.components);
            this.ListMenu.SuspendLayout();
            this.MenuHelp.SuspendLayout();
            this.SubMenuDiscovery.SuspendLayout();
            this.MenuDiscovery.SuspendLayout();
            this.MenuInitRoom.SuspendLayout();
            this.SubMenuInfor.SuspendLayout();
            this.MenuInfor.SuspendLayout();
            this.PanelSlider.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListMenu
            // 
            this.ListMenu.AutoScroll = true;
            this.ListMenu.BackColor = System.Drawing.Color.BlueViolet;
            this.ListMenu.Controls.Add(this.MenuFooter);
            this.ListMenu.Controls.Add(this.MenuHelp);
            this.ListMenu.Controls.Add(this.SubMenuDiscovery);
            this.ListMenu.Controls.Add(this.MenuDiscovery);
            this.ListMenu.Controls.Add(this.MenuInitRoom);
            this.ListMenu.Controls.Add(this.SubMenuInfor);
            this.ListMenu.Controls.Add(this.MenuInfor);
            this.ListMenu.Controls.Add(this.HeaderMenu);
            this.ListMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListMenu.Location = new System.Drawing.Point(0, 0);
            this.ListMenu.Margin = new System.Windows.Forms.Padding(4);
            this.ListMenu.Name = "ListMenu";
            this.ListMenu.Size = new System.Drawing.Size(212, 421);
            this.ListMenu.TabIndex = 0;
            // 
            // MenuFooter
            // 
            this.MenuFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuFooter.Location = new System.Drawing.Point(0, 554);
            this.MenuFooter.Name = "MenuFooter";
            this.MenuFooter.Size = new System.Drawing.Size(195, 100);
            this.MenuFooter.TabIndex = 6;
            // 
            // MenuHelp
            // 
            this.MenuHelp.Controls.Add(this.btn_Help);
            this.MenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHelp.Location = new System.Drawing.Point(0, 512);
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(195, 42);
            this.MenuHelp.TabIndex = 5;
            // 
            // btn_Help
            // 
            this.btn_Help.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Help.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Help.FlatAppearance.BorderSize = 0;
            this.btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Help.Location = new System.Drawing.Point(0, 0);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Help.Size = new System.Drawing.Size(195, 42);
            this.btn_Help.TabIndex = 0;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.UseVisualStyleBackColor = false;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // SubMenuDiscovery
            // 
            this.SubMenuDiscovery.Controls.Add(this.btn_ViewFanpage);
            this.SubMenuDiscovery.Controls.Add(this.btn_Donate);
            this.SubMenuDiscovery.Controls.Add(this.btn_ViewRank);
            this.SubMenuDiscovery.Controls.Add(this.btn_searchUser);
            this.SubMenuDiscovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuDiscovery.Location = new System.Drawing.Point(0, 350);
            this.SubMenuDiscovery.Name = "SubMenuDiscovery";
            this.SubMenuDiscovery.Size = new System.Drawing.Size(195, 162);
            this.SubMenuDiscovery.TabIndex = 4;
            // 
            // btn_ViewFanpage
            // 
            this.btn_ViewFanpage.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_ViewFanpage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewFanpage.FlatAppearance.BorderSize = 0;
            this.btn_ViewFanpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewFanpage.Location = new System.Drawing.Point(0, 120);
            this.btn_ViewFanpage.Name = "btn_ViewFanpage";
            this.btn_ViewFanpage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ViewFanpage.Size = new System.Drawing.Size(195, 42);
            this.btn_ViewFanpage.TabIndex = 3;
            this.btn_ViewFanpage.Text = "View Fanpage";
            this.btn_ViewFanpage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewFanpage.UseVisualStyleBackColor = false;
            this.btn_ViewFanpage.Click += new System.EventHandler(this.btn_ViewFanpage_Click);
            // 
            // btn_Donate
            // 
            this.btn_Donate.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Donate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Donate.FlatAppearance.BorderSize = 0;
            this.btn_Donate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Donate.Location = new System.Drawing.Point(0, 80);
            this.btn_Donate.Name = "btn_Donate";
            this.btn_Donate.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Donate.Size = new System.Drawing.Size(195, 40);
            this.btn_Donate.TabIndex = 2;
            this.btn_Donate.Text = "Nạp Tiền";
            this.btn_Donate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Donate.UseVisualStyleBackColor = false;
            this.btn_Donate.Click += new System.EventHandler(this.btn_Donate_Click);
            // 
            // btn_ViewRank
            // 
            this.btn_ViewRank.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_ViewRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ViewRank.FlatAppearance.BorderSize = 0;
            this.btn_ViewRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewRank.Location = new System.Drawing.Point(0, 40);
            this.btn_ViewRank.Name = "btn_ViewRank";
            this.btn_ViewRank.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ViewRank.Size = new System.Drawing.Size(195, 40);
            this.btn_ViewRank.TabIndex = 1;
            this.btn_ViewRank.Text = "Bảng Xếp Hạng";
            this.btn_ViewRank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewRank.UseVisualStyleBackColor = false;
            this.btn_ViewRank.Click += new System.EventHandler(this.btn_ViewRank_Click);
            // 
            // btn_searchUser
            // 
            this.btn_searchUser.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_searchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_searchUser.FlatAppearance.BorderSize = 0;
            this.btn_searchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchUser.Location = new System.Drawing.Point(0, 0);
            this.btn_searchUser.Name = "btn_searchUser";
            this.btn_searchUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_searchUser.Size = new System.Drawing.Size(195, 40);
            this.btn_searchUser.TabIndex = 0;
            this.btn_searchUser.Text = "Tìm Người Chơi";
            this.btn_searchUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchUser.UseVisualStyleBackColor = false;
            this.btn_searchUser.Click += new System.EventHandler(this.btn_searchUser_Click);
            // 
            // MenuDiscovery
            // 
            this.MenuDiscovery.Controls.Add(this.btn_Discovery);
            this.MenuDiscovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuDiscovery.Location = new System.Drawing.Point(0, 308);
            this.MenuDiscovery.Name = "MenuDiscovery";
            this.MenuDiscovery.Size = new System.Drawing.Size(195, 42);
            this.MenuDiscovery.TabIndex = 3;
            // 
            // btn_Discovery
            // 
            this.btn_Discovery.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Discovery.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Discovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Discovery.FlatAppearance.BorderSize = 0;
            this.btn_Discovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Discovery.Location = new System.Drawing.Point(0, 0);
            this.btn_Discovery.Name = "btn_Discovery";
            this.btn_Discovery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Discovery.Size = new System.Drawing.Size(195, 42);
            this.btn_Discovery.TabIndex = 0;
            this.btn_Discovery.Text = "Khám Phá";
            this.btn_Discovery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Discovery.UseVisualStyleBackColor = false;
            this.btn_Discovery.Click += new System.EventHandler(this.btn_Discovery_Click);
            // 
            // MenuInitRoom
            // 
            this.MenuInitRoom.Controls.Add(this.btn_InitRoom);
            this.MenuInitRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuInitRoom.Location = new System.Drawing.Point(0, 264);
            this.MenuInitRoom.Name = "MenuInitRoom";
            this.MenuInitRoom.Size = new System.Drawing.Size(195, 44);
            this.MenuInitRoom.TabIndex = 4;
            // 
            // btn_InitRoom
            // 
            this.btn_InitRoom.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_InitRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_InitRoom.FlatAppearance.BorderSize = 0;
            this.btn_InitRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InitRoom.Location = new System.Drawing.Point(0, 0);
            this.btn_InitRoom.Name = "btn_InitRoom";
            this.btn_InitRoom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_InitRoom.Size = new System.Drawing.Size(195, 44);
            this.btn_InitRoom.TabIndex = 0;
            this.btn_InitRoom.Text = "Tạo Phòng";
            this.btn_InitRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InitRoom.UseVisualStyleBackColor = false;
            this.btn_InitRoom.Click += new System.EventHandler(this.btn_InitRoom_Click);
            // 
            // SubMenuInfor
            // 
            this.SubMenuInfor.Controls.Add(this.btn_SignOut);
            this.SubMenuInfor.Controls.Add(this.btn_ChangePass);
            this.SubMenuInfor.Controls.Add(this.btn_ShowFullInfor);
            this.SubMenuInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenuInfor.Location = new System.Drawing.Point(0, 142);
            this.SubMenuInfor.Name = "SubMenuInfor";
            this.SubMenuInfor.Size = new System.Drawing.Size(195, 122);
            this.SubMenuInfor.TabIndex = 2;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_SignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SignOut.FlatAppearance.BorderSize = 0;
            this.btn_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOut.Location = new System.Drawing.Point(0, 80);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_SignOut.Size = new System.Drawing.Size(195, 42);
            this.btn_SignOut.TabIndex = 2;
            this.btn_SignOut.Text = "Đăng Xuất";
            this.btn_SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignOut.UseVisualStyleBackColor = false;
            this.btn_SignOut.Click += new System.EventHandler(this.btn_SignOut_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_ChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ChangePass.FlatAppearance.BorderSize = 0;
            this.btn_ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePass.Location = new System.Drawing.Point(0, 40);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ChangePass.Size = new System.Drawing.Size(195, 40);
            this.btn_ChangePass.TabIndex = 1;
            this.btn_ChangePass.Text = "Đổi Mật Khẩu";
            this.btn_ChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChangePass.UseVisualStyleBackColor = false;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btn_ShowFullInfor
            // 
            this.btn_ShowFullInfor.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_ShowFullInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ShowFullInfor.FlatAppearance.BorderSize = 0;
            this.btn_ShowFullInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowFullInfor.Location = new System.Drawing.Point(0, 0);
            this.btn_ShowFullInfor.Name = "btn_ShowFullInfor";
            this.btn_ShowFullInfor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_ShowFullInfor.Size = new System.Drawing.Size(195, 40);
            this.btn_ShowFullInfor.TabIndex = 0;
            this.btn_ShowFullInfor.Text = "Xem Hồ Sơ";
            this.btn_ShowFullInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowFullInfor.UseVisualStyleBackColor = false;
            this.btn_ShowFullInfor.Click += new System.EventHandler(this.btn_ShowFullInfor_Click);
            // 
            // MenuInfor
            // 
            this.MenuInfor.Controls.Add(this.btn_InforUser);
            this.MenuInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuInfor.Location = new System.Drawing.Point(0, 100);
            this.MenuInfor.Name = "MenuInfor";
            this.MenuInfor.Size = new System.Drawing.Size(195, 42);
            this.MenuInfor.TabIndex = 1;
            // 
            // btn_InforUser
            // 
            this.btn_InforUser.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_InforUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_InforUser.FlatAppearance.BorderSize = 0;
            this.btn_InforUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InforUser.Location = new System.Drawing.Point(0, 0);
            this.btn_InforUser.Name = "btn_InforUser";
            this.btn_InforUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_InforUser.Size = new System.Drawing.Size(195, 42);
            this.btn_InforUser.TabIndex = 0;
            this.btn_InforUser.Text = "Thông Tin Cá Nhân";
            this.btn_InforUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InforUser.UseVisualStyleBackColor = false;
            this.btn_InforUser.Click += new System.EventHandler(this.btn_InforUser_Click);
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Size = new System.Drawing.Size(195, 100);
            this.HeaderMenu.TabIndex = 0;
            // 
            // PanelSlider
            // 
            this.PanelSlider.BackgroundImage = global::Quiz_Project.Properties.Resources.HomeBackGround;
            this.PanelSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelSlider.Controls.Add(this.panel5);
            this.PanelSlider.Controls.Add(this.panel4);
            this.PanelSlider.Controls.Add(this.panel3);
            this.PanelSlider.Controls.Add(this.panel2);
            this.PanelSlider.Controls.Add(this.panel1);
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.Location = new System.Drawing.Point(212, 0);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.Size = new System.Drawing.Size(642, 421);
            this.PanelSlider.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(120, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 221);
            this.panel5.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btn_JoinRoom);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(80, 45);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(242, 131);
            this.panel10.TabIndex = 4;
            // 
            // btn_JoinRoom
            // 
            this.btn_JoinRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_JoinRoom.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_JoinRoom.BorderRadius = 20;
            this.btn_JoinRoom.BorderSize = 0;
            this.btn_JoinRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_JoinRoom.FlatAppearance.BorderSize = 0;
            this.btn_JoinRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JoinRoom.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_JoinRoom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_JoinRoom.Location = new System.Drawing.Point(0, 55);
            this.btn_JoinRoom.Name = "btn_JoinRoom";
            this.btn_JoinRoom.Size = new System.Drawing.Size(242, 42);
            this.btn_JoinRoom.TabIndex = 4;
            this.btn_JoinRoom.Text = "Tham Gia";
            this.btn_JoinRoom.UseVisualStyleBackColor = false;
            this.btn_JoinRoom.Click += new System.EventHandler(this.btn_JoinRoom_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txt_RoomId);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(242, 43);
            this.panel12.TabIndex = 3;
            // 
            // txt_RoomId
            // 
            this.txt_RoomId.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_RoomId.BoderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_RoomId.BoderFocusColor = System.Drawing.Color.HotPink;
            this.txt_RoomId.BoderSize = 2;
            this.txt_RoomId.BorderRadius = 15;
            this.txt_RoomId.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_RoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RoomId.Location = new System.Drawing.Point(0, 0);
            this.txt_RoomId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RoomId.Multiline = false;
            this.txt_RoomId.Name = "txt_RoomId";
            this.txt_RoomId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_RoomId.PasswordChar = false;
            this.txt_RoomId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_RoomId.PlaceholderText = "Type ID Room Here...";
            this.txt_RoomId.Size = new System.Drawing.Size(242, 35);
            this.txt_RoomId.TabIndex = 0;
            this.txt_RoomId.UderlinedStyle = true;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(242, 12);
            this.panel11.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(322, 45);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(80, 131);
            this.panel9.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(80, 131);
            this.panel8.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 176);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(402, 45);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(402, 45);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.btn_Rank);
            this.panel4.Controls.Add(this.btn_CreateRoom);
            this.panel4.Controls.Add(this.btn_Events);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(522, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 221);
            this.panel4.TabIndex = 3;
            // 
            // btn_Rank
            // 
            this.btn_Rank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Rank.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Rank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rank.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rank.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Rank.Location = new System.Drawing.Point(0, 130);
            this.btn_Rank.Name = "btn_Rank";
            this.btn_Rank.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Rank.Size = new System.Drawing.Size(120, 65);
            this.btn_Rank.TabIndex = 2;
            this.btn_Rank.Text = "Xếp Hạng";
            this.btn_Rank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rank.UseVisualStyleBackColor = true;
            this.btn_Rank.Click += new System.EventHandler(this.btn_ViewRank_Click);
            // 
            // btn_CreateRoom
            // 
            this.btn_CreateRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CreateRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_CreateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateRoom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateRoom.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CreateRoom.Location = new System.Drawing.Point(0, 65);
            this.btn_CreateRoom.Name = "btn_CreateRoom";
            this.btn_CreateRoom.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_CreateRoom.Size = new System.Drawing.Size(120, 65);
            this.btn_CreateRoom.TabIndex = 1;
            this.btn_CreateRoom.Text = "Tạo Phòng";
            this.btn_CreateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateRoom.UseVisualStyleBackColor = true;
            this.btn_CreateRoom.Click += new System.EventHandler(this.btn_InitRoom_Click);
            // 
            // btn_Events
            // 
            this.btn_Events.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Events.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Events.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Events.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Events.Location = new System.Drawing.Point(0, 0);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Events.Size = new System.Drawing.Size(120, 65);
            this.btn_Events.TabIndex = 0;
            this.btn_Events.Text = "Sự Kiện";
            this.btn_Events.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Events.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btn_ITRoom);
            this.panel3.Controls.Add(this.btn_FunnyRoom);
            this.panel3.Controls.Add(this.btn_Donate2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 221);
            this.panel3.TabIndex = 2;
            // 
            // btn_ITRoom
            // 
            this.btn_ITRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ITRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_ITRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ITRoom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ITRoom.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_ITRoom.Location = new System.Drawing.Point(0, 130);
            this.btn_ITRoom.Name = "btn_ITRoom";
            this.btn_ITRoom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ITRoom.Size = new System.Drawing.Size(120, 65);
            this.btn_ITRoom.TabIndex = 2;
            this.btn_ITRoom.Text = "Phòng IT";
            this.btn_ITRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ITRoom.UseVisualStyleBackColor = true;
            this.btn_ITRoom.Click += new System.EventHandler(this.btn_ITRoom_Click);
            // 
            // btn_FunnyRoom
            // 
            this.btn_FunnyRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FunnyRoom.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_FunnyRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FunnyRoom.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FunnyRoom.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_FunnyRoom.Location = new System.Drawing.Point(0, 65);
            this.btn_FunnyRoom.Name = "btn_FunnyRoom";
            this.btn_FunnyRoom.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_FunnyRoom.Size = new System.Drawing.Size(120, 65);
            this.btn_FunnyRoom.TabIndex = 1;
            this.btn_FunnyRoom.Text = "Phòng Vui Vẻ";
            this.btn_FunnyRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FunnyRoom.UseVisualStyleBackColor = true;
            this.btn_FunnyRoom.Click += new System.EventHandler(this.btn_FunnyRoom_Click);
            // 
            // btn_Donate2
            // 
            this.btn_Donate2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Donate2.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Donate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Donate2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donate2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Donate2.Location = new System.Drawing.Point(0, 0);
            this.btn_Donate2.Name = "btn_Donate2";
            this.btn_Donate2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Donate2.Size = new System.Drawing.Size(120, 65);
            this.btn_Donate2.TabIndex = 0;
            this.btn_Donate2.Text = "Nạp Tiền";
            this.btn_Donate2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Donate2.UseVisualStyleBackColor = true;
            this.btn_Donate2.Click += new System.EventHandler(this.btn_Donate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(200, 66);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "voquocduy32@gmail.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Quiz_Project.Properties.Resources.gmail;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(120, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(120, 32);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(402, 34);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.linkMyFB);
            this.panel18.Controls.Add(this.pictureBox1);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(402, 34);
            this.panel18.TabIndex = 4;
            // 
            // linkMyFB
            // 
            this.linkMyFB.AutoSize = true;
            this.linkMyFB.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkMyFB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMyFB.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkMyFB.Location = new System.Drawing.Point(80, 0);
            this.linkMyFB.Name = "linkMyFB";
            this.linkMyFB.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.linkMyFB.Size = new System.Drawing.Size(201, 22);
            this.linkMyFB.TabIndex = 1;
            this.linkMyFB.TabStop = true;
            this.linkMyFB.Text = "Click Here To View My Profile";
            this.linkMyFB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMyFB_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Quiz_Project.Properties.Resources.facebook;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label1);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(120, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(402, 32);
            this.panel15.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Me ";
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(167, 32);
            this.panel16.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel14.Location = new System.Drawing.Point(522, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(120, 100);
            this.panel14.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(120, 100);
            this.panel13.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbIntro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbIntro
            // 
            this.lbIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIntro.AutoSize = true;
            this.lbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.ForeColor = System.Drawing.Color.SkyBlue;
            this.lbIntro.Location = new System.Drawing.Point(73, 25);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(510, 72);
            this.lbIntro.TabIndex = 0;
            this.lbIntro.Text = "Chào Mừng Bạn Đến Với Hệ Thống Thi Trắc Nghiệm.\r\n\r\nHãy Bắt Đầu Trải Nghiệm Nào!";
            this.lbIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countText
            // 
            this.countText.Tick += new System.EventHandler(this.countText_Tick);
            // 
            // MenuPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 421);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.ListMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(870, 460);
            this.Name = "MenuPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sảnh Chờ";
            this.Load += new System.EventHandler(this.Content_Load);
            this.ListMenu.ResumeLayout(false);
            this.MenuHelp.ResumeLayout(false);
            this.SubMenuDiscovery.ResumeLayout(false);
            this.MenuDiscovery.ResumeLayout(false);
            this.MenuInitRoom.ResumeLayout(false);
            this.SubMenuInfor.ResumeLayout(false);
            this.MenuInfor.ResumeLayout(false);
            this.PanelSlider.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListMenu;
        private System.Windows.Forms.Panel SubMenuDiscovery;
        private System.Windows.Forms.Button btn_searchUser;
        private System.Windows.Forms.Panel MenuDiscovery;
        private System.Windows.Forms.Button btn_Discovery;
        private System.Windows.Forms.Panel SubMenuInfor;
        private System.Windows.Forms.Button btn_SignOut;
        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.Button btn_ShowFullInfor;
        private System.Windows.Forms.Panel MenuInfor;
        private System.Windows.Forms.Button btn_InforUser;
        private System.Windows.Forms.Panel HeaderMenu;
        private System.Windows.Forms.Panel MenuHelp;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Panel MenuInitRoom;
        private System.Windows.Forms.Button btn_InitRoom;
        private System.Windows.Forms.Button btn_ViewFanpage;
        private System.Windows.Forms.Button btn_Donate;
        private System.Windows.Forms.Button btn_ViewRank;
        private System.Windows.Forms.Panel MenuFooter;
        private System.Windows.Forms.Panel PanelSlider;
        private System.Windows.Forms.Timer countText;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Rank;
        private System.Windows.Forms.Button btn_CreateRoom;
        private System.Windows.Forms.Button btn_Events;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_ITRoom;
        private System.Windows.Forms.Button btn_FunnyRoom;
        private System.Windows.Forms.Button btn_Donate2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.LinkLabel linkMyFB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private CustomButton btn_JoinRoom;
        private LoginControl txt_RoomId;
    }
}