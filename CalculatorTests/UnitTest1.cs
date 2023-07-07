namespace CalculatorTests
{

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return a / b;
        }
    }




    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 7;
            int expectedResult = 12;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Subtract_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 10;
            int b = 3;
            int expectedResult = 7;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Multiply_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 4;
            int b = 6;
            int expectedResult = 24;

            // Act
            int result = calculator.Multiply(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 20;
            int b = 5;
            int expectedResult = 4;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 10;
            int b = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }

}