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
        public CheckEmployeeDetailsForm()
        {

            _listOfEmployees = EmployeeRepository.AllItems();
            InitializeComponent();
        }

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

        private void ChangeColor(object sender, EventArgs e)
        {                
            var listProjects = ProjectEmployeeRepository.GetAllItems();
            if (lstBoxEmployee.SelectedIndex != -1)
            {
                var selectedItem = _listOfEmployees.ElementAt(lstBoxEmployee.SelectedIndex);
                if (ProjectEmployeeRepository.CheckIfInRelation(selectedItem))
                {
                    foreach (var item in listProjects)
                    {
                        if (selectedItem == item.Item1)
                        {
                            var counterHours = ProjectEmployeeRepository.CountHoursOnProjects(selectedItem);
                            if (counterHours < 30 && counterHours > 0)
                            {
                                btnShowColor.BackColor = Color.Yellow;
                                btnShowColor.Text = $@"{counterHours} hours";
                            }
                            else if (counterHours >= 30 && counterHours <= 40)
                            {
                                btnShowColor.BackColor = Color.Green;
                                btnShowColor.Text = $@"{counterHours} hours";
                            }
                            else //if (counterHours > 40)
                            {
                                btnShowColor.BackColor = Color.Red;
                                btnShowColor.Text = $@"{counterHours} hours";
                            }
                        }
                    }                  
                }
                else
                {
                    btnShowColor.BackColor = Color.White;
                    btnShowColor.Text = "";
                }
            }          
        }

        private void CheckEmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            foreach (var employee in _listOfEmployees)
            {
                lstBoxEmployee.Items.Add(employee);
            }

        }
    }
}
