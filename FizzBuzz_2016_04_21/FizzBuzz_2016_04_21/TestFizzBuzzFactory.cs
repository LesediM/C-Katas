using NUnit.Framework;

namespace FizzBuzz_2016_04_21
{
    [TestFixture]
    public class TestFizzBuzzFactory
    {
        [Test]
        public void ExtractFizzBuzz_GivenInput1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var input = 1;
            var expected = "1";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var input = 2;
            var expected = "2";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 3;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var input = 4;
            var expected = "4";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 5;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 6;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var input = 9;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 10;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 15;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 20;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 30;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void ExtractFizzBuzz_GivenInput75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var input = 75;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzzFactory.ExtractFizzBuzz(input);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzzFactory CreateFizzBuzzFactory()
        {
            return new FizzBuzzFactory();
        }
    }
}
