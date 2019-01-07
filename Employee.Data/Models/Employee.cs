using System;
using Employee.Data.Enums;
using Employee.Infrastructure.Extensions;
using  Employee.Data.Enums;
using static Employee.Data.Enums.JobEnum;

namespace Employee.Data.Models
{
    public class EmployeeClass
    {
        private string _name;
        private string _surname;
        private string _oIB;

        public string Name
        {
            get => _name;
            set
            {
                _name = value.RemoveWhiteSpaces();
                _name = _name.CapitalizeEachWord();
            }
        }
        private string Surname
        {
            get => _surname;
            set
            {
                _surname = value.RemoveWhiteSpaces();
                _surname = _surname.CapitalizeEachWord();
            }
        }
        private string OIB { get => _oIB; set => _oIB = value.RemoveAllTheWhiteSpaces(); }
        private DateTime DateOfBirth { get; set; }
        private Job Job { get; set; }

        public EmployeeClass(string name, string surname, string oib, DateTime dateOfBirth, Job job)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateOfBirth = dateOfBirth;
            Job = job;
        }
    }
}
