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
            this.lstBoxProgrammers = new System.Windows.Forms.ListBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.Programers = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.lstBoxSecretary = new System.Windows.Forms.ListBox();
            this.lstBoxAccountant = new System.Windows.Forms.ListBox();
            this.lstBoxDesigner = new System.Windows.Forms.ListBox();
            this.lblAccountant = new System.Windows.Forms.Label();
            this.lblDesigner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxProgrammers
            // 
            this.lstBoxProgrammers.FormattingEnabled = true;
            this.lstBoxProgrammers.ItemHeight = 20;
            this.lstBoxProgrammers.Location = new System.Drawing.Point(24, 56);
            this.lstBoxProgrammers.Name = "lstBoxProgrammers";
            this.lstBoxProgrammers.Size = new System.Drawing.Size(208, 324);
            this.lstBoxProgrammers.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(53, 21);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(0, 20);
            this.labelInformation.TabIndex = 1;
            // 
            // Programers
            // 
            this.Programers.AutoSize = true;
            this.Programers.Location = new System.Drawing.Point(20, 21);
            this.Programers.Name = "Programers";
            this.Programers.Size = new System.Drawing.Size(91, 20);
            this.Programers.TabIndex = 2;
            this.Programers.Text = "Programers";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.Location = new System.Drawing.Point(257, 21);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(85, 20);
            this.lblSecretary.TabIndex = 3;
            this.lblSecretary.Text = "Secretarys";
            // 
            // lstBoxSecretary
            // 
            this.lstBoxSecretary.FormattingEnabled = true;
            this.lstBoxSecretary.ItemHeight = 20;
            this.lstBoxSecretary.Location = new System.Drawing.Point(261, 60);
            this.lstBoxSecretary.Name = "lstBoxSecretary";
            this.lstBoxSecretary.Size = new System.Drawing.Size(188, 324);
            this.lstBoxSecretary.TabIndex = 4;
            // 
            // lstBoxAccountant
            // 
            this.lstBoxAccountant.FormattingEnabled = true;
            this.lstBoxAccountant.ItemHeight = 20;
            this.lstBoxAccountant.Location = new System.Drawing.Point(479, 56);
            this.lstBoxAccountant.Name = "lstBoxAccountant";
            this.lstBoxAccountant.Size = new System.Drawing.Size(207, 324);
            this.lstBoxAccountant.TabIndex = 5;
            // 
            // lstBoxDesigner
            // 
            this.lstBoxDesigner.FormattingEnabled = true;
            this.lstBoxDesigner.ItemHeight = 20;
            this.lstBoxDesigner.Location = new System.Drawing.Point(735, 60);
            this.lstBoxDesigner.Name = "lstBoxDesigner";
            this.lstBoxDesigner.Size = new System.Drawing.Size(198, 324);
            this.lstBoxDesigner.TabIndex = 6;
            // 
            // lblAccountant
            // 
            this.lblAccountant.AutoSize = true;
            this.lblAccountant.Location = new System.Drawing.Point(475, 21);
            this.lblAccountant.Name = "lblAccountant";
            this.lblAccountant.Size = new System.Drawing.Size(99, 20);
            this.lblAccountant.TabIndex = 7;
            this.lblAccountant.Text = "Accountants";
            // 
            // lblDesigner
            // 
            this.lblDesigner.AutoSize = true;
            this.lblDesigner.Location = new System.Drawing.Point(731, 21);
            this.lblDesigner.Name = "lblDesigner";
            this.lblDesigner.Size = new System.Drawing.Size(81, 20);
            this.lblDesigner.TabIndex = 8;
            this.lblDesigner.Text = "Designers";
            
            // 
            // EmployeesOnProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 501);
            this.Controls.Add(this.lblDesigner);
            this.Controls.Add(this.lblAccountant);
            this.Controls.Add(this.lstBoxDesigner);
            this.Controls.Add(this.lstBoxAccountant);
            this.Controls.Add(this.lstBoxSecretary);
            this.Controls.Add(this.lblSecretary);
            this.Controls.Add(this.Programers);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.lstBoxProgrammers);
            this.Name = "EmployeesOnProjectForm";
            this.Text = "EmployeesOnProjectForm";
            this.Load += new System.EventHandler(this.ShowEmployees);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxProgrammers;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label Programers;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.ListBox lstBoxSecretary;
        private System.Windows.Forms.ListBox lstBoxAccountant;
        private System.Windows.Forms.ListBox lstBoxDesigner;
        private System.Windows.Forms.Label lblAccountant;
        private System.Windows.Forms.Label lblDesigner;
    }
}