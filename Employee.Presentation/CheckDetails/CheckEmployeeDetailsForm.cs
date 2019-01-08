using System;
using System.Collections.Generic;
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
  
        public CheckEmployeeDetailsForm()
        {
            _employeeRepository = new EmployeeRepository();
            InitializeComponent();
            
            
        }

        private void CheckEmployeeDetailsForm_Load(object sender, EventArgs e)
        {
            listBoxEmployees.Items.Clear();
            _listOfEmployees = _employeeRepository.AllItems();
            foreach (var employee in _listOfEmployees)
            {
                listBoxEmployees.Items.Add(employee);
            }
        }

        private void OpenEditEmployeeForm(object sender, EventArgs e)
        {
            var selectedItem = listBoxEmployees.SelectedItem as EmployeeClass;            
            if (listBoxEmployees.SelectedItem == null) return;
            var editForm = new EditEmployeeForm(selectedItem);           
            editForm.ShowDialog();
            Close();



        }
    }
}
