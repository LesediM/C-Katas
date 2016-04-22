using System;
using NUnit.Framework;

namespace StringCalculator_2016_04_22
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyNumberString_ShouldReturnZero()
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
        public void Add_GivenSingleNumberString_ShouldReturnThatNumber()
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
        public void Add_GivenNumberStringWithNewline_ShouldReturnSum()
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
        public void Add_GivenNumberStringWithNewDelimiter_ShouldReturnSum()
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
        public void Add_GivenNumberStringWithNegativeNumber_ShouldThrowNoNegativeException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenNumberStringWithManyNegativeNumbers_ShouldThrowNoNegativeException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -1,-2";
            var numbers = "-1,-2";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => stringCalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenNumberStringWithNumberGreateThan1000_ShouldReturnSumWithOut1000InCalculation()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2,1001";
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
            var expected = 6;
            var numbers = "//[***]1***2***3";
            var stringCalculator = CreateStringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringCalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Add_GivenNumberStringWithManyDelimiters_ShouldReturnSum()
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
        public void Add_GivenNumberStringWithManyDelimitersAndOneLong_ShouldReturnSum()
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
