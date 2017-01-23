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
    public partial class FormPrinciple : Form
    {
        public FormPrinciple()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE TO ADD STUDENT DATABASE?.", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addStudent(txtStdName.Text, txtStdID.Text, txtStdRoll.Text, txtStdYear.Text, txtStdDept.Text, txtStdDob.Text, txtStdGender.Text, txtStdBlood.Text, txtStdGardian.Text, txtStdContact.Text, txtStdAddress.Text, txtStdFee.Text);

                // ************ Clear the boxes 
                txtStdName.Text = txtStdID.Text = txtStdRoll.Text = txtStdYear.Text = txtStdDept.Text = txtStdDob.Text = txtStdGender.Text = txtStdBlood.Text = txtStdGardian.Text = txtStdContact.Text = txtStdAddress.Text = txtStdFee.Text = "";
            }
            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void t_submit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE TO ADD TEACHER DATABASE?.", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addTeacher(t_name.Text, t_id.Text,t_pass.Text, t_position.Text, t_subject.Text, t_department.Text, t_salary.Text, t_blood.Text, t_dob.Text, t_gender.Text, t_contact.Text, t_address.Text);

                // ************ Clear the boxes 
                t_name.Text = t_id.Text =t_pass.Text = t_position.Text = t_subject.Text = t_department.Text = t_salary.Text = t_blood.Text = t_dob.Text = t_gender.Text = t_contact.Text = t_address.Text = "";
            }

            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        private void btn_a_sub_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ARE YOU SURE TO ADD TEACHER DATABASE?.", "CONFORM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                queryClass.addAccountant(a_name.Text, a_id.Text, a_pass.Text, a_com_pos.Text, a_com_dob.Text, a_com_gender.Text, a_com_blood.Text, a_com_sal.Text, a_con.Text, a_rich_ad.Text);

                // ************ Clear the boxes 
                a_name.Text = a_id.Text = a_pass.Text=a_com_pos.Text = a_com_dob.Text = a_com_gender.Text = a_com_blood.Text = a_com_sal.Text = a_con.Text = a_rich_ad.Text = "";
                MessageBox.Show("Accountant SuccessFully Added");
            }

            else
            {
                MessageBox.Show("Adding Abroted");
            }
        }

        FormAllStu allStu = new FormAllStu();
        private void showAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allStu.ShowDialog();
        }

        FormAllTeacher Allteacher = new FormAllTeacher();
        private void showAllTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
               Allteacher.ShowDialog();
        }

        private void showAccountantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAllAccountant AllAccountant = new FormAllAccountant();
            AllAccountant.Show();
        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showStudentsByClassToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin c = new FormLogin();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin h = new FormLogin();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin u = new FormLogin();
            u.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormPrinciple_Load(object sender, EventArgs e)
        {

        }



        //private void showStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }

}
