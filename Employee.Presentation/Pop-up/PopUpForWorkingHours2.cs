using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
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
            var input = txtWorkingHours.Text;
            if (!input.CheckIfEmpty() && input.TryParseInt() && int.Parse(input) != 0)
            {
                ProjectEmployeeRepository.AddNewEmployeeToTheProject(_project, _employee,
                    int.Parse(input));
                ProjectEmployeeRepository.AddNewProjectToEmployee(_employee, _project, int.Parse(input));
                Close();
            }
            else
            {
                return;
            }
            
           
        }
    }
}
