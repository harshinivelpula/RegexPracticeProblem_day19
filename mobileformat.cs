using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem19
{
    public class mobileformat
    {
        public static string PHONENUMBER = ("[1-9][0-9][ ]?[6-9][0-9]{9}$");

        public bool validatemobilenumber(string validemail)
        {
            return Regex.IsMatch(validemail, PHONENUMBER);
        }
    }
}
