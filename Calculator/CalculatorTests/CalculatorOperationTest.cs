using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
   public class CalculatorOperationTest
    {
        [TestMethod]
        public void TestAdd()
        {
            CalculatorOperation cal = new CalculatorOperation();
            int result = cal.Add(5, 4);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            CalculatorOperation cal = new CalculatorOperation();
            int result = cal.Multiply(5, 4);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TestDivide()
        {
            CalculatorOperation cal = new CalculatorOperation();
            int numerator = 4;
            int denominator = 0;
            int actualResult;
            actualResult = cal.Divide(numerator, denominator);
        }

        //[TestMethod]
        //public void TestDivide()
        //{
        //    try
        //    {
        //        CalculatorOperation cal = new CalculatorOperation();
        //        int numerator = 4;
        //        int denominator = 0;
        //        int actualResult;
        //        actualResult = cal.Divide(numerator, denominator); // this will throw DivideByZeroException
        //    }
        //    catch (Exception e)
        //    {
        //        throw new AssertFailedException(e.Message, e);
        //    }
        //}

    }
}
