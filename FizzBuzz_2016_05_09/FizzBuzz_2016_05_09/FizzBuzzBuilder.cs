using System.Collections.Generic;

namespace FizzBuzz_2016_05_09
{
    public class FizzBuzzBuilder
    {
        public string Build(int input)
        {
            var inputDivisibleBy3 = input % 3 == 0;
            var inputDivisibleBy5 = input % 5 == 0;

            if (!(inputDivisibleBy3 || inputDivisibleBy5))
                return input.ToString();

            var list = new List<string>();
            if (inputDivisibleBy3)
                list.Add("Fizz");
            if (inputDivisibleBy5)
                list.Add("Buzz");
            var listConcated = string.Concat(list);
            return listConcated;
        }
    }
}