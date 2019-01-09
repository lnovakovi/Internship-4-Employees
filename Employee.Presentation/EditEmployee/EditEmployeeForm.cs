using System;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.EditEmployee
{
    public partial class EditEmployeeForm : Form
    {
        public EmployeeClass Employee;
       // public EmployeeRepository _EmployeeRepository;
        public EditEmployeeForm(EmployeeClass EmployeeToEdit)
        {
            Employee = EmployeeToEdit;
            //_EmployeeRepository= new EmployeeRepository();
            InitializeComponent();
            
        }

        private void SaveEdit(object sender, EventArgs e)
        {
            var selectedItem = new EmployeeClass(txtName.Text,txtSurname.Text,txtOIB.Text.RemoveAllTheWhiteSpaces(),dateTimePickerEmployee.Value, (JobEnum.Job)Enum.Parse(typeof(JobEnum.Job), cmbJob.SelectedItem.ToString()));
            //_EmployeeRepository.EditEmployee(selectedItem);
            Close();
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            AddJobsToCombo();
            txtName.Text = Employee.Name;
            txtSurname.Text = Employee._surname;
            txtOIB.Text = Employee.OIB;
            dateTimePickerEmployee.Value = Employee.DateOfBirth.Date;
            cmbJob.Text = Employee.Job.ToString();
        }

        private void AddJobsToCombo()
        {
            var enums = Enum.GetValues(typeof(JobEnum.Job));
            foreach (var job in enums)
            {
                cmbJob.Items.Add(job);
            }
        }
    }
}
