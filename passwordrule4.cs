using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class passwordrule4
    {
        public static string regexrule = "^[A-Za-z]{6,}[A-Z]{1}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$";
        public bool validatePassWord(string password3)
        {
            return Regex.IsMatch(password3, regexrule);
        }
    }
}
