namespace Quiz_Project
{
    partial class QuizGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizGame));
            this.countTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOptionA = new Quiz_Project.CustomButton();
            this.btnOptionB = new Quiz_Project.CustomButton();
            this.btnOptionC = new Quiz_Project.CustomButton();
            this.btnOptionD = new Quiz_Project.CustomButton();
            this.txt_Question = new Quiz_Project.CustomButton();
            this.txtUserScore = new Quiz_Project.CustomButton();
            this.CtrTimeLeft = new Quiz_Project.ControlProgressBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countTimeLeft
            // 
            this.countTimeLeft.Interval = 10;
            this.countTimeLeft.Tick += new System.EventHandler(this.countTimeLeft_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtUserScore);
            this.panel1.Controls.Add(this.CtrTimeLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txt_Question);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 101);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.40876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.49635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.189781F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.49635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.40876F));
            this.tableLayoutPanel1.Controls.Add(this.btnOptionA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOptionB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOptionC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOptionD, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.347826F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 327);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnOptionA
            // 
            this.btnOptionA.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOptionA.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOptionA.BorderRadius = 15;
            this.btnOptionA.BorderSize = 0;
            this.btnOptionA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptionA.FlatAppearance.BorderSize = 0;
            this.btnOptionA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionA.ForeColor = System.Drawing.Color.White;
            this.btnOptionA.Location = new System.Drawing.Point(92, 17);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(257, 136);
            this.btnOptionA.TabIndex = 0;
            this.btnOptionA.UseVisualStyleBackColor = false;
            this.btnOptionA.Click += new System.EventHandler(this.btnOptionA_Click);
            // 
            // btnOptionB
            // 
            this.btnOptionB.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOptionB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOptionB.BorderRadius = 15;
            this.btnOptionB.BorderSize = 0;
            this.btnOptionB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptionB.FlatAppearance.BorderSize = 0;
            this.btnOptionB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionB.ForeColor = System.Drawing.Color.White;
            this.btnOptionB.Location = new System.Drawing.Point(370, 17);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(257, 136);
            this.btnOptionB.TabIndex = 0;
            this.btnOptionB.UseVisualStyleBackColor = false;
            this.btnOptionB.Click += new System.EventHandler(this.btnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnOptionC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOptionC.BorderRadius = 15;
            this.btnOptionC.BorderSize = 0;
            this.btnOptionC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptionC.FlatAppearance.BorderSize = 0;
            this.btnOptionC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionC.ForeColor = System.Drawing.Color.White;
            this.btnOptionC.Location = new System.Drawing.Point(92, 173);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(257, 136);
            this.btnOptionC.TabIndex = 0;
            this.btnOptionC.UseVisualStyleBackColor = false;
            this.btnOptionC.Click += new System.EventHandler(this.btnOptionC_Click);
            // 
            // btnOptionD
            // 
            this.btnOptionD.BackColor = System.Drawing.Color.Plum;
            this.btnOptionD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOptionD.BorderRadius = 15;
            this.btnOptionD.BorderSize = 0;
            this.btnOptionD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptionD.FlatAppearance.BorderSize = 0;
            this.btnOptionD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionD.ForeColor = System.Drawing.Color.White;
            this.btnOptionD.Location = new System.Drawing.Point(370, 173);
            this.btnOptionD.Name = "btnOptionD";
            this.btnOptionD.Size = new System.Drawing.Size(257, 136);
            this.btnOptionD.TabIndex = 0;
            this.btnOptionD.UseVisualStyleBackColor = false;
            this.btnOptionD.Click += new System.EventHandler(this.btnOptionD_Click);
            // 
            // txt_Question
            // 
            this.txt_Question.BackColor = System.Drawing.Color.Transparent;
            this.txt_Question.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Question.BorderRadius = 0;
            this.txt_Question.BorderSize = 0;
            this.txt_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Question.FlatAppearance.BorderSize = 0;
            this.txt_Question.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txt_Question.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txt_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Question.ForeColor = System.Drawing.Color.LightGreen;
            this.txt_Question.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_Question.Location = new System.Drawing.Point(0, 0);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(722, 101);
            this.txt_Question.TabIndex = 0;
            this.txt_Question.UseVisualStyleBackColor = false;
            // 
            // txtUserScore
            // 
            this.txtUserScore.BackColor = System.Drawing.Color.Transparent;
            this.txtUserScore.BorderColor = System.Drawing.Color.Transparent;
            this.txtUserScore.BorderRadius = 15;
            this.txtUserScore.BorderSize = 0;
            this.txtUserScore.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtUserScore.FlatAppearance.BorderSize = 0;
            this.txtUserScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txtUserScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txtUserScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserScore.ForeColor = System.Drawing.Color.White;
            this.txtUserScore.Location = new System.Drawing.Point(572, 0);
            this.txtUserScore.Name = "txtUserScore";
            this.txtUserScore.Size = new System.Drawing.Size(150, 50);
            this.txtUserScore.TabIndex = 2;
            this.txtUserScore.UseVisualStyleBackColor = false;
            // 
            // CtrTimeLeft
            // 
            this.CtrTimeLeft.BackColor = System.Drawing.SystemColors.Control;
            this.CtrTimeLeft.ChannelColor = System.Drawing.Color.CornflowerBlue;
            this.CtrTimeLeft.ChannelHeight = 10;
            this.CtrTimeLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtrTimeLeft.ForeBackColor = System.Drawing.Color.Transparent;
            this.CtrTimeLeft.ForeColor = System.Drawing.Color.Transparent;
            this.CtrTimeLeft.Location = new System.Drawing.Point(0, 50);
            this.CtrTimeLeft.Maximum = 3000;
            this.CtrTimeLeft.Name = "CtrTimeLeft";
            this.CtrTimeLeft.ShowValue = Quiz_Project.TextPosition.Right;
            this.CtrTimeLeft.Size = new System.Drawing.Size(722, 10);
            this.CtrTimeLeft.SliderColor = System.Drawing.Color.LimeGreen;
            this.CtrTimeLeft.SliderHeight = 10;
            this.CtrTimeLeft.TabIndex = 1;
            // 
            // QuizGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Project.Properties.Resources.QuizGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 488);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(738, 527);
            this.Name = "QuizGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng Thi";
            this.Activated += new System.EventHandler(this.QuizGame_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizGame_FormClosed);
            this.Load += new System.EventHandler(this.QuizGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer countTimeLeft;
        private System.Windows.Forms.Panel panel1;
        private ControlProgressBar CtrTimeLeft;
        private System.Windows.Forms.Panel panel2;
        private CustomButton txt_Question;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomButton btnOptionA;
        private CustomButton btnOptionB;
        private CustomButton btnOptionC;
        private CustomButton btnOptionD;
        private CustomButton txtUserScore;
    }
}