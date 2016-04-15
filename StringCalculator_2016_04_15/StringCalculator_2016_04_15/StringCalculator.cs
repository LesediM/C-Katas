using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_15
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            var delimiters = GetDelimiters(ref numbers);
            var numberlist = GetNumberlist(numbers, delimiters);
            CheckForNegatives(numberlist);
            return numberlist.Sum(Convert.ToInt32);
        }

        private void CheckForNegatives(List<string> numberlist)
        {
            var negativelist = numberlist.Where(x => Convert.ToInt32(x) < 0).ToList();
            if (negativelist.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativelist.ToArray()));
        }

        private List<string> GetNumberlist(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray()).Where(x => !string.IsNullOrEmpty(x)).Where(x => Convert.ToInt32(x) <= 1000).ToList();
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
    }
}