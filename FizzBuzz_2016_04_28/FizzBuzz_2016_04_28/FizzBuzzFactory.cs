namespace FizzBuzz_2016_04_28
{
    public class FizzBuzzFactory
    {
        public string CreateFizzBuzz(int number)
        {
            var divisibleBy3 = number % 3 == 0;
            var divisibleBy5 = number % 5 == 0;

            if(!(divisibleBy3||divisibleBy5))
                return number.ToString();

            return GetFizzBuzz(divisibleBy3, divisibleBy5);
        }

        private string GetFizzBuzz(bool divisibleBy3, bool divisibleBy5)
        {
            var results = "";
            if (divisibleBy3)
                results += "Fizz";
            if (divisibleBy5)
                results += "Buzz";
            return results;
        }
    }
}