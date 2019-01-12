﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Employee.Data.Models;

namespace Employeee.Domain.Repositories
{
    public static class ProjectEmployeeRepository
    {
        
        //relation employee-projects
        private static List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> _employeeWithListOfProjects;

        //relation project-employees
        private static List<Tuple<Project, List<Tuple<EmployeeClass, int>>>> _projectWithListOfEmployees;

        //method to return projects with employees
        public static List<Tuple<Project, List<Tuple<EmployeeClass, int>>>> GetAllData() => _projectWithListOfEmployees;

        //method to return employees with projects
        public static List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> GetAllItems() => _employeeWithListOfProjects;

       
        private static List<EmployeeClass> _listOfEmployee;
        private static List<Project> _listOfProjects;

        public static void AddDataEmployee()
        {
            _employeeWithListOfProjects = new List<Tuple<EmployeeClass, List<Tuple<Project, int>>>>();
            _listOfEmployee = EmployeeRepository.AllItems();
            _listOfProjects = ProjectRepository.GetAllItems();
            var listProject = new List<Tuple<Project, int>>()
            {
                new Tuple<Project, int>(_listOfProjects.ElementAt(0), 7),               
            };
            _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(_listOfEmployee.ElementAt(0), listProject));
            var listProject1=new  List<Tuple<Project,int>>();
            listProject1.Add(new Tuple<Project, int>(_listOfProjects.ElementAt(0),12));
            _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(_listOfEmployee.ElementAt(1),listProject1));
        }

        public static void AddDataProject()
        {
            _projectWithListOfEmployees = new List<Tuple<Project, List<Tuple<EmployeeClass, int>>>>();
            _listOfProjects = ProjectRepository.GetAllItems();
            _listOfEmployee = EmployeeRepository.AllItems();
            var listEmployee = new List<Tuple<EmployeeClass, int>>()
            {
                new Tuple<EmployeeClass, int>(_listOfEmployee.ElementAt(0), 7),
                new Tuple<EmployeeClass, int>(_listOfEmployee.ElementAt(1), 12)
            };
            _projectWithListOfEmployees.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(_listOfProjects.ElementAt(0),listEmployee));
            

        }
        public static void AddNewEmployeeToTheProject(Project project, EmployeeClass employee,
            int numberOfWorkingHours)
        {
            var found = false;
            _listOfProjects = ProjectRepository.GetAllItems();
            if (_projectWithListOfEmployees != null)
            {
                foreach (var Project in _listOfProjects)
                {
                    foreach (var item in _projectWithListOfEmployees)
                    {
                        // find matching project
                        if (item.Item1 == project)
                        {
                            // check if employee is already on the project
                            foreach (var tupleEmployee in item.Item2)
                            {
                                if (tupleEmployee.Item1.OIB == employee.OIB)
                                {
                                    break;
                                }
                            }                          
                        }
                    }
                }
                if (!found)
                {
                    var list = new List<Tuple<EmployeeClass, int>>();
                    list.Add(new Tuple<EmployeeClass, int>(employee, numberOfWorkingHours));
                   _projectWithListOfEmployees.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(project,list));                   
                }
            }
            else
            {
                var list = new List<Tuple<EmployeeClass, int>>()
                {
                    new Tuple<EmployeeClass, int>(employee, numberOfWorkingHours)
                };
                _projectWithListOfEmployees.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(project, list));
            }          
        }

        public static void AddNewProjectToEmployee(EmployeeClass employee, Project project, int numberOfWorkingHours)
        {
            _listOfEmployee = EmployeeRepository.AllItems();
            var found = false;
            if (_employeeWithListOfProjects != null)
            {
                //go through _list of employees
                foreach (var item in _listOfEmployee)
                {  //check if it is in relation list employee-project
                    foreach (var relation in _employeeWithListOfProjects)
                    {
                        if (relation.Item1.OIB == item.OIB && item.OIB == employee.OIB)
                        { // if it is in relation list already, just add the project to the employee
                            relation.Item2.Add(new Tuple<Project, int>(project, numberOfWorkingHours));
                            found = true;
                            break;
                        }
                    }                   
                }
                if (!found)
                {
                    var list = new List<Tuple<Project, int>>();
                    list.Add(new Tuple<Project, int>(project, numberOfWorkingHours));
                    _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(employee, list));
                }
            }
            else
            { //if list is empty,just add it 
                var list = new List<Tuple<Project, int>>()
                {
                    new Tuple<Project, int>(project, numberOfWorkingHours)
                };
                    _employeeWithListOfProjects.Add(
                        new Tuple<EmployeeClass, List<Tuple<Project, int>>>(employee, list));
            }           
        }

        public static void BeforeAddingProjects(string oib, Project project,int numberOfWorkingHours)
        {
            _listOfEmployee = EmployeeRepository.AllItems();
            foreach (var employee in _listOfEmployee)
            {
                if (employee.OIB == oib)
                {
                   AddNewProjectToEmployee(employee,project,numberOfWorkingHours);
                    AddNewEmployeeToTheProject(project, employee, numberOfWorkingHours);
                }
            }
        }
        //delete
        public static string RemoveProjectFromRelation(Project projectToDelete)
        {
            foreach (var project in _projectWithListOfEmployees.ToList())
            {
                if (project.Item1 == projectToDelete)
                {
                    _projectWithListOfEmployees.Remove(project);
                }
            }
            foreach (var employee in _employeeWithListOfProjects.ToList())
            {
                foreach (var project in employee.Item2.ToList())
                {
                    if (project.Item1 == projectToDelete)
                        employee.Item2.Remove(project);
                }
            }
            ProjectRepository.DeleteProject(projectToDelete);
            return $"Deleted successfully {projectToDelete.NameOfTheProject} ";
        }

        //deleteEmployee
        public static string RemoveEmployee(EmployeeClass selectedEmployee)
        {
            var isPossibleToDelete = false;
            var hasProject = false; 
            foreach (var project in _projectWithListOfEmployees)
            {
                foreach (var employee in project.Item2.ToList())
                {
                    if (employee.Item1 == selectedEmployee && project.Item2.ToList().Count != 1)
                    {
                        project.Item2.Remove(employee);
                        isPossibleToDelete = true;
                        //hasProject = true;
                        //break;
                    }                  
                }
            }
            //if (!hasProject)
            //{
            //    EmployeeRepository.DeleteEmployee(selectedEmployee);
            //    return $"Deleted successfully {selectedEmployee.NameAndSurname()}";
            //}
            if (isPossibleToDelete)
            {
                foreach (var employee in _employeeWithListOfProjects.ToList())
                {
                    if (employee.Item1 == selectedEmployee)
                    {
                        _employeeWithListOfProjects.ToList().Remove(employee);
                    }
                }
                EmployeeRepository.DeleteEmployee(selectedEmployee);
                return $"Deleted successfully {selectedEmployee.NameAndSurname()} ";
            }
            else
            {
            return $"Can't delete employee because {selectedEmployee.NameAndSurname()}  is the only one on the project";
            }
           
        }

        public static int CountHoursOnProjects(EmployeeClass employee)
        {
            var numHours = 0;
            foreach (var relation in _employeeWithListOfProjects)
            {
                if (relation.Item1.Equals(employee))
                {
                    foreach (var projet in relation.Item2)
                    {
                        numHours += projet.Item2;
                    }
                }
            }
            return numHours;
        }

        public static bool CheckIfInRelation(EmployeeClass employee)
        {
            foreach (var relation in _employeeWithListOfProjects)
            {
                if (relation.Item1.OIB == employee.OIB)
                    return true;
            }
            return false;
        }       
    }
}
;