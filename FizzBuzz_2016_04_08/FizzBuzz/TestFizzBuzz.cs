using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class TestFizzBuzz
    {
        [Test]
        public void GetFizzBuzz_GivenOne_ShouldReturnOne()
        {
            //------------------Setup Test---------------
            var fizzBuzz = CreateFizzBuzz();
            //-----------------Execute Test-------------
            var result = fizzBuzz.GetFizzBuzz(1);
            //----------------Assert-------------------- 
            Assert.AreEqual("1", result);
        }
        
        [Test]
        public void GetFizzBuzz_GivenTwo_ShouldReturnTwo()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(2);

            Assert.AreEqual("2", result);
        }

        [Test]
        public void GetFizzBuzz_GivenThree_ShouldReturnFizz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(3);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenFour_ShouldReturnFour()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(4);

            Assert.AreEqual("4", result);
        }

        [Test]
        public void GetFizzBuzz_GivenFive_ShouldReturnBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(5);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenSix_ShouldReturnFizz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(6);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenNine_ShouldReturnFizz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(9);

            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenTen_ShouldReturnBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(10);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenFifteen_ShouldReturnFizzBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(15);

            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenTwenty_ShouldReturnBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(20);

            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenThirty_ShouldReturnFizzBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(30);

            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void GetFizzBuzz_GivenSeventyFive_ShouldReturnFizzBuzz()
        {
            var fizzbuzz = CreateFizzBuzz();

            var result = fizzbuzz.GetFizzBuzz(75);

            Assert.AreEqual("FizzBuzz", result);
        }


        private static FizzBuzz CreateFizzBuzz()
        {
            return new FizzBuzz();
        }

    }

    public class FizzBuzz
    {
        public string GetFizzBuzz(int inputNumber)
        {
            if (IsDivisibleByThree(inputNumber) && IsDivisibleByFive(inputNumber))
                return "FizzBuzz";
            if (IsDivisibleByThree(inputNumber))
                return "Fizz";
            if (IsDivisibleByFive(inputNumber))
                return "Buzz";
            return inputNumber.ToString();
        }

        private static bool IsDivisibleByThree(int inputNumber)
        {
            return inputNumber % 3 == 0;
        }

        private static bool IsDivisibleByFive(int inputNumber)
        {
            return inputNumber % 5 == 0;
        }
    }
}
