using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_06_24
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
        public void Convert_GivenNonRomanNumeralString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "A";
            var expected = "non roman numeral character found: A";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNonRomanNumeralString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "ZK";
            var expected = "non roman numeral character found: Z,K";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNonRepeatingNumeralsInNumeralString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VV";
            var expected = "non repeating numerals character: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenManyNonRepeatingNumeralsInNumeralString_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "VVDD";
            var expected = "non repeating numerals character: V,D";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
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
        public void Convert_GivenMixedNumeralString_VII_ShouldReturnSeven()
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
        public void Convert_GivenValidNumeralString_MMMI_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeralString = "MMMI";
            var expected = "sum exceeds 3000";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ApplicationException>(() => converter.Convert(numeralString));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Convert_GivenSubtractingNumeralString_IV_ShouldReturnFour()
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

        [Test]
        public void Convert_GivenNumeralString_MCMXC_ShouldReturnNineteenNinety()
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
