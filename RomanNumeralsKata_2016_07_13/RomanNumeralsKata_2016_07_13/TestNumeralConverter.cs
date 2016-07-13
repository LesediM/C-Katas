using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_13
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

        [TestCase("VII", 7)]
        public void Convert_GivenNumeralStringWithNoSubtractingNumerals_ShouldReturnDigit(string numeral, int expected)
        {
            //---------------Set up test pack-------------------
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
        public void Convert_GivenNumeralStringWithSubtractingNumerals_ShouldReturnDigit(string numeral, int expected)
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
        public void Convert_GivenNumeralStringWithStrangeCharacter_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "AVII";
            var expected = "Character is not a numeral: A";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyStrangeCharacters_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "AVIIB";
            var expected = "Character is not a numeral: A,B";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRepeatableRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VVII";
            var expected = "Numeral not allowed to repeat: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRepeatableRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "DDVVII";
            var expected = "Numeral not allowed to repeat: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithRepeatablesRepeatingMoreThan3Times_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VIIII";
            var expected = "Numeral not allowed to repeat more than 3 times: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepeatablesRepeatingMoreThan3Times_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "CCCCVIIII";
            var expected = "Numeral not allowed to repeat more than 3 times: C,I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithResultsGreaterThan3000_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMI";
            var expected = "Numeral not allowed to return greater than 3000";
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
