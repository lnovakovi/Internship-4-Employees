﻿namespace Employee.Presentation.CheckDetails
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
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.btnOpenEdit = new System.Windows.Forms.Button();
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
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 20;
            this.listBoxEmployees.Location = new System.Drawing.Point(22, 44);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(770, 384);
            this.listBoxEmployees.TabIndex = 1;
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
            // CheckEmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnOpenEdit);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.label1);
            this.Name = "CheckEmployeeDetailsForm";
            this.Text = "CheckEmployeeDetailsForm";
            this.Load += new System.EventHandler(this.CheckEmployeeDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Button btnOpenEdit;
    }
}