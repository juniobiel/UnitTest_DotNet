using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_NumberIsNotDivisibleByThreeOrFive_ResturnTheSameNumber()
        {
            var result = FizzBuzz.GetOutput(2);

            Assert.That(result, Does.Match("2"));
        }


        [Test]
        public void GetOutput_NumberIsDivisibleByThree_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Does.Match("Fizz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleByFive_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Does.Match("Buzz"));
        }

        [Test]
        public void GetOutput_NumberIsDivisibleByThreeAndFive_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Does.Match("FizzBuzz"));
        }

    }
}
