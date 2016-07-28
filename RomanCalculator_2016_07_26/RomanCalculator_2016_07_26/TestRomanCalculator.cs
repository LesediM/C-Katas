using System;
using NUnit.Framework;

namespace RomanCalculator_2016_07_26
{
    [TestFixture]
    public class TestRomanCalculator
    {
        [Test]
        public void Add_GivenTwoSingleRomanNumerals_ShouldConcat()
        {
            //---------------Set up test pack-------------------
            var expected = "II";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("I");
            calculator.Enter("I");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_ShouldConcatFromALargerNumeral()
        {
            //---------------Set up test pack-------------------
            var expected = "XXII";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("XX");
            calculator.Enter("II");
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("II", "II", "IV")]
        [TestCase("XX", "XX", "XL")]
        [TestCase("CC", "CC", "CD")]
        public void Add_ShouldNotRepeatMoreThanThreeTimes(string firstNumeral, string secondNumeral, string expected)
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter(firstNumeral);
            calculator.Enter(secondNumeral);
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [TestCase("V", "V", "X")]
        [TestCase("L", "L", "C")]
        [TestCase("D", "D", "M")]
        public void Add_ShouldNotRepeat(string firstNumeral, string secondNumeral, string expected)
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter(firstNumeral);
            calculator.Enter(secondNumeral);
            //---------------Execute Test ----------------------
            var results = calculator.Add();
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenOneStrangeCharactersInRomanNumeralString_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "Character is not a roman numeral: A";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("A");
            calculator.Enter("I");
            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => calculator.Add());
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }
        [Test]
        public void Add_GivenTwoStrangeCharactersInRomanNumeralString_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            var expected = "Character is not a roman numeral: A,B";
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------
            calculator.Enter("A");
            calculator.Enter("B");
            //---------------Execute Test ----------------------
            var results = Assert.Throws<ArgumentException>(() => calculator.Add());
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results.Message);
        }



        private static RomanCalculator CreateCalculator()
        {
            return new RomanCalculator();
        }
    }
}
