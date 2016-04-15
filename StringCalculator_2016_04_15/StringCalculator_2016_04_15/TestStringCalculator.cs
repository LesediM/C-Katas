using System;
using NUnit.Framework;

namespace StringCalculator_2016_04_15
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
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithOneNumber_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var expected = 1;
            var numbers = "1";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithTwoNumbers_ShouldReturn3()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "1,2";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNewlines_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1\n2,3";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNewDelimter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//;1;2;3";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNewDelimterAndNewline_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 3;
            var numbers = "//;\n1;2";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNegative_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Exception ex = Assert.Throws<ArgumentException>(() => stringcalculator.Add(numbers));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void Add_GivenStringWithNumberAbove1000_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "1,2,3,1001";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumberBelowOrEqual1000_ShouldReturn1006()
        {
            //---------------Set up test pack-------------------
            var expected = 1006;
            var numbers = "1,2,3,1000";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithLongDelimiter_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[***]1***2***3";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithMultipleDelimters_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 6;
            var numbers = "//[*][%]1*2%3";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithMultipleAndOneLongDelimters_ShouldReturn6()
        {
            //---------------Set up test pack-------------------
            var expected = 10;
            var numbers = "//[*][%][$$$]1*2%3,$$$4";
            var stringcalculator = new StringCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = stringcalculator.Add(numbers);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
