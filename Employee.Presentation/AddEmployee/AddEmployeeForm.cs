using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employeee.Domain.Repositories;
using Employee.Infrastructure.Extensions;
using Employee.Presentation.Pop_up;


namespace Employee.Presentation.AddEmployee
{
    public partial class AddEmployeeForm : Form
    {
        private List<Project> _listOfProjects;
       

        public AddEmployeeForm()
        {               
            InitializeComponent();
            RefreshProjectsInListBox();
            AddJobsToCombo();
        }

        private void RefreshProjectsInListBox()
        {
            lstBoxProjects.Items.Clear();
            _listOfProjects = ProjectRepository.GetAllItems();
            foreach (var project in _listOfProjects)
            {
                lstBoxProjects.Items.Add(project);
            }
        }

        private void AddJobsToCombo()
        {
            var enums = Enum.GetValues(typeof(JobEnum.Job));
            foreach (var job in enums)
            {
                cmbJob.Items.Add(job);
            }
        }
        private void SaveEmployee(object sender, EventArgs e)
        {
            
            if (!txtEmployeeName.ToString().CheckIfEmpty() && !txtEmployeeSurname.ToString().CheckIfEmpty() &&
                txtOIB.Text.TryParseInt()  && cmbJob.SelectedItem != null)
            {
                if (EmployeeRepository.AddEmployee(txtEmployeeName.Text, txtEmployeeSurname.Text, txtOIB.Text,
                        dateEmployeeBirth.Value, cmbJob.SelectedItem.ToString()) == "OK")
                {
                    MessageBox.Show("OK!");
                    var selectedProjects = lstBoxProjects.SelectedItems;
                    foreach (var project in selectedProjects)
                    {
                        var popUp = new PopUpForWorkingHours(project as Project, txtOIB.Text);
                        popUp.ShowDialog();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Adding failed,check date (must be older than 18), OIB only numbers","WARNING");
                    Close();
                }
            }             
            else
            {
                MessageBox.Show(@"Wrong input. Check if you entered evertyhing right, job position must be selected, OIB only numbers etc.", "WRONG INPUT");
                Close();
            }               
        }
    }
}
