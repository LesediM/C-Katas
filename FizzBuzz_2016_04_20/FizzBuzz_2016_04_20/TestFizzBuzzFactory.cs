using NUnit.Framework;

namespace FizzBuzz_2016_04_20
{
    [TestFixture]
    public class TestFizzBuzzFactory
    {
        [Test]
        public void GetFizzBuzz_GivenInputNumber1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 1;
            var expected = "1";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 2;
            var expected = "2";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 3;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 4;
            var expected = "4";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 5;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 6;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 9;
            var expected = "Fizz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 10;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 15;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 20;
            var expected = "Buzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber30_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 30;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void GetFizzBuzz_GivenInputNumber75_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var inputNumber = 75;
            var expected = "FizzBuzz";
            var fizzBuzzFactory = CreateFizzBuzzFactory();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzBuzzFactory.GetFizzBuzz(inputNumber);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        private FizzBuzzFactory CreateFizzBuzzFactory()
        {
            return new FizzBuzzFactory();
        }
    }
}
