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
    public partial class notification : Form
    {
        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {
            PopulateCatalog();
        }

        private void PopulateCatalog()
        {
            //populate your listitem here
            int l;
            string query = "SELECT *from job";
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HS3C3S4E\VINI;Initial Catalog=portal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            l = dt.Rows.Count;
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["JobTitle"].ToString());
                ListViewItem item1 = new ListViewItem(dr["JobType"].ToString());
                ListViewItem item2 = new ListViewItem(dr["CompanyName"].ToString());
                ListViewItem item3 = new ListViewItem(dr["Salary"].ToString());
                ListViewItem item4 = new ListViewItem(dr["Country"].ToString());
                ListViewItem item5 = new ListViewItem(dr["State"].ToString());
                //ListViewItem des = new ListViewItem(dr["Item_Description"].ToString());

                Notify1[] listItem = new Notify1 [1];

                for (int i = 0; i < listItem.Length; i++)
                {
                    listItem[i] = new Notify1();
                    listItem[i].JobTitle = item.Text;
                    listItem[i].JobType = item1.Text;
                    listItem[i].Company = item2.Text;
                    listItem[i].Salary = item3.Text;
                    listItem[i].Country = item4.Text;
                    listItem[i].State = item5.Text;
                    //listItem[i].Icon = Resources.group3;
                    //listItem[i].IconBackground = Color.Gray;

                    if (flowLayoutPanel1.Controls.Count < 0)
                    {
                        flowLayoutPanel1.Controls.Clear();

                    }
                    else
                    {
                        flowLayoutPanel1.Controls.Add(listItem[i]);
                    }


                }

            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm2 mainForm = new MainForm2();
            mainForm.Show();
        }
    }
}
