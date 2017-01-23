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
    public partial class FormUpdateTeacher : Form
    {
        public FormUpdateTeacher()
        {
            InitializeComponent();
        }

        private string a, b, c, d, e, f, g, h, i, j,k;
        public string passName
        {
            get { return a; }
            set { a = value; }
        }

        public string passId
        {
            get { return b; }
            set { b = value; }
        }

        private void t_submit_Click(object sender, EventArgs e)
        {
            string tname = t_name.Text;
            string tid = t_id.Text;
            
            string tpos = t_position.Text;
            string tsub = t_subject.Text;
            string tdept = t_department.Text;
            string tsal = t_salary.Text;
            string tblood = t_blood.Text;
            string tdob = t_dob.Text;
            string tgen = t_gender.Text;
            
           
            string tcon = t_contact.Text;
            string tadd = t_address.Text;


            queryClass.updateTeacher(tname, tid, tpos, tsub, tdept, tsal, tblood, tdob, tgen, tcon, tadd);
            this.Hide();
            FormAllTeacher d = new FormAllTeacher();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAllTeacher o = new FormAllTeacher();
                o.Show();
        }

        public string passPos
        {
            get { return c; }
            set { c = value; }
        }

        public string passSub
        {
            get { return d; }
            set { d = value; }
        }

        public string passDepartment
        {
            get { return e; }
            set { e= value; }
        }

       
        public string passSalary
        {
            get { return f; }
            set { f= value; }
        }

        public string passBlood
        {
            get { return g; }
            set { g = value; }
        }
        public string passDob
        {
            get { return h; }
            set { h = value; }
        }

        public string passGender
        {
            get { return i; }
            set { i = value; }
        }

        public string passContact
        {
            get { return j; }
            set { j = value; }
        }

        public string passAdd
        {
            get { return k; }
            set { k = value; }
        }




        private void FormUpdateTeacher_Load(object sender, EventArgs e)
        {
            t_name.Text = passName;
            t_id.Text = passId;
            t_position.Text = passPos;
            t_subject.Text = passSub;
            t_department.Text = passDepartment;
            t_salary.Text = passSalary;

            t_gender.Text = passGender;
            t_dob.Text = passDob;
            t_blood.Text = passBlood;
            
           
            t_contact.Text = passContact;
            t_address.Text = passAdd;
        }
    }
}
