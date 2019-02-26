using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChallenge
{
    static public class NineSeriesSum
    {
        public static void Create(int itemCount)
        {
            double SeriesSum = 0;
            for(double item = 1; item <= itemCount; item++)
            {
                SeriesSum = SeriesSum + (Math.Pow(10, item) - 1);
            }
            Console.WriteLine(SeriesSum);
        }
    }
}
