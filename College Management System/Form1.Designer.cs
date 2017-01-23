namespace College_Management_System
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.dataGridViewLogin = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logintypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet = new College_Management_System.CollegeManagementDataSet();
            this.loginTableAdapter = new College_Management_System.CollegeManagementDataSetTableAdapters.loginTableAdapter();
            this.collegeManagementDataSet1 = new College_Management_System.CollegeManagementDataSet1();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new College_Management_System.CollegeManagementDataSet1TableAdapters.teacherTableAdapter();
            this.collegeManagementDataSet_teacher1 = new College_Management_System.CollegeManagementDataSet_teacher1();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter1 = new College_Management_System.CollegeManagementDataSet_teacher1TableAdapters.teacherTableAdapter();
            this.dataGridView_t_login = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.collegeManagementData_teacher = new College_Management_System.CollegeManagementData_teacher();
            this.teacherTableAdapter2 = new College_Management_System.CollegeManagementData_teacherTableAdapters.teacherTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_t_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementData_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(81, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(370, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(273, 304);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(208, 31);
            this.txt_pass.TabIndex = 11;
            // 
            // txt_userid
            // 
            this.txt_userid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userid.Location = new System.Drawing.Point(273, 240);
            this.txt_userid.Multiline = true;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(208, 31);
            this.txt_userid.TabIndex = 12;
            // 
            // dataGridViewLogin
            // 
            this.dataGridViewLogin.AutoGenerateColumns = false;
            this.dataGridViewLogin.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.dataGridViewLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginidDataGridViewTextBoxColumn,
            this.loginpassDataGridViewTextBoxColumn,
            this.logintypeDataGridViewTextBoxColumn});
            this.dataGridViewLogin.DataSource = this.loginBindingSource;
            this.dataGridViewLogin.Location = new System.Drawing.Point(618, 26);
            this.dataGridViewLogin.Name = "dataGridViewLogin";
            this.dataGridViewLogin.Size = new System.Drawing.Size(433, 198);
            this.dataGridViewLogin.TabIndex = 26;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginidDataGridViewTextBoxColumn
            // 
            this.loginidDataGridViewTextBoxColumn.DataPropertyName = "login_id";
            this.loginidDataGridViewTextBoxColumn.HeaderText = "login_id";
            this.loginidDataGridViewTextBoxColumn.Name = "loginidDataGridViewTextBoxColumn";
            // 
            // loginpassDataGridViewTextBoxColumn
            // 
            this.loginpassDataGridViewTextBoxColumn.DataPropertyName = "login_pass";
            this.loginpassDataGridViewTextBoxColumn.HeaderText = "login_pass";
            this.loginpassDataGridViewTextBoxColumn.Name = "loginpassDataGridViewTextBoxColumn";
            // 
            // logintypeDataGridViewTextBoxColumn
            // 
            this.logintypeDataGridViewTextBoxColumn.DataPropertyName = "login_type";
            this.logintypeDataGridViewTextBoxColumn.HeaderText = "login_type";
            this.logintypeDataGridViewTextBoxColumn.Name = "logintypeDataGridViewTextBoxColumn";
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.collegeManagementDataSet;
            // 
            // collegeManagementDataSet
            // 
            this.collegeManagementDataSet.DataSetName = "CollegeManagementDataSet";
            this.collegeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // collegeManagementDataSet1
            // 
            this.collegeManagementDataSet1.DataSetName = "CollegeManagementDataSet1";
            this.collegeManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.collegeManagementDataSet1;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // collegeManagementDataSet_teacher1
            // 
            this.collegeManagementDataSet_teacher1.DataSetName = "CollegeManagementDataSet_teacher1";
            this.collegeManagementDataSet_teacher1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "teacher";
            this.teacherBindingSource1.DataSource = this.collegeManagementDataSet_teacher1;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView_t_login
            // 
            this.dataGridView_t_login.AutoGenerateColumns = false;
            this.dataGridView_t_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_t_login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
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
            this.dataGridView_t_login.DataSource = this.teacherBindingSource2;
            this.dataGridView_t_login.Location = new System.Drawing.Point(596, 304);
            this.dataGridView_t_login.Name = "dataGridView_t_login";
            this.dataGridView_t_login.Size = new System.Drawing.Size(705, 150);
            this.dataGridView_t_login.TabIndex = 27;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.teacherBindingSource2.DataSource = this.collegeManagementData_teacher;
            // 
            // collegeManagementData_teacher
            // 
            this.collegeManagementData_teacher.DataSetName = "CollegeManagementData_teacher";
            this.collegeManagementData_teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter2
            // 
            this.teacherTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1228, 660);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 35);
            this.button2.TabIndex = 30;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_t_login);
            this.Controls.Add(this.dataGridViewLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_userid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_t_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementData_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.DataGridView dataGridViewLogin;
        private CollegeManagementDataSet collegeManagementDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private CollegeManagementDataSetTableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logintypeDataGridViewTextBoxColumn;
        private CollegeManagementDataSet1 collegeManagementDataSet1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private CollegeManagementDataSet1TableAdapters.teacherTableAdapter teacherTableAdapter;
        private CollegeManagementDataSet_teacher1 collegeManagementDataSet_teacher1;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private CollegeManagementDataSet_teacher1TableAdapters.teacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView_t_login;
        private CollegeManagementData_teacher collegeManagementData_teacher;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private CollegeManagementData_teacherTableAdapters.teacherTableAdapter teacherTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.Button button2;
    }
}

