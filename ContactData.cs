using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Job_Portal
{
    class ContactData
    {
        public int ContactId { set; get; }
        public string UserName { set; get; }

        public string MailId { set; get; }
        public string Subject { set; get; }
        public string Message { set; get; }


        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");

        public List<ContactData> UserContactData()
        {
            List<ContactData> ListData = new List<ContactData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Contact ";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                           ContactData cd = new ContactData();
                            cd.UserName = reader["UserName"].ToString();
                            cd.MailId = reader["MailId"].ToString();
                            cd.Subject = reader["Subject"].ToString();
                            cd.Message = reader["Message"].ToString();

                            ListData.Add(cd);

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
            return ListData;
        }
    }
}
