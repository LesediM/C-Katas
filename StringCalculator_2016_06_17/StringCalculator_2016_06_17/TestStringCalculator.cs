using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringCalculator_2016_06_17

{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyNumberString_ShouldReturnZero()
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
        public void Add_GivenSingleLargeNumberString_ShouldReturnSingleLargeNumber()
        {
            //---------------Set up test pack-------------------
            var numbers = "100";
            var expected = 100;
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
        public void Add_GivenNewlineCharacterInNumberString_ShouldReturnSum()
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
        public void Add_GivenNewdelimiterInNumberString_ShouldReturnSum()
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
        public void Add_GivenNegativeInNumberString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,-2";
            var expected = "negatives not allowed: -2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        } [Test]
        public void Add_GivenManyNegativeInNumberString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,-2,-3";
            var expected = "negatives not allowed: -2,-3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenNumAbove1000InNumberString_ShouldReturnSumWithIgnoredNumAbove1000()
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
        public void Add_GivenNewDifferentDelimitersInNumberString_ShouldReturnSum()
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
        public void Add_GivenNewManyDifferentDelimitersInNumberString_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//[*][%][^^^]\n1*2%3^^^4";
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
