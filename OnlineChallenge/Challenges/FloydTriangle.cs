using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChallenge
{
    /*
    1 
    01
    101 
    0101 
    10101 
     */
    static public class FloydTriangle
    {
        public static void Create(int rowCount)
        {
            string previous = string.Empty;
            for(int row = 1; row <= rowCount; row++)
            {
                previous = (row % 2).ToString() + previous;
                Console.WriteLine(previous);
            }
        }
    }
}
