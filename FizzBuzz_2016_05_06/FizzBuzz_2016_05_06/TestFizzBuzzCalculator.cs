using NUnit.Framework;

namespace FizzBuzz_2016_05_06
{
    [TestFixture]
    public class TestFizzBuzzCalculator
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(20, "Buzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(75, "FizzBuzz")]
        public void Build_GivenInput_ShouldReturnResult(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.Build(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzCalculator CreateFizzBuzzCalculator()
        {
            return new FizzBuzzCalculator();
        }
    }
}
