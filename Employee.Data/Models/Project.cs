using System;
using Employee.Data.Enums;
using Employee.Infrastructure.Extensions;

namespace Employee.Data.Models
{
    public class Project
    {
        private string _nameOfTheProject;

        public string NameOfTheProject { get => _nameOfTheProject; set => _nameOfTheProject = value.RemoveWhiteSpaces(); }
        private StateEnum.StateProject  StateOfTheProject{ get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }

        public Project(string name, StateEnum.StateProject stateOfTheProject, DateTime startDate , DateTime endDate)
        {
            NameOfTheProject = name;
            StateOfTheProject = stateOfTheProject;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Name: {NameOfTheProject} , State: {StateOfTheProject}, Start: {StartDate} - End: {EndDate}";
        }
    }
}
