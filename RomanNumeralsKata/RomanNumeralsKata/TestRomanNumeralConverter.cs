using System;
using NUnit.Framework;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class TestRomanNumeralConverter
    {
        [Test]
        public void Convert_GivenEmptyNumerals_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var numerals = "";
            var expected = 0;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNonRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "Z";
            var expected = "non roman numerals not allowed: Z";
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => numeralConverter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNonRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "ZA";
            var expected = "non roman numerals not allowed: Z,A";
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => numeralConverter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenRepeatingNonRepetitiveRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "VV";
            var expected = "non repeating roman numerals repeated: V";
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => numeralConverter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyRepeatingNonRepetitiveRomanNumerals_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numerals = "VVLL";
            var expected = "non repeating roman numerals repeated: V,L";
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => numeralConverter.Convert(numerals));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenNumeral_I_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var numerals = "I";
            var expected = 1;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_V_ShouldReturnFive()
        {
            //---------------Set up test pack-------------------
            var numerals = "V";
            var expected = 5;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_X_ShouldReturnTen()
        {
            //---------------Set up test pack-------------------
            var numerals = "X";
            var expected = 10;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_L_ShouldReturnFifty()
        {
            //---------------Set up test pack-------------------
            var numerals = "L";
            var expected = 50;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_C_ShouldReturnOneHundred()
        {
            //---------------Set up test pack-------------------
            var numerals = "C";
            var expected = 100;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_D_ShouldReturnFiveHundred()
        {
            //---------------Set up test pack-------------------
            var numerals = "D";
            var expected = 500;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_M_ShouldReturnOneThousand()
        {
            //---------------Set up test pack-------------------
            var numerals = "M";
            var expected = 1000;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenNumeral_VII_ShouldReturnSeven()
        {
            //---------------Set up test pack-------------------
            var numerals = "VII";
            var expected = 7;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_IV_ShouldReturnFour()
        {
            //---------------Set up test pack-------------------
            var numerals = "IV";
            var expected = 4;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_IX_ShouldReturnNine()
        {
            //---------------Set up test pack-------------------
            var numerals = "IX";
            var expected = 9;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_XL_ShouldReturnForty()
        {
            //---------------Set up test pack-------------------
            var numerals = "XL";
            var expected = 40;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_XC_ShouldReturnNinety()
        {
            //---------------Set up test pack-------------------
            var numerals = "XC";
            var expected = 90;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_CD_ShouldReturnFourHundred()
        {
            //---------------Set up test pack-------------------
            var numerals = "CD";
            var expected = 400;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenSubtractingNumeral_CM_ShouldReturnNineHundred()
        {
            //---------------Set up test pack-------------------
            var numerals = "CM";
            var expected = 900;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Convert_GivenComplexNumeral_MCMXC_ShouldReturnNineteenNinety()
        {
            //---------------Set up test pack-------------------
            var numerals = "MCMXC";
            var expected = 1990;
            var numeralConverter = CreateNumeralConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = numeralConverter.Convert(numerals);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private static RomanNumeralConverter CreateNumeralConverter()
        {
            return new RomanNumeralConverter();
        }
    }
}
