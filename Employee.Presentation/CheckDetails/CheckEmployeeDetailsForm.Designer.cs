namespace Employee.Presentation.CheckDetails
{
    partial class CheckEmployeeDetailsForm
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
            this.btnOpenEdit = new System.Windows.Forms.Button();
            this.btnCheckProjects = new System.Windows.Forms.Button();
            this.btnShowColor = new System.Windows.Forms.Button();
            this.lstBoxEmployee = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            // 
            // btnOpenEdit
            // 
            this.btnOpenEdit.Location = new System.Drawing.Point(142, 445);
            this.btnOpenEdit.Name = "btnOpenEdit";
            this.btnOpenEdit.Size = new System.Drawing.Size(127, 54);
            this.btnOpenEdit.TabIndex = 2;
            this.btnOpenEdit.Text = "Edit employee";
            this.btnOpenEdit.UseVisualStyleBackColor = true;
            this.btnOpenEdit.Click += new System.EventHandler(this.OpenEditEmployeeForm);
            // 
            // btnCheckProjects
            // 
            this.btnCheckProjects.Location = new System.Drawing.Point(301, 449);
            this.btnCheckProjects.Name = "btnCheckProjects";
            this.btnCheckProjects.Size = new System.Drawing.Size(148, 49);
            this.btnCheckProjects.TabIndex = 3;
            this.btnCheckProjects.Text = "Check projects";
            this.btnCheckProjects.UseVisualStyleBackColor = true;
            this.btnCheckProjects.Click += new System.EventHandler(this.OpenCheckEmployeesProjectForm);
            // 
            // btnShowColor
            // 
            this.btnShowColor.BackColor = System.Drawing.Color.White;
            this.btnShowColor.Location = new System.Drawing.Point(562, 38);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(144, 57);
            this.btnShowColor.TabIndex = 5;
            this.btnShowColor.UseVisualStyleBackColor = false;
            // 
            // lstBoxEmployee
            // 
            this.lstBoxEmployee.FormattingEnabled = true;
            this.lstBoxEmployee.ItemHeight = 20;
            this.lstBoxEmployee.Location = new System.Drawing.Point(31, 38);
            this.lstBoxEmployee.Name = "lstBoxEmployee";
            this.lstBoxEmployee.Size = new System.Drawing.Size(525, 384);
            this.lstBoxEmployee.TabIndex = 6;
            this.lstBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.ChangeColor);
            // 
            // CheckEmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 554);
            this.Controls.Add(this.lstBoxEmployee);
            this.Controls.Add(this.btnShowColor);
            this.Controls.Add(this.btnCheckProjects);
            this.Controls.Add(this.btnOpenEdit);
            this.Controls.Add(this.label1);
            this.Name = "CheckEmployeeDetailsForm";
            this.Text = "CheckEmployeeDetailsForm";
            this.Load += new System.EventHandler(this.CheckEmployeeDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenEdit;
        private System.Windows.Forms.Button btnCheckProjects;
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.ListBox lstBoxEmployee;
    }
}