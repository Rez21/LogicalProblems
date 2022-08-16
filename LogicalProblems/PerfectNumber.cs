using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class PerfectNumber
    {
        public static void GetPerfectnumber()
        {
            int n, i, sum, min, max;
            Console.WriteLine("Enter Start point number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End point number");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect number in provided range is:");
            for (n = min; n <= max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)

                        sum += i;
                    i++;


                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }
        }
    }
}
