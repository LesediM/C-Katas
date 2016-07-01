using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_01
{
    [TestFixture]
    public class TestNumeralConverter
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void Convert_GivenSingleNumeralString_ShouldReturnDigit(string numerlalString, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numerlalString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_GivenNumeralStringCombination_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VII";
            var expected = 7;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        public void Convert_GivenSingleSubtractingNumeralString_ShouldReturnDigit(string numerlalString, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numerlalString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeralString_ShouldReturnExceptionWhenSumGreaterThan3000()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "Sum cannot be greater than 3000: MMMI";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithRepeatLimitViolated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VIIII";
            var expected = "Repeat limit violated for: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepeatLimitViolated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "CCCCVIIII";
            var expected = "Repeat limit violated for: C,I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRepeatCharsViolated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VVIII";
            var expected = "Non repeat chars violation found: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRepeatCharsViolated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "DDVVIII";
            var expected = "Non repeat chars violation found: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "DAVIII";
            var expected = "Non repeat chars violation found: A";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "DABVIII";
            var expected = "Non repeat chars violation found: A,B";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [TestCase("MMDCCLI", 2751)]
        [TestCase("CDXLVIII", 448)]
        [TestCase("CCCLXIX", 369)]
        public void Convert_GivenComplexNumeralString_ShouldReturnDigit(string numeralString, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }


        private static NumeralConverter CreateConverter()
        {
            return new NumeralConverter();
        }
    }
}
