using System;
using System.Collections.Generic;
using System.Linq;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;

namespace Employeee.Domain.Repositories
{
    public static class ProjectEmployeeRepository
    {
        private static List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> _employeeWithListOfProjects;//relation employee-projects
        private static List<Tuple<Project, List<Tuple<EmployeeClass, int>>>> _projectWithListOfEmployees; //relation project-employees
        public static List<Tuple<Project, List<Tuple<EmployeeClass, int>>>> GetAllData() => _projectWithListOfEmployees;
        public static List<Tuple<EmployeeClass, List<Tuple<Project, int>>>> GetAllItems() =>
            _employeeWithListOfProjects;
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
            var listProject1 = new List<Tuple<Project, int>>
            {
                new Tuple<Project, int>(_listOfProjects.ElementAt(0), 12)
            };
            _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(_listOfEmployee.ElementAt(1), listProject1));
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
            _projectWithListOfEmployees.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(_listOfProjects.ElementAt(0), listEmployee));
        }

        public static void AddNewEmployeeToTheProject(Project project, EmployeeClass employee,
            int numberOfWorkingHours)
        {
            var found = false;
            _listOfProjects = ProjectRepository.GetAllItems();
            if (_projectWithListOfEmployees != null && CheckIfInRelation(project))
            {
                foreach (var item in _projectWithListOfEmployees)
                {
                    // find matching project
                    if (item.Item1 != project) continue;
                    // check if employee is already on the project
                    foreach (var tupleEmployee in item.Item2)
                    {
                        if (tupleEmployee.Item1.OIB != employee.OIB) continue;
                        found = true;
                        break;
                    }
                }
                if (found) return;
                foreach (var relation in _projectWithListOfEmployees)
                {
                    if (project == relation.Item1)
                        relation.Item2.Add(new Tuple<EmployeeClass, int>(employee, numberOfWorkingHours));
                }
            }
            else
            {
                var list = new List<Tuple<EmployeeClass, int>>()
                {
                    new Tuple<EmployeeClass, int>(employee, numberOfWorkingHours)
                };
                _projectWithListOfEmployees?.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(project, list));
            }
        }

        public static void AddNewProjectToEmployee(EmployeeClass employee, Project project, int numberOfWorkingHours)
        {
            _listOfEmployee = EmployeeRepository.AllItems();
            var found = false;
            if (_employeeWithListOfProjects != null)
            {  //go through _list of employees
                foreach (var item in _listOfEmployee)
                {  //check if it is in relation list employee-project
                    foreach (var relation in _employeeWithListOfProjects)
                    {  // if it is in relation list already, just add the project to the employee 
                        if (relation.Item1.OIB != item.OIB || item.OIB != employee.OIB) continue;
                        relation.Item2.Add(new Tuple<Project, int>(project, numberOfWorkingHours));
                        found = true;
                        break;
                    }
                }
                if (found) return;
                var list = new List<Tuple<Project, int>> {new Tuple<Project, int>(project, numberOfWorkingHours)};
                _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(employee, list));
            }
            else
            {
                //if list is empty,just add it 
                var list = new List<Tuple<Project, int>>()
                {
                    new Tuple<Project, int>(project, numberOfWorkingHours)
                };
                _employeeWithListOfProjects?.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(employee, list));
            }
        }

        public static void BeforeAddingProjects(string oib, Project project, int numberOfWorkingHours)
        {
            _listOfEmployee = EmployeeRepository.AllItems();
            foreach (var employee in _listOfEmployee)
            {
                if (employee.OIB != oib.RemoveAllTheWhiteSpaces()) continue;
                AddNewProjectToEmployee(employee, project, numberOfWorkingHours);
                AddNewEmployeeToTheProject(project, employee, numberOfWorkingHours);
            }
        }

        public static string RemoveProjectFromRelation(Project projectToDelete)
        {
            //delete from relation project-employees
            _projectWithListOfEmployees = GetAllData();
            foreach (var project in _projectWithListOfEmployees.ToList())
            {
                if (project.Item1 == projectToDelete)
                {
                    _projectWithListOfEmployees.Remove(project);
                }
            }
            RemoveProjectFromRelationEmployeeProject(projectToDelete);
            ProjectRepository.DeleteProject(projectToDelete);
            return $"Deleted successfully {projectToDelete.NameOfTheProject} ";
        }

        public static void RemoveProjectFromRelationEmployeeProject(Project projectToDelete)
        {
            //delete from relation employee-project
            foreach (var employee in _employeeWithListOfProjects.ToList())
            {
                foreach (var project in employee.Item2.ToList())
                {
                    if (project.Item1 != projectToDelete) continue;
                    if (employee.Item2.ToList().Count > 1)
                        employee.Item2.Remove(project);
                    else
                        _employeeWithListOfProjects.Remove(employee); //if that is only emp.project
                }
            }
        }
        public static void RemoveProjectFromEmployee(Project projectToDelete, EmployeeClass selEmployee)
        {
            foreach (var employee in _employeeWithListOfProjects.ToList())
            {
                if (selEmployee.OIB != employee.Item1.OIB) continue;
                foreach (var project in employee.Item2.ToList())
                {
                    if (project.Item1.NameOfTheProject != projectToDelete.NameOfTheProject) continue;
                    if (employee.Item2.ToList().Count > 1)
                        employee.Item2.Remove(project);
                    else
                        _employeeWithListOfProjects.Remove(employee); //if that is only emp.project
                }
            }
        }
        public static string RemoveEmployee(EmployeeClass selectedEmployee)
        {          
            if (CheckIfInRelation(selectedEmployee))
            {
                if (IsPossibleToDeleteEmployee(selectedEmployee))
                {
                    foreach (var relation in _projectWithListOfEmployees.ToList())
                    {
                        foreach (var employee in relation.Item2.ToList())
                        {
                            if (employee.Item1.OIB != selectedEmployee.OIB) continue;
                            relation.Item2.Remove(employee);
                            foreach (var relation1 in _employeeWithListOfProjects.ToList())
                            {
                                if (relation1.Item1 != selectedEmployee) continue;
                                _employeeWithListOfProjects.Remove(relation1);
                                EmployeeRepository.DeleteEmployee(selectedEmployee);
                            }
                        }
                        return $"Deleted successfully {selectedEmployee.NameAndSurname()}";
                    }
                }
                else
                {
                    return $"Can't delete {selectedEmployee.NameAndSurname()} because he/she is the only one on the project";
                }
            }
            else //if employee doesn't have any projects,just delete him
            {
                EmployeeRepository.DeleteEmployee(selectedEmployee);
                return $"Deleted successfully {selectedEmployee.NameAndSurname()}";
            }
            return "Delete failed";
        }

        public static void EditRelationProjectEmployee(EmployeeClass selectedEmployee)
        {
            foreach (var project in _projectWithListOfEmployees)
            {
                foreach (var employee in project.Item2.ToList())
                {
                    if (employee.Item1 != selectedEmployee || (project.Item2.ToList().Count <= 1)) continue;
                    //delete from relation project-employees
                    project.Item2.Remove(employee);
                    //now delete from relation employee-projects
                    foreach (var relation in _employeeWithListOfProjects.ToList())
                    {
                        if (relation.Item1 == selectedEmployee)
                        {
                            _employeeWithListOfProjects.ToList().Remove(relation);
                        }
                    }
                }
            }        
        }

        public static void EditRelationEmployeeProject(EmployeeClass oldEmp, EmployeeClass newEmp)
        {
            foreach (var relation in _employeeWithListOfProjects.ToList())
            {
                if (relation.Item1.OIB != oldEmp.OIB) continue;
                var list = relation.Item2;
                _employeeWithListOfProjects.Remove(relation);
                _employeeWithListOfProjects.Add(new Tuple<EmployeeClass, List<Tuple<Project, int>>>(newEmp, list));
                break;
            }
        }
        public static void EditRelationProjectEmployee(EmployeeClass oldEmp, EmployeeClass newEmp)
        {
            foreach (var relation in _projectWithListOfEmployees.ToList())
            {
                foreach (var project in relation.Item2)
                {
                    if (project.Item1.OIB != oldEmp.OIB) continue;
                    var workHours = project.Item2;
                    relation.Item2.Remove(project);
                    relation.Item2.Add(new Tuple<EmployeeClass, int>(newEmp, workHours));
                    break;
                }
            }
        }
        public static void EditRelationEmployeeProject(Project oldPro, Project newPro)
        {
            foreach (var relation in _employeeWithListOfProjects.ToList())
            {
                foreach (var project in relation.Item2)
                {
                    if (project.Item1 != oldPro) continue;
                    var num = project.Item2;
                    relation.Item2.Remove(project);
                    relation.Item2.Add(new Tuple<Project, int>(newPro,num));
                    break;
                }
            }
        }
        public static void EditRelationProjectEmployee(Project oldPro, Project newPro)
        {
            foreach (var relation in _projectWithListOfEmployees.ToList())
            {
                if(relation.Item1 != oldPro)continue;
                var tuple = relation.Item2;
                _projectWithListOfEmployees.Remove(relation);
                _projectWithListOfEmployees.Add(new Tuple<Project, List<Tuple<EmployeeClass, int>>>(newPro, tuple));
            }
        }

        public static void EditRelationProjectEmployee(int workHours,Project project, EmployeeClass employee)
        {
            foreach (var relation in _projectWithListOfEmployees)
            {
                if (relation.Item1 != project) continue;
                foreach (var tuple in relation.Item2.ToList())
                {
                    if (tuple.Item1.OIB != employee.OIB) continue;
                    relation.Item2.Remove(tuple);
                    relation.Item2.Add(new Tuple<EmployeeClass, int>(employee,workHours));
                }
            }
        }

        public static void EditRelationEmployeeProject(int workHours,Project project,EmployeeClass employee)
        {
            foreach (var relation in _employeeWithListOfProjects)
            {
                if(relation.Item1.OIB != employee.OIB) continue;
                foreach (var tuple in relation.Item2.ToList())
                {
                    if(tuple.Item1!=project) continue;
                    relation.Item2.Remove(tuple);
                    relation.Item2.Add(new Tuple<Project, int>(project,workHours));
                }
            }
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

        public static bool CheckIfInRelation(Project project)
        {
            foreach (var relation in _projectWithListOfEmployees)
            {
                if (relation.Item1 == project)
                    return true;
            }
            return false;
        }

        public static int GetNumberOfEmployees(Project project)
        {
            foreach (var relation in _projectWithListOfEmployees)
            {
                if (relation.Item1 == project)
                    return relation.Item2.Count;
            }
            return 0;
        }

        public static bool IsPossibleToDeleteEmployee(EmployeeClass employee)
        {
            var isPossible = true;
            foreach (var relation in _projectWithListOfEmployees)
            {
                foreach (var emp in relation.Item2)
                {
                    if (emp.Item1.OIB != employee.OIB) continue;
                    if (relation.Item2.Count != 1) continue;
                    isPossible = false;
                    break;
                }
            }
            return isPossible;
        }

        public static int CountHoursOnProjects(EmployeeClass employee)
        {
            var numHours = 0;
            foreach (var relation in _employeeWithListOfProjects)
            {
                if (!relation.Item1.Equals(employee)) continue;
                foreach (var project in relation.Item2)
                {
                    numHours += project.Item2;
                }
            }
            return numHours;
        }
    }
}
