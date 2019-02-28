using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace OnlineChallenge
{
    /*
    Some positive integers n have the property that the sum[n + reverse(n)] consists entirely of odd(decimal) digits.For instance, 36 + 63 = 99 and 409 + 904 = 1313. 
    We will call such numbers reversible; so 36, 63, 409, and 904 are reversible.Leading zeroes are not allowed in either n or reverse(n).
    There are 120 reversible numbers below one-thousand.
    How many reversible numbers are there below one-billion (109)?
    */
    static public class ReversibleNumbers
    {
        public static int GetCount(int thresholdNumber)
        {
            HashSet<int> output = new HashSet<int>();
            for (int number = 1; number < thresholdNumber; number++)
            {
                if (!output.Contains(number) && (number % 10 != 0))
                {
                    string reverseNumber = Reverse(number);
                    if (IsOddDigits(number + Convert.ToInt32(reverseNumber)))
                    {
                        output.Add(number);
                        output.Add(Convert.ToInt32(reverseNumber));
                    }
                }                
            }
            return output.Count;
        }
        private static bool IsOddDigits(int number)
        {
            return Regex.IsMatch(number.ToString(), @"^[13579]*$");
        }
        private static string Reverse(int Number)
        {
            return new string(Number.ToString().Reverse().ToArray());
        }
    }
}
