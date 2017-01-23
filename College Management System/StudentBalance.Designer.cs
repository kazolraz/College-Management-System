namespace College_Management_System
{
    partial class StudentBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentBalance));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_add_fees = new System.Windows.Forms.Button();
            this.tk = new System.Windows.Forms.Label();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1_BALANCE = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdRollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet_studentbalance = new College_Management_System.CollegeManagementDataSet_studentbalance();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.studentTableAdapter = new College_Management_System.CollegeManagementDataSet_studentbalanceTableAdapters.studentTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BALANCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_studentbalance)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1239, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 65;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_add_fees
            // 
            this.btn_add_fees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_fees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add_fees.Location = new System.Drawing.Point(37, 74);
            this.btn_add_fees.Name = "btn_add_fees";
            this.btn_add_fees.Size = new System.Drawing.Size(183, 23);
            this.btn_add_fees.TabIndex = 15;
            this.btn_add_fees.Text = "ADD FEES";
            this.btn_add_fees.UseVisualStyleBackColor = true;
            this.btn_add_fees.Click += new System.EventHandler(this.btn_add_fees_Click);
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
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(37, 39);
            this.txt_fees.Multiline = true;
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(183, 23);
            this.txt_fees.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_add_fees);
            this.groupBox1.Controls.Add(this.tk);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Location = new System.Drawing.Point(794, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 131);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FEE";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // dataGridView1_BALANCE
            // 
            this.dataGridView1_BALANCE.AutoGenerateColumns = false;
            this.dataGridView1_BALANCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_BALANCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.stdIdDataGridViewTextBoxColumn,
            this.stdRollDataGridViewTextBoxColumn,
            this.stdYearDataGridViewTextBoxColumn,
            this.stdDeptDataGridViewTextBoxColumn,
            this.stdFeeDataGridViewTextBoxColumn});
            this.dataGridView1_BALANCE.DataSource = this.studentBindingSource1;
            this.dataGridView1_BALANCE.Location = new System.Drawing.Point(48, 104);
            this.dataGridView1_BALANCE.Name = "dataGridView1_BALANCE";
            this.dataGridView1_BALANCE.Size = new System.Drawing.Size(740, 334);
            this.dataGridView1_BALANCE.TabIndex = 62;
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
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            // 
            // stdIdDataGridViewTextBoxColumn
            // 
            this.stdIdDataGridViewTextBoxColumn.DataPropertyName = "stdId";
            this.stdIdDataGridViewTextBoxColumn.HeaderText = "Id";
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
            // stdFeeDataGridViewTextBoxColumn
            // 
            this.stdFeeDataGridViewTextBoxColumn.DataPropertyName = "stdFee";
            this.stdFeeDataGridViewTextBoxColumn.HeaderText = "stdFee";
            this.stdFeeDataGridViewTextBoxColumn.Name = "stdFeeDataGridViewTextBoxColumn";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.collegeManagementDataSet_studentbalance;
            // 
            // collegeManagementDataSet_studentbalance
            // 
            this.collegeManagementDataSet_studentbalance.DataSetName = "CollegeManagementDataSet_studentbalance";
            this.collegeManagementDataSet_studentbalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(168, 25);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 25);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // StudentBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1_BALANCE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentBalance";
            this.Text = "StudentBalance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_BALANCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_studentbalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_add_fees;
        private System.Windows.Forms.Label tk;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1_BALANCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private CollegeManagementDataSet_studentbalance collegeManagementDataSet_studentbalance;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private CollegeManagementDataSet_studentbalanceTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdRollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdFeeDataGridViewTextBoxColumn;
    }
}