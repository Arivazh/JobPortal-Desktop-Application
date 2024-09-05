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
using System.Configuration;
using Job_Portal.User;

namespace Job_Portal
{

    public partial class ContactList : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");

        //public void displayStudentData()
        //{
        //    ContactData Cd = new ContactData();
        //    List<ContactData> listdata = Cd.UserContactData();

        //    Contact_List_DGV.DataSource = listdata;
        //}
        private void CL_Update_btn_Click(object sender, EventArgs e)
        {

        }

        private void Contact_List_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


         }

        private void ContactList_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Contact", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow item in dt.Rows)
            {
                int n = Contact_List_DGV.Rows.Add();
                Contact_List_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Contact_List_DGV.Rows[n].Cells[1].Value = item["UserName"].ToString();
            }

        }

        private void Add_job_Update_btn_Click(object sender, EventArgs e)
        {

        }
    }


    }
    


        