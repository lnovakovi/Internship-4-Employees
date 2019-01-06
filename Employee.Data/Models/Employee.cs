using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Data.Enums;
using Employee.Infrastructure.Extensions;

namespace Employee.Data.Models
{
    public class Employee
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
        private DateTime DateoFBirth { get; set; }
        private JobEnum Job { get; set; }

        public Employee(string name, string surname, string oib, DateTime dateoFBirth, JobEnum job)
        {
            Name = name;
            Surname = surname;
            OIB = oib;
            DateoFBirth = dateoFBirth;
            Job = job;
        }
    }
}
