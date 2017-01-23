using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Formedit_stu : Form
    {
        public Formedit_stu()
        {
            InitializeComponent();
        }

        private string stuName;
        private string stuID;
        private string stuRoll;
        private string stuYear;
        private string stuDepartment;
        private string stuDob;
        private string stuGender;
        private string stuBlood;
        private string stuGuardian;
        private string stuContact;
        private string stuAddress;
        private string stuFee;
        public string passStuName
        {
            get { return stuName; }
            set { stuName = value; }
        }

        public string passStuID
        {
            get { return stuID; }
            set { stuID = value; }
        }
        public string passStuRoll
        {
            get { return stuRoll; }
            set { stuRoll = value; }
        }


        public string passStuYear
        {
            get { return stuYear; }
            set { stuYear = value; }
        }


        public string passStuDepatment
        {
            get { return stuDepartment; }
            set { stuDepartment = value; }
        }


        public string passStuDob
        {
            get { return stuDob; }
            set { stuDob = value; }
        }


        public string passStuGender
        {
            get { return stuGender; }
            set { stuGender = value; }
        }


        public string passStuBlood
        {
            get { return stuBlood; }
            set { stuBlood = value; }
        }


        public string passStuGuardian
        {
            get { return stuGuardian; }
            set { stuGuardian = value; }
        }


        public string passStuContact
        {
            get { return stuContact; }
            set { stuContact = value; }
        }


        public string passStuAddress
        {
            get { return stuAddress; }
            set { stuAddress = value; }
        }
        public string passStuFee
        {
            get { return stuFee; }
            set { stuFee = value; }
        }


        private void Formedit_stu_Load(object sender, EventArgs e)
        {
            txtStdName.Text = stuName;
            txtStdID.Text = stuID;
            txtStdRoll.Text = stuRoll;
            txtStdYear.Text = stuYear;
            txtStdDept.Text = stuDepartment;
            txtStdDob.Text = stuDob;
            txtStdGender.Text = stuGender;
            txtStdBlood.Text = stuBlood;
            txtStdGardian.Text = stuGuardian;
            txtStdContact.Text = stuContact;
            txtStdAddress.Text = stuAddress;
            txtStdFee.Text = stuFee;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sName;
            string sId;
            string sRoll;
            string sYear;
            string sDepartment;
            string sDob;
            string sGender;
            string sBlood;
            string sGuardian;

            string sContact;
            string sAddress;
            string sFee;


            sName = txtStdName.Text;
            sId = txtStdID.Text;
            sRoll = txtStdRoll.Text;
            sYear = txtStdYear.Text;
            sDepartment = txtStdDept.Text;
            sDob = txtStdDob.Text;
            sGender = txtStdGender.Text;
            sBlood = txtStdBlood.Text;
            sGuardian = txtStdGardian.Text;
            sContact = txtStdContact.Text;
            sAddress = txtStdAddress.Text;
            sFee = txtStdFee.Text;



            queryClass.updateStudent(sName, sId, sRoll, sYear, sDepartment, sDob, sGender, sBlood, sGuardian, sContact, sAddress, sFee);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAllStu n = new FormAllStu();
            n.Show();
        }
    }
}
