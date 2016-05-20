using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator_2016_05_20
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
        public void Add_GivenSingleNumberString_ShouldReturnSingleNumber()
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
        public void Add_GivenLargeSingleNumberString_ShouldReturnLargeSingleNumber()
        {
            //---------------Set up test pack-------------------
            var numbers = "1000";
            var expected = 1000;
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
        public void Add_GivenNegativeInNumberString_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var numbers = "2,-3";
            var expected = "negatives not allowed: -3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Add_GivenManyNegativeInNumberString_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var numbers = "-2,-3";
            var expected = "negatives not allowed: -2,-3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Add_GivenNumAbove1000InNumberString_ShouldReturnSumButIgnoreNumAbove1000()
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
        public void Add_GivenNewDelimiterInNumberString_ShouldReturnSum()
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
        public void Add_GivenNewLongDelimiterInNumberString_ShouldReturnSum()
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
        public void Add_GivenNewManyDelimiterInNumberString_ShouldReturnSum()
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
        public void Add_GivenNewManyAndLongDelimiterInNumberString_ShouldReturnSum()
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

        private static StringCalculator CreateStringCalculator()
        {
            return new StringCalculator();
        }
    }
}
