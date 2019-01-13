using System;
using System.Collections.Generic;
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
                new Project("DUMP   days", StateEnum.StateProject.Finished, new DateTime(2017, 12, 10).Date,
                    new DateTime(2018, 11, 02).Date),
                new Project("Web page", StateEnum.StateProject.InProgress, DateTime.Now,
                    (DateTime.Now + TimeSpan.FromDays(50)).Date),
                new Project("eLearning",StateEnum.StateProject.Planned, new DateTime(2019,02,02).Date, new DateTime(2019,03,03).Date)
            };
        }

        public static List<Project> GetAllItems() => _listOfProjects;

        public static string AddNewProject(Project project)
        {
            if (!CheckName(project.NameOfTheProject) || !CheckDates(project.StartDate, project.EndDate)) return "Fail";
            _listOfProjects.Add(project);
            return " OK ";
        }

        public static bool CheckName(string name)
        {
            foreach (var project in _listOfProjects)
            {
                if (!string.Equals(project.NameOfTheProject, name, StringComparison.CurrentCultureIgnoreCase)) continue;
                return false;
            }
            return true;
        }

        public static void DeleteProject(Project selectedProject)
        {
            _listOfProjects.Remove(selectedProject);
        }

        public static bool CheckDates(DateTime value1, DateTime value2)
        {
            return value2.Date > value1.Date;
        }

        public static void EditProject(Project itemForEdit)
        {
            Project itemToDelete = null;
            foreach (var todoItem in GetAllItems())
            {
                if (todoItem.NameOfTheProject != itemForEdit.NameOfTheProject) continue;
                itemToDelete = todoItem;
                break;
            }
            if (itemToDelete == null) return;
            _listOfProjects.Remove(itemToDelete);
            _listOfProjects.Add(itemForEdit);
        }

        public static List<Project> EmployeesProject(EmployeeClass employee)
        {
            var oldPro = new List<Project>();
            var listToShow = ProjectEmployeeRepository.GetAllItems();
            foreach (var relation in listToShow)
            {
                if (relation.Item1.OIB != employee.OIB) continue;
                foreach (var projects in relation.Item2)
                {
                    oldPro.Add(projects.Item1);
                }
            }
            return oldPro;
        }

        public static List<Project> EmployeesNotProject(EmployeeClass employee)
        {
            var newPro = new List<Project>();
            var listToShow = EmployeesProject(employee);
            foreach (var project in _listOfProjects)
            {
                if (listToShow.Contains(project)) continue;
                newPro.Add(project);
            }
            return newPro;
        }
    }
}
