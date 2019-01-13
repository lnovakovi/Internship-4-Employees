namespace Employee.Presentation.AddEmployee
{
    partial class AddEmployeeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.dateEmployeeBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.lstBoxProjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "OIB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(150, 18);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(165, 26);
            this.txtEmployeeName.TabIndex = 5;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(150, 69);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(173, 26);
            this.txtEmployeeSurname.TabIndex = 6;
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(152, 118);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(171, 26);
            this.txtOIB.TabIndex = 7;
            // 
            // dateEmployeeBirth
            // 
            this.dateEmployeeBirth.Location = new System.Drawing.Point(183, 159);
            this.dateEmployeeBirth.Name = "dateEmployeeBirth";
            this.dateEmployeeBirth.Size = new System.Drawing.Size(200, 26);
            this.dateEmployeeBirth.TabIndex = 8;
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(150, 205);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(173, 28);
            this.cmbJob.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Projects that employee works on/ will work on / worked on";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(152, 432);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(163, 53);
            this.btnSaveEmployee.TabIndex = 12;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.SaveEmployee);
            // 
            // lstBoxProjects
            // 
            this.lstBoxProjects.FormattingEnabled = true;
            this.lstBoxProjects.ItemHeight = 20;
            this.lstBoxProjects.Location = new System.Drawing.Point(49, 275);
            this.lstBoxProjects.Name = "lstBoxProjects";
            this.lstBoxProjects.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxProjects.Size = new System.Drawing.Size(402, 144);
            this.lstBoxProjects.TabIndex = 13;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 516);
            this.Controls.Add(this.lstBoxProjects);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.dateEmployeeBirth);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtEmployeeSurname);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.DateTimePicker dateEmployeeBirth;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.ListBox lstBoxProjects;
    }
}