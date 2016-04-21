using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using NUnit.Framework;

namespace StringCalculator_2016_04_21
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiterlist = GetDelimiterlist(ref numbers);

            var numberList = GetNumbers(numbers, delimiterlist);
            NegativeNumberCheck(numberList);

            return GetNumbers(numbers, delimiterlist).Sum(x => int.Parse(x));
        }

        private List<char> GetDelimiterlist(ref string numbers)
        {
            var delimiterlist = new List<char>() {',', '\n'};
            if (numbers.Contains("//"))
            {
                numbers = numbers.Substring(2);
                delimiterlist.AddRange(numbers.Where((x, y) => !int.TryParse(x.ToString(), out y)));
            }
            return delimiterlist;
        }

        private void NegativeNumberCheck(string[] numberList)
        {
            var negatives = numberList.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }

        private string[] GetNumbers(string numbers, List<char> delimiterlist)
        {
            return numbers.Split(delimiterlist.ToArray(), StringSplitOptions.RemoveEmptyEntries).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}