using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employee.Presentation.Pop_up;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.AddProject
{
    public partial class AddProjectForm : Form
    {
        private List<EmployeeClass> _listOfEmployees;
        
        public AddProjectForm()
        {
            InitializeComponent();
            AddStatesOfProjects();
            AddEmployees();
            
        }

        public void AddStatesOfProjects()
        {
            var enums = Enum.GetValues(typeof(StateEnum.StateProject));
            foreach (var job in enums)
            {
                cmbState.Items.Add(job);
            }
        }

        public void AddEmployees()
        {
            lstBoxEmployee.Items.Clear();
            _listOfEmployees = EmployeeRepository.AllItems();
            foreach (var employee in _listOfEmployees)
            {
                lstBoxEmployee.Items.Add(employee);
            }
        }
       
        private void SaveProject(object sender, EventArgs e)
        {

            if (!txtProjectName.ToString().CheckIfEmpty() && cmbState.SelectedItem != null && ProjectRepository.CheckName(txtProjectName.Text))
            {
               
                var project = new Project(txtProjectName.Text, (StateEnum.StateProject)Enum.Parse(typeof(StateEnum.StateProject), cmbState.SelectedItem.ToString()), datePickerStartDate.Value, datePickerEndDate.Value);
                ProjectRepository.AddNewProject(project);
                var selectedEmployees = lstBoxEmployee.SelectedItems;
                foreach (var employee in selectedEmployees)
                {
                    var popUp = new PopUpForWorkingHours2(employee as EmployeeClass,project);
                    popUp.ShowDialog();
                }
            }

            
           
            Close();
        }
    }
}
