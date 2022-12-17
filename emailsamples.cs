using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class emailsamples
    {
        public static string regexrule = "^[a-z]{3}([.+-@])?([a-z]+)?([0-9]+)?([@])?([a-z]+)?[.][a-z]{3}([,.])?([a-z]+)?$";
        public bool validateValidAllEmail(string validemail)
        {
            return Regex.IsMatch(validemail, regexrule);
        }
    }
}
