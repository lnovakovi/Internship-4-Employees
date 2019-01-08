using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.AddProject
{
    public partial class AddProjectForm : Form
    {
        private List<EmployeeClass> _listOfEmployees;
        private EmployeeRepository _employeeRepository;
        private ProjectRepository _projectRepository;
        public AddProjectForm()
        {
            InitializeComponent();
            _employeeRepository=new EmployeeRepository();
            _projectRepository=new ProjectRepository();
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
            _listOfEmployees = _employeeRepository.AllItems();
            
            foreach (var employee in _listOfEmployees)
            {
                chkListEmployees.Items.Add(employee.ToString());
            }
        }
       
        private void SaveProject(object sender, EventArgs e)
        {

            if (!txtProjectName.ToString().CheckIfEmpty() && cmbState.SelectedItem != null)
            {
                var project = new Project(txtProjectName.ToString(), (StateEnum.StateProject)Enum.Parse(typeof(StateEnum.StateProject), cmbState.SelectedItem.ToString()), datePickerStartDate.Value, datePickerEndDate.Value);
                _projectRepository.AddNewProject(project);
            }
                
           
            Close();
        }
    }
}
