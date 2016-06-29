using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_06_29
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
        public void Convert_GivenNumeralStringResultsGreaterThanThreeThousand_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "Results cannot be greater than 3000";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithRepititionsGreaterThanThree_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IIII";
            var expected = "Repititions of numerals cannot be greater than 3: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepititionsGreaterThanThree_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IIIIXXXX";
            var expected = "Repititions of numerals cannot be greater than 3: I,X";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }


        [Test]
        public void Convert_GivenNumeralStringWithRepititionsOfNonRepeatable_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VV";
            var expected = "Repititions of non repeatable numerals not allowed: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepititionsOfNonRepeatable_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VVDD";
            var expected = "Repititions of non repeatable numerals not allowed: V,D";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenNumeralStringWithStrangeNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "A";
            var expected = "Strange numerals not allowed: A";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyStrangeNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "ABG";
            var expected = "Strange numerals not allowed: A,B,G";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenNumeralStringMCMXC_ShouldReturnDigit1990()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MCMXC";
            var expected = 1990;
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
