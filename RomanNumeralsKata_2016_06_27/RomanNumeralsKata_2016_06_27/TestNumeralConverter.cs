using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_06_27
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
        [Test]
        public void Convert_GivenSingleNumeralString_I_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var numeralString = "I";
            var expected = 1;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_X_ShouldReturnTen()
        {
            //---------------Set up test pack-------------------
            var numeralString = "X";
            var expected = 10;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_V_ShouldReturnFive()
        {
            //---------------Set up test pack-------------------
            var numeralString = "V";
            var expected = 5;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_L_ShouldReturnFifty()
        {
            //---------------Set up test pack-------------------
            var numeralString = "L";
            var expected = 50;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_C_ShouldReturnOneHundred()
        {
            //---------------Set up test pack-------------------
            var numeralString = "C";
            var expected = 100;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_D_ShouldReturnFiveHundred()
        {
            //---------------Set up test pack-------------------
            var numeralString = "D";
            var expected = 500;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSingleNumeralString_M_ShouldReturnOneThousand()
        {
            //---------------Set up test pack-------------------
            var numeralString = "M";
            var expected = 1000;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNonRomanNumeralsInString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "Z";
            var expected = "non roman numerals not allowed: Z";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNonRomanNumeralsInString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "ZA";
            var expected = "non roman numerals not allowed: Z,A";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNonRepeatingRepeatedNumeralsInString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VV";
            var expected = "non repeating numerals repeating not allowed: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNonRepeatingRepeatedNumeralsInString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VVLL";
            var expected = "non repeating numerals repeating not allowed: V,L";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralString_VII_ShouldReturnSeven()
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
        public void Convert_GivenNumeralStringWithSubtractingNumerals_ShouldReturnConversion()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IV";
            var expected = 4;
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [TestCase("IX", 9)]
        [TestCase("XL", 40)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("CM", 900)]
        public void Convert_GivenNumeralStringWithAnySubtractingNumerals_ShouldReturnConversion(string numeralString, int expected)
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
        public void Convert_GivenRepeatingRepeatedMoreThanThreeTimes_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IIII";
            var expected = "repeating numerals repeating more than 3 times: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyRepeatingRepeatedMoreThanThreeTimes_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "XXXXIIII";
            var expected = "repeating numerals repeating more than 3 times: I,X";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }


        [TestCase("MMDCCLI", 2751)]
        [TestCase("CDXLVIII", 448)]
        public void Convert_GivenComplexNumeralString_ShouldReturnConversion(string numeralString, int expected)
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