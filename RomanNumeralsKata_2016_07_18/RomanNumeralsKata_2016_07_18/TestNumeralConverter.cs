using System;
using NUnit.Framework;

namespace RomanNumeralsKata_2016_07_18
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
        public void Convert_GivenNumeralString_ShouldReturnDigit(string numeral, int expected)
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
        public void Convert_GivenSimpleMixedNumeralString_ShouldReturnDigit()
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
        public void Convert_GivenSubtractingNumeralString_ShouldReturnDigit(string numeral, int expected)
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
        public void Convert_GivenNumeralStringWithRepitionAboveThree_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VIIIII";
            var expected = "Numerals cannot be repeated more than 3 times: I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyRepitionAboveThree_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "XXXXVIIIII";
            var expected = "Numerals cannot be repeated more than 3 times: X,I";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithNonRepeatinCharsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "VVII";
            var expected = "Numerals cannot be repeated: V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyNonRepeatinCharsRepeated_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "DDVVII";
            var expected = "Numerals cannot be repeated: D,V";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringReturnDigitAboveThreeThousand_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMI";
            var expected = "Numerals cannot be above 3000";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMZI";
            var expected = "Numerals cannot be rendered: Z";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Convert_GivenNumeralStringWithManyStrangeChars_ShouldReturnException()
        {
            //---------------Set up test pack-------------------
            var numeral = "MMMZGI";
            var expected = "Numerals cannot be rendered: Z,G";
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => converter.Convert(numeral));
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }


        [TestCase("MMDCCLI", 2751)]
        [TestCase("CDXLVIII", 448)]
        [TestCase("CCCLXIX", 369)]
        public void Convert_GivenNumeralStringWithComplexCombination_ShouldReturnDigit(string numeral, int expected)
        {
            //---------------Set up test pack-------------------
            var converter = CreateConverter();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = converter.Convert(numeral);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private static NumeralConverter CreateConverter()
        {
            return new NumeralConverter();
        }
    }
}
