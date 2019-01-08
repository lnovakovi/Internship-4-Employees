using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employeee.Domain.Repositories;
using Employee.Infrastructure.Extensions;

namespace Employee.Presentation.AddEmployee
{
    public partial class AddEmployeeForm : Form
    {
        private List<Project> _listOfProjects;
        private readonly ProjectRepository _projectRepository;
        private readonly EmployeeRepository _employeeRepository;
        public AddEmployeeForm()
        {
            InitializeComponent();
            _projectRepository = new ProjectRepository();
            _employeeRepository= new EmployeeRepository();
            RefreshProjectsInListBox();
            AddJobsToCombo();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RefreshProjectsInListBox()
        {
          listBoxProjects.Items.Clear();
            _listOfProjects = _projectRepository.GetAllItems();
            foreach (var project in _listOfProjects)
            {
                listBoxProjects.Items.Add(project.NameOfTheProject);
            }
        }

        private void AddJobsToCombo()
        {
            var enums = Enum.GetValues(typeof(JobEnum.Job));
            foreach (var job in enums)
            {
                cmbJob.Items.Add(job);
            }
        }
        private void SaveEmployee(object sender, EventArgs e)
        {
            if (!txtEmployeeName.ToString().CheckIfEmpty() && !txtEmployeeSurname.ToString().CheckIfEmpty() &&
                !txtOIB.ToString().CheckIfNumber() && cmbJob.SelectedItem != null)
            {
                
                var dateOfBirth = dateEmployeeBirth.Value;
                var job = cmbJob.SelectedItem.ToString();
                MessageBox.Show(_employeeRepository.AddEmployee(txtEmployeeName.ToString(), txtEmployeeSurname.ToString(), txtOIB.ToString(), dateOfBirth, job));                
                Close();                
            }             
            else
            {
                MessageBox.Show(@"Wrong input");
                Close();
            }     
           
        }
    }
}
