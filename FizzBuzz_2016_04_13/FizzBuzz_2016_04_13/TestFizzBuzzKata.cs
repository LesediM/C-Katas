using NUnit.Framework;

namespace FizzBuzz_2016_04_13
{
    [TestFixture]
    public class TestFizzBuzzKata
    {
        private FizzBuzzKata _fizzbuzzkata;

        [SetUp]
        public void CreateFizzBuzz()
        {
            _fizzbuzzkata = new FizzBuzzKata();
        }
        

        [Test]
        public void GetFizzBuzz_Given1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var expected = "1";
            var number = 1;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var expected = "2";
            var number = 2;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 3;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var expected = "4";
            var number = 4;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 5;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 6;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 9;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 10;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 15;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 20;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 30;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 75;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = _fizzbuzzkata.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, result);
        }
    }
}