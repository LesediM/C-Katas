using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NumeralConverter
{
    [TestFixture]
    class NumeralConverterTest
    {
        [Test]
        public void GetDigit_GivenEmptyNumeral_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var numeralString = "";
            var expected = 0;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenUnknownNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "A";
            var expected = "Invalid numeral: A";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenAnyUnknownNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "Z";
            var expected = "Invalid numeral: Z";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenNonRepeatingNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "LL";
            var expected = "Non repeating numerals found: L";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenAnyNonRepeatingNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "DD";
            var expected = "Non repeating numerals found: D";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenManyNonRepeatingNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "DDLL";
            var expected = "Non repeating numerals found: D,L";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenNumeralI_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var numeralString = "I";
            var expected = 1;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralII_ShouldReturnTwo()
        {
            //---------------Set up test pack-------------------
            var numeralString = "II";
            var expected = 2;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralIII_ShouldReturnThree()
        {
            //---------------Set up test pack-------------------
            var numeralString = "III";
            var expected = 3;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralX_ShouldReturnTen()
        {
            //---------------Set up test pack-------------------
            var numeralString = "X";
            var expected = 10;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralVII_ShouldReturnSeven()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VII";
            var expected = 7;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralL_ShouldReturnFifty()
        {
            //---------------Set up test pack-------------------
            var numeralString = "L";
            var expected = 50;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralC_ShouldReturnAHundred()
        {
            //---------------Set up test pack-------------------
            var numeralString = "C";
            var expected = 100;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralD_ShouldReturnFiveHundred()
        {
            //---------------Set up test pack-------------------
            var numeralString = "D";
            var expected = 500;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralM_ShouldReturnOneThousand()
        {
            //---------------Set up test pack-------------------
            var numeralString = "M";
            var expected = 1000;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralMMM_ShouldReturnThreeThousand()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMM";
            var expected = 3000;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralMMMI_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "Digits cannot exceed 3000";
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => converterTest.GetDigit(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void GetDigit_GivenNumeralWithSubtractingNumeralIV_ShouldReturnFour()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IV";
            var expected = 4;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralWithSubtractingNumeralIX_ShouldReturnNine()
        {
            //---------------Set up test pack-------------------
            var numeralString = "IX";
            var expected = 9;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [TestCase("IX",9)]
        [TestCase("XL",40)]
        [TestCase("XC",90)]
        [TestCase("CD",400)]
        [TestCase("CM",900)]
        public void GetDigit_GivenNumeralWithAnySubtractingNumeral_ShouldReturnDigit(string numeralString, int expected)
        {
            //---------------Set up test pack-------------------
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralWithDifferentNumeralsCCCLXIX_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeralString = "CCCLXIX";
            var expected = 369;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GetDigit_GivenNumeralWithDifferentNumeralsMMDCCLI_ShouldReturnDigit()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMDCCLI";
            var expected = 2751;
            var converterTest = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converterTest.GetDigit(numeralString);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private static NumeralsConverter CreateConverter()
        {
            return new NumeralsConverter();
        }
    }
}
