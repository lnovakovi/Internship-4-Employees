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
            this.lstBoxProjects = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.btnSaveEdit.Location = new System.Drawing.Point(113, 314);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(155, 68);
            this.btnSaveEdit.TabIndex = 10;
            this.btnSaveEdit.Text = "Save";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.SaveEdit);
            // 
            // lstBoxProjects
            // 
            this.lstBoxProjects.FormattingEnabled = true;
            this.lstBoxProjects.ItemHeight = 20;
            this.lstBoxProjects.Location = new System.Drawing.Point(454, 31);
            this.lstBoxProjects.Name = "lstBoxProjects";
            this.lstBoxProjects.Size = new System.Drawing.Size(317, 244);
            this.lstBoxProjects.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 82);
            this.button1.TabIndex = 12;
            this.button1.Text = "Remove project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveProject);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(606, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 82);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddProject);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBoxProjects);
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
        private System.Windows.Forms.ListBox lstBoxProjects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}