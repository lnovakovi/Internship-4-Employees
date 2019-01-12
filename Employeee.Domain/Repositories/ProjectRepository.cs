using System;
using System.Collections.Generic;
using System.Linq;
using Employee.Data.Enums;
using Employee.Data.Models;

namespace Employeee.Domain.Repositories
{
    public static class ProjectRepository
    {
        private static List<Project> _listOfProjects;
             
        public static void AddProjectData()
        {

            _listOfProjects = new List<Project>()
            {
                new Project("DUMP   days", StateEnum.StateProject.Finished, new DateTime(2017,12,10).Date,
                    new DateTime(2018,11,02).Date),
                new Project("Web page", StateEnum.StateProject.InProgress,DateTime.Now, (DateTime.Now+ TimeSpan.FromDays(50)).Date)
            };
        }
        public static List<Project> GetAllItems() => _listOfProjects;

        public static void AddNewProject(Project project)
        {
            _listOfProjects.Add(project);
        }

        public static bool CheckName(string name)
        {
            foreach (var project in _listOfProjects)
            {
                if (project.NameOfTheProject.ToLower() == name.ToLower())
                {
                    return false;
                }
            }
            return true;
        }

        public static void DeleteProject(Project selectedProject)
        {
            foreach (var project in _listOfProjects.ToList())
            {
                if (project == selectedProject)
                    _listOfProjects.Remove(project);
            }
        }
        
        public static bool CheckDates(DateTime? value1, DateTime? value2)
        {
            if (value1.HasValue && value2.HasValue)
            {
                return value2 < value1;
            }
            return false;
        }
    }
}
