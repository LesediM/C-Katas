using System;

namespace FizzBuzz_2016_04_19
{
    internal class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            var fizzBuzzNumber = "";
            fizzBuzzNumber += number % 3 == 0 ? "Fizz" : "";
            fizzBuzzNumber += number % 5 == 0 ? "Buzz" : "";
            return string.IsNullOrEmpty(fizzBuzzNumber) ? number.ToString() : fizzBuzzNumber;
        }
    }
}