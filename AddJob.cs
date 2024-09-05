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

namespace Job_Portal
{
    public partial class AddJob : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public AddJob()
        {
            InitializeComponent();

            //TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayStudentData();
        }



        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayStudentData();
        }
        public void displayStudentData()
        {
            StudentData Sd = new StudentData();
            List<StudentData> listdata = Sd.StudentListData();

            dataGridView1.DataSource = listdata;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Add_job_add_btn_Click(object sender, EventArgs e)
        {
            //AddJob_Id.Text == ""
               if (AddJob_CollegeName.Text == ""
            || Add_Job_Title.Text == ""
            || Add_Job_Description.Text == ""
            || Add_job_No_of_post.Text == ""
            || add_job_Qualification.Text == ""
            || Add_job_domainarea.Text == ""
            || Add_job_Salary.Text == ""
          || Add_job_Type.Text == ""
          || Add_job_company_name.Text == ""
          || Add_job_Mail_id.Text == ""
          || Add_job_Address.Text == ""
          || Add_job_Country.Text == ""
          || Add_job_State.Text == ""
          || Add_job_Last_to_Apply.Text == "")

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
                        string checkJobID = "SELECT COUNT (*)FROM job WHERE JobId = @jobID AND DeleteDate IS NULL";
                        using (SqlCommand checkJob = new SqlCommand(checkJobID, connect))
                        {
                            checkJob.Parameters.AddWithValue("@jobID", AddJob_Id.Text.Trim());
                            int count = (int)checkJob.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show(AddJob_Id.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO job(CollegeName,JobTitle,Description,NoOfPost,Qualification,DomainArea,Salary,JobType,CompanyName,MailId,Address,Country,State,LastToApply, InsertDate)VALUES(@CollegeName,@JobTitle,@Description,@NoOfPost,@Qualification,@DomainArea,@Salary,@JobType,@CompanyName,@MailId,@Address,@Country,@State,@LastToApply, @InsertDate)";
                                //"JobId, CollegeName,JobTitle,Description,NoOfPost,Qualification,Qualification,Specialization,Salary,JobType,CompanyName,MailId,Address,Country,State,LastToApply, InsertDate)" +



                                // string path = Path.Combine(@"C:\Users\vini1\Desktop\Job Portal\Directory\"
                                //+ AddJob_Id.Text.Trim() + ".jpg");

                                // string directoryPath = Path.GetDirectoryName(path);
                                // if (!Directory.Exists(directoryPath))
                                // {
                                //     Directory.CreateDirectory(directoryPath);
                                // }

                                // File.Copy(Add_job_company_name.Text, path, true);
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    //cmd.Parameters.AddWithValue("@JobId", AddJob_Id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CollegeName", AddJob_CollegeName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@JobTitle", Add_Job_Title.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Description", Add_Job_Description.Text.Trim());
                                    cmd.Parameters.AddWithValue("@NoOfPost", Add_job_No_of_post.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Qualification", add_job_Qualification.Text.Trim());
                                    //cmd.Parameters.AddWithValue("@Specialization", Add_job_specialization.Text.Trim());
                                    cmd.Parameters.AddWithValue("@DomainArea", Add_job_domainarea.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Salary", Add_job_Salary.Text.Trim());
                                    cmd.Parameters.AddWithValue("@JobType", Add_job_Type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CompanyName", Add_job_company_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@MailId", Add_job_Mail_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Address", Add_job_Address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Country", Add_job_Country.Text.Trim());
                                    cmd.Parameters.AddWithValue("@State", Add_job_State.Text.Trim());
                                    ////cmd.Parameters.AddWithValue("@JobId", AddJob_Id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@LastToApply", Add_job_Last_to_Apply.Text.Trim());
                                    //cmd.Parameters.AddWithValue("@Field1", Add_job_field1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@InsertDate", today);
                                                                    
                                     cmd.ExecuteNonQuery();

                                    displayStudentData();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();

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

        private void Add_job_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         }

        private void Add_job_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            


        }

        private void Add_job_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Add_job_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddJob_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    AddJob_Id.Text = row.Cells["JobId"].Value.ToString();                 
            //    AddJob_CollegeName.Text = row.Cells["CollegeName"].Value.ToString();
            //    Add_Job_Title.Text = row.Cells["JobTitle"].Value.ToString();
            //    Add_Job_Description.Text = row.Cells["Description"].Value.ToString();
            //    Add_job_No_of_post.Text = row.Cells["NoOfPost"].Value.ToString();
            //    add_job_Qualification.Text = row.Cells["Qualification"].Value.ToString();
            //    Add_job_domainarea.Text = row.Cells["DomainArea"].Value.ToString();
            //   //Add_job_specialization.Text = row.Cells["Specialization"].Value.ToString();
            //    //Add_job_field.Text = row.Cells["Field"].Value.ToString();
            //    Add_job_Salary.Text = row.Cells["Salary"].Value.ToString();
            //    Add_job_Type.Text = row.Cells["JobType"].Value.ToString();
            //    Add_job_company_name.Text = row.Cells["CompanyName"].Value.ToString();
            //    Add_job_Mail_id.Text = row.Cells["MailId"].Value.ToString();
            //    Add_job_Address.Text = row.Cells["Address "].Value.ToString();
            //    Add_job_Country.Text = row.Cells["Country"].Value.ToString();
            //    Add_job_State.Text = row.Cells["State "].Value.ToString();
            //    //Add_job_field.Text = row.Cells["Field"].Value.ToString();
            //    Add_job_Last_to_Apply.Text = row.Cells["LastToApply"].Value.ToString();
                


            //}
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void clearFields()
        {
            AddJob_Id.Text = "";
            AddJob_CollegeName.Text = "";
            Add_Job_Title.Text = "";
            Add_Job_Description.Text = "";
            Add_job_No_of_post.Text= "";
            add_job_Qualification.Text = "";
            Add_job_domainarea.Text = "";
            Add_job_Salary.Text = "";
            Add_job_Type.SelectedIndex =-1;
            Add_job_company_name.Text = "";
            Add_job_Mail_id.Text = "";
            Add_job_Address.Text = "";
            Add_job_Country.SelectedIndex =-1;
            Add_job_State.Text = "";

        }
        private void Add_job_Update_btn_Click(object sender, EventArgs e)
        {
            if (AddJob_Id.Text == ""
               || AddJob_CollegeName.Text == ""
            || Add_Job_Title.Text == ""
            || Add_Job_Description.Text == ""
            || Add_job_No_of_post.Text == ""
            || add_job_Qualification.Text == ""
            || Add_job_domainarea.Text == ""
            || Add_job_Salary.Text == ""
          || Add_job_Type.Text == ""
          || Add_job_company_name.Text == ""
          || Add_job_Mail_id.Text == ""
          || Add_job_Address.Text == ""
          || Add_job_Country.Text == ""
          || Add_job_State.Text == ""
          || Add_job_Last_to_Apply.Text == "")

            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                    "JobId:" + AddJob_Id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(check == DialogResult.Yes)
                {

                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE job SET CollegeName=@CollegeName,JobTitle=@JobTitle,Description=@Description,NoOfPost=@NoOfPost,Qualification=@Qualification,DomainArea=@DomainArea,Salary=@Salary,JobType=@JobType,CompanyName=@CompanyName,MailId=@MailId,Address=@Address,Country=@Country,State=@State,LastToApply=@LastToApply,UpdateDate=@UpdateDate WHERE JobId=@JobId";
                        using (SqlCommand cmd= new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@CollegeName", AddJob_CollegeName.Text.Trim());
                            cmd.Parameters.AddWithValue("@JobTitle", Add_Job_Title.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", Add_Job_Description.Text.Trim());
                            cmd.Parameters.AddWithValue("@NoOfPost", Add_job_No_of_post.Text.Trim());
                            cmd.Parameters.AddWithValue("@Qualification", add_job_Qualification.Text.Trim());
                            cmd.Parameters.AddWithValue("@DomainArea", Add_job_domainarea.Text.Trim());
                            cmd.Parameters.AddWithValue("@Salary", Add_job_Salary.Text.Trim());
                            cmd.Parameters.AddWithValue("@JobType", Add_job_Type.Text.Trim());
                            cmd.Parameters.AddWithValue("@CompanyName", Add_job_company_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@MailId", Add_job_Mail_id.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", Add_job_Address.Text.Trim());
                            cmd.Parameters.AddWithValue("@Country", Add_job_Country.Text.Trim());
                            cmd.Parameters.AddWithValue("@State", Add_job_State.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastToApply", Add_job_Last_to_Apply.Text.Trim());
                            cmd.Parameters.AddWithValue("@UpdateDate", today);
                            cmd.Parameters.AddWithValue("@JobId", AddJob_Id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                AddJob_Id.Text = row.Cells["JobId"].Value.ToString();
                AddJob_CollegeName.Text = row.Cells["CollegeName"].Value.ToString();
                Add_Job_Title.Text = row.Cells["JobTitle"].Value.ToString();
                Add_Job_Description.Text = row.Cells["Description"].Value.ToString();
                Add_job_No_of_post.Text = row.Cells["NoOfPost"].Value.ToString();
                add_job_Qualification.Text = row.Cells["Qualification"].Value.ToString();
                Add_job_domainarea.Text = row.Cells["DomainArea"].Value.ToString();

                Add_job_Salary.Text = row.Cells["Salary"].Value.ToString();
                Add_job_Type.Text = row.Cells["JobType"].Value.ToString();
                Add_job_company_name.Text = row.Cells["CompanyName"].Value.ToString();
                Add_job_Mail_id.Text = row.Cells["MailId"].Value.ToString();
                Add_job_Address.Text = row.Cells["Address"].Value.ToString();
                Add_job_Country.Text = row.Cells["Country"].Value.ToString();
                Add_job_State.Text = row.Cells["State"].Value.ToString();

                Add_job_Last_to_Apply.Text = row.Cells["LastToApply"].Value.ToString();



            }
        }

        private void Add_job_Clear_btn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void Add_job_Delete_btn_Click(object sender, EventArgs e)
        {
            if (AddJob_Id.Text == ""
              || AddJob_CollegeName.Text == ""
           || Add_Job_Title.Text == ""
           || Add_Job_Description.Text == ""
           || Add_job_No_of_post.Text == ""
           || add_job_Qualification.Text == ""
           || Add_job_domainarea.Text == ""
           || Add_job_Salary.Text == ""
         || Add_job_Type.Text == ""
         || Add_job_company_name.Text == ""
         || Add_job_Mail_id.Text == ""
         || Add_job_Address.Text == ""
         || Add_job_Country.Text == ""
         || Add_job_State.Text == ""
         || Add_job_Last_to_Apply.Text == "")

            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "JobId:" + AddJob_Id.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {

                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE job SET DeleteDate=@DeleteDate WHERE JobId=@JobId";
                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            
                            cmd.Parameters.AddWithValue("@DeleteDate", today);
                            cmd.Parameters.AddWithValue("@JobId", AddJob_Id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayStudentData();

                            MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();

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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
