using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_2016_04_11
{
    public class FizzBuzz
    {
        public string CalculateFizzBuzz(int number)
        {
            var isDivisibleBy3 = IsDivisibleBy3(number);
            var isDivisibleBy5 = IsDivisibleBy5(number);

            var output = "";
            output += isDivisibleBy3 ? "Fizz" : "";
            output += isDivisibleBy5 ? "Buzz" : "";

            return output == "" ? number.ToString() : output;
        }

        private bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }

        private bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }
    }
}
