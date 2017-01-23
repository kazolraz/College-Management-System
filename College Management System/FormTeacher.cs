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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }


        private string teacherSubject;
        public string passTeacherSub
        {
            get { return teacherSubject; }
            set { teacherSubject = value; }
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementDataSet2.marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.collegeManagementDataSet2.marks);



            lbl_subject.Text = passTeacherSub;

            if (lbl_subject.Text == "Bengali")
            {
                txt_english.Enabled = false;
                txt_math.Enabled = false;
                txt_phy.Enabled = false;
            }


            if (lbl_subject.Text == "English")
            {
                txt_bangla.Enabled = false;
                txt_math.Enabled = false;
                txt_phy.Enabled = false;
            }

            if (lbl_subject.Text == "Mathematics")
            {
                txt_english.Enabled = false;
                txt_bangla.Enabled = false;
                txt_phy.Enabled = false;
            }

            if (lbl_subject.Text == "Physics")
            {
                txt_english.Enabled = false;
                txt_bangla.Enabled = false;
                txt_math.Enabled = false;
            }

        }

        private void btnAddMarks_Click(object sender, EventArgs e)
        {

            queryClass.addMarks(txt_bangla.Text, txt_english.Text, txt_math.Text, txt_phy.Text, txt_src.Text);
            queryClass.searchStuMarks("", this.dataGridMarks);
        }

        private void txt_src_TextChanged(object sender, EventArgs e)
        {
            queryClass.searchStuMarks(txt_src.Text, dataGridMarks);
            string bangla = dataGridMarks.CurrentRow.Cells[4].Value.ToString(); ;
            string english = dataGridMarks.CurrentRow.Cells[5].Value.ToString(); ;
            string math = dataGridMarks.CurrentRow.Cells[6].Value.ToString(); ;
            string gn = dataGridMarks.CurrentRow.Cells[7].Value.ToString(); ;

            if (bangla == "")
            {
                txt_bangla.Text = "0";
            }
            else
            {
                txt_bangla.Text = bangla;
            }

            if (english == "")
            {
                txt_english.Text = "0";
            }
            else
            {
                txt_english.Text = english;
            }

            if (math == "")
            {
                txt_math.Text = "0";
            }
            else
            {
                txt_math.Text = math;
            }

            if (gn == "")
            {
                txt_phy.Text = "0";
            }
            else
            {
                txt_phy.Text = gn;
            }

            if (txt_src.Text == "")
            {
                txt_bangla.Text = txt_english.Text = txt_math.Text = txt_phy.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin p = new FormLogin();
            p.Show();
        }
    }
}
