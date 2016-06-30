using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_06_30
{
    [TestFixture]
    public class TestNumeralConverter
    {
        [Test]
        public void Convert_GivenEmptyOrNullNumeralString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var numeralString = "";
            var expected = 0;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void Convert_GivenSingleNumeralString_ShouldReturnDigit(string numeralString, int expected)
        {
            //---------------Set up test pack-------------------
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
        public void Convert_GivenSingleSubtractingNumeralString_ShouldReturnDigit(string numeralString, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_GivenMixedNumeralString_ShouldReturnDigit()
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
        [Test]
        public void Convert_GivenNumeralStringOutcomeGreaterThan3000_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "Resulting digit will be greater than 3000: MMMI";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithInvalidNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VO";
            var expected = "Invalid numerals found: O";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyInvalidNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VOY";
            var expected = "Invalid numerals found: O,Y";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNumeralsViolatingRepeatCount_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VIIII";
            var expected = "Numerals exceeding repeat count of 3 found: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenNumeralStringWithManyNumeralsViolatingRepeatCount_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "XXXXVIIII";
            var expected = "Numerals exceeding repeat count of 3 found: I,X";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRepeatableNumeralsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "CDD";
            var expected = "Non repeatable numerals repeated: D";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRepeatableNumeralsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "CDDVV";
            var expected = "Non repeatable numerals repeated: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [TestCase("CDXLVIII", 448)]
        [TestCase("MMDCCLI", 2751)]
        public void Convert_GivenNumeralString_ShouldReturnDigit(string numeralString, int expected)
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
