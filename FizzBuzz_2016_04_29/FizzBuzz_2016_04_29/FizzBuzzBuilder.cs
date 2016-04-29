namespace FizzBuzz_2016_04_29
{
    public class FizzBuzzBuilder
    {
        public string Build(int input)
        {
            var numberIsDivisibleBy3 = input % 3 == 0;
            var numberIsDivisibleBy5 = input % 5 == 0;

            if (!(numberIsDivisibleBy3 || numberIsDivisibleBy5))
                return input.ToString();

            return GetFizzBuzzResult(numberIsDivisibleBy3, numberIsDivisibleBy5);
        }

        private string GetFizzBuzzResult(bool numberIsDivisibleBy3, bool numberIsDivisibleBy5)
        {
            var result = "";
            result += numberIsDivisibleBy3 ? "Fizz" : "";
            result += numberIsDivisibleBy5 ? "Buzz" : "";
            return result;
        }
    }
}