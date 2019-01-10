using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.Pop_up
{
    public partial class PopUpForWorkingHours : Form
    {
        private string _oib;
        private Project _project;
        private object _employee;
        public PopUpForWorkingHours(Project project,string oib)
        {
            _oib = oib;
            _project= project;
            InitializeComponent();
            labelInstruction.Text = $@"Enter working hours for {_project.NameOfTheProject}";

        }

        //need to check if number is right 
        private void Close(object sender, EventArgs e)
        {
            if (txtWorkingHours.Text.CheckIfNumber() && !txtWorkingHours.Text.CheckIfEmpty())
            {
                ProjectEmployeeRepository.BeforeAddingProjects(_oib, _project, int.Parse(txtWorkingHours.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
            
        }
    }
}
