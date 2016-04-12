using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace StringKata_2016_04_12
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturn0()
        {
            var expected = 0;
            var numbers = "";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWith1_ShouldReturn1()
        {
            var expected = 1;
            var numbers = "1";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWith2Numbers_ShouldReturn3()
        {
            var expected = 3;
            var numbers = "1,2";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithNewline_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "1\n2,3";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithNewDelimiter_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "//;1;2,3";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithNegative_ShouldReturnException()
        {
            var expected = "negatives not allowed: -2";
            var numbers = "1,-2,3";

            var result = Assert.Throws<ArgumentException>(()=> CreateCalculator().Add(numbers));
            Assert.AreEqual(expected, result.Message);
        }

        [Test]
        public void Add_GivenStringWith1001_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "1,2,3,1001";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithLongDelimiter_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "//***1***2***3";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_GivenStringWithMultipleDelimiters_ShouldReturn6()
        {
            var expected = 6;
            var numbers = "//*%1%2*3";

            var result = CreateCalculator().Add(numbers);

            Assert.AreEqual(expected, result);
        }

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
