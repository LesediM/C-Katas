using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_20
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = GetDelimiters(ref numbers);

            var numberlist = GetNumberlist(numbers, delimiters);

            NegativeNumberCheck(numberlist.ToArray());

            return numberlist.Sum(x => int.Parse(x));
        }

        private IEnumerable<string> GetNumberlist(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries).Where(x => int.Parse(x) <= 1000);
        }

        private List<char> GetDelimiters(ref string numbers)
        {
            var delimiters = new List<char> { ',', '\n' };
            if (numbers.Contains("//"))
            {
                numbers = numbers.Replace("[", "").Replace("]", "").Substring(2);
                delimiters.AddRange(numbers.Where((x, y) => !int.TryParse(x.ToString(), out y)).ToArray());
            }
            return delimiters;
        }

        private void NegativeNumberCheck(string[] numberlist)
        {
            var negativenumbers = numberlist.Where(x => int.Parse(x) < 0);
            if (negativenumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativenumbers.ToArray()));
        }
    }
}