using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = GetDelimiters(numbers);
            var numberlist = GetNumbersFromString(numbers, delimiters);
            NegativeExcetionCheck(numberlist);
            return numberlist.Sum(Convert.ToInt32);
        }

        private void NegativeExcetionCheck(IEnumerable<string> numberlist)
        {
            var negativenumberlist = numberlist.Where(x => Convert.ToInt32(x) < 0);
            if (negativenumberlist.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativenumberlist.ToArray()));
        }

        private List<char> GetDelimiters(string numbers)
        {
            var delimiters = new List<char>() { ',', '\n' };
            if (numbers.Contains("//"))
            {
                delimiters.AddRange(numbers.Where((x, y) => int.TryParse(x.ToString(), out y) == false));
            }
            return delimiters;
        }

        private List<string> GetNumbersFromString(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray()).Where(x => !string.IsNullOrEmpty(x)).Where(x => Convert.ToInt32(x) <= 1000).ToList();
        }
    }
}