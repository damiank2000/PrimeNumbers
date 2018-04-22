using PrimeNumbers;
using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeNumberTester = new PrimeNumberTester();

            for(int f=0; f <= 100000; f++)
            {
                if (primeNumberTester.IsPrimeNumber(f))
                {
                    Console.WriteLine(f);
                }
            }

            Console.WriteLine("Press ENTER to end");
            Console.ReadLine();
        }
    }
}
