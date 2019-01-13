using System;
using System.Windows.Forms;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using Employeee.Domain.Repositories;

namespace Employee.Presentation
{
    public partial class PopUpForWorkingHours : Form
    {
        private readonly string _oib;
        private readonly Project _project;
        
        public PopUpForWorkingHours(Project project,string oib)
        {
            _oib = oib;
            _project= project;
            InitializeComponent();
            labelInstruction.Text = $@"Enter working hours for {_project.NameOfTheProject}";
        }

        private void Close(object sender, EventArgs e)
        {
            var input = txtWorkingHours.Text;
            if (input.TryParseInt() && !input.CheckIfEmpty() && int.Parse(input) >0 )
            {
                ProjectEmployeeRepository.BeforeAddingProjects(_oib, _project, int.Parse(txtWorkingHours.Text));
                Close();
            }
            else
            {
                MessageBox.Show(@"Wrong input");
            }          
        }
    }
}
