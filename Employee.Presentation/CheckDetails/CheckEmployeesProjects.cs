using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
            var counter = 0;
            var listToShow = ProjectEmployeeRepository.GetAllItems();
            foreach (var item in listToShow)
            {
                if (item.Item1.OIB == _selectedEmployee.OIB)
                {
                    
                    foreach (var project in item.Item2)
                    { 
                        lstBoxProjects.Items.Add(project.Item1.NameOfTheProject +" " + project.Item2 + "hours");
                        counter += project.Item2;
                    }
                }             
            }

           
        }
    }
}
