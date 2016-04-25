namespace FizzBuzz_2016_04_25
{
    public class FizzBuzzCalculator
    {
        public string GenerateString(int number)
        {
            var divisibleBy3 = CheckIfDivisible(number, 3);
            var divisibleBy5 = CheckIfDivisible(number, 5);
            if (!divisibleBy3 && !divisibleBy5)
                return number.ToString();

            var fizzBuzzString = GetFizzBuzzString(divisibleBy3, divisibleBy5);
            return fizzBuzzString;
        }

        private string GetFizzBuzzString(bool divisibleBy3, bool divisibleBy5)
        {
            var fizzBuzzString = "";
            if (divisibleBy3)
                fizzBuzzString += "Fizz";
            if (divisibleBy5)
                fizzBuzzString += "Buzz";
            return fizzBuzzString;
        }

        private bool CheckIfDivisible(int number, int denominator)
        {
            return number % denominator == 0;
        }
    }
}