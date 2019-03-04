using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OnlineChallenge
{
    static public class CreditCardNumberCheck
    {
        /*
        | Card Type  | Begins With          | Number Length |
        |------------|----------------------|---------------|
        | AMEX       | 34 or 37             | 15            |
        | Discover   | 6011                 | 16            |
        | Mastercard | 51, 52, 53, 54 or 55 | 16            |
        | VISA       | 4                    | 13 or 16      
         */
        
        public static string GetCreditCardType(long number)
        {
            if (Regex.Match(number.ToString(), @"^([\d]{13}|[\d]{15}|[\d]{16})").Success)
            {
                if (Regex.Match(number.ToString(), @"((?=^(34)|^(37))([\d]{15}))$").Success)
                    return "AMEX";
                else if (Regex.Match(number.ToString(), @"((?=^(6011))([\d]{16}))$").Success)
                    return "Discover";
                else if (Regex.Match(number.ToString(), @"((?=^(51)|^(52)|^(53)|^(54)|^(55))([\d]{15}))$").Success)
                    return "Mastercard";
                else if (Regex.Match(number.ToString(), @"((?=^(4))([\d]{13}|[\d]{16}))$").Success)
                    return "VISA";
            }
            return "Unknown";
        }
    }
}
