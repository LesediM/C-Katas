using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_06
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
        public void Convert_GivenSingleNumerals_ShouldReturnDigit(string numeral, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_GivenAdditionNumerals_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeral = "VII";
            var expected = 7;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        public void Convert_GivenSingleSubtractingNumerals_ShouldReturnDigit(string numeral, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_GivenNumeralsViolatingMaxRepeatCount_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VIIII";
            var expected = "Numerals cannot repeat more than 3 times: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNumeralsViolatingMaxRepeatCount_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMMVIIII";
            var expected = "Numerals cannot repeat more than 3 times: M,I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralsViolatingRepeatRule_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MVVI";
            var expected = "Numerals cannot repeat: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNumeralsViolatingRepeatRule_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MDDVVI";
            var expected = "Numerals cannot repeat: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenNumeralsWithStrangeCharacters_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MDH";
            var expected = "Unknown numerals: H";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralsWithManyStrangeCharacters_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MDHS";
            var expected = "Unknown numerals: H,S";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }[Test]
        public void Convert_GivenNumeralStringSumExceeds3000_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMI";
            var expected = "Sum of numerals exceeds 3000: MMMI";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        private static NumeralConverter CreateConverter()
        {
            return new NumeralConverter();
        }
    }
}
