namespace College_Management_System
{
    partial class FormAllTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllTeacher));
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnColse = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridView_AT = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet_teacher = new College_Management_System.CollegeManagementDataSet_teacher();
            this.teacherTableAdapter = new College_Management_System.CollegeManagementDataSet_teacherTableAdapters.teacherTableAdapter();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnColse)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // actionEdit
            // 
            this.actionEdit.Name = "actionEdit";
            this.actionEdit.Size = new System.Drawing.Size(131, 26);
            this.actionEdit.Text = "EDIT";
            this.actionEdit.Click += new System.EventHandler(this.actionEdit_Click);
            // 
            // aCTIONToolStripMenuItem
            // 
            this.aCTIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionEdit,
            this.actionDelete});
            this.aCTIONToolStripMenuItem.Name = "aCTIONToolStripMenuItem";
            this.aCTIONToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.aCTIONToolStripMenuItem.Text = "OPTIONS";
            // 
            // actionDelete
            // 
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(131, 26);
            this.actionDelete.Text = "DELETE";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(435, 59);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(96, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnColse
            // 
            this.btnColse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColse.Image = ((System.Drawing.Image)(resources.GetObject("btnColse.Image")));
            this.btnColse.Location = new System.Drawing.Point(1271, 677);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(83, 34);
            this.btnColse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColse.TabIndex = 17;
            this.btnColse.TabStop = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(534, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "ALL TEACHER";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(129, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 31);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "SEARCH";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // DataGridView_AT
            // 
            this.DataGridView_AT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_AT.AutoGenerateColumns = false;
            this.DataGridView_AT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_AT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tIdDataGridViewTextBoxColumn,
            this.tPosDataGridViewTextBoxColumn,
            this.tSubDataGridViewTextBoxColumn,
            this.tDeptDataGridViewTextBoxColumn,
            this.tSalaryDataGridViewTextBoxColumn,
            this.tBloodDataGridViewTextBoxColumn,
            this.tDobDataGridViewTextBoxColumn,
            this.tGenderDataGridViewTextBoxColumn,
            this.tContactDataGridViewTextBoxColumn,
            this.tAddressDataGridViewTextBoxColumn});
            this.DataGridView_AT.DataSource = this.teacherBindingSource1;
            this.DataGridView_AT.Location = new System.Drawing.Point(0, 101);
            this.DataGridView_AT.Name = "DataGridView_AT";
            this.DataGridView_AT.Size = new System.Drawing.Size(1354, 570);
            this.DataGridView_AT.TabIndex = 14;
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
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "teacher";
            this.teacherBindingSource1.DataSource = this.collegeManagementDataSet_teacher;
            // 
            // collegeManagementDataSet_teacher
            // 
            this.collegeManagementDataSet_teacher.DataSetName = "CollegeManagementDataSet_teacher";
            this.collegeManagementDataSet_teacher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            // 
            // FormAllTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DataGridView_AT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllTeacher";
            this.Text = "FormAllTeacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAllTeacher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnColse)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_AT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_teacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox btnColse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridView DataGridView_AT;
        private CollegeManagementDataSet_teacher collegeManagementDataSet_teacher;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private CollegeManagementDataSet_teacherTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAddressDataGridViewTextBoxColumn;
    }
}