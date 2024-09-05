
namespace Job_Portal.User
{
    partial class MainForm2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Notify_btn = new System.Windows.Forms.Button();
            this.User_profile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblshowName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_logout = new System.Windows.Forms.Button();
            this.user_contact = new System.Windows.Forms.Button();
            this.user_about = new System.Windows.Forms.Button();
            this.user_findajob = new System.Windows.Forms.Button();
            this.user_home = new System.Windows.Forms.Button();
            this.user_greet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.home1 = new Job_Portal.User.Home();
            this.find1 = new Job_Portal.User.find();
            this.aboutUs1 = new Job_Portal.User.AboutUs();
            this.contact1 = new Job_Portal.User.Contact();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Notify_btn);
            this.panel1.Controls.Add(this.User_profile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.user_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 112);
            this.panel1.TabIndex = 0;
            // 
            // Notify_btn
            // 
            this.Notify_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Notify_btn.Image = global::Job_Portal.Properties.Resources.notification;
            this.Notify_btn.Location = new System.Drawing.Point(1101, 67);
            this.Notify_btn.Name = "Notify_btn";
            this.Notify_btn.Size = new System.Drawing.Size(41, 37);
            this.Notify_btn.TabIndex = 3;
            this.Notify_btn.UseVisualStyleBackColor = true;
            this.Notify_btn.Click += new System.EventHandler(this.Notify_btn_Click);
            // 
            // User_profile
            // 
            this.User_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_profile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_profile.ForeColor = System.Drawing.Color.White;
            this.User_profile.Location = new System.Drawing.Point(925, 66);
            this.User_profile.Name = "User_profile";
            this.User_profile.Size = new System.Drawing.Size(95, 38);
            this.User_profile.TabIndex = 2;
            this.User_profile.Text = "Profile";
            this.User_profile.UseVisualStyleBackColor = true;
            this.User_profile.Click += new System.EventHandler(this.User_profile_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Portal";
            // 
            // user_exit
            // 
            this.user_exit.AutoSize = true;
            this.user_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_exit.ForeColor = System.Drawing.Color.White;
            this.user_exit.Location = new System.Drawing.Point(1145, 8);
            this.user_exit.Name = "user_exit";
            this.user_exit.Size = new System.Drawing.Size(24, 24);
            this.user_exit.TabIndex = 0;
            this.user_exit.Text = "X";
            this.user_exit.Click += new System.EventHandler(this.user_exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.lblshowName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.user_logout);
            this.panel2.Controls.Add(this.user_contact);
            this.panel2.Controls.Add(this.user_about);
            this.panel2.Controls.Add(this.user_findajob);
            this.panel2.Controls.Add(this.user_home);
            this.panel2.Controls.Add(this.user_greet);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 576);
            this.panel2.TabIndex = 1;
            // 
            // lblshowName
            // 
            this.lblshowName.AutoSize = true;
            this.lblshowName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblshowName.Location = new System.Drawing.Point(73, 193);
            this.lblshowName.Name = "lblshowName";
            this.lblshowName.Size = new System.Drawing.Size(0, 34);
            this.lblshowName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(88, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "LogOut";
            // 
            // user_logout
            // 
            this.user_logout.FlatAppearance.BorderSize = 0;
            this.user_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_logout.Image = global::Job_Portal.Properties.Resources.tiny_logout;
            this.user_logout.Location = new System.Drawing.Point(28, 514);
            this.user_logout.Name = "user_logout";
            this.user_logout.Size = new System.Drawing.Size(45, 50);
            this.user_logout.TabIndex = 6;
            this.user_logout.UseVisualStyleBackColor = true;
            this.user_logout.Click += new System.EventHandler(this.user_logout_Click);
            // 
            // user_contact
            // 
            this.user_contact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_contact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_contact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_contact.ForeColor = System.Drawing.Color.White;
            this.user_contact.Image = global::Job_Portal.Properties.Resources.phone;
            this.user_contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_contact.Location = new System.Drawing.Point(42, 453);
            this.user_contact.Name = "user_contact";
            this.user_contact.Size = new System.Drawing.Size(169, 41);
            this.user_contact.TabIndex = 5;
            this.user_contact.Text = "CONTACT";
            this.user_contact.UseVisualStyleBackColor = true;
            this.user_contact.Click += new System.EventHandler(this.user_contact_Click);
            // 
            // user_about
            // 
            this.user_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_about.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_about.ForeColor = System.Drawing.Color.White;
            this.user_about.Image = global::Job_Portal.Properties.Resources.chat;
            this.user_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_about.Location = new System.Drawing.Point(42, 394);
            this.user_about.Name = "user_about";
            this.user_about.Size = new System.Drawing.Size(169, 41);
            this.user_about.TabIndex = 4;
            this.user_about.Text = "ABOUT";
            this.user_about.UseVisualStyleBackColor = true;
            this.user_about.Click += new System.EventHandler(this.user_about_Click);
            // 
            // user_findajob
            // 
            this.user_findajob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_findajob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_findajob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_findajob.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_findajob.ForeColor = System.Drawing.Color.White;
            this.user_findajob.Image = global::Job_Portal.Properties.Resources.findajob;
            this.user_findajob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_findajob.Location = new System.Drawing.Point(42, 332);
            this.user_findajob.Name = "user_findajob";
            this.user_findajob.Size = new System.Drawing.Size(169, 41);
            this.user_findajob.TabIndex = 3;
            this.user_findajob.Text = "    FIND A JOB";
            this.user_findajob.UseVisualStyleBackColor = true;
            this.user_findajob.Click += new System.EventHandler(this.user_findajob_Click);
            // 
            // user_home
            // 
            this.user_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.user_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_home.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_home.ForeColor = System.Drawing.Color.White;
            this.user_home.Image = global::Job_Portal.Properties.Resources.HOME;
            this.user_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_home.Location = new System.Drawing.Point(42, 272);
            this.user_home.Name = "user_home";
            this.user_home.Size = new System.Drawing.Size(169, 41);
            this.user_home.TabIndex = 2;
            this.user_home.Text = "HOME";
            this.user_home.UseVisualStyleBackColor = true;
            this.user_home.Click += new System.EventHandler(this.user_home_Click);
            // 
            // user_greet
            // 
            this.user_greet.AutoSize = true;
            this.user_greet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_greet.ForeColor = System.Drawing.Color.White;
            this.user_greet.Location = new System.Drawing.Point(70, 155);
            this.user_greet.Name = "user_greet";
            this.user_greet.Size = new System.Drawing.Size(124, 24);
            this.user_greet.TabIndex = 1;
            this.user_greet.Text = "Welcome!!!";
            this.user_greet.Click += new System.EventHandler(this.user_greet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Job_Portal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(74, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.home1);
            this.panel3.Controls.Add(this.find1);
            this.panel3.Controls.Add(this.aboutUs1);
            this.panel3.Controls.Add(this.contact1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(252, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 576);
            this.panel3.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(1, 0);
            this.home1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(930, 576);
            this.home1.TabIndex = 3;
            // 
            // find1
            // 
            this.find1.Location = new System.Drawing.Point(-2, 0);
            this.find1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(930, 576);
            this.find1.TabIndex = 2;
            // 
            // aboutUs1
            // 
            this.aboutUs1.Location = new System.Drawing.Point(1, -4);
            this.aboutUs1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(930, 576);
            this.aboutUs1.TabIndex = 1;
            // 
            // contact1
            // 
            this.contact1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact1.Location = new System.Drawing.Point(1, 0);
            this.contact1.Name = "contact1";
            this.contact1.Size = new System.Drawing.Size(930, 576);
            this.contact1.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 688);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_exit;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user_greet;
        private System.Windows.Forms.Button user_home;
        private System.Windows.Forms.Button user_contact;
        private System.Windows.Forms.Button user_about;
        private System.Windows.Forms.Button user_findajob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button user_logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button User_profile;
        private System.Windows.Forms.Label lblshowName;
        private Home home1;
        private find find1;
        private AboutUs aboutUs1;
        private Contact contact1;
        private System.Windows.Forms.Button Notify_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}