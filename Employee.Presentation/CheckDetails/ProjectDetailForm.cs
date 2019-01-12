using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.CheckDetails
{
    public partial class ProjectDetailForm : Form
    {
        private List<Project> _listOfProjects;
        
        public ProjectDetailForm()
        {
            
            InitializeComponent();
        }

        private void ProjectDetailForm_Load(object sender, System.EventArgs e)
        {
            chkListBoxProject.Items.Clear();
            _listOfProjects = ProjectRepository.GetAllItems();
            foreach (var project in _listOfProjects)
            {
                chkListBoxProject.Items.Add(project);
            }
        }

        private void OpenFormCheckProjectEmployees(object sender, System.EventArgs e)
        {
            var selectedProject = chkListBoxProject.SelectedItem as Project;
            if (selectedProject != null)
            {
                var checkForm = new EmployeesOnProjectForm(selectedProject);
                checkForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You haven't chosen project.");
            }
            
        }
    }
}
