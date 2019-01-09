namespace Employee.Presentation.CheckDetails
{
    partial class CheckEmployeesProjects
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
            this.SuspendLayout();
            // 
            // lstBoxProjects
            // 
            this.lstBoxProjects.FormattingEnabled = true;
            this.lstBoxProjects.ItemHeight = 20;
            this.lstBoxProjects.Location = new System.Drawing.Point(55, 50);
            this.lstBoxProjects.Name = "lstBoxProjects";
            this.lstBoxProjects.Size = new System.Drawing.Size(564, 284);
            this.lstBoxProjects.TabIndex = 0;
            // 
            // CheckEmployeesProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxProjects);
            this.Name = "CheckEmployeesProjects";
            this.Text = "CheckEmployeesProjects";
            this.Load += new System.EventHandler(this.CheckEmployeesProjects_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxProjects;
    }
}