using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;
using static Employee.Data.Enums.JobEnum;

namespace Employee.Presentation.EditEmployee
{
    public partial class EditEmployeeForm : Form
    {
        private readonly EmployeeClass _employee;
        private List<Project> _oldPro;
        private List<Project> _newPro;
        public EditEmployeeForm(EmployeeClass employeeToEdit)
        {
            MessageBox.Show(@"Remember,if you are going to change date of birth, you can't enter age under 18, it won't save your changes", @"REMINDER");
            _employee = employeeToEdit;
            InitializeComponent();          
            AddProjectsToListBox();
        }

        private void SaveEdit(object sender, EventArgs e)
        { var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var newName = _employee.Name;
                var newSurname = _employee.Surname;
                var dateOfBirth = _employee.DateOfBirth;
                var job = _employee.Job;
                if (!string.Equals(txtName.Text, _employee.Name, StringComparison.CurrentCultureIgnoreCase) && !txtName.Text.CheckIfEmpty())
                    newName = txtName.Text;
                if (!string.Equals(txtSurname.Text, _employee.Surname, StringComparison.CurrentCultureIgnoreCase) && !txtSurname.Text.CheckIfEmpty())
                    newSurname = txtSurname.Text;
                if (dateTimePickerEmployee != null && dateOfBirth != dateTimePickerEmployee.Value)
                    dateOfBirth = dateTimePickerEmployee.Value;
                if (cmbJob.SelectedItem != null && (Job)cmbJob.SelectedItem != job)
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

        private void AddProjectsToListBox()
        {
            _oldPro = ProjectRepository.EmployeesProject(_employee);
            foreach (var project in _oldPro)
            {
                lstBoxOldProjects.Items.Add(project);
            }
            _newPro = ProjectRepository.EmployeesNotProject(_employee);
            foreach (var project in _newPro)
            {
                lstBoxNewProjects.Items.Add(project);
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
            var enums = Enum.GetValues(typeof(Job));
            foreach (var job in enums)
            {
                cmbJob.Items.Add(job);
            }
        }
        private void RemoveProject(object sender, EventArgs e)
        {
            var listOfProjects = ProjectRepository.GetAllItems();
            if (lstBoxOldProjects.SelectedIndex == -1) return;
            var projectToDelete = lstBoxOldProjects.SelectedItem;
            foreach (var project in listOfProjects.ToList())
            {
                if (project != projectToDelete) continue;
                if (ProjectEmployeeRepository.GetNumberOfEmployees(project) > 1)
                {
                    ProjectEmployeeRepository.RemoveProjectFromEmployee(project,_employee);
                    ProjectEmployeeRepository.EditRelationProjectEmployee(_employee);
                    lstBoxOldProjects.Items.Remove(projectToDelete);
                    lstBoxNewProjects.Items.Add(projectToDelete);
                }
                else
                {
                    MessageBox.Show(
                        $@"Can't delete {(projectToDelete as Project)?.NameOfTheProject} because {_employee.NameAndSurname()} is the only one on the project.");
                }
            }
        }

        private void AddProject(object sender, EventArgs e)
        {
            if (lstBoxNewProjects.SelectedIndex <= -1) return;
            var selectedItem = lstBoxNewProjects.SelectedItem as Project;
            var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            _newPro.Remove(selectedItem);
            _oldPro.Add(selectedItem);
            if (selectedItem != null)
            {
                lstBoxOldProjects.Items.Add(selectedItem);
                lstBoxNewProjects.Items.Remove(selectedItem);
                var popUp = new PopUpForWorkingHours2(_employee, selectedItem);
                popUp.ShowDialog();
            }
            MessageBox.Show($@"Added");

        }

        private void ChangeWorkingHours(object sender, EventArgs e)
        {
            if (lstBoxOldProjects.SelectedIndex > -1)
            {
                var selectedItem = lstBoxOldProjects.SelectedItem as Project;
                var change = new ChangeWorkingHours(selectedItem, _employee);
                change.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"You have to check project employee is working on");
            }                    
        }

        private void Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
