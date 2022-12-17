using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class uppercaserule2
    {
        public static string passwordregex = ("^[A-Z]{1,8}[a-z0-9]{7,}$");
        public bool validatePassWord(string password2)
        {
            return Regex.IsMatch(password2, passwordregex);
        }
    }
}
