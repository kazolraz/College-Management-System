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
    public partial class Accountan_Form : Form
    {
        public Accountan_Form()
        {
            InitializeComponent();
        }

        private void showStudentFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showTeachersBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        StudentBalance sb = new StudentBalance();
        TeacherSalaryForm ts = new TeacherSalaryForm();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE TO ADD STUDENT DATABASE?.", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addStudent(txtStdName.Text, txtStdID.Text, txtStdRoll.Text, txtStdYear.Text, txtStdDept.Text, txtStdDob.Text, txtStdGender.Text, txtStdBlood.Text, txtStdGardian.Text, txtStdContact.Text, txtStdAddress.Text, txtStdFee.Text);

                MessageBox.Show("Student Added Successfully");
                // ************ Clear the boxes 
                txtStdName.Text = txtStdID.Text = txtStdRoll.Text = txtStdYear.Text = txtStdDept.Text = txtStdDob.Text = txtStdGender.Text = txtStdBlood.Text = txtStdGardian.Text = txtStdContact.Text = txtStdAddress.Text = txtStdFee.Text = "";
            }
            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sb.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin po = new FormLogin();
            po.Show();
        }
    }

   
    }


