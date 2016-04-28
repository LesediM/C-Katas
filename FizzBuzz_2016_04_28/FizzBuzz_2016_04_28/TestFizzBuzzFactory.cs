using NUnit.Framework;

namespace FizzBuzz_2016_04_28
{
    [TestFixture]
    public class TestFizzBuzzFactory
    {
        [Test]
        public void CreateFizzBuzz_GivenNumber1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var number = 1;
            var expected = "1";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var number = 2;
            var expected = "2";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 3;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var number = 4;
            var expected = "4";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 5;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 6;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var number = 9;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 10;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 15;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 20;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 30;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void CreateFizzBuzz_GivenNumber75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var number = 75;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.CreateFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzFactory CreateFizzBuzzFactory()
        {
            return new FizzBuzzFactory();
        }
    }
}
