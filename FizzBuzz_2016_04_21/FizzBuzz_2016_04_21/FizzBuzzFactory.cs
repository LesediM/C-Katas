namespace FizzBuzz_2016_04_21
{
    public class FizzBuzzFactory
    {
        public string ExtractFizzBuzz(int input)
        {
            var divisibleBy3 = CheckIfDivisible(input, 3);
            var divisibleBy5 = CheckIfDivisible(input, 5);

            if (!divisibleBy3 && !divisibleBy5)
                return input.ToString();

            var fizzBuzzString = divisibleBy3 ? "Fizz" : "";
            fizzBuzzString += divisibleBy5 ? "Buzz" : "";

            return fizzBuzzString;
        }

        private bool CheckIfDivisible(int input, int numberToDivide)
        {
            return input % numberToDivide == 0;
        }
    }
}