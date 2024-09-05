using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Job_Portal.User
{
    class UserData
    {
        public int UserId { set; get; }
        public string UserName { set; get; }
        public string password { set; get; }
        public string FullName { set; get; }
        public  string MailId { set; get; }
        public string PhoneNumber { set; get; }
        public string TenthPercentage { set; get; }
        public string TwefthPercentage { set; get; }
        public string CGPA { set; get; }
        public string Address { set; get; }
       public string Resume { set; get; }
        public string Country { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");

        public List<UserData> UserListData()
        {
            List<UserData> listData = new List<UserData>();
            if(connect.State!= ConnectionState.Open)
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
                            UserData ud = new UserData();
                            ud.UserId = (int)reader["UserId"];
                            ud.UserName = reader["UserName"].ToString();
                            ud.password = reader["Password"].ToString();
                            ud.FullName = reader["Name"].ToString();
                            ud.MailId = reader["MailId"].ToString();
                            ud.PhoneNumber = reader["PhoneNumber"].ToString();
                            ud.TenthPercentage = reader["TenthGrade"].ToString();
                            ud.TwefthPercentage = reader["TwefthGrade"].ToString();
                            ud.CGPA = reader["CGPA"].ToString();
                            ud.Address = reader["Address"].ToString();
                            ud.Resume = reader["Resume"].ToString();
                            ud.Country = reader["Country"].ToString();

                            listData.Add(ud);
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
            return listData;

        } 
       

      
         
            

    }
}
