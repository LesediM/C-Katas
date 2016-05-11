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
