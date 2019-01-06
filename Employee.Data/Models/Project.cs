using System;
using Employee.Infrastructure.Extensions;

namespace Employee.Data.Models
{
    public class Project
    {
        private string _nameOfTheProject;

        public string NameOfTheProject { get => _nameOfTheProject; set => _nameOfTheProject = value.RemoveWhiteSpaces(); }
        private Tuple<Employee, int> ListOfEmployeesOnProjectAndHours { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        public Project(string name, Tuple<Employee, int> lstOfEmployees, DateTime startDate, DateTime endDate)
        {
            NameOfTheProject = name;
            ListOfEmployeesOnProjectAndHours = lstOfEmployees;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
