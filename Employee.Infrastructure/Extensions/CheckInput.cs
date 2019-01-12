using System;
using System.Linq;

namespace Employee.Infrastructure.Extensions
{
    public static class CheckInput
    {
       
        public static bool CheckIfEmpty(this string inputString) => inputString == "";

        public static bool TryParseInt(this string inputString)
        {
            var output = 0;
            return int.TryParse(inputString,out output);            
        }
    }
}
