using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    internal class passwordrule1
    {
        public static string regexpasswordrule1 = "[A-Za-z0-9]{8,}";

        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, regexpasswordrule1);
        }
    }
}
