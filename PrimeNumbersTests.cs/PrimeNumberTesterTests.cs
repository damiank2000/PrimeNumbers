using NUnit.Framework;
using PrimeNumbers;

namespace PrimeNumbersTests
{
    [TestFixture]
    public class PrimeNumberTesterTests
    {
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(9, false)]
        [TestCase(11, true)]
        [TestCase(13, true)]
        [TestCase(15, false)]
        [TestCase(17, true)]
        [TestCase(19, true)]
        [TestCase(23, true)]
        [TestCase(25, false)]
        [TestCase(49, false)]
        [TestCase(121, false)]
        [TestCase(169, false)]
        public void DetectsPrimes(int number, bool expected)
        {
            var primeNumberTester = new PrimeNumberTester();

            var actual = primeNumberTester.IsPrimeNumber(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
