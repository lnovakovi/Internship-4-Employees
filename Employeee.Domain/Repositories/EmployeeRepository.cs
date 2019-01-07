using System;
using System.Collections.Generic;
using Employee.Data.Enums;
using Employee.Data.Models;


namespace Employeee.Domain.Repositories
{
    public class EmployeeRepository
    {
        public List<EmployeeClass> _listOfEmployees;

        public EmployeeRepository()
        {
            AddData();
        }
        
        public void AddData()
        {
           
            _listOfEmployees = new List<EmployeeClass>()
            {
                new EmployeeClass("John","Wick","99876519",new DateTime(1990,09,01),JobEnum.Job.Programmer),
                new EmployeeClass("Jessica","White","81920872",new DateTime(1885,10,01),JobEnum.Job.Designer),
                new EmployeeClass("Charles","Black","34850201",new DateTime(1881,10,03),JobEnum.Job.Programmer )
            };
        }
    }
}
