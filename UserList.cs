using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Job_Portal
{
    public partial class UserList : UserControl
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserList_Load(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from [User]", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = User_List_DGV.Rows.Add();
               User_List_DGV.Rows[n].Cells[0].Value = item[0].ToString();
               // User_List_DGV.Rows[n].Cells[1].Value = item["UserId"].ToString();
                User_List_DGV.Rows[n].Cells[1].Value = item["Name"].ToString();
                User_List_DGV.Rows[n].Cells[2].Value = item["MailId"].ToString();
                User_List_DGV.Rows[n].Cells[3].Value = item["PhoneNumber"].ToString();
               // User_List_DGV.Rows[n].Cells[4].Value = item["Country"].ToString();

            }

        }
    }
}

