namespace Employee.Presentation.CheckDetails
{
    partial class EmployeesOnProjectForm
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
            this.lstBoxEmployees = new System.Windows.Forms.ListBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxEmployees
            // 
            this.lstBoxEmployees.FormattingEnabled = true;
            this.lstBoxEmployees.ItemHeight = 20;
            this.lstBoxEmployees.Location = new System.Drawing.Point(57, 57);
            this.lstBoxEmployees.Name = "lstBoxEmployees";
            this.lstBoxEmployees.Size = new System.Drawing.Size(384, 224);
            this.lstBoxEmployees.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(53, 21);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 20);
            this.labelInformation.TabIndex = 1;
            // 
            // EmployeesOnProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 372);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.lstBoxEmployees);
            this.Name = "EmployeesOnProjectForm";
            this.Text = "EmployeesOnProjectForm";
            this.Load += new System.EventHandler(this.ShowEmployees);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxEmployees;
        private System.Windows.Forms.Label labelInformation;
    }
}