using System;
using System.Linq;

namespace PrimeNumbers
{
    public class PrimeNumberTester
    {
        public bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;

            var potentialFactors = Enumerable.Range(2, (number - 2));

            foreach (var potentialFactor in potentialFactors)
            {
                if (potentialFactor != number 
                    && potentialFactor.IsFactorOf(number)) return false;
            }

            return true;
        }
    }

}