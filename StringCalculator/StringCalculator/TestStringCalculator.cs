using System;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var expected = 0;
            var numbers = "";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_Given1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var expected = 1;
            var numbers = "1";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenTwoNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWithNewline_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1\n2,3";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWithNewDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//;1;2;3";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWithNegative_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";
            var calculator = new Calculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Exception ex = Assert.Throws<ArgumentException>(() => calculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void Add_GivenNumberStringWith1001_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1,2,3,1001";
            var calculator = new Calculator();
            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWith1000_ShouldReturn1006()
        {
            //---------------Set up test pack-------------------
            var expected = 1006;
            var numbers = "1,2,3,1000";
            var calculator = new Calculator();
            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWithLongDelimter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//***1***2***3";
            var calculator = new Calculator();
            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenNumberStringWithTwoDelimters_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//*%1*2%3";
            var calculator = new Calculator();
            //---------------Execute Test ----------------------
            var result = calculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}
