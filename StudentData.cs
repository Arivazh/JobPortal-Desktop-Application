using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Job_Portal
{
    class StudentData
    {
        public int JobId { set; get; } //0
        //public string JobId { set; get; }//1

        public string CollegeName { set; get; } //2
        public string JobTitle { set; get; } //3
        public string Description { set; get; } //4
        public string NoOfPost { set; get; } //5
        public string Qualification { set; get; } //6
        //public string Specialization { set; get; }
        public string DomainArea { set; get; }
        
        public string Salary { set; get; } //8
        public string JobType { set; get; }  //9
        public string CompanyName { set; get; } //10
        public string MailId { set; get; } //11
        public string Address { set; get; } //12

        public string Country { set; get; } //13
        public string State { set; get; } //14
        public string LastToApply { set; get; } //15
        



        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");

        public List<StudentData> StudentListData()
        {
            List<StudentData> listdata = new List<StudentData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM job WHERE DeleteDate is NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            StudentData Sd = new StudentData();
                            Sd.JobId = (int)reader["JobId"];
                            //Sd.JobId = reader["JobId"].ToString();
                            Sd.CollegeName = reader["CollegeName"].ToString();
                            Sd.JobTitle = reader["JobTitle"].ToString();
                            Sd.Description = reader["Description"].ToString();
                            Sd.NoOfPost = reader["NoOfPost"].ToString();
                            Sd.Qualification = reader["Qualification"].ToString();
                            //Sd.Specialization = reader["Specialization "].ToString();
                            Sd.DomainArea = reader["DomainArea"].ToString();
                            Sd.Salary = reader["Salary"].ToString();
                            Sd.JobType = reader["JobType"].ToString();
                            Sd.CompanyName = reader["CompanyName"].ToString();
                            Sd.MailId = reader["MailId"].ToString();
                            Sd.Address = reader["Address"].ToString();
                            Sd.Country = reader["Country"].ToString();
                            Sd.State = reader["State"].ToString();
                            Sd.LastToApply = reader["LastToApply"].ToString();
                            


                            listdata.Add(Sd);



                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex);

                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }
    }
}

