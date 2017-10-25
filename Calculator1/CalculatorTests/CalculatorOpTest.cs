using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    [TestClass]
   public class CalculatorOpTest
    {
        [TestMethod]
        public void Test_Add()
        {
            CalculatorOp cal = new CalculatorOp();
            int result = cal.Add(5, 4);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void Test_Mul()
        {
            CalculatorOp cal = new CalculatorOp();
            int result = cal.Mul(5, 4);
            Assert.AreEqual(20, result);
        }
    }
}
