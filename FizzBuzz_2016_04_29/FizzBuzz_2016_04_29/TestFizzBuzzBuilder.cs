using NUnit.Framework;

namespace FizzBuzz_2016_04_29
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
        public void Build_GivenInput_ShouldReturnBuildOfFizzBuzz(int input, string expected)
        {
            //---------------Set up test pack-------------------
            var fizzBuzzBuilder = CreateFizzBuzzBuilder();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzBuilder.Build(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }


        private FizzBuzzBuilder CreateFizzBuzzBuilder()
        {
            return new FizzBuzzBuilder();
        }
    }
}
