using System.Windows.Forms;
using Employee.Data.Enums;
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
            var listToShow = ProjectEmployeeRepository.GetAllData();
            foreach (var item in listToShow)
            {
                if (item.Item1.NameOfTheProject == _selectedProject.NameOfTheProject)
                {
                    foreach (var project in item.Item2)
                    {
                        if (project.Item1.Job == JobEnum.Job.Programmer)
                        {
                            lstBoxProgrammers.Items.Add($"{project.Item1.NameAndSurname()} - {project.Item2} hours");
                            Programers.Text = $"Programers: {lstBoxProgrammers.Items.Count.ToString()}";
                        }
                        else if (project.Item1.Job == JobEnum.Job.Designer)
                        {
                            lstBoxDesigner.Items.Add($"{project.Item1.NameAndSurname()} - {project.Item2} hours");
                            lblDesigner.Text = $"Designers: {lstBoxDesigner.Items.Count.ToString()}";
                        }
                        else if (project.Item1.Job == JobEnum.Job.Accountant)
                        {
                            lstBoxAccountant.Items.Add($"{project.Item1.NameAndSurname()} - {project.Item2} hours");
                            lblAccountant.Text = $"Accountants: {lstBoxAccountant.Items.Count.ToString()} ";
                        }
                        else
                        {
                            lstBoxSecretary.Items.Add($"{project.Item1.NameAndSurname()} - {project.Item2} hours");
                            lblSecretary.Text = $"Secretary: {lstBoxSecretary.Items.Count.ToString()}";
                        }
                    }
                }
            }          
        }
    }
}
