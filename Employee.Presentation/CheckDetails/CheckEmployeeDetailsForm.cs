using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Presentation.EditEmployee;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.CheckDetails
{
    public partial class CheckEmployeeDetailsForm : Form
    {
        private List<EmployeeClass> _listOfEmployees;
        private readonly EmployeeRepository _employeeRepository;

        private readonly ProjectEmployeeRepository _projectEmployeeRepository;
  
        public CheckEmployeeDetailsForm()
        {
            _employeeRepository = new EmployeeRepository();
            _projectEmployeeRepository = new ProjectEmployeeRepository();

            InitializeComponent();
        }

//        private void CheckEmployeeDetailsForm_Load(object sender, EventArgs e)
//        {
//            
//        }

        private void OpenEditEmployeeForm(object sender, EventArgs e)
        {
            var selectedItem = lstBoxEmployee.SelectedItem as EmployeeClass;            
            if (lstBoxEmployee.SelectedItem == null) return;
            var editForm = new EditEmployeeForm(selectedItem);           
            editForm.ShowDialog();
            Close();



        }

        private void OpenCheckEmployeesProjectForm(object sender, EventArgs e)
        {
            var selectedItem = lstBoxEmployee.SelectedItem as EmployeeClass;
            var checkForm = new CheckEmployeesProjects(selectedItem);
            checkForm.ShowDialog();
        }

        private void list(object sender, EventArgs e)
        {
            var counterHours = 0;
            _listOfEmployees = _employeeRepository.AllItems();
            var listProjects = _projectEmployeeRepository.GetAllItems();
            foreach (var employee in _listOfEmployees)
            {
                lstBoxEmployee.Items.Add(employee);
                foreach (var item in listProjects)
                {
                    if (employee.OIB == item.Item1.OIB)
                    {
                        foreach (var project in item.Item2)
                        {
                            counterHours += project.Item2;
                        }
                    }
                }

            }
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var counterHours = 0;
            _listOfEmployees = _employeeRepository.AllItems();
            var listProjects = _projectEmployeeRepository.GetAllItems();
            var selectedItem = _listOfEmployees.ElementAt(lstBoxEmployee.SelectedIndex);
            foreach (var item in listProjects)
            {
                if (selectedItem.OIB == item.Item1.OIB)
                {
                    foreach (var project in item.Item2)
                    {
                        counterHours += project.Item2;
                    }
                }                  
            }
            if (counterHours < 30 && counterHours > 0 ) { btnShowColor.BackColor = Color.Yellow;}
            else if ( counterHours >=30 && counterHours <=40) { btnShowColor.BackColor = Color.Green;}               
            else if (counterHours > 40)
            {
                btnShowColor.BackColor = Color.Red;
            }
            else
            {
                btnShowColor.BackColor = Color.White;
            }
        }
    }
}
