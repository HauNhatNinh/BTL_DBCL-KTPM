using NUnit.Framework;
using System;

namespace CSharp_Demo
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        public void Add_WithVariousInputs_ReturnsCorrectSum(int a, int b, int expected)
        {
            var result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _calculator.Divide(10, 0));
        }
    }
}
