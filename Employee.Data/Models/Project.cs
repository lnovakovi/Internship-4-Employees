using System;
using Employee.Data.Enums;
using Employee.Infrastructure.Extensions;

namespace Employee.Data.Models
{
    public class Project
    {
        private string _nameOfTheProject;

        public string NameOfTheProject
        {
            get => _nameOfTheProject;
            set
            {
                _nameOfTheProject = value.RemoveWhiteSpaces();
                _nameOfTheProject = _nameOfTheProject.CapitalizeEachWord();
            }
        }

        public StateEnum.StateProject  StateOfTheProject{ get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Project(string name, StateEnum.StateProject stateOfTheProject, DateTime startDate , DateTime endDate)
        {
            NameOfTheProject = name;
            StateOfTheProject = stateOfTheProject;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"Name: {NameOfTheProject} , State: {StateOfTheProject}, Start: {StartDate:MM/dd/yyyy} - End: {EndDate:MM/dd/yyyy}";
        }
    }
}
