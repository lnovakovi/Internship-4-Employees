using System;
using System.Collections.Generic;
using System.Linq;
using Employee.Data.Models;

namespace Employeee.Domain.Repositories
{
    public class ProjectEmployeeRepository
    {
        private EmployeeRepository _employeeRepository;

        private ProjectRepository _projectRepository;
        //relation employee-project
        private List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> _employeeWithListOfProjects;

        //relation project-employee
        private Tuple<Project, List<Tuple<EmployeeClass, int>>> _projectWithListOfEmployees;
        public Tuple<Project, List<Tuple<EmployeeClass, int>>> GetAllData() => _projectWithListOfEmployees;

        public ProjectEmployeeRepository()
        {
            _employeeRepository = new EmployeeRepository();
            _projectRepository = new ProjectRepository();
            AddDataEmployee();
        }
        public List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> GetAllItems() => _employeeWithListOfProjects;

        public void AddDataEmployee()
        {
            _employeeWithListOfProjects = new List<Tuple<EmployeeClass, List<Tuple<Project, int>>>>();
            var listOfEmployee = _employeeRepository.AllItems();
            var listOfProjects = _projectRepository.GetAllItems(); 
            var podTuple = new Tuple<Project,int>(listOfProjects.ElementAt(0),7);
            var podTuple2 = new Tuple<Project,int>(listOfProjects.ElementAt(1),8);
            var listProject = new List<Tuple<Project, int>>();
            listProject.Add(podTuple);
            listProject.Add(podTuple2);
            var myTuple = new Tuple<EmployeeClass,List<Tuple<Project,int>>>(listOfEmployee.ElementAt(0),listProject);
            _employeeWithListOfProjects.Add(myTuple);





        }
    }
}
