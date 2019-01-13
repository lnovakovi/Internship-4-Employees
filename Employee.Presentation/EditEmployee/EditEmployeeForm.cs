using System;
using System.Linq;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;
using static Employee.Data.Enums.JobEnum;

namespace Employee.Presentation.EditEmployee
{
    public partial class EditEmployeeForm : Form
    {
        private EmployeeClass _employee;
        private EmployeeClass _editedEMployee;
        public EditEmployeeForm(EmployeeClass EmployeeToEdit)
        {
            MessageBox.Show(
                "Remember,if you are going to change date of birth, you can't enter age under 18, it won't save your changes", "REMINDER");
            _employee = EmployeeToEdit;
            InitializeComponent();          
            AddProjectsToListBox();
        }

        private void SaveEdit(object sender, EventArgs e)
        { DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var newName = _employee.Name;
                var newSurname = _employee.Surname;
                var dateOfBirth = _employee.DateOfBirth;
                var job = _employee.Job;
                if (txtName.Text.ToLower() != _employee.Name.ToLower() && !txtName.Text.CheckIfEmpty())
                    newName = txtName.Text;
                if (txtSurname.Text.ToLower() != _employee.Surname.ToLower() && !txtSurname.Text.CheckIfEmpty())
                    newSurname = txtSurname.Text;
                if (dateOfBirth != dateTimePickerEmployee.Value)
                    dateOfBirth = dateTimePickerEmployee.Value;
                if ((Job)cmbJob.SelectedItem != job)
                    job = (Job)cmbJob.SelectedItem;
                var newEmployee = new EmployeeClass(newName, newSurname, _employee.OIB, dateOfBirth, job);
                EmployeeRepository.EditEmployee(newEmployee);
                ProjectEmployeeRepository.EditRelationEmployeeProject(_employee, newEmployee);
                ProjectEmployeeRepository.EditRelationProjectEmployee(_employee, newEmployee);
                Close();
            }
            else
            {
               Close();
            }
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {   //add existing data
            AddJobsToCombo();
            txtName.Text = _employee.Name;
            txtSurname.Text = _employee.Surname;
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
                        lstBoxProjects.Items.Add(project.Item1.NameOfTheProject);
                    }
                }
            }
        }

        private void RemoveProject(object sender, EventArgs e)
        {
            var _listOfProjects = ProjectRepository.GetAllItems();
            if (lstBoxProjects.SelectedIndex != -1)
            {
                var projectToDelete = lstBoxProjects.SelectedItem;
                foreach (var project in _listOfProjects.ToList())
                {
                    if (project.NameOfTheProject == projectToDelete.ToString())
                    {
                        if (ProjectEmployeeRepository.GetNumberOfEmployees(project) > 1)
                        {
                            ProjectEmployeeRepository.RemoveProjectFromRelationEmployeeProject(project);
                            ProjectEmployeeRepository.EditRelationProjectEmployee(_employee);
                            lstBoxProjects.Items.Remove(projectToDelete);
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Can't delete {projectToDelete.ToString()} because {_employee.NameAndSurname()} is the only one on the project.");
                        }                      
                    }
                }
            }
            else
            {
                return;
            }           
        }

        private void AddProject(object sender, EventArgs e)
        {

        }

    }
}
