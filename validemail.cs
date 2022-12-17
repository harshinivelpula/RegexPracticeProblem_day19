using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class validemail
    {
        public static string regexrule = ("^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}[.][A-Za-z]{2,}([.][A-Za-z]{2})?$");
        public bool validateemail(string validemail)
        {
            return Regex.IsMatch(validemail, regexrule);
        }
    }
}
