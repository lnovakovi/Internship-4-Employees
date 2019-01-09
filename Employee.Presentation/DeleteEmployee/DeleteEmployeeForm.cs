using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.DeleteEmployee
{
    public partial class DeleteEmployeeForm : Form
    {
        private List<EmployeeClass> _listOfEmployees;
        //private EmployeeRepository _employeeRepository;
        public DeleteEmployeeForm()
        {
            InitializeComponent();
            //_employeeRepository=new EmployeeRepository();
            RefreshData();
            
        }

        private void RefreshData()
        {
            chkListBoxEmployee.Items.Clear();
            //_listOfEmployees = _employeeRepository.AllItems();
            foreach (var employee in _listOfEmployees)
            {
                chkListBoxEmployee.Items.Add(employee.ToString());
            }
        }
        private void DeleteEmployee(object sender, System.EventArgs e)
        {
            
            var delete = chkListBoxEmployee.SelectedItem as EmployeeClass;
            //_listOfEmployees = _employeeRepository.AllItems();
            _listOfEmployees.Remove(delete);
            Close();


        }
    }
}
