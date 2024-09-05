
namespace Job_Portal
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.Greet_btn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_button = new System.Windows.Forms.Button();
            this.AddJob_btn = new System.Windows.Forms.Button();
            this.DashBoard_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Contact_btn = new System.Windows.Forms.Button();
            this.UserList_btn = new System.Windows.Forms.Button();
            this.Resume_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Joblist_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_show_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dashBoard1 = new Job_Portal.DashBoard();
            this.addJob1 = new Job_Portal.AddJob();
            this.jobList1 = new Job_Portal.JobList();
            this.resume1 = new Job_Portal.Resume();
            this.userList1 = new Job_Portal.UserList();
            this.list1 = new Job_Portal.Contact();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Portal";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1344, 17);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 21);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Greet_btn
            // 
            this.Greet_btn.AutoSize = true;
            this.Greet_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greet_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Greet_btn.Location = new System.Drawing.Point(48, 180);
            this.Greet_btn.Name = "Greet_btn";
            this.Greet_btn.Size = new System.Drawing.Size(113, 24);
            this.Greet_btn.TabIndex = 1;
            this.Greet_btn.Text = "Welcome!!!";
            this.Greet_btn.Click += new System.EventHandler(this.Greet_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.Logout_button);
            this.panel2.Controls.Add(this.AddJob_btn);
            this.panel2.Controls.Add(this.DashBoard_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Contact_btn);
            this.panel2.Controls.Add(this.UserList_btn);
            this.panel2.Controls.Add(this.Resume_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Joblist_btn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Greet_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 690);
            this.panel2.TabIndex = 2;
            // 
            // Logout_button
            // 
            this.Logout_button.FlatAppearance.BorderSize = 0;
            this.Logout_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_button.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_button.Image = global::Job_Portal.Properties.Resources.tiny_logout;
            this.Logout_button.Location = new System.Drawing.Point(17, 627);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(51, 57);
            this.Logout_button.TabIndex = 14;
            this.Logout_button.UseVisualStyleBackColor = true;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // AddJob_btn
            // 
            this.AddJob_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddJob_btn.FlatAppearance.BorderSize = 0;
            this.AddJob_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddJob_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddJob_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddJob_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJob_btn.ForeColor = System.Drawing.Color.White;
            this.AddJob_btn.Image = global::Job_Portal.Properties.Resources.tiny__add_job;
            this.AddJob_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddJob_btn.Location = new System.Drawing.Point(17, 314);
            this.AddJob_btn.Name = "AddJob_btn";
            this.AddJob_btn.Size = new System.Drawing.Size(213, 40);
            this.AddJob_btn.TabIndex = 13;
            this.AddJob_btn.Text = "     ADD JOB";
            this.AddJob_btn.UseVisualStyleBackColor = true;
            this.AddJob_btn.Click += new System.EventHandler(this.AddJob_btn_Click);
            // 
            // DashBoard_btn
            // 
            this.DashBoard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashBoard_btn.FlatAppearance.BorderSize = 0;
            this.DashBoard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DashBoard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.DashBoard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoard_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_btn.ForeColor = System.Drawing.Color.White;
            this.DashBoard_btn.Image = global::Job_Portal.Properties.Resources.performance;
            this.DashBoard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashBoard_btn.Location = new System.Drawing.Point(17, 259);
            this.DashBoard_btn.Name = "DashBoard_btn";
            this.DashBoard_btn.Size = new System.Drawing.Size(213, 40);
            this.DashBoard_btn.TabIndex = 12;
            this.DashBoard_btn.Text = "   DASHBOARD";
            this.DashBoard_btn.UseVisualStyleBackColor = true;
            this.DashBoard_btn.Click += new System.EventHandler(this.DashBoard_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Location = new System.Drawing.Point(17, 631);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(51, 49);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(253, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1453, 676);
            this.panel3.TabIndex = 3;
            // 
            // Contact_btn
            // 
            this.Contact_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contact_btn.FlatAppearance.BorderSize = 0;
            this.Contact_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Contact_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Contact_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_btn.ForeColor = System.Drawing.Color.White;
            this.Contact_btn.Image = global::Job_Portal.Properties.Resources.applied_jobs_db;
            this.Contact_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contact_btn.Location = new System.Drawing.Point(17, 564);
            this.Contact_btn.Name = "Contact_btn";
            this.Contact_btn.Size = new System.Drawing.Size(213, 40);
            this.Contact_btn.TabIndex = 9;
            this.Contact_btn.Text = "            CONTACT ";
            this.Contact_btn.UseVisualStyleBackColor = true;
            this.Contact_btn.Click += new System.EventHandler(this.Contact_btn_Click);
            // 
            // UserList_btn
            // 
            this.UserList_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserList_btn.FlatAppearance.BorderSize = 0;
            this.UserList_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.UserList_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.UserList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserList_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserList_btn.ForeColor = System.Drawing.Color.White;
            this.UserList_btn.Image = global::Job_Portal.Properties.Resources.TINY_USER;
            this.UserList_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserList_btn.Location = new System.Drawing.Point(17, 502);
            this.UserList_btn.Name = "UserList_btn";
            this.UserList_btn.Size = new System.Drawing.Size(213, 40);
            this.UserList_btn.TabIndex = 8;
            this.UserList_btn.Text = "        USER LIST";
            this.UserList_btn.UseVisualStyleBackColor = true;
            this.UserList_btn.Click += new System.EventHandler(this.UserList_btn_Click);
            // 
            // Resume_btn
            // 
            this.Resume_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resume_btn.FlatAppearance.BorderSize = 0;
            this.Resume_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Resume_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Resume_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume_btn.ForeColor = System.Drawing.Color.White;
            this.Resume_btn.Image = global::Job_Portal.Properties.Resources.tiny_resume__1_;
            this.Resume_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resume_btn.Location = new System.Drawing.Point(17, 441);
            this.Resume_btn.Name = "Resume_btn";
            this.Resume_btn.Size = new System.Drawing.Size(213, 40);
            this.Resume_btn.TabIndex = 7;
            this.Resume_btn.Text = "         RESUME";
            this.Resume_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Resume_btn.UseVisualStyleBackColor = true;
            this.Resume_btn.Click += new System.EventHandler(this.Resume_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 647);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign Out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Joblist_btn
            // 
            this.Joblist_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Joblist_btn.FlatAppearance.BorderSize = 0;
            this.Joblist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Joblist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Joblist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Joblist_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joblist_btn.ForeColor = System.Drawing.Color.White;
            this.Joblist_btn.Image = global::Job_Portal.Properties.Resources.Total_jobs_db;
            this.Joblist_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Joblist_btn.Location = new System.Drawing.Point(17, 374);
            this.Joblist_btn.Name = "Joblist_btn";
            this.Joblist_btn.Size = new System.Drawing.Size(213, 40);
            this.Joblist_btn.TabIndex = 4;
            this.Joblist_btn.Text = "      JOB LIST";
            this.Joblist_btn.UseVisualStyleBackColor = true;
            this.Joblist_btn.Click += new System.EventHandler(this.Joblist_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Portal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_show_name
            // 
            this.lbl_show_name.AutoSize = true;
            this.lbl_show_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.lbl_show_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_show_name.Location = new System.Drawing.Point(74, 257);
            this.lbl_show_name.Name = "lbl_show_name";
            this.lbl_show_name.Size = new System.Drawing.Size(64, 24);
            this.lbl_show_name.TabIndex = 15;
            this.lbl_show_name.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dashBoard1);
            this.panel4.Controls.Add(this.addJob1);
            this.panel4.Controls.Add(this.jobList1);
            this.panel4.Controls.Add(this.resume1);
            this.panel4.Controls.Add(this.userList1);
            this.panel4.Controls.Add(this.list1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(247, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1124, 690);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dashBoard1
            // 
            this.dashBoard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashBoard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashBoard1.Location = new System.Drawing.Point(0, 2);
            this.dashBoard1.Name = "dashBoard1";
            this.dashBoard1.Size = new System.Drawing.Size(1124, 700);
            this.dashBoard1.TabIndex = 5;
            // 
            // addJob1
            // 
            this.addJob1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addJob1.Location = new System.Drawing.Point(3, -2);
            this.addJob1.Name = "addJob1";
            this.addJob1.Size = new System.Drawing.Size(1117, 723);
            this.addJob1.TabIndex = 4;
            // 
            // jobList1
            // 
            this.jobList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jobList1.Location = new System.Drawing.Point(3, 3);
            this.jobList1.Name = "jobList1";
            this.jobList1.Size = new System.Drawing.Size(1121, 698);
            this.jobList1.TabIndex = 3;
            // 
            // resume1

            this.resume1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resume1.Location = new System.Drawing.Point(6, 3);
            this.resume1.Name = "resume1";
            this.resume1.Size = new System.Drawing.Size(1118, 698);
            this.resume1.TabIndex = 2;

            // userList1
            // 
            this.userList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userList1.Location = new System.Drawing.Point(3, 2);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(1121, 694);
            this.userList1.TabIndex = 1;
            // 
            // list1
            // 
            this.list1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list1.Location = new System.Drawing.Point(3, 0);
            this.list1.Margin = new System.Windows.Forms.Padding(4);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(1118, 696);
            this.list1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 734);
            this.Controls.Add(this.lbl_show_name);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Greet_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Joblist_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UserList_btn;
        private System.Windows.Forms.Button Resume_btn;
        private System.Windows.Forms.Button Contact_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button DashBoard_btn;
        private System.Windows.Forms.Button AddJob_btn;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Label lbl_show_name;
        private DashBoard dashBoard1;
        private AddJob addJob1;
        private JobList jobList1;
        private Resume resume1;
        private UserList userList1;
        private Contact list1;
    }
}