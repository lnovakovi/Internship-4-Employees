using System;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.EditEmployee
{
    public partial class EditEmployeeForm : Form
    {
        private EmployeeClass _employee;
    
        public EditEmployeeForm(EmployeeClass EmployeeToEdit)
        {
            _employee = EmployeeToEdit;
            InitializeComponent();          
            AddProjectsToListBox();
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            var selectedItem = new EmployeeClass(txtName.Text,txtSurname.Text,txtOIB.Text.RemoveAllTheWhiteSpaces(),dateTimePickerEmployee.Value, (JobEnum.Job)Enum.Parse(typeof(JobEnum.Job), cmbJob.SelectedItem.ToString()));
            Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            AddJobsToCombo();
            txtName.Text = _employee.Name;
            txtSurname.Text = _employee._surname;
            txtOIB.Text = _employee.OIB;
            dateTimePickerEmployee.Value = _employee.DateOfBirth.Date;
            cmbJob.Text = _employee.Job.ToString();
        }

        private void AddJobsToCombo()
        {
            var enums = Enum.GetValues(typeof(JobEnum.Job));
            foreach (var job in enums)
            {
                cmbJob.Items.Add(job);
            }
        }

        private void AddProjectsToListBox()
        {
            var listOfProjects = ProjectEmployeeRepository.GetAllItems();
            foreach (var employee in listOfProjects)
            {
                if (employee.Item1 == _employee)
                {
                    foreach (var project in employee.Item2)
                    {
                        lstBoxProjects.Items.Add(project.Item1);
                    }
                }
            }
        }

        private void RemoveProject(object sender, EventArgs e)
        {
            var _listOfProjects = ProjectEmployeeRepository.GetAllData();
            foreach (var project in _listOfProjects)
            {

            }
        }

        private void AddProject(object sender, EventArgs e)
        {

        }
    }
}
