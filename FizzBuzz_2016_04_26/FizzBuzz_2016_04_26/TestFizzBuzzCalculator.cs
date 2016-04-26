using NUnit.Framework;

namespace FizzBuzz_2016_04_26
{
    [TestFixture]
    public class TestFizzBuzzCalculator
    {
        [Test]
        public void ResolveNumber_GivenNumber1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var number = 1;
            var expected = "1";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var number = 2;
            var expected = "2";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 3;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var number = 4;
            var expected = "4";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 5;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 6;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 9;
            var expected = "Fizz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 10;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 15;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 20;
            var expected = "Buzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber30_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 30;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ResolveNumber_GivenNumber75_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 75;
            var expected = "FizzBuzz";
            var fizzBuzzCalculator = CreateFizzBuzzCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzCalculator.ResolveNumber(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzCalculator CreateFizzBuzzCalculator()
        {
            return new FizzBuzzCalculator();
        }
    }
}
