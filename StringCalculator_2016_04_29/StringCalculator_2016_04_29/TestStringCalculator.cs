using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator_2016_04_29
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyNumberString_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var expected = 0;
            var numbers = "";
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
            var expected = 1;
            var numbers = "1";
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
            var expected = 3;
            var numbers = "1,2";
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
            var expected = 6;
            var numbers = "1,2,3";
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
            var expected = 6;
            var numbers = "1\n2,3";
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
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenManyNegativeNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2,-3";
            var numbers = "1,-2,-3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Add_GivenNumberStringWith1001_ShouldReturnSumButIgnoreNumbersAbove1000()
        {
            //---------------Set up test pack-------------------
            var expected = 2;
            var numbers = "1001,2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWithNewdelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "//;\n1;2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWithLongDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "//[***]\n1***2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWithManyDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[*][%]\n1*2%3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWithManyAndOneLongDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 10;
            var numbers = "//[*][%][$$$]\n1*2%3$$$4";
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
