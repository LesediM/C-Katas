using NUnit.Framework;

namespace FizzBuzz_2016_04_15
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void FizzBuzzMe_Given1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var expected = "1";
            var number = 1;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_Given2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var expected = "2";
            var number = 2;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_Given3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 3;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_Given4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var expected = "4";
            var number = 4;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 5;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 6;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 9;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 10;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 15;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 20;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void FizzBuzzMe_Given30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 30;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_Given75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 75;
            var fizzbuzz = new FizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzz.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
