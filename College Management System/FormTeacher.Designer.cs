namespace College_Management_System
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridMarks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMrollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMbanglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMenglishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMmathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMphyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuMgpaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeManagementDataSet2 = new College_Management_System.CollegeManagementDataSet2();
            this.marksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuMarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.txt_phy = new System.Windows.Forms.TextBox();
            this.txt_math = new System.Windows.Forms.TextBox();
            this.txt_english = new System.Windows.Forms.TextBox();
            this.txt_src = new System.Windows.Forms.TextBox();
            this.txt_bangla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.marksTableAdapter = new College_Management_System.CollegeManagementDataSet2TableAdapters.marksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMarksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(1226, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 75;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridMarks
            // 
            this.dataGridMarks.AutoGenerateColumns = false;
            this.dataGridMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.stuMidDataGridViewTextBoxColumn,
            this.stuMrollDataGridViewTextBoxColumn,
            this.stuMyearDataGridViewTextBoxColumn,
            this.stuMbanglaDataGridViewTextBoxColumn,
            this.stuMenglishDataGridViewTextBoxColumn,
            this.stuMmathDataGridViewTextBoxColumn,
            this.stuMphyDataGridViewTextBoxColumn,
            this.stuMgpaDataGridViewTextBoxColumn});
            this.dataGridMarks.DataSource = this.marksBindingSource3;
            this.dataGridMarks.Location = new System.Drawing.Point(374, 153);
            this.dataGridMarks.Name = "dataGridMarks";
            this.dataGridMarks.Size = new System.Drawing.Size(940, 466);
            this.dataGridMarks.TabIndex = 71;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stuMidDataGridViewTextBoxColumn
            // 
            this.stuMidDataGridViewTextBoxColumn.DataPropertyName = "stuM_id";
            this.stuMidDataGridViewTextBoxColumn.HeaderText = "stuM_id";
            this.stuMidDataGridViewTextBoxColumn.Name = "stuMidDataGridViewTextBoxColumn";
            // 
            // stuMrollDataGridViewTextBoxColumn
            // 
            this.stuMrollDataGridViewTextBoxColumn.DataPropertyName = "stuM_roll";
            this.stuMrollDataGridViewTextBoxColumn.HeaderText = "stuM_roll";
            this.stuMrollDataGridViewTextBoxColumn.Name = "stuMrollDataGridViewTextBoxColumn";
            // 
            // stuMyearDataGridViewTextBoxColumn
            // 
            this.stuMyearDataGridViewTextBoxColumn.DataPropertyName = "stuM_year";
            this.stuMyearDataGridViewTextBoxColumn.HeaderText = "stuM_year";
            this.stuMyearDataGridViewTextBoxColumn.Name = "stuMyearDataGridViewTextBoxColumn";
            // 
            // stuMbanglaDataGridViewTextBoxColumn
            // 
            this.stuMbanglaDataGridViewTextBoxColumn.DataPropertyName = "stuM_bangla";
            this.stuMbanglaDataGridViewTextBoxColumn.HeaderText = "stuM_bangla";
            this.stuMbanglaDataGridViewTextBoxColumn.Name = "stuMbanglaDataGridViewTextBoxColumn";
            // 
            // stuMenglishDataGridViewTextBoxColumn
            // 
            this.stuMenglishDataGridViewTextBoxColumn.DataPropertyName = "stuM_english";
            this.stuMenglishDataGridViewTextBoxColumn.HeaderText = "stuM_english";
            this.stuMenglishDataGridViewTextBoxColumn.Name = "stuMenglishDataGridViewTextBoxColumn";
            // 
            // stuMmathDataGridViewTextBoxColumn
            // 
            this.stuMmathDataGridViewTextBoxColumn.DataPropertyName = "stuM_math";
            this.stuMmathDataGridViewTextBoxColumn.HeaderText = "stuM_math";
            this.stuMmathDataGridViewTextBoxColumn.Name = "stuMmathDataGridViewTextBoxColumn";
            // 
            // stuMphyDataGridViewTextBoxColumn
            // 
            this.stuMphyDataGridViewTextBoxColumn.DataPropertyName = "stuM_phy";
            this.stuMphyDataGridViewTextBoxColumn.HeaderText = "stuM_phy";
            this.stuMphyDataGridViewTextBoxColumn.Name = "stuMphyDataGridViewTextBoxColumn";
            // 
            // stuMgpaDataGridViewTextBoxColumn
            // 
            this.stuMgpaDataGridViewTextBoxColumn.DataPropertyName = "stuM_gpa";
            this.stuMgpaDataGridViewTextBoxColumn.HeaderText = "stuM_gpa";
            this.stuMgpaDataGridViewTextBoxColumn.Name = "stuMgpaDataGridViewTextBoxColumn";
            // 
            // marksBindingSource3
            // 
            this.marksBindingSource3.DataMember = "marks";
            this.marksBindingSource3.DataSource = this.collegeManagementDataSet2;
            // 
            // collegeManagementDataSet2
            // 
            this.collegeManagementDataSet2.DataSetName = "CollegeManagementDataSet2";
            this.collegeManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marksBindingSource1
            // 
            this.marksBindingSource1.DataMember = "marks";
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "marks";
            // 
            // stuMarksBindingSource
            // 
            this.stuMarksBindingSource.DataMember = "stuMarks";
            // 
            // marksBindingSource2
            // 
            this.marksBindingSource2.DataMember = "marks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 74;
            this.label8.Text = "Add Grade :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(1234, 101);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(94, 24);
            this.lbl_subject.TabIndex = 70;
            this.lbl_subject.Text = "SUBJECT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "BANGALI";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_type.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_type.Location = new System.Drawing.Point(153, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(134, 29);
            this.lbl_type.TabIndex = 5;
            this.lbl_type.Text = "TEACHER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "PHYSICS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "SEARCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "ENGLISH";
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(254, 465);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(73, 29);
            this.btnAddMarks.TabIndex = 68;
            this.btnAddMarks.Text = "Update";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click);
            // 
            // txt_phy
            // 
            this.txt_phy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phy.Location = new System.Drawing.Point(196, 421);
            this.txt_phy.Name = "txt_phy";
            this.txt_phy.Size = new System.Drawing.Size(137, 26);
            this.txt_phy.TabIndex = 63;
            // 
            // txt_math
            // 
            this.txt_math.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_math.Location = new System.Drawing.Point(196, 363);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(137, 26);
            this.txt_math.TabIndex = 64;
            // 
            // txt_english
            // 
            this.txt_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_english.Location = new System.Drawing.Point(196, 310);
            this.txt_english.Name = "txt_english";
            this.txt_english.Size = new System.Drawing.Size(137, 26);
            this.txt_english.TabIndex = 65;
            // 
            // txt_src
            // 
            this.txt_src.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_src.Location = new System.Drawing.Point(196, 153);
            this.txt_src.Name = "txt_src";
            this.txt_src.Size = new System.Drawing.Size(137, 26);
            this.txt_src.TabIndex = 66;
            this.txt_src.TextChanged += new System.EventHandler(this.txt_src_TextChanged);
            // 
            // txt_bangla
            // 
            this.txt_bangla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bangla.Location = new System.Drawing.Point(196, 255);
            this.txt_bangla.Name = "txt_bangla";
            this.txt_bangla.Size = new System.Drawing.Size(137, 26);
            this.txt_bangla.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "MATHEMATICS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1364, 50);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.41573F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.58427F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_type, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(687, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 39);
            this.tableLayoutPanel1.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(508, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 29);
            this.label7.TabIndex = 76;
            this.label7.Text = "COLLEGE MANAGEMENT SYSTEM";
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridMarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddMarks);
            this.Controls.Add(this.txt_phy);
            this.Controls.Add(this.txt_math);
            this.Controls.Add(this.txt_english);
            this.Controls.Add(this.txt_src);
            this.Controls.Add(this.txt_bangla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuMarksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridMarks;
        private System.Windows.Forms.BindingSource marksBindingSource1;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private System.Windows.Forms.BindingSource stuMarksBindingSource;
        private System.Windows.Forms.BindingSource marksBindingSource2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.TextBox txt_phy;
        private System.Windows.Forms.TextBox txt_math;
        private System.Windows.Forms.TextBox txt_english;
        private System.Windows.Forms.TextBox txt_src;
        private System.Windows.Forms.TextBox txt_bangla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private CollegeManagementDataSet2 collegeManagementDataSet2;
        private System.Windows.Forms.BindingSource marksBindingSource3;
        private CollegeManagementDataSet2TableAdapters.marksTableAdapter marksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMrollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMbanglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMenglishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMmathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMphyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuMgpaDataGridViewTextBoxColumn;
    }
}