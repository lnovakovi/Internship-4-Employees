using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string s)
        {
            s = s.Trim();
            return Regex.Replace(s, @"\s{2,}", " ");
        }

        public static string CapitalizeEachWord(this string s)
        {
            return Regex.Replace(s.ToLower(), @"(^\w)|(\s\w)", m => m.Value.ToUpper());
        }

        public static string RemoveAllTheWhiteSpaces(this string s)
        {
            return Regex.Replace(s, @"\s+", "");
        }
    }
}
