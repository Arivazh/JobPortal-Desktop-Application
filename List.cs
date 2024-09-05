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


namespace Job_Portal
{
    public partial class Contact : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Contact", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = Contact_List_DGV.Rows.Add();
                Contact_List_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Contact_List_DGV.Rows[n].Cells[1].Value = item["UserName"].ToString();
                Contact_List_DGV.Rows[n].Cells[2].Value = item["MailId"].ToString();
                Contact_List_DGV.Rows[n].Cells[3].Value = item["Subject"].ToString();
                Contact_List_DGV.Rows[n].Cells[4].Value = item["Message"].ToString();
            }

        }
    }
}
