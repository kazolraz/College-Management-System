namespace College_Management_System
{
    partial class ShowStudentAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudentAccount));
            this.button2 = new System.Windows.Forms.Button();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrideView_AllStu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_AllStu)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(823, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 65;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            // 
            // DataGrideView_AllStu
            // 
            this.DataGrideView_AllStu.AutoGenerateColumns = false;
            this.DataGrideView_AllStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideView_AllStu.DataSource = this.studentBindingSource;
            this.DataGrideView_AllStu.Location = new System.Drawing.Point(106, 214);
            this.DataGrideView_AllStu.Name = "DataGrideView_AllStu";
            this.DataGrideView_AllStu.Size = new System.Drawing.Size(661, 404);
            this.DataGrideView_AllStu.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 62;
            this.button1.Text = "View Profile";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(193, 138);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(394, 25);
            this.txtSearch.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(101, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Search";
            // 
            // ShowStudentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataGrideView_AllStu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowStudentAccount";
            this.Text = "ShowStudentAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShowStudentAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_AllStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridView DataGrideView_AllStu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}