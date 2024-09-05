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
    

    public partial class Contact : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public Contact()
        {
            InitializeComponent();
            //TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            //displayContactData();
        }
        public void displayContactData()
        {
            ContactData cd = new ContactData();
            List<ContactData> ListData = new List<ContactData>();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void user_send_Click(object sender, EventArgs e)
        {
            

        }

        public void contact_send_Click(object sender, EventArgs e)
        {
            if(Contact_NameTxt.Text==""
                || Contact_MailId.Text == ""
                || Contact_subject.Text == ""
                ||contact_message.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkUserId = "SELECT COUNT(*) FROM Contact WHERE UserName = @UserName ";
                        using (SqlCommand checkUser = new SqlCommand(checkUserId, connect))
                        {
                            checkUser.Parameters.AddWithValue("@UserName", Contact_NameTxt.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            if (count >=1 )
                            {
                                MessageBox.Show(Contact_NameTxt.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                              
                                string insertData = "INSERT INTO Contact(UserName,MailId,Subject,Message)VALUES(@UserName,@MailId,@Subject,@Message)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@UserName", Contact_NameTxt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@MailId", Contact_MailId.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Subject", Contact_subject.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Message",contact_message .Text.Trim());

                                    cmd.ExecuteNonQuery();
                              
                                    //displayUserData();

                                    MessageBox.Show("Your Message has been sent Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                                }
                            }
                        }
                    }
                    catch (Exception ex)
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

        private void Contact_NameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
