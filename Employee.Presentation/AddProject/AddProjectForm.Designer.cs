namespace Employee.Presentation.AddProject
{
    partial class AddProjectForm
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
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.datePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.datePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProjectSave = new System.Windows.Forms.Button();
            this.lstBoxEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(181, 27);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(125, 26);
            this.txtProjectName.TabIndex = 3;
            // 
            // datePickerStartDate
            // 
            this.datePickerStartDate.Location = new System.Drawing.Point(181, 94);
            this.datePickerStartDate.Name = "datePickerStartDate";
            this.datePickerStartDate.Size = new System.Drawing.Size(200, 26);
            this.datePickerStartDate.TabIndex = 4;
            // 
            // datePickerEndDate
            // 
            this.datePickerEndDate.Location = new System.Drawing.Point(181, 156);
            this.datePickerEndDate.Name = "datePickerEndDate";
            this.datePickerEndDate.Size = new System.Drawing.Size(200, 26);
            this.datePickerEndDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(185, 226);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(121, 28);
            this.cmbState.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tick employees on that project";
            // 
            // btnProjectSave
            // 
            this.btnProjectSave.Location = new System.Drawing.Point(282, 351);
            this.btnProjectSave.Name = "btnProjectSave";
            this.btnProjectSave.Size = new System.Drawing.Size(121, 52);
            this.btnProjectSave.TabIndex = 10;
            this.btnProjectSave.Text = "Save";
            this.btnProjectSave.UseVisualStyleBackColor = true;
            this.btnProjectSave.Click += new System.EventHandler(this.SaveProject);
            // 
            // lstBoxEmployee
            // 
            this.lstBoxEmployee.FormattingEnabled = true;
            this.lstBoxEmployee.ItemHeight = 20;
            this.lstBoxEmployee.Location = new System.Drawing.Point(476, 76);
            this.lstBoxEmployee.Name = "lstBoxEmployee";
            this.lstBoxEmployee.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxEmployee.Size = new System.Drawing.Size(423, 224);
            this.lstBoxEmployee.TabIndex = 11;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.lstBoxEmployee);
            this.Controls.Add(this.btnProjectSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePickerEndDate);
            this.Controls.Add(this.datePickerStartDate);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.DateTimePicker datePickerStartDate;
        private System.Windows.Forms.DateTimePicker datePickerEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProjectSave;
        private System.Windows.Forms.ListBox lstBoxEmployee;
    }
}