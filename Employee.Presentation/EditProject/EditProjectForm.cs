using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.EditProject
{
    public partial class EditProjectForm : Form
    {
        private readonly Project _project;
        private List<EmployeeClass> _oldEmp;
        private List<EmployeeClass> _newEmp;

        public EditProjectForm(Project projectToEdit)
        {
            _project = projectToEdit;
            InitializeComponent();
            AddEmployes();
        }

        private void EditProjectForm_Load(object sender, EventArgs e)
        {
            txtName.Text = _project.NameOfTheProject;
            dateTime.Value = _project.StartDate;
            dateEnd.Value = _project.EndDate;
            SetStateInCombo();
            cmbState.Text = _project.StateOfTheProject.ToString();
        }

        private void AddEmployes()
        {
            _oldEmp = EmployeeRepository.EmployeesOnTheProject(_project);
            foreach (var emp in _oldEmp)
            {
                lstBoxOldEmployees.Items.Add(emp);
            }

            _newEmp = EmployeeRepository.EmployeesNotOnProject(_project);
            foreach (var emp in _newEmp)
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
            var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dateEnd.Value != endDate)
                {
                    endDate = dateEnd.Value;
                }

                if (dateTime.Value != startDate)
                {
                    startDate = dateTime.Value;
                }

                if (cmbState != null && (StateEnum.StateProject) cmbState.SelectedItem != state)
                    state = (StateEnum.StateProject) cmbState.SelectedItem;
                var newProject = new Project(_project.NameOfTheProject, state, startDate, endDate);
                if (ProjectRepository.CheckDates(startDate, endDate))
                {
                    ProjectRepository.EditProject(newProject);
                    ProjectEmployeeRepository.EditRelationProjectEmployee(_project, newProject);
                    ProjectEmployeeRepository.EditRelationEmployeeProject(_project, newProject);
                    Close();
                }
                else
                    MessageBox.Show(@"Failed edition, watch out on dates!");
                    Close();
            }

            Close();
        }

        private void RemoveEmployee(object sender, EventArgs e)
        {
            if (lstBoxOldEmployees.Items.Count == 1)
            {
                MessageBox.Show(@"Can't delete only employee on project");
                return;
            }          
            var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            var selectedItem = lstBoxOldEmployees.SelectedItem as EmployeeClass;
            ProjectEmployeeRepository.EditRelationProjectEmployee(selectedItem);
            ProjectEmployeeRepository.RemoveProjectFromRelationEmployeeProject(_project);
            _oldEmp.Remove(selectedItem);
            _newEmp.Add(selectedItem);
            lstBoxOldEmployees.Items.Remove(selectedItem ?? throw new InvalidOperationException());
            lstBoxNewEmployees.Items.Add(selectedItem);
        }

        private void AddEmployee(object sender, EventArgs e)
        {
            var selectedItem = lstBoxNewEmployees.SelectedItem as EmployeeClass;
            var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;
            _newEmp.Remove(selectedItem);
            _oldEmp.Add(selectedItem);
            lstBoxOldEmployees.Items.Add(selectedItem ?? throw new InvalidOperationException());
            lstBoxNewEmployees.Items.Remove(selectedItem);
            var popUp = new PopUpForWorkingHours(_project, selectedItem.OIB);
            popUp.ShowDialog();
            MessageBox.Show($@"Added");
        }
    }
}
