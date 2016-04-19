using NUnit.Framework;

namespace FizzBuzz_2016_04_19
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void GetFizzBuzz_GivenNumberOne_ShouldReturnSameNumber()
        {
            //---------------Set up test pack-------------------
            var expected = "1";
            var number = 1;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberTwoShouldReturnSameNumber()
        {
            //---------------Set up test pack-------------------
            var expected = "2";
            var number = 2;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberThreeShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 3;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberFourShouldReturnSameNumber()
        {
            //---------------Set up test pack-------------------
            var expected = "4";
            var number = 4;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberFiveShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 5;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberSixShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 6;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberNineShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 9;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberTenShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 10;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberFifteenShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 15;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberTwentyShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 20;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberThirtyShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 30;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        [Test]
        public void GetFizzBuzz_GivenNumberSeventyFiveShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 75;
            var fizzbuzz = CreateFizzbuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = fizzbuzz.GetFizzBuzz(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected,result);
        }

        private FizzBuzz CreateFizzbuzz()
        {
            return new FizzBuzz();
        }
    }
}
