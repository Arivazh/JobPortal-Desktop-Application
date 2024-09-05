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

namespace Job_Portal.User
{
    public partial class user_Profile1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public user_Profile1()
        {
            InitializeComponent();
        }

        private void profile1_edit_Click(object sender, EventArgs e)
        {
            edit1 edit = new edit1();
            if(edit == null)
            {
                edit.Parent = this;
            }
            edit.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Profile1_browse_Click(object sender, EventArgs e)
        {
             try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files (*.txt; *.pdf)|*.txt;*.pdf";
                string Path = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                     Path = dialog.FileName;
                    Profile1_browse.Text = Path;
                
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void profile_add_Click(object sender, EventArgs e)
        {
            if(profile1_Name.Text==""
                ||profile1_Mailid.Text==""
                || profile1_PhoneNumber.Text==""
                ||profile1_Address.Text==""
                || Profile1_browse.Text == "")
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
                        string checkJobID = "SELECT COUNT (*)FROM [User] WHERE Name = @Name AND DeleteDate IS NULL";
                        using (SqlCommand checkJob = new SqlCommand(checkJobID, connect))
                        {
                            checkJob.Parameters.AddWithValue("@Name", profile1_Name.Text.Trim());
                            int count = (int)checkJob.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(profile1_Name.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO [User](Name,MailId,PhoneNumber,Address,Resume,InsertDate)VALUES(@Name,@MailId,@PhoneNumber,@Address,@Resume,@InsertDate)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@Name", profile1_Name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@MailId", profile1_Mailid.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PhoneNumber", profile1_PhoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Address", profile1_Address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Resume", Profile1_browse.Text.Trim());
                                  
                                    cmd.Parameters.AddWithValue("@InsertDate", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                 
                                }
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }

            }
        }

        private void user_Profile1_Load(object sender, EventArgs e)
        {
      

        }
    }
}
