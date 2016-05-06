using System.Text;

namespace FizzBuzz_2016_05_06
{
    public class FizzBuzzCalculator
    {
        public string Build(int input)
        {
            var numberIsDivisibleBy3 = input % 3 == 0;
            var numberIsDivisibleBy5 = input % 5 == 0;

            if (!(numberIsDivisibleBy3 || numberIsDivisibleBy5))
                return input.ToString();

            var fizzbuzzBuildString = FizzBuzzBuilder(numberIsDivisibleBy3, numberIsDivisibleBy5).ToString();
            return fizzbuzzBuildString;
        }

        private StringBuilder FizzBuzzBuilder(bool numberIsDivisibleBy3, bool numberIsDivisibleBy5)
        {
            StringBuilder fizzBuzzBuild = new StringBuilder();
            if (numberIsDivisibleBy3)
                fizzBuzzBuild.Append("Fizz");
            if (numberIsDivisibleBy5)
                fizzBuzzBuild.Append("Buzz");
            return fizzBuzzBuild;
        }
    }
}