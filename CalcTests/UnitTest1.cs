using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcAssignmentNET;

namespace CalcTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            double num1 = 3;
            double num2 = 8;
            double expected = 11;

            double actual = Calculator.Add(num1, num2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtract()
        {
            double num1 = 8;
            double num2 = 3;
            double expected = 5;

            double actual = Calculator.Subtract(num1, num2);

            Assert.AreEqual(expected, actual);
        }
    }
}
