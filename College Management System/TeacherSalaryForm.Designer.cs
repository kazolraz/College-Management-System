namespace College_Management_System
{
    partial class TeacherSalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSalaryForm));
            this.btn_add_salary = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet_teachersalaryform = new College_Management_System.CollegeManagementDataSet_teachersalaryform();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new College_Management_System.CollegeManagementDataSet_teachersalaryformTableAdapters.teacherTableAdapter();
            this.dataGridView1_T_Salary_Form = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet_teacher_balance = new College_Management_System.CollegeManagementDataSet_teacher_balance();
            this.teacherTableAdapter1 = new College_Management_System.CollegeManagementDataSet_teacher_balanceTableAdapters.teacherTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teachersalaryform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_T_Salary_Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_salary
            // 
            this.btn_add_salary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_salary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_salary.Location = new System.Drawing.Point(37, 74);
            this.btn_add_salary.Name = "btn_add_salary";
            this.btn_add_salary.Size = new System.Drawing.Size(183, 23);
            this.btn_add_salary.TabIndex = 15;
            this.btn_add_salary.Text = "ADD BONUS";
            this.btn_add_salary.UseVisualStyleBackColor = true;
            this.btn_add_salary.Click += new System.EventHandler(this.btn_add_salary_Click);
            // 
            // tk
            // 
            this.tk.AutoSize = true;
            this.tk.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tk.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tk.Location = new System.Drawing.Point(226, 36);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(38, 21);
            this.tk.TabIndex = 19;
            this.tk.Text = "TK";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_salary);
            this.groupBox1.Controls.Add(this.tk);
            this.groupBox1.Controls.Add(this.txt_salary);
            this.groupBox1.Location = new System.Drawing.Point(821, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 131);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SALARY";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(37, 39);
            this.txt_salary.Multiline = true;
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(183, 23);
            this.txt_salary.TabIndex = 17;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "teacher";
            this.teacherBindingSource1.DataSource = this.collegeManagementDataSet_teachersalaryform;
            // 
            // collegeManagementDataSet_teachersalaryform
            // 
            this.collegeManagementDataSet_teachersalaryform.DataSetName = "CollegeManagementDataSet_teachersalaryform";
            this.collegeManagementDataSet_teachersalaryform.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 65);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 25);
            this.txtSearch.TabIndex = 59;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1_T_Salary_Form
            // 
            this.dataGridView1_T_Salary_Form.AutoGenerateColumns = false;
            this.dataGridView1_T_Salary_Form.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_T_Salary_Form.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tIdDataGridViewTextBoxColumn,
            this.tPassDataGridViewTextBoxColumn,
            this.tPosDataGridViewTextBoxColumn,
            this.tSubDataGridViewTextBoxColumn,
            this.tDeptDataGridViewTextBoxColumn,
            this.tSalaryDataGridViewTextBoxColumn,
            this.tBloodDataGridViewTextBoxColumn,
            this.tDobDataGridViewTextBoxColumn,
            this.tGenderDataGridViewTextBoxColumn,
            this.tContactDataGridViewTextBoxColumn,
            this.tAddressDataGridViewTextBoxColumn});
            this.dataGridView1_T_Salary_Form.DataSource = this.teacherBindingSource2;
            this.dataGridView1_T_Salary_Form.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1_T_Salary_Form.Name = "dataGridView1_T_Salary_Form";
            this.dataGridView1_T_Salary_Form.Size = new System.Drawing.Size(759, 490);
            this.dataGridView1_T_Salary_Form.TabIndex = 65;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "tName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "tName";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // tIdDataGridViewTextBoxColumn
            // 
            this.tIdDataGridViewTextBoxColumn.DataPropertyName = "tId";
            this.tIdDataGridViewTextBoxColumn.HeaderText = "tId";
            this.tIdDataGridViewTextBoxColumn.Name = "tIdDataGridViewTextBoxColumn";
            // 
            // tPassDataGridViewTextBoxColumn
            // 
            this.tPassDataGridViewTextBoxColumn.DataPropertyName = "tPass";
            this.tPassDataGridViewTextBoxColumn.HeaderText = "tPass";
            this.tPassDataGridViewTextBoxColumn.Name = "tPassDataGridViewTextBoxColumn";
            // 
            // tPosDataGridViewTextBoxColumn
            // 
            this.tPosDataGridViewTextBoxColumn.DataPropertyName = "tPos";
            this.tPosDataGridViewTextBoxColumn.HeaderText = "tPos";
            this.tPosDataGridViewTextBoxColumn.Name = "tPosDataGridViewTextBoxColumn";
            // 
            // tSubDataGridViewTextBoxColumn
            // 
            this.tSubDataGridViewTextBoxColumn.DataPropertyName = "tSub";
            this.tSubDataGridViewTextBoxColumn.HeaderText = "tSub";
            this.tSubDataGridViewTextBoxColumn.Name = "tSubDataGridViewTextBoxColumn";
            // 
            // tDeptDataGridViewTextBoxColumn
            // 
            this.tDeptDataGridViewTextBoxColumn.DataPropertyName = "tDept";
            this.tDeptDataGridViewTextBoxColumn.HeaderText = "tDept";
            this.tDeptDataGridViewTextBoxColumn.Name = "tDeptDataGridViewTextBoxColumn";
            // 
            // tSalaryDataGridViewTextBoxColumn
            // 
            this.tSalaryDataGridViewTextBoxColumn.DataPropertyName = "tSalary";
            this.tSalaryDataGridViewTextBoxColumn.HeaderText = "tSalary";
            this.tSalaryDataGridViewTextBoxColumn.Name = "tSalaryDataGridViewTextBoxColumn";
            // 
            // tBloodDataGridViewTextBoxColumn
            // 
            this.tBloodDataGridViewTextBoxColumn.DataPropertyName = "tBlood";
            this.tBloodDataGridViewTextBoxColumn.HeaderText = "tBlood";
            this.tBloodDataGridViewTextBoxColumn.Name = "tBloodDataGridViewTextBoxColumn";
            // 
            // tDobDataGridViewTextBoxColumn
            // 
            this.tDobDataGridViewTextBoxColumn.DataPropertyName = "tDob";
            this.tDobDataGridViewTextBoxColumn.HeaderText = "tDob";
            this.tDobDataGridViewTextBoxColumn.Name = "tDobDataGridViewTextBoxColumn";
            // 
            // tGenderDataGridViewTextBoxColumn
            // 
            this.tGenderDataGridViewTextBoxColumn.DataPropertyName = "tGender";
            this.tGenderDataGridViewTextBoxColumn.HeaderText = "tGender";
            this.tGenderDataGridViewTextBoxColumn.Name = "tGenderDataGridViewTextBoxColumn";
            // 
            // tContactDataGridViewTextBoxColumn
            // 
            this.tContactDataGridViewTextBoxColumn.DataPropertyName = "tContact";
            this.tContactDataGridViewTextBoxColumn.HeaderText = "tContact";
            this.tContactDataGridViewTextBoxColumn.Name = "tContactDataGridViewTextBoxColumn";
            // 
            // tAddressDataGridViewTextBoxColumn
            // 
            this.tAddressDataGridViewTextBoxColumn.DataPropertyName = "tAddress";
            this.tAddressDataGridViewTextBoxColumn.HeaderText = "tAddress";
            this.tAddressDataGridViewTextBoxColumn.Name = "tAddressDataGridViewTextBoxColumn";
            // 
            // teacherBindingSource2
            // 
            this.teacherBindingSource2.DataMember = "teacher";
            this.teacherBindingSource2.DataSource = this.collegeManagementDataSet_teacher_balance;
            // 
            // collegeManagementDataSet_teacher_balance
            // 
            this.collegeManagementDataSet_teacher_balance.DataSetName = "CollegeManagementDataSet_teacher_balance";
            this.collegeManagementDataSet_teacher_balance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(1232, 688);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 66;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeacherSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1_T_Salary_Form);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeacherSalaryForm";
            this.Text = "TeacherSalaryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherSalaryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teachersalaryform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_T_Salary_Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher_balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add_salary;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private CollegeManagementDataSet_teachersalaryform collegeManagementDataSet_teachersalaryform;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private CollegeManagementDataSet_teachersalaryformTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1_T_Salary_Form;
        private CollegeManagementDataSet_teacher_balance collegeManagementDataSet_teacher_balance;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private CollegeManagementDataSet_teacher_balanceTableAdapters.teacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}