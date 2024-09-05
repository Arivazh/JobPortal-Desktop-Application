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
using Job_Portal.User;

namespace Job_Portal
{
    public partial class Form1 : Form
    {
        public static string username;
        public static string Username;
        //public static string USERNAME;
      
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //username = login_username.Text;
            //MainForm2 mainForm2 = new MainForm2();
            //mainForm2.Show();


            if (login_username.Text == "" || login_password.Text == "" || login_Type.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM admin WHERE username = @username" + " AND password=@password" +" AND LoginType=@LoginType";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@LoginType", login_Type.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            string logintype = login_Type.SelectedItem.ToString();
                            if (table.Rows.Count > 0)
                            {
                                for(int i=0; i<table.Rows.Count;i++)
                                {
                                    if (table.Rows[i]["LoginType"].ToString() == logintype)
                                    {
                                        MessageBox.Show("You are Login as" + table.Rows[i][2]);
                                        if(login_Type.SelectedIndex == 0)
                                        {

                                            if (login_username.Text == "Admin3" && login_password.Text == "Admin234" && login_Type.Text == "Admin")
                                            {
                                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                MainForm mForm = new MainForm();
                                                mForm.Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Incorrect username/password for Admin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            //MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //MainForm mForm = new MainForm();
                                            //Username = login_username.Text;
                                            //mForm.Show();
                                            //this.Hide();
                                            //username = login_username.Text;
                                            //MainForm2 mainForm = new MainForm2();
                                            //mainForm.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MainForm2 mform2 = new MainForm2();
                                            
                                            username = login_username.Text;
                                            
                                            this.Hide();
                                            //username = login_username.Text;
                                            mform2.Show();
                                           // username = login_username.Text;
                                           //MainForm2 mainForm3 = new MainForm2();
                                           // mainForm3.Show();
                                        }
                                    }
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
                //    //try
                //    {
                //        connect.Open();
                //    }
                //catch (Exception ex)
                //    {
                //        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    finally
                //    {
                //        connect.Close();
                //    }

            }
        }



                private void Form1_Load(object sender, EventArgs e)
                {

                }
            
        

    }
}



