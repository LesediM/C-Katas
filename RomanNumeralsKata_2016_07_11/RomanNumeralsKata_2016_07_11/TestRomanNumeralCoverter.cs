using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_11
{
    [TestFixture]
    public class TestRomanNumeralCoverter
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
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSimpleMixedNumeral_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeral = "VII";
            var expected = 7;
            var converter = CreateCoverter();
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
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Convert_ShouldReturnExceptionIfDigitIsGreaterThan3000()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMI";
            var expected = "Numeral cannot be greater than 3000";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenSingleNumeralWithRepeatLimitViolation_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VIIII";
            var expected = "Numeral cannot be repeated more than 3 times: I";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenManyNumeralWithRepeatLimitViolation_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMMVIIII";
            var expected = "Numeral cannot be repeated more than 3 times: M,I";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenSingleNumeralWithNonRepeatCharViolation_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VVIII";
            var expected = "Numeral cannot be repeated: V";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNumeralsWithNonRepeatCharViolation_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "LLVVIII";
            var expected = "Numeral cannot be repeated: L,V";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenSingleNumeralWithStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "ZVIII";
            var expected = "Character is not a roman numeral: Z";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNumeralWithStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "SZVIII";
            var expected = "Character is not a roman numeral: S,Z";
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }


        [TestCase("CCCLXIX", 369)]
        [TestCase("MCMXCVIII", 1998)]
        public void Convert_GivenComplexNumerals_ShouldReturnDigit(string numeral, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateCoverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private static RomanNumeralCoverter CreateCoverter()
        {
            return new RomanNumeralCoverter();
        }
    }
}
