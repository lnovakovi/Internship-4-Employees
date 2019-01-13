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
            this.lstBoxFinished = new System.Windows.Forms.ListBox();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lstBoxInProgress = new System.Windows.Forms.ListBox();
            this.lblPlanned = new System.Windows.Forms.Label();
            this.lstBoxPlanned = new System.Windows.Forms.ListBox();
            this.labelFinished = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxFinished
            // 
            this.lstBoxFinished.FormattingEnabled = true;
            this.lstBoxFinished.ItemHeight = 20;
            this.lstBoxFinished.Location = new System.Drawing.Point(55, 50);
            this.lstBoxFinished.Name = "lstBoxFinished";
            this.lstBoxFinished.Size = new System.Drawing.Size(174, 304);
            this.lstBoxFinished.TabIndex = 0;
            // 
            // lblFinished
            // 
            this.lblFinished.AutoSize = true;
            this.lblFinished.Location = new System.Drawing.Point(0, 0);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(0, 20);
            this.lblFinished.TabIndex = 1;
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Location = new System.Drawing.Point(281, 19);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(94, 20);
            this.lblInProgress.TabIndex = 2;
            this.lblInProgress.Text = "In Progress:";
            // 
            // lstBoxInProgress
            // 
            this.lstBoxInProgress.FormattingEnabled = true;
            this.lstBoxInProgress.ItemHeight = 20;
            this.lstBoxInProgress.Location = new System.Drawing.Point(285, 50);
            this.lstBoxInProgress.Name = "lstBoxInProgress";
            this.lstBoxInProgress.Size = new System.Drawing.Size(176, 304);
            this.lstBoxInProgress.TabIndex = 3;
            // 
            // lblPlanned
            // 
            this.lblPlanned.AutoSize = true;
            this.lblPlanned.Location = new System.Drawing.Point(510, 19);
            this.lblPlanned.Name = "lblPlanned";
            this.lblPlanned.Size = new System.Drawing.Size(71, 20);
            this.lblPlanned.TabIndex = 4;
            this.lblPlanned.Text = "Planned:";
            // 
            // lstBoxPlanned
            // 
            this.lstBoxPlanned.FormattingEnabled = true;
            this.lstBoxPlanned.ItemHeight = 20;
            this.lstBoxPlanned.Location = new System.Drawing.Point(514, 54);
            this.lstBoxPlanned.Name = "lstBoxPlanned";
            this.lstBoxPlanned.Size = new System.Drawing.Size(168, 304);
            this.lstBoxPlanned.TabIndex = 5;
            // 
            // labelFinished
            // 
            this.labelFinished.AutoSize = true;
            this.labelFinished.Location = new System.Drawing.Point(51, 19);
            this.labelFinished.Name = "labelFinished";
            this.labelFinished.Size = new System.Drawing.Size(73, 20);
            this.labelFinished.TabIndex = 6;
            this.labelFinished.Text = "Finished:";
            // 
            // CheckEmployeesProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFinished);
            this.Controls.Add(this.lstBoxPlanned);
            this.Controls.Add(this.lblPlanned);
            this.Controls.Add(this.lstBoxInProgress);
            this.Controls.Add(this.lblInProgress);
            this.Controls.Add(this.lblFinished);
            this.Controls.Add(this.lstBoxFinished);
            this.Name = "CheckEmployeesProjects";
            this.Text = "CheckEmployeesProjects";
            this.Load += new System.EventHandler(this.CheckEmployeesProjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxFinished;
        private System.Windows.Forms.Label lblFinished;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.ListBox lstBoxInProgress;
        private System.Windows.Forms.Label lblPlanned;
        private System.Windows.Forms.ListBox lstBoxPlanned;
        private System.Windows.Forms.Label labelFinished;
    }
}