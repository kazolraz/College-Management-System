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
    public partial class StudentBalance : Form
    {
        public StudentBalance()
        {
            InitializeComponent();
        }

        private void StudentBalance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeManagementDataSet_studentbalance.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.collegeManagementDataSet_studentbalance.student);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string studentID = txtSearch.Text;
            queryClass.searchStu(studentID, this.dataGridView1_BALANCE);
        }

        private void btn_add_fees_Click(object sender, EventArgs e)
        {
            string Stuid = dataGridView1_BALANCE.CurrentRow.Cells[2].Value.ToString();
            string oldfee = dataGridView1_BALANCE.CurrentRow.Cells[6].Value.ToString();
            string adFee = txt_fees.Text;

            queryClass.add_fee(Stuid, oldfee, adFee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accountan_Form ji = new Accountan_Form();
            ji.Show();
        }
    }
}
