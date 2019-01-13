namespace Employee.Presentation.EditEmployee
{
    partial class EditEmployeeForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmployee = new System.Windows.Forms.DateTimePicker();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.lstBoxOldProjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstBoxNewProjects = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "OIB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(123, 73);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(168, 26);
            this.txtSurname.TabIndex = 6;
            // 
            // txtOIB
            // 
            this.txtOIB.Enabled = false;
            this.txtOIB.Location = new System.Drawing.Point(118, 121);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(172, 26);
            this.txtOIB.TabIndex = 7;
            // 
            // dateTimePickerEmployee
            // 
            this.dateTimePickerEmployee.Location = new System.Drawing.Point(158, 172);
            this.dateTimePickerEmployee.Name = "dateTimePickerEmployee";
            this.dateTimePickerEmployee.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEmployee.TabIndex = 8;
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(134, 221);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(170, 28);
            this.cmbJob.TabIndex = 9;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(85, 284);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(155, 68);
            this.btnSaveEdit.TabIndex = 10;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.SaveEdit);
            // 
            // lstBoxOldProjects
            // 
            this.lstBoxOldProjects.FormattingEnabled = true;
            this.lstBoxOldProjects.ItemHeight = 20;
            this.lstBoxOldProjects.Location = new System.Drawing.Point(404, 37);
            this.lstBoxOldProjects.Name = "lstBoxOldProjects";
            this.lstBoxOldProjects.Size = new System.Drawing.Size(379, 244);
            this.lstBoxOldProjects.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(686, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveProject);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(789, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddProject);
            // 
            // lstBoxNewProjects
            // 
            this.lstBoxNewProjects.FormattingEnabled = true;
            this.lstBoxNewProjects.ItemHeight = 20;
            this.lstBoxNewProjects.Location = new System.Drawing.Point(789, 37);
            this.lstBoxNewProjects.Name = "lstBoxNewProjects";
            this.lstBoxNewProjects.Size = new System.Drawing.Size(375, 244);
            this.lstBoxNewProjects.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Projects employee is working on:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "You can add new projects";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(753, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(429, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "*You can add / remove projects without clicking button Save";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 58);
            this.button3.TabIndex = 18;
            this.button3.Text = "Change working hours";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChangeWorkingHours);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 60);
            this.label9.TabIndex = 19;
            this.label9.Text = "If you want to modify working hours\r\n for employee,please select project\r\n and cl" +
    "ick button Change working hours.\r\n";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(91, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 49);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.Close);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 464);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBoxNewProjects);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBoxOldProjects);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.cmbJob);
            this.Controls.Add(this.dateTimePickerEmployee);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.Load += new System.EventHandler(this.EditEmployeeForm_Load);
            this.Click += new System.EventHandler(this.ChangeWorkingHours);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmployee;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.ListBox lstBoxOldProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstBoxNewProjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
    }
}