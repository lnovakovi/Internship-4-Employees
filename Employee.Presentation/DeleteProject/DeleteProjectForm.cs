using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.DeleteProject
{
    public partial class DeleteProjectForm : Form
    {
        public DeleteProjectForm()
        {
            InitializeComponent();
            RefreshProjects();
        }

        private void RefreshProjects()
        {
            lstProjects.Items.Clear();
            var listOfProjects = ProjectRepository.GetAllItems();
            foreach (var project in listOfProjects)
            {
                lstProjects.Items.Add(project);
            }
        }
        //not working right 
        private void DeleteSelectedProject(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { 
                MessageBox.Show(ProjectEmployeeRepository.RemoveProjectFromRelation(lstProjects.SelectedItem as Project));
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                Close();
            }
        }
    }
}
