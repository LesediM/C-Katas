namespace FizzBuzz_2016_05_04
{
    public class FizzBuzzBuilder
    {
        public string Build(int input)
        {
            var numberIsDivisibleByThree = input % 3 == 0;
            var numberIsDivisibleByFive = input % 5 == 0;

            if (!(numberIsDivisibleByThree || numberIsDivisibleByFive))
                return input.ToString();

            var fizzBuzzBuild = GetFizzBuzzBuild(numberIsDivisibleByThree, numberIsDivisibleByFive);
            return fizzBuzzBuild;
        }

        private string GetFizzBuzzBuild(bool numberIsDivisibleByThree, bool numberIsDivisibleByFive)
        {
            var fizzBuzzBuild = "";
            fizzBuzzBuild += numberIsDivisibleByThree ? "Fizz" : "";
            fizzBuzzBuild += numberIsDivisibleByFive ? "Buzz" : "";
            return fizzBuzzBuild;
        }
    }
}