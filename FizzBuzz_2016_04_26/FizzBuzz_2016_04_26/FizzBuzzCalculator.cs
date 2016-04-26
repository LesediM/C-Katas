namespace FizzBuzz_2016_04_26
{
    public class FizzBuzzCalculator
    {
        public string ResolveNumber(int number)
        {
            var divisibleBy3 = CheckIfDivisibleBy3(number);
            var divisibleBy5 = CheckIfDivisibleBy5(number);
            if (!(divisibleBy3 || divisibleBy5))
                return number.ToString();

            var resolvedFizzBuzz = divisibleBy3 ? "Fizz" : "";
            resolvedFizzBuzz += divisibleBy5 ? "Buzz" : "";
            return resolvedFizzBuzz;
        }

        private bool CheckIfDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private bool CheckIfDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}