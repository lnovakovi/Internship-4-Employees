using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.Pop_up
{
    public partial class PopUpForWorkingHours2 : Form
    {
        private EmployeeClass _employee;
        private Project _project;
        public PopUpForWorkingHours2(EmployeeClass employee, Project project)
        {
            _employee = employee;
            _project = project;
            InitializeComponent();
            labelInstruction.Text = $"Enter working hours for {employee}";
        }

        private void SaveWorkingHours(object sender, EventArgs e)
        {
            ProjectEmployeeRepository.AddNewEmployeeToTheProject(_project, _employee,
                int.Parse(txtWorkingHours.Text));
            ProjectEmployeeRepository.AddNewProjectToEmployee(_employee,_project,int.Parse(txtWorkingHours.Text));
           Close();
        }
    }
}
