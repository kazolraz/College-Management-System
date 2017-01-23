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
    public partial class FormAllStu : Form
    {
        public FormAllStu()
        {
            InitializeComponent();
        }

        private void FormAllStu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementDataSet1_student.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeManagementDataSet1_student.student);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string studentID = txtSearch.Text;
            queryClass.searchStu(studentID, this.DataGrid_AllStu);
        }


        
        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrinciple y = new FormPrinciple();
            y.Show();

        }
        Formedit_stu editStudent = new Formedit_stu();
        private void actionEdit_Click(object sender, EventArgs e)
        {
            string name = DataGrid_AllStu.CurrentRow.Cells[1].Value.ToString();
            string id = DataGrid_AllStu.CurrentRow.Cells[2].Value.ToString();
            string roll = DataGrid_AllStu.CurrentRow.Cells[3].Value.ToString();
            string yearStd = DataGrid_AllStu.CurrentRow.Cells[4].Value.ToString();
            string department = DataGrid_AllStu.CurrentRow.Cells[5].Value.ToString();
            string dob = DataGrid_AllStu.CurrentRow.Cells[6].Value.ToString();
            string gender = DataGrid_AllStu.CurrentRow.Cells[7].Value.ToString();
            string blood = DataGrid_AllStu.CurrentRow.Cells[8].Value.ToString();
            string guardian = DataGrid_AllStu.CurrentRow.Cells[9].Value.ToString();
            string contact = DataGrid_AllStu.CurrentRow.Cells[10].Value.ToString();
            string address = DataGrid_AllStu.CurrentRow.Cells[11].Value.ToString();
            string fee = DataGrid_AllStu.CurrentRow.Cells[12].Value.ToString();

            editStudent.passStuName = name;
            editStudent.passStuID = id;
            editStudent.passStuRoll = roll;
            editStudent.passStuYear = yearStd;
            editStudent.passStuDepatment = department;
            editStudent.passStuDob = dob;
            editStudent.passStuGender = gender;
            editStudent.passStuBlood = blood;
            editStudent.passStuGuardian = guardian;
            editStudent.passStuContact = contact;
            editStudent.passStuAddress = address;
            editStudent.passStuFee = fee;
            this.Hide();
            editStudent.ShowDialog();
        }

        private void actionDelete_Click_1(object sender, EventArgs e)
        {

            queryClass.stuDel(txtSearch.Text, this.DataGrid_AllStu);
           queryClass.stuDelMarks(txtSearch.Text);

            string a = "";   /// Refresh student Lsist
            queryClass.searchStu(a, this.DataGrid_AllStu);

        }
    }
}
