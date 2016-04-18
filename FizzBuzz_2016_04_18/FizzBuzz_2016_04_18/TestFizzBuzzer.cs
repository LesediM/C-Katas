using NUnit.Framework;

namespace FizzBuzz_2016_04_18
{
    [TestFixture]
    public class TestFizzBuzzer
    {
        [Test]
        public void FizzBuzzMe_GivenOne_ShouldReturnOne()
        {
            //---------------Set up test pack-------------------
            var expected = "1";
            var number = 1;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenTwo_ShouldReturnTwo()
        {
            //---------------Set up test pack-------------------
            var expected = "2";
            var number = 2;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenThree_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 3;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenFour_ShouldReturnFour()
        {
            //---------------Set up test pack-------------------
            var expected = "4";
            var number = 4;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenFive_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 5;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenSix_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 6;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenNine_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 9;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenTen_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 10;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenTen_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 15;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenTwenty_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 20;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenThirty_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 30;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzzMe_GivenSeventyFive_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 75;
            var fizzbuzzer = new FizzBuzzer();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzbuzzer.FizzBuzzMe(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
    }
}
