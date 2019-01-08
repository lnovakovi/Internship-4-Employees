using System;
using System.Linq;

namespace Employee.Infrastructure.Extensions
{
    public static class CheckInput
    {
        public static bool CheckIfNumber(this string inputString) => inputString.All(char.IsDigit);

        public static bool CheckIfEmpty(this string inputString) => inputString == " ";
    }
}
