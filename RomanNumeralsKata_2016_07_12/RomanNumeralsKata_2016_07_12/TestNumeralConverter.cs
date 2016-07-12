using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_12
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
        public void Convert_GivenSingleNumeral_ShouldReturnDigit(string numeral, int expected)
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
        public void Convert_GivenNumerals_ShouldDigit()
        {
            //---------------Set up test pack-------------------
            var numerals = "VII";
            var expected = 7;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        public void Convert_GivenSingleSuibtractingNumeral_ShouldReturnDigit(string numeral, int expected)
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
        public void Convert_GivenMethodReturnsResultsGreaterThan3000_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "MMMI";
            var expected = "Numeral sum cannot exceed 3000";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }

        [Test]
        public void Convert_GivenSingleNumeralsRepeatingMoreThan3Times_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "VIIII";
            var expected = "Numeral cannot repeat more than 3 times: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }
        [Test]
        public void Convert_GivenManyNumeralsRepeatingMoreThan3Times_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "XXXXXVIIII";
            var expected = "Numeral cannot repeat more than 3 times: X,I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }

        [Test]
        public void Convert_GivenSingleStaticNumeralsRepeating_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "VVIII";
            var expected = "Numeral cannot be repeated: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }
        [Test]
        public void Convert_GivenManyStaticNumeralsRepeating_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "DDVVIII";
            var expected = "Numeral cannot be repeated: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }
        [Test]
        public void Convert_GivenSingleStrangeNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "SVIII";
            var expected = "Character is not roman numeral: S";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }
        [Test]
        public void Convert_GivenManyStrangeNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "STVIII";
            var expected = "Character is not roman numeral: S,T";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var exception = Assert.Throws<ArgumentException>(() => converter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, exception.Message);
        }

        private static NumeralConverter CreateConverter()
        {
            return new NumeralConverter();
        }
    }
}
