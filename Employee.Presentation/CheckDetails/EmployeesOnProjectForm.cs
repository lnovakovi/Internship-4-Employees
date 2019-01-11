using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.CheckDetails
{
    public partial class EmployeesOnProjectForm : Form
    {
        private Project _selectedProject;
        public EmployeesOnProjectForm(Project selectedProject)
        {
            _selectedProject = selectedProject;
            InitializeComponent();
        }

        private void ShowEmployees(object sender, System.EventArgs e)
        {
            var br = 0;
            var listToShow = ProjectEmployeeRepository.GetAllData();
            foreach (var item in listToShow)
            {
                if (item.Item1.NameOfTheProject == _selectedProject.NameOfTheProject)
                {
                    foreach (var  project in item.Item2)
                    {
                        lstBoxEmployees.Items.Add(project.Item1.NameAndSurname() + " " + project.Item2 + "hours");
                        br += 1;
                    }
                }
            }
            
        }
    }
}
