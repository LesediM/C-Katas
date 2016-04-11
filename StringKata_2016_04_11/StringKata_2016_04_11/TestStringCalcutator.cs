using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringKata_2016_04_11
{
    [TestFixture]
    public class TestStringCalcutator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            var expected = 0;
            var numbers = "";

            var results = CreateCalculator().Add(numbers);
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithOne_ShouldReturn1()
        {
            var expected = 1;
            var numbers = "1";

            var results = CreateCalculator().Add(numbers);
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithTwoNumbers_ShouldReturnSum()
        {
            var expected = 3;
            var numbers = "1,2";

            var results = CreateCalculator().Add(numbers);
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersAndNewLine_ShouldReturnSum()
        {
            var expected = 6;
            var numbers = "1\n2,3";

            var results = CreateCalculator().Add(numbers);
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersAndNewDelimiter_ShouldReturnSum()
        {
            var expected = 6;
            var numbers = "//;1;2,3";

            var results = CreateCalculator().Add(numbers);
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersContainingNegative_ShouldReturnSum()
        {
            var expected = "negatives not allowed: -3";
            var numbers = "1,2,-3";

            var ex = Assert.Throws<ArgumentException>(() => CreateCalculator().Add(numbers));

            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void Add_GivenStringWithNumbersContaining1001_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "1,2,3,1001";

            var results = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersContaining1000_ShouldReturn1006()
        {
            var expected = 1006;
            var numbers = "1,2,3,1000";

            var results = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersContainingLongDelimiter_ShouldReturn1006()
        {
            var expected = 6;
            var numbers = "//***1***2***3";

            var results = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNumbersContaining2Delimiters_ShouldReturn1006()
        {
            var expected = 6;
            var numbers = "//*%1*2%3";

            var results = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, results);
        }

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
