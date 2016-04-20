using System;
using NUnit.Framework;

namespace StringCalculator_2016_04_20
{
    [TestFixture]
    public class TestStringCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var expected = 0;
            var numbers = "";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenStringWithOneNumber_ShouldReturnThatNumber()
        {
            //---------------Set up test pack-------------------
            var expected = 1;
            var numbers = "1";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenStringWithTwoNumber_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithMultipleNumbers_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1,2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithNewlineChar_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1\n2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithChangeOfDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "//;\n1;2";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenStringWithNegativeNumber_ShouldThrowNegativeNumberException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ArgumentException>(() => stringcalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result.Message);
        }
        [Test]
        public void Add_GivenStringWithMultipleNegativeNumbers_ShouldThrowNegativeNumberException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2,-3";
            var numbers = "1,-2,-3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = Assert.Throws<ArgumentException>(() => stringcalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result.Message);
        }

        [Test]
        public void Add_GivenStringWithNumberGreaterThan1000_ShouldIgnore1000InCalculation()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2,1001";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Add_GivenStringWithNumberLessThanEqualTo1000_ShouldInclude1000InCalculation()
        {
            //---------------Set up test pack-------------------
            var expected = 1003;
            var numbers = "1,2,1000";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithLongDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[***]1***2***3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithMultipleDelimiters_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[*][%]\n1*2%3";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithMultipleDelimitersAndOneLongDelimiter_ShouldReturnSum()
        {
            //---------------Set up test pack-------------------
            var expected = 10;
            var numbers = "//[***][$][%]\n1*2%3$4";
            var stringcalculator = CreateStringcalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private StringCalculator CreateStringcalculator()
        {
            return new StringCalculator();
        }
    }
}
