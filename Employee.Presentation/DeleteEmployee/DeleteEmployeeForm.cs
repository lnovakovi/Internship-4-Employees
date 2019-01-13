using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.DeleteEmployee
{
    public partial class DeleteEmployeeForm : Form
    {
        private readonly List<EmployeeClass> _listOfEmployees;
        
        public DeleteEmployeeForm()
        {
            InitializeComponent();
            _listOfEmployees = EmployeeRepository.AllItems();
            RefreshData();        
        }

        private void RefreshData()
        {
            chkListBoxEmployee.Items.Clear();
            foreach (var employee in _listOfEmployees.ToList())
            {
                chkListBoxEmployee.Items.Add(employee);
            }
        }
        private void DeleteEmployee(object sender, System.EventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                if (chkListBoxEmployee.SelectedIndex > -1)
                {
                    var selectedEmployee = chkListBoxEmployee.SelectedItem as EmployeeClass;
                    MessageBox.Show(ProjectEmployeeRepository.RemoveEmployee(selectedEmployee));
                }               
                Close();
            }
            else
            {
                Close(); 
            }

           
        }
    }
}
