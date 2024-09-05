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
    public partial class JobList : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public JobList()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JobList_Load(object sender, EventArgs e)
        {
            //SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from job", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = Job_list_DGV.Rows.Add();
                Job_list_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Job_list_DGV.Rows[n].Cells[1].Value = item["JobId"].ToString();
                Job_list_DGV.Rows[n].Cells[2].Value = item["CollegeName"].ToString();
                Job_list_DGV.Rows[n].Cells[3].Value = item["JobTitle"].ToString();
                Job_list_DGV.Rows[n].Cells[4].Value = item["Description"].ToString();
                Job_list_DGV.Rows[n].Cells[5].Value = item["NoOfPost"].ToString();
                Job_list_DGV.Rows[n].Cells[6].Value = item["Qualification"].ToString();
                Job_list_DGV.Rows[n].Cells[7].Value = item["DomainArea"].ToString();
                Job_list_DGV.Rows[n].Cells[8].Value = item["Salary"].ToString();
                Job_list_DGV.Rows[n].Cells[9].Value = item["JobType"].ToString();
                Job_list_DGV.Rows[n].Cells[10].Value = item["CompanyName"].ToString();
                Job_list_DGV.Rows[n].Cells[11].Value = item["MailId"].ToString();
                Job_list_DGV.Rows[n].Cells[12].Value = item["Address"].ToString();
                Job_list_DGV.Rows[n].Cells[13].Value = item["Country"].ToString();
                Job_list_DGV.Rows[n].Cells[14].Value = item["State"].ToString();
                //Job_list_DGV.Rows[n].Cells[15].Value = item["LastToApply"].ToString();

            }
        }

        private void Job_list_search_TextChanged(object sender, EventArgs e)
        {
            //Get the data from textbox
            string keyword = Job_list_search.Text;
            //SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from job WHERE CollegeName LIKE'%" + keyword + "%' OR DomainArea LIKE'%" + keyword + "%' OR Qualification LIKE '%" + keyword + "%'", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Job_list_DGV.DataSource = dt;

        }
    }
}
