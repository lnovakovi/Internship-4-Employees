using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Presentation.AddEmployee;
using Employee.Presentation.AddProject;
using Employee.Presentation.CheckDetails;
using Employee.Presentation.DeleteEmployee;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.Main
{
    public partial class MainForm : Form
    {
       
             
        public MainForm()
        {
           
            InitializeComponent();
        }
        
        private void OpenAddForm(object sender, EventArgs e)
        {
            var addForm = new AddEmployeeForm();
            addForm.ShowDialog();
        }

        private void OpenCheckEmployeesForm(object sender, EventArgs e)
        {
            var checkForm = new CheckEmployeeDetailsForm();
            checkForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OpenDeleteEmployeeForm(object sender, EventArgs e)
        {
            var deleteForm = new DeleteEmployeeForm();
            deleteForm.ShowDialog();
        }

        private void OpenAddProjectForm(object sender, EventArgs e)
        {
            var addProject = new AddProjectForm();
            addProject.ShowDialog();
        }

        private void OpenCheckProjectForm(object sender, EventArgs e)
        {
            var checkProjects = new ProjectDetailForm();
            checkProjects.ShowDialog();
        }
    }
}
