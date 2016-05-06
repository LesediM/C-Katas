using System;
using NUnit.Framework;

namespace StringCalculator_2016_05_06
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var numbers = "";
            var expected = 0;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenSingleNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1";
            var expected = 1;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenTwoNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,2";
            var expected = 3;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenManyNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,2,3";
            var expected = 6;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNewlineNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1\n2,3";
            var expected = 6;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNegativeNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,-2";
            var expected = "negatives not allowed: -2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws< ArgumentException > (() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenManyNegativeNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "-1,-2";
            var expected = "negatives not allowed: -1,-2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws< ArgumentException > (() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenNewDelimiterNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//;\n1;2";
            var expected = 3;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWith1001_ShouldReturnSumIgnore1001()
        {
            //---------------Set up test pack-------------------
            var numbers = "1001,2";
            var expected = 2;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNewLongDelimiterNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//[***]\n1***2***3";
            var expected = 6;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenManyNewDelimiterNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//[*][%]\n1*2%3";
            var expected = 6;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenManyAndLongNewDelimiterNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//[*][%][$$$]\n1*2%3$$$4";
            var expected = 10;
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private StringCalculator CreateStringCalculator()
        {
            return new StringCalculator();
        }
    }
}
