namespace PrimeNumbers
{
    public static class IntExtensions
    {
        public static bool IsFactorOf(this int candidate, int number)
        {
            return number % candidate == 0;
        }
    }

}