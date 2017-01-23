namespace College_Management_System
{
    partial class FormAllStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllStu));
            this.btnColse = new System.Windows.Forms.PictureBox();
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGrid_AllStu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdRollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdBloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdGuardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet1_student = new College_Management_System.CollegeManagementDataSet1_student();
            this.studentTableAdapter = new College_Management_System.CollegeManagementDataSet1_studentTableAdapters.studentTableAdapter();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnColse)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AllStu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet1_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColse
            // 
            this.btnColse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColse.Image = ((System.Drawing.Image)(resources.GetObject("btnColse.Image")));
            this.btnColse.Location = new System.Drawing.Point(1271, 677);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(83, 34);
            this.btnColse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnColse.TabIndex = 12;
            this.btnColse.TabStop = false;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
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
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(388, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(96, 29);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
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
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(129, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 31);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(575, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "ALL STUDENT ";
            // 
            // DataGrid_AllStu
            // 
            this.DataGrid_AllStu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_AllStu.AutoGenerateColumns = false;
            this.DataGrid_AllStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_AllStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.stdIdDataGridViewTextBoxColumn,
            this.stdRollDataGridViewTextBoxColumn,
            this.stdYearDataGridViewTextBoxColumn,
            this.stdDeptDataGridViewTextBoxColumn,
            this.stdDobDataGridViewTextBoxColumn,
            this.stdGenderDataGridViewTextBoxColumn,
            this.stdBloodDataGridViewTextBoxColumn,
            this.stdGuardianDataGridViewTextBoxColumn,
            this.stdContactDataGridViewTextBoxColumn,
            this.stdAddressDataGridViewTextBoxColumn,
            this.stdFeeDataGridViewTextBoxColumn});
            this.DataGrid_AllStu.DataSource = this.studentBindingSource1;
            this.DataGrid_AllStu.Location = new System.Drawing.Point(0, 101);
            this.DataGrid_AllStu.Name = "DataGrid_AllStu";
            this.DataGrid_AllStu.Size = new System.Drawing.Size(1354, 570);
            this.DataGrid_AllStu.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stdNameDataGridViewTextBoxColumn
            // 
            this.stdNameDataGridViewTextBoxColumn.DataPropertyName = "stdName";
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "stdName";
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            // 
            // stdIdDataGridViewTextBoxColumn
            // 
            this.stdIdDataGridViewTextBoxColumn.DataPropertyName = "stdId";
            this.stdIdDataGridViewTextBoxColumn.HeaderText = "stdId";
            this.stdIdDataGridViewTextBoxColumn.Name = "stdIdDataGridViewTextBoxColumn";
            // 
            // stdRollDataGridViewTextBoxColumn
            // 
            this.stdRollDataGridViewTextBoxColumn.DataPropertyName = "stdRoll";
            this.stdRollDataGridViewTextBoxColumn.HeaderText = "stdRoll";
            this.stdRollDataGridViewTextBoxColumn.Name = "stdRollDataGridViewTextBoxColumn";
            // 
            // stdYearDataGridViewTextBoxColumn
            // 
            this.stdYearDataGridViewTextBoxColumn.DataPropertyName = "stdYear";
            this.stdYearDataGridViewTextBoxColumn.HeaderText = "stdYear";
            this.stdYearDataGridViewTextBoxColumn.Name = "stdYearDataGridViewTextBoxColumn";
            // 
            // stdDeptDataGridViewTextBoxColumn
            // 
            this.stdDeptDataGridViewTextBoxColumn.DataPropertyName = "stdDept";
            this.stdDeptDataGridViewTextBoxColumn.HeaderText = "stdDept";
            this.stdDeptDataGridViewTextBoxColumn.Name = "stdDeptDataGridViewTextBoxColumn";
            // 
            // stdDobDataGridViewTextBoxColumn
            // 
            this.stdDobDataGridViewTextBoxColumn.DataPropertyName = "stdDob";
            this.stdDobDataGridViewTextBoxColumn.HeaderText = "stdDob";
            this.stdDobDataGridViewTextBoxColumn.Name = "stdDobDataGridViewTextBoxColumn";
            // 
            // stdGenderDataGridViewTextBoxColumn
            // 
            this.stdGenderDataGridViewTextBoxColumn.DataPropertyName = "stdGender";
            this.stdGenderDataGridViewTextBoxColumn.HeaderText = "stdGender";
            this.stdGenderDataGridViewTextBoxColumn.Name = "stdGenderDataGridViewTextBoxColumn";
            // 
            // stdBloodDataGridViewTextBoxColumn
            // 
            this.stdBloodDataGridViewTextBoxColumn.DataPropertyName = "stdBlood";
            this.stdBloodDataGridViewTextBoxColumn.HeaderText = "stdBlood";
            this.stdBloodDataGridViewTextBoxColumn.Name = "stdBloodDataGridViewTextBoxColumn";
            // 
            // stdGuardianDataGridViewTextBoxColumn
            // 
            this.stdGuardianDataGridViewTextBoxColumn.DataPropertyName = "stdGuardian";
            this.stdGuardianDataGridViewTextBoxColumn.HeaderText = "stdGuardian";
            this.stdGuardianDataGridViewTextBoxColumn.Name = "stdGuardianDataGridViewTextBoxColumn";
            // 
            // stdContactDataGridViewTextBoxColumn
            // 
            this.stdContactDataGridViewTextBoxColumn.DataPropertyName = "stdContact";
            this.stdContactDataGridViewTextBoxColumn.HeaderText = "stdContact";
            this.stdContactDataGridViewTextBoxColumn.Name = "stdContactDataGridViewTextBoxColumn";
            // 
            // stdAddressDataGridViewTextBoxColumn
            // 
            this.stdAddressDataGridViewTextBoxColumn.DataPropertyName = "stdAddress";
            this.stdAddressDataGridViewTextBoxColumn.HeaderText = "stdAddress";
            this.stdAddressDataGridViewTextBoxColumn.Name = "stdAddressDataGridViewTextBoxColumn";
            // 
            // stdFeeDataGridViewTextBoxColumn
            // 
            this.stdFeeDataGridViewTextBoxColumn.DataPropertyName = "stdFee";
            this.stdFeeDataGridViewTextBoxColumn.HeaderText = "stdFee";
            this.stdFeeDataGridViewTextBoxColumn.Name = "stdFeeDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.collegeManagementDataSet1_student;
            // 
            // collegeManagementDataSet1_student
            // 
            this.collegeManagementDataSet1_student.DataSetName = "CollegeManagementDataSet1_student";
            this.collegeManagementDataSet1_student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // FormAllStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.btnColse);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGrid_AllStu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllStu";
            this.Text = "FormAllStu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAllStu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnColse)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_AllStu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet1_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnColse;
        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView DataGrid_AllStu;
        private CollegeManagementDataSet1_student collegeManagementDataSet1_student;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private CollegeManagementDataSet1_studentTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdRollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdGuardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFeeDataGridViewTextBoxColumn;
    }
}