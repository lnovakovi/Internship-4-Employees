using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Presentation.Pop_up;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.EditProject
{
    public partial class EditProjectForm : Form
    {
        private Project _project;
        private List<EmployeeClass> oldEmp;
        private List<EmployeeClass> newEmp;

        public EditProjectForm(Project projectToEdit)
        {
            _project = projectToEdit;
            InitializeComponent();
            AddEmployes();
        }

        private void EditProjectForm_Load(object sender, System.EventArgs e)
        {
            txtName.Text = _project.NameOfTheProject;
            dateTime.Value = _project.StartDate;
            dateEnd.Value = _project.EndDate;
            SetStateInCombo();
            cmbState.Text = _project.StateOfTheProject.ToString();
        }

        private void AddEmployes()
        {
            oldEmp = EmployeeRepository.employeesOnTheProject(_project);
            foreach (var emp in oldEmp)
            {
                lstBoxOldEmployees.Items.Add(emp);
            }

            newEmp = EmployeeRepository.employeesNotOnProject(_project);
            foreach (var emp in newEmp)
            {
                lstBoxNewEmployees.Items.Add(emp);
            }
        }
        private void SetStateInCombo()
        {
            var enums = Enum.GetValues(typeof(StateEnum.StateProject));
            foreach (var state in enums)
            {
                cmbState.Items.Add(state);
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var startDate = _project.StartDate;
            var endDate = _project.EndDate;
            var state = _project.StateOfTheProject;
            DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dateEnd.Value != endDate)
                {
                   endDate = dateEnd.Value;}

                if (dateTime.Value != startDate)
                {
                    startDate = dateTime.Value;}
                if ((StateEnum.StateProject)cmbState.SelectedItem != state)
                    state = (StateEnum.StateProject)cmbState.SelectedItem;
                var newProject = new Project(_project.NameOfTheProject,state,startDate,endDate);

            }
            else
            {
                Close();
            }
            Close();
        }

        private void RemoveEmployee(object sender, EventArgs e)
        {
            if (lstBoxOldEmployees.Items.Count == 1)
            {
                MessageBox.Show("Can't delete only employee on project");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var selectedItem = lstBoxOldEmployees.SelectedItem as EmployeeClass;
                    ProjectEmployeeRepository.EditRelationProjectEmployee(selectedItem);
                    ProjectEmployeeRepository.RemoveProjectFromRelationEmployeeProject(_project);
                    oldEmp.Remove(selectedItem);
                    newEmp.Add(selectedItem);
                    lstBoxOldEmployees.Items.Remove(selectedItem);
                    lstBoxNewEmployees.Items.Add(selectedItem);
                }
                else
                {
                    return;
                }
            }
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var selectedItem = lstBoxNewEmployees.SelectedItem as EmployeeClass;
            DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newEmp.Remove(selectedItem);
                oldEmp.Add(selectedItem);
                lstBoxOldEmployees.Items.Add(selectedItem);
                lstBoxNewEmployees.Items.Remove(selectedItem);
                var popUp = new PopUpForWorkingHours(_project, selectedItem.OIB);
                popUp.ShowDialog();
                MessageBox.Show($"Added");
            }
            else
            {
                return;
            }
        }
    }
}
