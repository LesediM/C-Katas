namespace FizzBuzz_2016_05_10
{
    public class FizzBuzzBuilder
    {
        public string Build(int input)
        {
            if (input % 3 == 0)
                return "Fizz";
            return input.ToString();
        }
    }
}