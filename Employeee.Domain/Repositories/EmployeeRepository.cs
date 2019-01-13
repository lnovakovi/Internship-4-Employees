using System;
using System.Collections.Generic;
using Employee.Data.Enums;
using Employee.Data.Models;
using Employee.Infrastructure.Extensions;
using static System.DateTime;


namespace Employeee.Domain.Repositories
{
    public static class EmployeeRepository
    {
        private static List<EmployeeClass> _listOfEmployees;       
        public static void AddData()
        {
           
            _listOfEmployees = new List<EmployeeClass>()
            {
                new EmployeeClass("John","Wick","99876519",new DateTime(1990,09,01),JobEnum.Job.Programmer),
                new EmployeeClass("Jessica","White","81920872",new DateTime(1885,10,01),JobEnum.Job.Designer),
                new EmployeeClass("Charles","Black","34850201",new DateTime(1881,10,03),JobEnum.Job.Programmer )
            };
        }

        public static List<EmployeeClass> AllItems()
        {
            return _listOfEmployees;
        }

        public static bool CheckAge(DateTime choosedDate) => (Now - choosedDate).Days / 365 > 18;

        public static bool CheckOib(string oib)
        {
            var counter = 0;
            if (_listOfEmployees == null)
                return counter == 0;
                
            foreach (var employee in _listOfEmployees)
            {
                if (employee.OIB == oib.RemoveAllTheWhiteSpaces())
                    counter += 1;
            }
            return counter == 0;
        }
        public static string AddEmployee(string name,string surname,string oib,DateTime dateOfBirth, string position)  
        {
            if (!CheckOib(oib.RemoveAllTheWhiteSpaces()) || !CheckAge(dateOfBirth)) return "Fail";
            _listOfEmployees.Add(new EmployeeClass(name, surname, oib, dateOfBirth, (JobEnum.Job)Enum.Parse(typeof(JobEnum.Job), position)));
            return "OK";
        }

        public static bool EditEmployee(EmployeeClass itemForEdit)
        {
            EmployeeClass itemToDelete = null;
            foreach (var todoItem in AllItems())
            {
                if (todoItem.OIB != itemForEdit.OIB) continue;
                itemToDelete = todoItem;
                break;
            }
            if (itemToDelete == null)
                return false;
            _listOfEmployees.Remove(itemToDelete);
            _listOfEmployees.Add(itemForEdit);

            return true;
        }

        public static void DeleteEmployee(EmployeeClass selectedEmployee)
        {
            _listOfEmployees.Remove(selectedEmployee);
        }

        public static List<EmployeeClass> EmployeesNotOnProject(Project project)
        {
            var list=new List<EmployeeClass>();
            var listWithEmp = EmployeesOnTheProject(project);
            foreach (var employee in _listOfEmployees)
            {
                if(listWithEmp.Contains(employee)) continue;
                list.Add(employee);
            }
            return list;
        }

        public static List<EmployeeClass> EmployeesOnTheProject(Project project)
        {
            var list = new List<EmployeeClass>();
            var listWithProjects = ProjectEmployeeRepository.GetAllItems();
            foreach (var relation in listWithProjects)
            {
                foreach (var tupleProject in relation.Item2)
                {
                    if (tupleProject.Item1 != project) continue;
                    list.Add(relation.Item1);                    
                }
            }
            return list;
        }
    }
}
