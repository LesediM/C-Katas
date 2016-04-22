using System.Collections.Generic;

namespace FizzBuzz_2016_04_22
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            var fizzBuzzString = GetFizzBuzzString(number);
            if (string.IsNullOrEmpty(fizzBuzzString))
                return $"{number}";
            return fizzBuzzString;
        }

        private string GetFizzBuzzString(int number)
        {
            var fizzBuzzString = "";
            fizzBuzzString += CheckIfDivisible(number, 3) ? "Fizz" : "";
            fizzBuzzString += CheckIfDivisible(number, 5) ? "Buzz" : "";
            return fizzBuzzString;
        }

        private bool CheckIfDivisible(int number, int denominator)
        {
            return number % denominator == 0;
        }
    }
}