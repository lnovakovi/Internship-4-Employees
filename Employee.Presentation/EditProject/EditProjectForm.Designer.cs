namespace Employee.Presentation.EditProject
{
    partial class EditProjectForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lstBoxOldEmployees = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBoxNewEmployees = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "State:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(194, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 26);
            this.txtName.TabIndex = 4;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(194, 94);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(204, 26);
            this.dateTime.TabIndex = 5;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(194, 144);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(204, 26);
            this.dateEnd.TabIndex = 6;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(194, 189);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(204, 28);
            this.cmbState.TabIndex = 7;
            // 
            // lstBoxOldEmployees
            // 
            this.lstBoxOldEmployees.FormattingEnabled = true;
            this.lstBoxOldEmployees.ItemHeight = 20;
            this.lstBoxOldEmployees.Location = new System.Drawing.Point(488, 44);
            this.lstBoxOldEmployees.Name = "lstBoxOldEmployees";
            this.lstBoxOldEmployees.Size = new System.Drawing.Size(278, 204);
            this.lstBoxOldEmployees.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employees on project:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(837, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "You can add this employees:";
            // 
            // lstBoxNewEmployees
            // 
            this.lstBoxNewEmployees.FormattingEnabled = true;
            this.lstBoxNewEmployees.ItemHeight = 20;
            this.lstBoxNewEmployees.Location = new System.Drawing.Point(822, 46);
            this.lstBoxNewEmployees.Name = "lstBoxNewEmployees";
            this.lstBoxNewEmployees.Size = new System.Drawing.Size(279, 204);
            this.lstBoxNewEmployees.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveChanges);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "You can add/remove employees without clicking the Save button";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(822, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 61);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(642, 304);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 61);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstBoxNewEmployees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstBoxOldEmployees);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.Load += new System.EventHandler(this.EditProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ListBox lstBoxOldEmployees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBoxNewEmployees;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}