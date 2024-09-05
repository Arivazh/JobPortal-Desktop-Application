using System;
using System.Windows.Forms;

namespace Job_Portal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (check == DialogResult.Yes)
            //{
            //    Form1 loginForm = new Form1();
            //    loginForm.Show();
            //    this.Hide();
            //}
        }

        private void DashBoard_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            addJob1.Visible = false;
            jobList1.Visible = false;
            resume1.Visible = false;
            userList1.Visible = false;
            list1.Visible = false;

            DashBoard dashForm = dashBoard1 as DashBoard;
            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddJob_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addJob1.Visible = true;
            jobList1.Visible = false;
            resume1.Visible = false;
            userList1.Visible = false;
            list1.Visible = false;

            AddJob addJobForm = addJob1 as AddJob;
            if (addJobForm != null)
            {
                addJobForm.RefreshData();
            }

        }

        private void Joblist_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addJob1.Visible = false;
            jobList1.Visible = true;
            resume1.Visible = false;
            userList1.Visible = false;
            list1.Visible = false;

        }

        private void Resume_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addJob1.Visible = false;
            jobList1.Visible = false;
            resume1.Visible = true;
            userList1.Visible = false;
            list1.Visible = false;

        }

        private void UserList_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addJob1.Visible = false;
            jobList1.Visible = false;
            resume1.Visible = false;
            userList1.Visible = true;
            list1.Visible = false;
        }

        private void Contact_btn_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = false;
            addJob1.Visible = false;
            jobList1.Visible = false;
            resume1.Visible = false;
            userList1.Visible = false;
            list1.Visible = true;
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }

        }

        private void Greet_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          lbl_show_name.Text = Form1.Username;

        }
    }
}
