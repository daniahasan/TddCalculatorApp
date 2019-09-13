using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnPositiveOnAddingTwoNumbers()
        {
            Calculator testcalculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int result;
            result = testcalculator.Add(num1, num2);
            Assert.AreEqual(5, result, "Testing two integers 3 and 2");
        }
    }
}
