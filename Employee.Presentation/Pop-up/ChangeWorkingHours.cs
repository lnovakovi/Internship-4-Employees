using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation
{
    public partial class ChangeWorkingHours : Form
    {
        private readonly Project _project;
        private readonly EmployeeClass _emp;
        public ChangeWorkingHours(Project project,EmployeeClass emp)
        {
            _project = project;
            _emp = emp;
            InitializeComponent();
            lblEnter.Text = $@"Enter hours for {emp.NameAndSurname()}";
        }

        private void OK_click(object sender, EventArgs e)
        {
            var input = txtHours.Text;
            if (input.TryParseInt() && !input.CheckIfEmpty() && int.Parse(input) > 0)
            {
                ProjectEmployeeRepository.EditRelationProjectEmployee(int.Parse(input),_project,_emp);
                ProjectEmployeeRepository.EditRelationEmployeeProject(int.Parse(input),_project,_emp);
                Close();
            }
            else
            {
                MessageBox.Show(@"Wrong input");
            }
            Close();
        }
    }
}
