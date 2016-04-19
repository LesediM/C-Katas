using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace StringCalculator_2016_04_18
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = GetDelimiters(ref numbers);
            var numberlist = GetNumbers(numbers, delimiters);
            NegativeNumberCheck(numberlist);
            return SumNumberList(numberlist);
        }

        private int SumNumberList(string[] numberlist)
        {
            return numberlist
                .Where(x => int.Parse(x) <= 1000)
                .Sum(x => string.IsNullOrEmpty(x) ? 0 : int.Parse(x));
        }

        private List<char> GetDelimiters(ref string numbers)
        {
            var delimters = new List<char>() { ',', '\n' };
            if (numbers.Contains("//"))
            {
                numbers = numbers.Substring(2).Replace("[", "").Replace("]", "");
                delimters.AddRange(numbers.Where((x, y) => !int.TryParse(x.ToString(), out y)));
            }
            return delimters;
        }

        private void NegativeNumberCheck(string[] numberlist)
        {
            var negativelist = numberlist.Where(x => int.Parse(x) < 0);
            if (negativelist.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativelist.ToArray()));
        }

        private string[] GetNumbers(string numbers, List<char> delimters)
        {
            return numbers.Split(delimters.ToArray()).Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }
    }
}