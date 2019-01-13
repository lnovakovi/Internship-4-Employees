namespace Employee.Presentation.EditEmployee
{
    partial class AddProjectToEmployee
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
            this.lstBoxProjects = new System.Windows.Forms.ListBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxProjects
            // 
            this.lstBoxProjects.FormattingEnabled = true;
            this.lstBoxProjects.ItemHeight = 20;
            this.lstBoxProjects.Location = new System.Drawing.Point(46, 112);
            this.lstBoxProjects.Name = "lstBoxProjects";
            this.lstBoxProjects.Size = new System.Drawing.Size(392, 224);
            this.lstBoxProjects.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(42, 54);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(266, 20);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Check which project you want to add";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(133, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(159, 57);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.AddProject);
            // 
            // AddProjectToEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 472);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lstBoxProjects);
            this.Name = "AddProjectToEmployee";
            this.Text = "AddProjectToEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxProjects;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnOK;
    }
}