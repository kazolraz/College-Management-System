namespace College_Management_System
{
    partial class FormAllAccountant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllAccountant));
            this.actionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.actionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Acc = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Acc_Search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.accountantBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet_accountant = new College_Management_System.CollegeManagementDataSet_accountant();
            this.accountantTableAdapter = new College_Management_System.CollegeManagementDataSet_accountantTableAdapters.accountantTableAdapter();
            this.accountantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid_All_Acc = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBloodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet3 = new College_Management_System.CollegeManagementDataSet3();
            this.accountantTableAdapter1 = new College_Management_System.CollegeManagementDataSet3TableAdapters.accountantTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip_Acc.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_accountant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // actionDelete
            // 
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(131, 26);
            this.actionDelete.Text = "DELETE";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
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
            this.aCTIONToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.aCTIONToolStripMenuItem.Text = "ACTION";
            // 
            // menuStrip_Acc
            // 
            this.menuStrip_Acc.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip_Acc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Acc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCTIONToolStripMenuItem});
            this.menuStrip_Acc.Location = new System.Drawing.Point(383, 68);
            this.menuStrip_Acc.Name = "menuStrip_Acc";
            this.menuStrip_Acc.Size = new System.Drawing.Size(86, 29);
            this.menuStrip_Acc.TabIndex = 20;
            this.menuStrip_Acc.Text = "menuStrip1";
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
            // Acc_Search
            // 
            this.Acc_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_Search.Location = new System.Drawing.Point(129, 3);
            this.Acc_Search.Name = "Acc_Search";
            this.Acc_Search.Size = new System.Drawing.Size(187, 31);
            this.Acc_Search.TabIndex = 6;
            this.Acc_Search.TextChanged += new System.EventHandler(this.Acc_Search_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.71951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.28049F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Acc_Search, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 34);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(487, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "ALL ACCOUNTANT ";
            // 
            // accountantBindingSource2
            // 
            this.accountantBindingSource2.DataMember = "accountant";
            this.accountantBindingSource2.DataSource = this.collegeManagementDataSet_accountant;
            // 
            // collegeManagementDataSet_accountant
            // 
            this.collegeManagementDataSet_accountant.DataSetName = "CollegeManagementDataSet_accountant";
            this.collegeManagementDataSet_accountant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantTableAdapter
            // 
            this.accountantTableAdapter.ClearBeforeFill = true;
            // 
            // accountantBindingSource1
            // 
            this.accountantBindingSource1.DataMember = "accountant";
            // 
            // accountantBindingSource
            // 
            this.accountantBindingSource.DataMember = "accountant";
            // 
            // DataGrid_All_Acc
            // 
            this.DataGrid_All_Acc.AutoGenerateColumns = false;
            this.DataGrid_All_Acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_All_Acc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.aIdDataGridViewTextBoxColumn,
            this.aPassDataGridViewTextBoxColumn,
            this.aPosDataGridViewTextBoxColumn,
            this.aDobDataGridViewTextBoxColumn,
            this.aGenderDataGridViewTextBoxColumn,
            this.aBloodDataGridViewTextBoxColumn,
            this.aSalaryDataGridViewTextBoxColumn,
            this.aContactDataGridViewTextBoxColumn,
            this.aAddressDataGridViewTextBoxColumn});
            this.DataGrid_All_Acc.DataSource = this.accountantBindingSource3;
            this.DataGrid_All_Acc.Location = new System.Drawing.Point(45, 153);
            this.DataGrid_All_Acc.Name = "DataGrid_All_Acc";
            this.DataGrid_All_Acc.Size = new System.Drawing.Size(1144, 445);
            this.DataGrid_All_Acc.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "aName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "aName";
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            // 
            // aIdDataGridViewTextBoxColumn
            // 
            this.aIdDataGridViewTextBoxColumn.DataPropertyName = "aId";
            this.aIdDataGridViewTextBoxColumn.HeaderText = "aId";
            this.aIdDataGridViewTextBoxColumn.Name = "aIdDataGridViewTextBoxColumn";
            // 
            // aPassDataGridViewTextBoxColumn
            // 
            this.aPassDataGridViewTextBoxColumn.DataPropertyName = "aPass";
            this.aPassDataGridViewTextBoxColumn.HeaderText = "aPass";
            this.aPassDataGridViewTextBoxColumn.Name = "aPassDataGridViewTextBoxColumn";
            // 
            // aPosDataGridViewTextBoxColumn
            // 
            this.aPosDataGridViewTextBoxColumn.DataPropertyName = "aPos";
            this.aPosDataGridViewTextBoxColumn.HeaderText = "aPos";
            this.aPosDataGridViewTextBoxColumn.Name = "aPosDataGridViewTextBoxColumn";
            // 
            // aDobDataGridViewTextBoxColumn
            // 
            this.aDobDataGridViewTextBoxColumn.DataPropertyName = "aDob";
            this.aDobDataGridViewTextBoxColumn.HeaderText = "aDob";
            this.aDobDataGridViewTextBoxColumn.Name = "aDobDataGridViewTextBoxColumn";
            // 
            // aGenderDataGridViewTextBoxColumn
            // 
            this.aGenderDataGridViewTextBoxColumn.DataPropertyName = "aGender";
            this.aGenderDataGridViewTextBoxColumn.HeaderText = "aGender";
            this.aGenderDataGridViewTextBoxColumn.Name = "aGenderDataGridViewTextBoxColumn";
            // 
            // aBloodDataGridViewTextBoxColumn
            // 
            this.aBloodDataGridViewTextBoxColumn.DataPropertyName = "aBlood";
            this.aBloodDataGridViewTextBoxColumn.HeaderText = "aBlood";
            this.aBloodDataGridViewTextBoxColumn.Name = "aBloodDataGridViewTextBoxColumn";
            // 
            // aSalaryDataGridViewTextBoxColumn
            // 
            this.aSalaryDataGridViewTextBoxColumn.DataPropertyName = "aSalary";
            this.aSalaryDataGridViewTextBoxColumn.HeaderText = "aSalary";
            this.aSalaryDataGridViewTextBoxColumn.Name = "aSalaryDataGridViewTextBoxColumn";
            // 
            // aContactDataGridViewTextBoxColumn
            // 
            this.aContactDataGridViewTextBoxColumn.DataPropertyName = "aContact";
            this.aContactDataGridViewTextBoxColumn.HeaderText = "aContact";
            this.aContactDataGridViewTextBoxColumn.Name = "aContactDataGridViewTextBoxColumn";
            // 
            // aAddressDataGridViewTextBoxColumn
            // 
            this.aAddressDataGridViewTextBoxColumn.DataPropertyName = "aAddress";
            this.aAddressDataGridViewTextBoxColumn.HeaderText = "aAddress";
            this.aAddressDataGridViewTextBoxColumn.Name = "aAddressDataGridViewTextBoxColumn";
            // 
            // accountantBindingSource3
            // 
            this.accountantBindingSource3.DataMember = "accountant";
            this.accountantBindingSource3.DataSource = this.collegeManagementDataSet3;
            // 
            // collegeManagementDataSet3
            // 
            this.collegeManagementDataSet3.DataSetName = "CollegeManagementDataSet3";
            this.collegeManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountantTableAdapter1
            // 
            this.accountantTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1087, 661);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAllAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataGrid_All_Acc);
            this.Controls.Add(this.menuStrip_Acc);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAllAccountant";
            this.Text = "FormAllAccountant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAllAccountant_Load);
            this.menuStrip_Acc.ResumeLayout(false);
            this.menuStrip_Acc.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet_accountant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_All_Acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountantBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource accountantBindingSource;
        private System.Windows.Forms.BindingSource accountantBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem actionDelete;
        private System.Windows.Forms.ToolStripMenuItem actionEdit;
        private System.Windows.Forms.ToolStripMenuItem aCTIONToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip_Acc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Acc_Search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private CollegeManagementDataSet_accountant collegeManagementDataSet_accountant;
        private System.Windows.Forms.BindingSource accountantBindingSource2;
        private CollegeManagementDataSet_accountantTableAdapters.accountantTableAdapter accountantTableAdapter;
        private System.Windows.Forms.DataGridView DataGrid_All_Acc;
        private CollegeManagementDataSet3 collegeManagementDataSet3;
        private System.Windows.Forms.BindingSource accountantBindingSource3;
        private CollegeManagementDataSet3TableAdapters.accountantTableAdapter accountantTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBloodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}