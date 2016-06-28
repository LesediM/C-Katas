using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_06_28
{
    [TestFixture]
    public class TestNumeralConverter
    {
        [Test]
        public void Convert_GivenEmptyNumeralString_ShouldReturnZero()
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
        public void Convert_GivenSingleNumeralStringWithSubtractingNumerals_ShouldReturnDigit(string numeralString, int expected)
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
        public void Convert_GivenNumeralStringResultsExceed3000_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "Results exceed 3000";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "ZZ";
            var expected = "Non roman numerals detected: Z";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "ZZGG";
            var expected = "Non roman numerals detected: Z,G";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRepeatingRomanNumeralsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VV";
            var expected = "Non repeating numerals repeating detected: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRepeatingRomanNumeralsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VVDD";
            var expected = "Non repeating numerals repeating detected: V,D";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithRepetitionsExceeding3_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IIII";
            var expected = "Numerals repeating more than 3 times detected: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepetitionsExceeding3_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IIIIXXXX";
            var expected = "Numerals repeating more than 3 times detected: I,X";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenComplexNumeralString_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeralString = "CCCLXIX";
            var expected = 369;
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
