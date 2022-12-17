using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class validlastname
    {
        public static string regexvalidlastname = (@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public bool validatelastname(string validlastname)
        {
            return Regex.IsMatch(validlastname, regexvalidlastname);
        }
    }
}
