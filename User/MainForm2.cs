using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Job_Portal.User
{
    public partial class MainForm2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public MainForm2()
        {
            InitializeComponent();
        }

        private  void MainForm2_Load(object sender, EventArgs e)
        {
            lblshowName.Text = Form1.username;


        }

        private void user_exit_Click(object sender, EventArgs e)
        {
            //DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (check == DialogResult.Yes)
            //{
            //    Form1 loginForm = new Form1();
            //    loginForm.Show();
            //    this.Hide();
            //}
            Application.Exit();
        }

        private void user_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void user_home_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            find1.Visible = false;
            aboutUs1.Visible = false;
            contact1.Visible = false;
        }

        private void user_findajob_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            find1.Visible = true;
            aboutUs1.Visible = false;
            contact1.Visible = false;
        }

        private void user_about_Click(object sender, EventArgs e)
        {

            home1.Visible = false;
            find1.Visible = false;
            aboutUs1.Visible = true;
            contact1.Visible = false;


        }

        private void user_contact_Click(object sender, EventArgs e)
        {
            home1.Visible = false;
            find1.Visible = false;
            aboutUs1.Visible = false;
            contact1.Visible = true;

        }

        private void user_profile_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void User_profile_Click_1(object sender, EventArgs e)
        {
            user_Profile1 form = new user_Profile1();
            if(form == null)
            {
                form.Parent = this;
            }
            form.Show();
            this.Hide();

         }

        private void user_greet_Click(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notify_btn_Click(object sender, EventArgs e)
        {
            //notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath("notification.ico"));
            //notifyIcon1.Text = "";
            //notifyIcon1.Visible = true;
            //notifyIcon1.BalloonTipTitle = "Welcome ";
            //notifyIcon1.BalloonTipText = "click me";
            //notifyIcon1.ShowBalloonTip(1);
            notification notify = new notification();
            notify.Show();
            this.Hide();

        }
    }
}
