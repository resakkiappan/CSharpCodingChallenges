using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChallenge
{
    static public class NumberToWord
    {
        private static Dictionary<int, string> dictTextNumbers = new Dictionary<int, string>()
        {
            {1, "One" }, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, {10, "Ten"},
            {11, "Eleven" }, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"},
            {20, "Twenty" }, {30, "Thrity"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"}, {70, "Seventy"}, {80, "Eighty"}, {90, "Ninty"}, {100, "Hundred"},
            {1000, "Thousand" }, {1000000, "Million"}, {1000000000, "Billion"}
        };
        private static string FindTextByNumber(int number)
        {
            string returnValue = string.Empty;
            dictTextNumbers.TryGetValue(number, out returnValue);
            return returnValue;
        }

        public static string Convert(int number)
        {
            string text = FindTextByNumber(number);
            if (string.IsNullOrEmpty(text))
            {
                switch (number.ToString().ToCharArray().Length)
                {
                    case 2:
                        return Convert(((int)number / 10) * 10) + Convert((int)number % 10);
                    case 3:
                        return Convert((int)number / 100) + Convert(100) + Convert((int)number % 100);
                    case 4:
                    case 5:
                    case 6:
                        return Convert((int)number / 1000) + Convert(1000) + Convert((int)number % 1000);
                    case 7:
                    case 8:
                    case 9:
                        return Convert((int)number / 1000000) + Convert(1000000) + Convert((int)number % 1000000);
                    default:
                        return string.Empty;
                }
            }
            return text;
        }
    }
}
