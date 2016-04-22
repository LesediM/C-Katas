using NUnit.Framework;

namespace FizzBuzz_2016_04_22
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void Calculate_GivenNumber1_ShouldReturn1()
        {
            //---------------Set up test pack-------------------
            var expected = "1";
            var number = 1;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber2_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var expected = "2";
            var number = 2;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber3_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 3;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber4_ShouldReturn4()
        {
            //---------------Set up test pack-------------------
            var expected = "4";
            var number = 4;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber5_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 5;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber6_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 6;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber9_ShouldReturnFizz()
        {
            //---------------Set up test pack-------------------
            var expected = "Fizz";
            var number = 9;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber10_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 10;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber15_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 15;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber20_ShouldReturnBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "Buzz";
            var number = 20;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber30_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 30;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }
        [Test]
        public void Calculate_GivenNumber75_ShouldReturnFizzBuzz()
        {
            //---------------Set up test pack-------------------
            var expected = "FizzBuzz";
            var number = 75;
            var fizzBuzz = CreateFizzBuzz();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var results = fizzBuzz.Calculate(number);
            //---------------Test Result -----------------------
            Assert.AreEqual(expected, results);
        }

        private FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }
    }
}
