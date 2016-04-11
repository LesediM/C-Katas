using NUnit.Framework;

namespace FizzBuzz_2016_04_11
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void FizzBuzz_Given1_ShouldReturn1()
        {
            //setup
            var expected = "1";
            var number = 1;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given2_ShouldReturn2()
        {
            //setup
            var expected = "2";
            var number = 2;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given3_ShouldReturnFizz()
        {
            //setup
            var expected = "Fizz";
            var number = 3;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given4_ShouldReturn4()
        {
            //setup
            var expected = "4";
            var number = 4;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given5_ShouldReturnBuzz()
        {
            //setup
            var expected = "Buzz";
            var number = 5;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given6_ShouldReturnFizz()
        {
            //setup
            var expected = "Fizz";
            var number = 6;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given9_ShouldReturnFizz()
        {
            //setup
            var expected = "Fizz";
            var number = 9;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given10_ShouldReturnBuzz()
        {
            //setup
            var expected = "Buzz";
            var number = 10;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given15_ShouldReturnFizzBuzz()
        {
            //setup
            var expected = "FizzBuzz";
            var number = 15;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given20_ShouldReturnBuzz()
        {
            //setup
            var expected = "Buzz";
            var number = 20;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            //setup
            var expected = "FizzBuzz";
            var number = 30;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void FizzBuzz_Given75_ShouldReturnFizzBuzz()
        {
            //setup
            var expected = "FizzBuzz";
            var number = 75;
            //condition
            //execute
            var results = CreateFizzBuzz().CalculateFizzBuzz(number);
            //assert
            Assert.AreEqual(expected, results);
        }

        private FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }
    }
}