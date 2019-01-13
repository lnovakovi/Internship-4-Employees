using System;
using Employee.Infrastructure.Extensions;
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
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value.RemoveWhiteSpaces();
                _surname = _surname.CapitalizeEachWord();
            }
        }
        public string OIB { get => _oIB; set => _oIB = value.RemoveAllTheWhiteSpaces(); }
        public DateTime DateOfBirth { get; set; }
        public Job Job { get; set; }

        public EmployeeClass(string name, string surname, string oib, DateTime dateOfBirth, Job job)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateOfBirth = dateOfBirth;
            Job = job;
        }

        public override string ToString()
        {
            return $"{Name} {Surname},{OIB}, {DateOfBirth.ToShortDateString()} , {Job.ToString()}";
        }

        public string NameAndSurname()
        {
            return $"{Name} {Surname}";
        }
    }
}
