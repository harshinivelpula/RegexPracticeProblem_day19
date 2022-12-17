using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class validfirstname
    {
        public static string REGEX_VALIDFIRSTNAME = (@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public bool validatefirstname(string validfirstname)
        {
            return Regex.IsMatch(validfirstname, REGEX_VALIDFIRSTNAME);
        }
    }
}
