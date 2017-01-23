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
    public partial class FormAllTeacher : Form
    {
        public FormAllTeacher()
        {
            InitializeComponent();
        }

        private void FormAllTeacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementDataSet_teacher.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.collegeManagementDataSet_teacher.teacher);

        }
        FormUpdateTeacher d1 = new FormUpdateTeacher();
        private void actionEdit_Click(object sender, EventArgs e)
        {

            
            string Tname = DataGridView_AT.CurrentRow.Cells[1].Value.ToString();
            string Tid = DataGridView_AT.CurrentRow.Cells[2].Value.ToString();
            string Tpos = DataGridView_AT.CurrentRow.Cells[3].Value.ToString();
            string Tsub = DataGridView_AT.CurrentRow.Cells[4].Value.ToString();
            string Tdepartment = DataGridView_AT.CurrentRow.Cells[5].Value.ToString();
            string Tsalary = DataGridView_AT.CurrentRow.Cells[6].Value.ToString();
            string Tblood = DataGridView_AT.CurrentRow.Cells[7].Value.ToString();
            string Tdob = DataGridView_AT.CurrentRow.Cells[8].Value.ToString();
            string Tgender = DataGridView_AT.CurrentRow.Cells[9].Value.ToString();
            string Tcontact = DataGridView_AT.CurrentRow.Cells[10].Value.ToString();
            string Taddress = DataGridView_AT.CurrentRow.Cells[11].Value.ToString();

            d1.passName = Tname;
            d1.passId = Tid;
            d1.passPos = Tpos;
            d1.passSub = Tsub;
            d1.passDepartment = Tdepartment;
            d1.passSalary = Tsalary;
            d1.passBlood = Tblood;
            d1.passDob = Tdob;
            d1.passGender = Tgender;
            d1.passContact = Tcontact;
            d1.passAdd = Taddress;

            this.Hide();
            d1.ShowDialog();
        }

       

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string teacherID = txtSearch.Text;
            queryClass.searchTeacher(teacherID, this.DataGridView_AT);
        }

        private void actionDelete_Click(object sender, EventArgs e)
        {
            queryClass.TeacherDel(txtSearch.Text, this.DataGridView_AT);

            string a = "";   //Refresh student List
            queryClass.searchTeacher(a, this.DataGridView_AT);
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrinciple l = new FormPrinciple();
            l.Show();
        }

        //private void DataGridView_AT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
    
}
    

