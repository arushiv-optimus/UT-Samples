﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTSampleCode;

namespace UTSampleCodeTest
{
    [TestClass]
   public class PositiveandNegativeCaseTest
    {
        // Inside if loop
        [TestMethod]
        public void TestIsPrimeWith0And1()
        {
            PositiveAndNegativeCase positiveAndNegativeCase = new PositiveAndNegativeCase();
            bool expectedResult = true;

            //Act
            bool actualResult = positiveAndNegativeCase.IsPrime(1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Inside if - for - if loop
        [TestMethod]
        public void TestIsPrimeWithFalsePrimeValue()
        {
            PositiveAndNegativeCase positiveAndNegativeCase = new PositiveAndNegativeCase();
            bool expectedResult = false;

            //Act
            bool actualResult = positiveAndNegativeCase.IsPrime(12);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Inside if - for loop
        [TestMethod]
        public void TestIsPrimeWithTruePrimeValue()
        {
            PositiveAndNegativeCase positiveAndNegativeCase = new PositiveAndNegativeCase();
            bool expectedResult = true;

            //Act
            bool actualResult = positiveAndNegativeCase.IsPrime(7);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        // Inside else loop
        [TestMethod]
        public void TestIsPrimeWithNegativeValue()
        {
            PositiveAndNegativeCase positiveAndNegativeCase = new PositiveAndNegativeCase();
            bool expectedResult = false;

            //Act
            bool actualResult = positiveAndNegativeCase.IsPrime(-10);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

    [TestClass]
    public class ExceptionHandlingCaseTest
    {
        [TestMethod]
        public void TestDivide()
        {
            try
            {
                ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
                int numerator = 4;
                int denominator = 0;
                int actualResult;

                //Act
                actualResult = exceptionHandlingCase.Divide(numerator, denominator); // this will throw DivideByZeroException
            }
            catch (Exception e)
            {
                //Assert
                throw new AssertFailedException(e.Message, e);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TestDivideWithDivideByZeroException()
        {
            ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
            int numerator = 4;
            int denominator = 0;
            int actualResult;

            actualResult = exceptionHandlingCase.Divide(numerator, denominator);
        }

        [TestMethod]
        public void TestSmallest()
        {
            ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
            int[] arr = { 12,6,8,1,7,9,23 };
            int expectedValue = 1;

            //Act
            int actualValue = exceptionHandlingCase.Smallest(arr);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TestSmallestWithSizeZero()
        {
            ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
            int[] arr = { 12 };
            int expectedValue = 12;

            //Act
            int actualValue = exceptionHandlingCase.Smallest(arr);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestSmallestWithNullReferenceException()
        {
            ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
            int[] arr = null;

            //Act
            int actualValue = exceptionHandlingCase.Smallest(arr);

        }

        [TestMethod]
        public void TestSmallestWithNullValue()
        {
            try
            {
                ExceptionHandlingCase exceptionHandlingCase = new ExceptionHandlingCase();
                int[] arr = null;

                //Act
                int actualValue = exceptionHandlingCase.Smallest(arr);
            }
            catch (Exception e)
            {
                //Assert
                throw new AssertFailedException(e.Message, e);
            }

        }
    }
}
