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
                chkListBoxProject.Items.Add(project.ToString());
            }
        }
    }
}
