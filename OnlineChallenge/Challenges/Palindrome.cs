using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChallenge
{
    static public class Palindrome
    {
        public static void Verify(string input)
        {
            char[] inputCharacterArray = input.ToCharArray();
            string Palindrome = "palindrome";
            for(int frontTraversal = 0, rearTravesal = input.Length - 1; (frontTraversal < input.Length || rearTravesal >= 0); frontTraversal ++, rearTravesal --)
            {
                if (inputCharacterArray[frontTraversal] != inputCharacterArray[rearTravesal])
                {
                    Palindrome = "not a " + Palindrome;
                    break;
                }
            }
            Console.WriteLine("Input is {0}", Palindrome);
        }
    }
}
