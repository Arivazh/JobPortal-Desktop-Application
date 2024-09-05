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

namespace Job_Portal
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void signup_showpass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showpass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(signup_username.Text==""||signup_password.Text=="" ||signup_LoginType.Text=="")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State!=ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(id)FROM admin WHERE username=@user";
                        using(SqlCommand checkuser = new SqlCommand(selectUsername, connect))
                        {
                            checkuser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkuser.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO admin" + "(username, password,LoginType, date_register)" + "VALUES(@username, @password,@LoginType, @dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@LoginType", signup_LoginType.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginform = new Form1();
                                    loginform.Show();
                                    this.Hide();
                                }
                            }
                        }
                        //DateTime today = DateTime.Today;
                        //string insertData = "INSERT INTO users" + "(username, password, date_register)"+ "VALUES(@username, @password, @dateReg)";
                       // using(SqlCommand cmd= new SqlCommand(insertData, connect))
                        //{
                            //cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                            //cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                            //cmd.Parameters.AddWithValue("@dateReg", today);
                            //cmd.ExecuteNonQuery();
                            //MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Form1 loginform = new Form1();
                            //loginform.Show();
                           // this.Hide();
                        //}
                     
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
               

            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
