namespace _2_CodeFirstApp
{
    partial class FrmCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEducator = new System.Windows.Forms.ComboBox();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEducator = new System.Windows.Forms.LinkLabel();
            this.lblStudent = new System.Windows.Forms.LinkLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(157, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Başlangıç Tarihi :";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(157, 58);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(116, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bitiş Tarihi :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(157, 90);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(116, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eğitmen :";
            // 
            // cbEducator
            // 
            this.cbEducator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducator.FormattingEnabled = true;
            this.cbEducator.Location = new System.Drawing.Point(157, 123);
            this.cbEducator.Name = "cbEducator";
            this.cbEducator.Size = new System.Drawing.Size(116, 21);
            this.cbEducator.TabIndex = 3;
            // 
            // gbStudents
            // 
            this.gbStudents.Location = new System.Drawing.Point(279, 28);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(236, 145);
            this.gbStudents.TabIndex = 4;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Öğrenciler";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEducator
            // 
            this.lblEducator.AutoSize = true;
            this.lblEducator.Location = new System.Drawing.Point(276, 176);
            this.lblEducator.Name = "lblEducator";
            this.lblEducator.Size = new System.Drawing.Size(69, 13);
            this.lblEducator.TabIndex = 6;
            this.lblEducator.TabStop = true;
            this.lblEducator.Text = "Eğitmen Ekle";
            this.lblEducator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEducator_LinkClicked);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(447, 176);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(68, 13);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.TabStop = true;
            this.lblStudent.Text = "Öğrenci Ekle";
            this.lblStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblStudent_LinkClicked);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(33, 197);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(482, 134);
            this.dgv.TabIndex = 7;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(39, 337);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 5;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 383);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblEducator);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbStudents);
            this.Controls.Add(this.cbEducator);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmCourse";
            this.Text = "Ad :";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lblEducator;
        private System.Windows.Forms.LinkLabel lblStudent;
        private System.Windows.Forms.Button btnList;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.ComboBox cbEducator;
        public System.Windows.Forms.GroupBox gbStudents;
    }
}

