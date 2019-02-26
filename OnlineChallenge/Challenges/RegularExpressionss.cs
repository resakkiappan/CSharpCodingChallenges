using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OnlineChallenge
{    
    static public class RegularExpressionss
    {
        private static string userName = @"\b[A-Z]\w+[$][A-Z][a-z0-9]+$"; //([A - Z][a - z0 - 9]+[$] [A-Z] [a-z0-9]+)[?=.*\d]{0,3}$

        public static bool VerifyUserName(string value)
        {
            return VerifyMatch(userName, value);
        }

        private static bool VerifyMatch(string regularExpression, string value)
        {
            Regex regex = new Regex(regularExpression);
            return regex.IsMatch(value);
        }
    }
}
