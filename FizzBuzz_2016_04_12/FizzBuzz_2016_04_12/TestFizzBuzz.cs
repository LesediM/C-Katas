using NUnit.Framework;

namespace FizzBuzz_2016_04_12
{
    public class TestFizzBuzz
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TearDown]
        public void DisposeSetUp()
        {
            _fizzBuzz = null;
        }

        [Test]
        public void GetFizzBuzz_Given1_ShouldReturn1()
        {
            var number = 1;
            var expected = "1";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given2_ShouldReturn2()
        {
            var number = 2;
            var expected = "2";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given3_ShouldReturnFizz()
        {
            var number = 3;
            var expected = "Fizz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given4_ShouldReturn4()
        {
            var number = 4;
            var expected = "4";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given5_ShouldReturnBuzz()
        {
            var number = 5;
            var expected = "Buzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given6_ShouldReturnFizz()
        {
            var number = 6;
            var expected = "Fizz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given9_ShouldReturnFizz()
        {
            var number = 9;
            var expected = "Fizz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given10_ShouldReturnBuzz()
        {
            var number = 10;
            var expected = "Buzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given15_ShouldReturnFizzBuzz()
        {
            var number = 15;
            var expected = "FizzBuzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given20_ShouldReturnBuzz()
        {
            var number = 20;
            var expected = "Buzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            var number = 30;
            var expected = "FizzBuzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetFizzBuzz_Given75_ShouldReturnFizzBuzz()
        {
            var number = 75;
            var expected = "FizzBuzz";

            var results = GetFizzBuzz(number);

            Assert.AreEqual(expected, results);
        }


        private string GetFizzBuzz(int number)
        {
            return _fizzBuzz.GetFizzBuzz(number);
        }

    }
}