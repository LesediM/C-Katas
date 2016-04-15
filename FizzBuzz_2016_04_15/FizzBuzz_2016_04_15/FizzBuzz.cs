using System;
using System.Collections.Generic;

namespace FizzBuzz_2016_04_15
{
    public class FizzBuzz
    {
        public string FizzBuzzMe(int number)
        {
            var fizzbuzzlist = new List<string>();
            if (number % 3 == 0)
                fizzbuzzlist.Add("Fizz");
            if (number % 5 == 0)
                fizzbuzzlist.Add("Buzz");
            return fizzbuzzlist.Count > 0 ? String.Join("", fizzbuzzlist.ToArray()) : number.ToString();
        }
    }
}