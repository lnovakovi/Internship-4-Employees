using System;
using System.Windows.Forms;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation.Pop_up
{
    public partial class PopUpForWorkingHours : Form
    {
        private string _oib;
        private object _project;
        public PopUpForWorkingHours(object project,string oib)
        {
            _oib = oib;
            _project = project;
            labelInstruction.Text = $"Enter working hours for {project}";
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
           if(txtWorkingHours.Text.CheckIfNumber() && txtWorkingHours.Text.CheckIfEmpty())
            {
                ProjectEmployeeRepository.BeforeAddingProjects(_oib,_project,int.Parse(txtWorkingHours.Text));
                Close();
            }
           else
           {
               MessageBox.Show("Wrong input");
           }
        }
    }
}
