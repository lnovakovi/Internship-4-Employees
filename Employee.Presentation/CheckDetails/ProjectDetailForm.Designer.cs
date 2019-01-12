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
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblAccountant = new System.Windows.Forms.Label();
            this.lblDeisgner = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
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
            this.chkListBoxProject.Size = new System.Drawing.Size(710, 277);
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
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Location = new System.Drawing.Point(767, 46);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(100, 20);
            this.lblProgrammer.TabIndex = 4;
            this.lblProgrammer.Text = "Programmer:";
            // 
            // lblAccountant
            // 
            this.lblAccountant.AutoSize = true;
            this.lblAccountant.Location = new System.Drawing.Point(767, 101);
            this.lblAccountant.Name = "lblAccountant";
            this.lblAccountant.Size = new System.Drawing.Size(95, 20);
            this.lblAccountant.TabIndex = 5;
            this.lblAccountant.Text = "Accountant:";
            // 
            // lblDeisgner
            // 
            this.lblDeisgner.AutoSize = true;
            this.lblDeisgner.Location = new System.Drawing.Point(767, 153);
            this.lblDeisgner.Name = "lblDeisgner";
            this.lblDeisgner.Size = new System.Drawing.Size(77, 20);
            this.lblDeisgner.TabIndex = 6;
            this.lblDeisgner.Text = "Designer:";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.Location = new System.Drawing.Point(767, 204);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(81, 20);
            this.lblSecretary.TabIndex = 7;
            this.lblSecretary.Text = "Secretary:";
            // 
            // ProjectDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.lblSecretary);
            this.Controls.Add(this.lblDeisgner);
            this.Controls.Add(this.lblAccountant);
            this.Controls.Add(this.lblProgrammer);
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
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblAccountant;
        private System.Windows.Forms.Label lblDeisgner;
        private System.Windows.Forms.Label lblSecretary;
    }
}