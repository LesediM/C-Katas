using NUnit.Framework;

namespace FizzBuzz_2016_05_10
{
    [TestFixture]
    public class TestFizzBuzzBuilder
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
            var builder = CreateBuilder();
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            var results = builder.Build(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzBuilder CreateBuilder()
        {
            return new FizzBuzzBuilder();
        }
    }
}
