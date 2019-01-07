using System.Text.RegularExpressions;

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
