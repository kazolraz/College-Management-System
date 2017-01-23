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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrinciple fp = new FormPrinciple();
            FormTeacher ft = new FormTeacher();
            Accountan_Form fa = new Accountan_Form();
            try
            {

                queryClass.login_func(txt_userid.Text, this.dataGridViewLogin);


                string userid = dataGridViewLogin.CurrentRow.Cells[1].Value.ToString();
                string userPas = dataGridViewLogin.CurrentRow.Cells[2].Value.ToString();
                string userType = dataGridViewLogin.CurrentRow.Cells[3].Value.ToString();





                string typePrinciple = "Principle";

                if (txt_userid.Text == userid && txt_pass.Text == userPas)
                {
                    if (userType == typePrinciple)
                    {
                        
                        fp.Show();
                    }
                    else if (userType == "Teacher")
                    {
                        queryClass.loginTeacher(txt_userid.Text, dataGridViewLogin);
                        string userSubject = dataGridView_t_login.CurrentRow.Cells[5].Value.ToString();
                       
                        ft.passTeacherSub = userSubject;

                        ft.ShowDialog();

                    }

                    else if (userType == "Accountant")
                    {

                        queryClass.loginAccountant(txt_userid.Text, this.dataGridViewLogin);
                       
                        fa.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid userid or pass");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid userid or pass");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementData_teacher.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter2.Fill(this.collegeManagementData_teacher.teacher);
            // TODO: This line of code loads data into the 'collegeManagementDataSet_teacher1.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter1.Fill(this.collegeManagementDataSet_teacher1.teacher);
            // TODO: This line of code loads data into the 'collegeManagementDataSet1.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.collegeManagementDataSet1.teacher);
            // TODO: This line of code loads data into the 'collegeManagementDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.collegeManagementDataSet.login);
            dataGridViewLogin.Hide();

            dataGridView_t_login.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
