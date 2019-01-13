namespace Employee.Presentation.CheckDetails
{
    partial class ProjectDetailForm
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
            this.chkListBoxProject = new System.Windows.Forms.CheckedListBox();
            this.btnCheckEmployees = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            // 
            // chkListBoxProject
            // 
            this.chkListBoxProject.FormattingEnabled = true;
            this.chkListBoxProject.Location = new System.Drawing.Point(22, 63);
            this.chkListBoxProject.Name = "chkListBoxProject";
            this.chkListBoxProject.Size = new System.Drawing.Size(632, 277);
            this.chkListBoxProject.TabIndex = 1;
            // 
            // btnCheckEmployees
            // 
            this.btnCheckEmployees.Location = new System.Drawing.Point(43, 369);
            this.btnCheckEmployees.Name = "btnCheckEmployees";
            this.btnCheckEmployees.Size = new System.Drawing.Size(148, 60);
            this.btnCheckEmployees.TabIndex = 2;
            this.btnCheckEmployees.Text = "Check Employees";
            this.btnCheckEmployees.UseVisualStyleBackColor = true;
            this.btnCheckEmployees.Click += new System.EventHandler(this.OpenFormCheckProjectEmployees);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit project";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OpenEditProjectForm);
            // 
            // ProjectDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckEmployees);
            this.Controls.Add(this.chkListBoxProject);
            this.Controls.Add(this.label1);
            this.Name = "ProjectDetailForm";
            this.Text = "ProjectDetailForm";
            this.Load += new System.EventHandler(this.ProjectDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListBoxProject;
        private System.Windows.Forms.Button btnCheckEmployees;
        private System.Windows.Forms.Button button2;
    }
}