using NUnit.Framework;

namespace FizzBuzz_2016_04_25
{
    [TestFixture]
    public class TestFizzBuzzCalculator
    {
        [Test]
        public void GenerateString_GivenNumber1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var number = 1;
            var expected = "1";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var number = 1;
            var expected = "1";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 3;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var number = 4;
            var expected = "4";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 5;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 6;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 9;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 10;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 15;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 20;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 30;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void GenerateString_GivenNumber75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 75;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.GenerateString(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzCalculator CreateFizzBuzzCalculator()
        {
            return new FizzBuzzCalculator();
        }
    }
}
