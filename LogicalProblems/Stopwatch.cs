using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Stopwatch
    {
        public static void PlayStopWatch()
        {
            Console.WriteLine("Press Enter for Start stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("Press Enter to stop the stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elapsed time =" + (stop - start));
        }
    }
}
