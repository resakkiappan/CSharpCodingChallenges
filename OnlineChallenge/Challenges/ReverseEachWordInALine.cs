using System.Linq;
using System.Text.RegularExpressions;

namespace OnlineChallenge
{
    static public class ReverseEachWordInALine
    {
        public static string Reverse(string str)
        {
            return Regex.Replace(str, @"[^\s]+", m => new string(m.Value.Reverse().ToArray()));
        }
    }
}
