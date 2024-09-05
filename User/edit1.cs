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
    
    public partial class edit1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public edit1()
        {
            InitializeComponent();
        }

        private void Edit1_update_Click(object sender, EventArgs e)
        {
            if (Edit1_user_name.Text == ""
               || Edit1_Name.Text == ""
            || Edit1_phoneNumber.Text == ""
            || Edit1_Mailid.Text == ""
            || Edit1_Address.Text == ""
            || Edit1_country.Text == ""
            || Edit1_tenth.Text == ""
            || Edit1_twelfth.Text == ""
            || Edit1_cgpa.Text == ""
            || Edit1_resume.Text == "")
          

            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "UserName:" + Edit1_user_name.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {

                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string insertData = "INSERT INTO [User](Name,MailId,PhoneNumber,TenthGrade,TwefthGrade,CGPA,Address,Resume,Country,InsertDate)VALUES(@Name,@MailId,@PhoneNumber,@TenthGrade,@TwefthGrade,@CGPA,@Address,@Resume,@Country,@InsertDate)";
                        //string updateData = "UPDATE [user] SET Name=@Name,MailId=@MailId,PhoneNumber=@PhoneNumber,TenthGrade=@TenthGrade,TwefthGrade=@TwefthGrade,CGPA=@CGPA,Address=@Address,Resume=@Resume,Country=@Country,UpdateDate=@UpdateDate WHERE UserName=@UserName";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            //cmd.Parameters.AddWithValue("@UserName", Edit1_user_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@Name", Edit1_Name.Text.Trim());
                            cmd.Parameters.AddWithValue("@MailId", Edit1_Mailid.Text.Trim());
                            cmd.Parameters.AddWithValue("@PhoneNumber", Edit1_phoneNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@TenthGrade", Edit1_tenth.Text.Trim());
                            cmd.Parameters.AddWithValue("@TwefthGrade", Edit1_twelfth.Text.Trim());
                            cmd.Parameters.AddWithValue("@CGPA", Edit1_cgpa.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", Edit1_Address.Text.Trim());
                            cmd.Parameters.AddWithValue("@Resume", Edit1_resume.Text.Trim());
                            cmd.Parameters.AddWithValue("@Country", Edit1_country.Text.Trim());
                            
                            cmd.Parameters.AddWithValue("@InsertDate", today);
                            cmd.Parameters.AddWithValue("@UserName", Edit1_user_name.Text.Trim());
                           

                            cmd.ExecuteNonQuery();

                            

                            MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

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
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Edit1_resume_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files (*.txt; *.pdf)|*.txt;*.pdf";
                string Path = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Path = dialog.FileName;
                    Edit1_resume.Text = Path;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm2 mainForm = new MainForm2();
            mainForm.Show();
        }
    }
}
