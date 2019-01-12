using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.CheckDetails
{
    public partial class CheckEmployeesProjects : Form
    {
        
        private EmployeeClass _selectedEmployee;
        public CheckEmployeesProjects(EmployeeClass selectedEmployee)
        {
            
            _selectedEmployee = selectedEmployee;
            InitializeComponent();
        }

        private void CheckEmployeesProjects_Load(object sender, EventArgs e)
        {
            var listToShow = ProjectEmployeeRepository.GetAllItems();
            foreach (var item in listToShow)
            {
                if (item.Item1 == _selectedEmployee)
                {                  
                    foreach (var project in item.Item2)
                    {
                        if (project.Item1.StateOfTheProject == StateEnum.StateProject.Planned)
                        {
                            lstBoxPlanned.Items.Add($"{project.Item1.NameOfTheProject} - {project.Item2} hours");
                            lblPlanned.Text = $"Planned: {lstBoxPlanned.Items.Count}";
                        }
                        else if (project.Item1.StateOfTheProject == StateEnum.StateProject.InProgress)
                        {
                            lstBoxInProgress.Items.Add($"{project.Item1.NameOfTheProject} - {project.Item2} hours");
                            lblInProgress.Text = $"In progress: {lstBoxInProgress.Items.Count}";
                        }
                        else
                        {
                            lstBoxFinished.Items.Add($"{project.Item1.NameOfTheProject} - {project.Item2} hours");
                            labelFinished.Text = $"Finished: {lstBoxFinished.Items.Count}";
                        }
                        
                    }
                }             
            }         
        }
    }
}
