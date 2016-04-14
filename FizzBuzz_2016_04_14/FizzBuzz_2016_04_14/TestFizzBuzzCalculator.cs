using NUnit.Framework;

namespace FizzBuzz_2016_04_14
{
    [TestFixture]
    public class TestFizzBuzzCalculator
    {
        [Test]
        public void GetFizzBuzz_Given1_ShouldReturn1()
        {
            var expected = "1";
            var number = 1;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given2_ShouldReturn2()
        {
            var expected = "2";
            var number = 2;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given3_ShouldReturnFizz()
        {
            var expected = "Fizz";
            var number = 3;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given4_ShouldReturn4()
        {
            var expected = "4";
            var number = 4;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given5_ShouldReturnBuzz()
        {
            var expected = "Buzz";
            var number = 5;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given6_ShouldReturnFizz()
        {
            var expected = "Fizz";
            var number = 6;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given9_ShouldReturnFizz()
        {
            var expected = "Fizz";
            var number = 9;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given10_ShouldReturnBuzz()
        {
            var expected = "Buzz";
            var number = 10;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given15_ShouldReturnFizzBuzz()
        {
            var expected = "FizzBuzz";
            var number = 15;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given20_ShouldReturnBuzz()
        {
            var expected = "Buzz";
            var number = 20;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given30_ShouldReturnFizzBuzz()
        {
            var expected = "FizzBuzz";
            var number = 30;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFizzBuzz_Given75_ShouldReturnFizzBuzz()
        {
            var expected = "FizzBuzz";
            var number = 75;
            var fizzBuzzCalculator = new FizzBuzzCalculator();

            var result = fizzBuzzCalculator.GetFizzBuzz(number);

            Assert.AreEqual(expected, result);
        }
    }
}
