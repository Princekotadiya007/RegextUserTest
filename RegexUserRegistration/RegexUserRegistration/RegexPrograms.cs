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
        public string ValidateLastName(string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            return TestPattern(pattern, input);
        }
        public string ValidateEmail(string input)
        {
            string pattern = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            return TestPattern(pattern, input);
        }
        public string ValidatePhoneNumber(string input)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            return TestPattern(pattern, input);
        }
        public string ValidPasswordRule1(string input)
        {
            string pattern = @"[A-Z a-z 0-9]{8,}";
            return TestPattern(pattern, input);
        }
        public string ValidPasswordRule2(string input)
        {
            string pattern = "(?=.*[A-Z])[A-Za-z0-9]{8,}";
            return TestPattern(pattern, input);
        }
        public string ValidPasswordRule3(string input)
        {
            string pattern = "(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}";
            return TestPattern(pattern, input);
        }
        public string ValidPasswordRule4(string input)
        {
            string pattern = "(?=.*[A-Z])(?=.*[0-9])(?=.*[*#@$!^_-])[A-Za-z0-9]{8,}";
            return TestPattern(pattern, input);
        }
        public string SimpleEmail(string input)
        {
            string pattern = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
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
