namespace FizzBuzz_2016_05_10
{
    public class FizzBuzzBuilder
    {
        public string Build(int input)
        {
            var divisibleBy3 = input % 3 == 0;
            var divisibleBy5 = input % 5 == 0;

            if (!(divisibleBy3 | divisibleBy5))
                return input.ToString();

            var fizz = divisibleBy3 ? "Fizz" : "";
            var buzz = divisibleBy5 ? "Buzz" : "";
            var fizzbuzz = string.Concat(fizz, buzz);
            return fizzbuzz;

        }
    }
}