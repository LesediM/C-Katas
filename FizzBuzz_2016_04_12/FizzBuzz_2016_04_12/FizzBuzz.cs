using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_2016_04_12
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            var returnString = DetermineFizzBuzz(number);

            if (string.IsNullOrEmpty(returnString))
                return number.ToString();

            return returnString;
        }

        private string DetermineFizzBuzz(int number)
        {
            var returnString = String.Empty;
            returnString += number%3 == 0 ? "Fizz" : "";
            returnString += number%5 == 0 ? "Buzz" : "";
            return returnString;
        }
    }
}
