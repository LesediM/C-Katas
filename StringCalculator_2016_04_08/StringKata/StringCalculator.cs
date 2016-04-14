using System;
using NUnit.Framework;

namespace StringKata
{
    [TestFixture]
    public class StringCalculator
    {
        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //Setup
            var expected = 0;
            var numbers = "";

            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithOneNumber_ShouldReturnThatNumber()
        {
            //Setup
            var expected = 1;
            var numbers = "1";

            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithTwoNumbers_ShouldReturnSumOfNumbers()
        {
            //Setup
            var expected = 6;
            var numbers = "1,2,3";

            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithNewlines_ShouldReturnSumOfNumbers()
        {
            //Setup
            var expected = 6;
            var numbers = "1\n2,3";

            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithChangeDelimiter_ShouldReturnSumOfNumbers()
        {
            //Setup
            var expected = 6;
            var numbers = "//;1;2,3";

            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithOneNegative_ShouldThrowException()
        {
            //Setup
            var numbers = "1,-2,3";
            var expected = "negatives not allowed: -2";
            //Condition
            var results = Assert.Throws<ApplicationException>(() => CreateCalculator().Add(numbers));
            //Execute
            //Test
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Add_GivenStringWithTwoNegative_ShouldThrowExceptionWithTwoNumbers()
        {
            //Setup
            var numbers = "1,-2,-3";
            var expected = "negatives not allowed: -2,-3";
            //Condition
            var results = Assert.Throws<ApplicationException>(() => CreateCalculator().Add(numbers));
            //Execute
            //Test
            Assert.AreEqual(expected, results.Message);
        }

        [Test]
        public void Add_GivenStringWith1000_ShouldSumOfNumbers()
        {
            //Setup
            var numbers = "1,2,3,1000";
            var expected = 1006;
            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWith1001_ShouldReturnSix()
        {
            //Setup
            var numbers = "1,2,3,1001";
            var expected = 6;
            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithLongDelimiter_ShouldReturnSix()
        {
            //Setup
            var numbers = "//***1***2***3";
            var expected = 6;
            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithTwoDelimiters_ShouldReturnSix()
        {
            //Setup
            var numbers = "//*%1*2%3";
            var expected = 6;
            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void Add_GivenStringWithTwoDelimitersAndOneLongDelimiter_ShouldReturnSix()
        {
            //Setup
            var numbers = "//;;;*%1*2%3";
            var expected = 6;
            //Condition
            //Execute
            var results = CreateCalculator().Add(numbers);
            //Test
            Assert.AreEqual(expected, results);
        }

        private Calculator CreateCalculator()
        {
            return new Calculator();
        }
    }
}
