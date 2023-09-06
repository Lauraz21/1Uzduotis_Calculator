using _1Uzduotis_Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ReturnsSum()
        {
            double num1 = 5;
            double num2 = 10;
            double expected = 15;

            double actual = Program.Add(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Minus_ReturnsSum()
        {
            double num1 = 10;
            double num2 = 2;
            double expected = 8;

            double actual = Program.Minus(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Mult_ReturnsSum()
        {

            double num1 = 2;
            double num2 = 2;
            double expected = 4;

            double actual = Program.Mult(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Div_ReturnsSum()
        {

            double num1 = 21;
            double num2 = 3;
            double expected = 7;

            double actual = Program.Div(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pow_ReturnsSum()
        {
            double num1 = 5;
            double num2 = 3;
            double expected = 125;

            double actual = Program.Pow(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sqrt_ReturnsSum()
        {
            double num1 = 9;
            double num2 = 2;
            double expected = 3;

            double actual = Program.Sqrt(num1, num2);

            Assert.AreEqual(expected, actual);
        }
    }
}