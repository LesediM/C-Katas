using System;
using NUnit.Framework;

namespace StringCalculator_2016_04_21
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
        public void Add_GivenSingleNumberString_ShouldReturnThatNumber()
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
        public void Add_GivenTwoNumberString_ShouldReturnSumOfNumbers()
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
        public void Add_GivenNumberStringWithNewline_ShouldReturnSumOfNumbers()
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
        public void Add_GivenNumberStringWithNewDelimter_ShouldReturnSumOfNumbers()
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
        public void Add_GivenNumberStringWithNegativeNumber_ShouldReturnThrowException()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,-2";
            var expected = "negatives not allowed: -2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers)); ;
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,results.Message);
        }
        [Test]
        public void Add_GivenNumberStringWithTwoNegativeNumbers_ShouldReturnThrowException()
        {
            //---------------Set up test pack-------------------
            var numbers = "-1,-2";
            var expected = "negatives not allowed: -1,-2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers)); ;
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,results.Message);
        }
        [Test]
        public void Add_GivenNumberStringWithNumberGreateThan1000_ShouldReturnIgnoreNumberGreaterThan1000InSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "1,2,3,1001";
            var expected = 6;
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
            var numbers = "//[***]1***2***3";
            var expected = 6;
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
        public void Add_GivenNumberStringWithManyDelimiterAndOneLong_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var numbers = "//[***][%][$]\n1***2%3$4";
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
