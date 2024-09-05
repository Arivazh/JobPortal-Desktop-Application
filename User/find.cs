using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Portal.User
{
    public partial class find : UserControl
    {
        public find()
        {
            InitializeComponent();
        }
        //public static string Title;
        //public static string Type;
        //public static string CompanyName;
        //public static string salary;
        //public static string country;
        //public static string state;

        private void find_Load(object sender, EventArgs e)
        {

        }

        private void GoTo_btn_Click(object sender, EventArgs e)
        {
             Test1 testform = new Test1();
            if (testform == null)
            {
                testform.Parent = this;
            }
            testform.Show();
            this.Hide();

         
        }
    }
}
