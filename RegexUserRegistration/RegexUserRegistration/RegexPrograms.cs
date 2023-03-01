using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class RegexPrograms
    {
        public string ValidateFirstName(string input)
        {
            string pattern = "^[A-z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string TestPattern(string pattern, string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Not valid";
            }
        }
    }
}
