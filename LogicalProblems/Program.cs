namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            Console.WriteLine("Enter a number to select problem");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("4. Reverse Number");
            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 1:
                    FibonacciSeries.Fibonacci();
                    break;

                case 2:
                    PerfectNumber.GetPerfectnumber();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.FindPrime();
                    break;
                case 4:
                    ReverseNumber.FindReverse();
                    break;
            }
        }
    }
}