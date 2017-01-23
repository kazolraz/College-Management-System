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
    public partial class TeacherSalaryForm : Form
    {
        public TeacherSalaryForm()
        {
            InitializeComponent();
        }

        private void TeacherSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementDataSet_teacher_balance.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter1.Fill(this.collegeManagementDataSet_teacher_balance.teacher);
            // TODO: This line of code loads data into the 'collegeManagementDataSet_teachersalaryform.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.collegeManagementDataSet_teachersalaryform.teacher);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string TeacherID = txtSearch.Text;
            queryClass.searchTeacher(TeacherID, this.dataGridView1_T_Salary_Form);
        }

        private void btn_add_salary_Click(object sender, EventArgs e)
        {
            string Tid = dataGridView1_T_Salary_Form.CurrentRow.Cells[2].Value.ToString();
            string oldsalary = dataGridView1_T_Salary_Form.CurrentRow.Cells[7].Value.ToString();
            string adSalary = txt_salary.Text;

            queryClass.add_salary(Tid, oldsalary, adSalary);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountan_Form ko = new Accountan_Form();
            ko.Show();
        }
    }
}
