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

namespace Job_Portal
{
    public partial class Resume : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
        
        public Resume()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Resume_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from [User]", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = Resume_DGV.Rows.Add();
                Resume_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                //Resume_DGV.Rows[n].Cells[1].Value = item["Userid"].ToString();
                Resume_DGV.Rows[n].Cells[1].Value = item["MailId"].ToString();
                Resume_DGV.Rows[n].Cells[2].Value = item["Resume"].ToString();

            }
            


        }

        private void Resume_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
