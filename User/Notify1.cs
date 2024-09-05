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
    public partial class Notify1 : UserControl
    {
        public Notify1()
        {
            InitializeComponent();
        }

        private void Notify1_Load(object sender, EventArgs e)
        {

        }
        private Color _iconBack;
        private string _jobtitle;
        private string _jobtype;
        private string _companyname;
        private string _salary;
        private string _country;
        private string _state;
        private Image _icon;
        private string _Apply;
        // jobtitle
        [Category("custom Props")]
        public string JobTitle
        {
            get { return _jobtitle; }
            set { _jobtitle = value; label1.Text = value; }
        }
        //[Category("custom Props")]
        //public Color IconBackground
        //{
        //    get { return _iconBack; }
        //    set { _iconBack = value; panel1.BackColor = value; }
        //}
        //  _jobtype;
        [Category("custom Props")]
        public string JobType
        {
            get { return _jobtype; }
            set { _jobtype = value; label2.Text = value; }
        }
        // _companyname
        [Category("custom Props")]
        public string Company
        {
            get { return _companyname; }
            set { _companyname = value; label3.Text = value; }
        }
        //salary
        [Category("custom Props")]
        public string Salary
        {
            get { return _salary; }
            set { _salary = value; label4.Text = value; }
        }
        //country
        [Category("custom Props")]
        public string Country
        {
            get { return _country; }
            set { _country = value;label5.Text = value; }
        }

        //state
        [Category("custom Props")]
        public string State
        {
            get { return _state; }
            set { _state = value; label6.Text = value; }
        }
        //// _icon;
        //[Category("custom Props")]
        //public Image Icon
        //{
        //    get { return _icon; }
        //    set { _icon = value; pictureBox1.Image = value; }
        //}
        ////Apply button

        //[Category("custom Props")]
        //public string Button
        //{
        //    get { return _Apply; }
        //    set { _Apply = value; btn_apply.Text = value; }
        //}

        private void Test2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;

        }

        private void Test2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        //private void btn_apply_Click(object sender, EventArgs e)
        //{
        //    edit1 regForm = new edit1();
        //    regForm.Show();
        //    this.Hide();
        //}
    }
}
