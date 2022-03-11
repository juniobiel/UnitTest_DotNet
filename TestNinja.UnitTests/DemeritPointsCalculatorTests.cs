using NUnit.Framework;
using TestNinja.Fundamentals;
using System;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsLessThanZero_ReturnOutOfRangeException()
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsGreaterThanMaxSpeed_ReturnOutOfRangeException()
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedIsEqualOrLessThanSpeedLimit_ReturnZero()
        {
            var result = _calculator.CalculateDemeritPoints(50);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(64, 0)]
        [TestCase(70, 1)]
        [TestCase(90, 5)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expected)
        {
            var result = _calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
