using System;
using NUnit.Framework;

namespace StringKata_2016_04_13
{
    [TestFixture]
    public class TestStringCalculator
    {
        private StringCalculator _stringcalculator;

        [SetUp]
        public void Init()
        {
            _stringcalculator = new StringCalculator();
        }

        [Test]
        public void AddNumbers_GivenEmptyString_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var expected = 0;
            var numberstring = "";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_Given1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var expected = 1;
            var numberstring = "1";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenTwoNumbers_ShouldReturn3()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numberstring = "1,2";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithNewLineCharacter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "1\n2,3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithNewDelimiter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "//;1;2;3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithNewDelimiterAndNewline_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "//;\n1;2;3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithNegative_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numberstring = "1,-2,3";

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _stringcalculator.AddNumbers(numberstring));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithTwoNegatives_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2,-3";
            var numberstring = "1,-2,-3";

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Exception ex = Assert.Throws(typeof(ArgumentException), () => _stringcalculator.AddNumbers(numberstring));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWith1001_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "1,2,3,1001";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWith1000_ShouldReturn1006()
        {
            //---------------Set up test pack-------------------
            var expected = 1006;
            var numberstring = "1,2,3,1000";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithLongDelimiter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "//***1***2***3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void AddNumbers_GivenNumberStringWithTwoDelimiters_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numberstring = "//*%1*2%3";
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = _stringcalculator.AddNumbers(numberstring);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
