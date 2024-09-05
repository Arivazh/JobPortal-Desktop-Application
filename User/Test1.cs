using Job_Portal.Properties;
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


namespace Job_Portal.User
{
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Test1_Load(object sender, EventArgs e)
        {
            PopulateCatalog();
        }
        //private void populateItems()
        //{
        //    //populate it here
        //    Test2[] test = new Test2[20];
        //    //loop through each item
        //    for(int i = 0; i < test.Length; i++)
        //    {
        //        test[i] = new Test2();
        //        test[i].Icon = Resources.group3;
        //        test[i].JobTitle = "JobTitle ";
        //        test[i].JobType = "JobType ";
        //        test[i].Company = "Company ";
        //        test[i].Salary = "Salary ";
        //        test[i].Country = "Country";
        //        test[i].State = "State ";
        //        //add to flow layout
        //        if (flowLayoutPanel1.Controls.Count < 0)
        //        {
        //            flowLayoutPanel1.Controls.Clear();

        //        }
        //        else
        //        {
        //            flowLayoutPanel1.Controls.Add(test[i]);
        //        }

        //    }
        //}

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
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["JobTitle"].ToString());
                ListViewItem item1 = new ListViewItem(dr["JobType"].ToString());
                ListViewItem item2 = new ListViewItem(dr["CompanyName"].ToString());
                ListViewItem item3 = new ListViewItem(dr["Salary"].ToString());
                ListViewItem item4 = new ListViewItem(dr["Country"].ToString());
                ListViewItem item5 = new ListViewItem(dr["State"].ToString());
                //ListViewItem des = new ListViewItem(dr["Item_Description"].ToString());

                Test2[] listItem = new Test2[1];

                for(int i=0; i< listItem.Length  ; i++)
                {
                    listItem[i] = new Test2();
                    listItem[i].JobTitle = item.Text;
                    listItem[i].JobType = item1.Text;
                    listItem[i].Company = item2.Text;
                    listItem[i].Salary = item3.Text;
                    listItem[i].Country = item4.Text;
                    listItem[i].State = item5.Text;
                    listItem[i].Icon = Resources.group3;
                    listItem[i].IconBackground = Color.Gray;

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


    }
}
