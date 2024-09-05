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
    public partial class FindJob : UserControl
    {
        public FindJob()
        {
            InitializeComponent();
        }

        private void FindJob_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
            set { _jobtitle = value; lbl_JobTitle.Text = value; }
        }
        [Category("custom Props")]
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel1.BackColor = value; }
        }
        //  _jobtype;
        [Category("custom Props")]
        public string JobType
        {
            get { return _jobtype; }
            set { _jobtype = value; lbl_JobType.Text = value; }
        }
        // _companyname
        [Category("custom Props")]
        public string CompanyName
        {
            get { return _companyname; }
            set { _companyname = value; lbl_CompanyName.Text = value; }
        }
        //salary
        [Category("custom Props")]
        public string Salary
        {
            get { return _salary; }
            set { _salary = value; lbl_Salary.Text = value; }
        }
        //country
        [Category("custom Props")]
        public string Country
        {
            get { return _country; }
            set { _country = value; lbl_Country.Text = value; }
        }

        //state
        [Category("custom Props")]
        public string State
        {
            get { return _state; }
            set { _state = value; lbl_state.Text = value; }
        }
        // _icon;
        [Category("custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; Find_PicBox.Image = value; }
        }
        //Apply button

        [Category("custom Props")]
        public string Button
        {
            get { return _Apply; }
            set { _Apply = value; Apply_btn.Text = value; }
        }
    }
}
