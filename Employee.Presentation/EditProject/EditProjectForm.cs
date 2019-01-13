using System;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;

namespace Employee.Presentation.EditProject
{
    public partial class EditProjectForm : Form
    {
        private Project _project;

        public EditProjectForm(Project projectToEdit)
        {
            _project = projectToEdit;
            InitializeComponent();
            MessageBox.Show("You can add/remove employees without clicking the save button");
        }

        private void EditProjectForm_Load(object sender, System.EventArgs e)
        {
            txtName.Text = _project.NameOfTheProject;
            dateTime.Value = _project.StartDate;
            dateEnd.Value = _project.EndDate;
            SetStateInCombo();
            cmbState.Text = _project.StateOfTheProject.ToString();
        }

        private void SetStateInCombo()
        {
            var enums = Enum.GetValues(typeof(StateEnum.StateProject));
            foreach (var state in enums)
            {
                cmbState.Items.Add(state);
            }
        }

        private void SaveChanges(object sender, EventArgs e)
        {
            var startDate = _project.StartDate;
            var endDate = _project.EndDate;
            var state = _project.StateOfTheProject;
            DialogResult dialogResult = MessageBox.Show(@"Are you sure?", @"WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dateEnd.Value != endDate)
                {
                   endDate = dateEnd.Value;}

                if (dateTime.Value != startDate)
                {
                    startDate = dateTime.Value;}
                if ((StateEnum.StateProject)cmbState.SelectedItem != state)
                    state = (StateEnum.StateProject)cmbState.SelectedItem;
            var newProject = new Project(_project.NameOfTheProject,state,startDate,endDate);

            }
            else
            {
                Close();
            }
        }
    }
}
