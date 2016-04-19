using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_19
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;
            var delimiterlist = GetDelimiterlist(ref numbers);
            var numberlist = GetNumbersFromString(numbers, delimiterlist);
            CheckForNegativeNumbers(numberlist);

            return
                SumNumberList(numberlist);
        }

        private int SumNumberList(string[] numberlist)
        {
            return numberlist
                .Where(x => int.Parse(x) <= 1000)
                .Sum(int.Parse);
        }

        private void CheckForNegativeNumbers(string[] numberlist)
        {
            var negativenumberlist = numberlist.Where(x => int.Parse(x) < 0);
            if (negativenumberlist.Any())
                throw new ArgumentException("negative numbers not allowed: " + string.Join(",", negativenumberlist.ToArray()));
        }

        private string[] GetNumbersFromString(string numbers, List<char> delimiterlist)
        {
            return numbers.Split(delimiterlist.ToArray())
                .Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        private List<char> GetDelimiterlist(ref string numbers)
        {
            var delimiterlist = new List<char> { ',', '\n' };
            if (numbers.Contains("//"))
            {
                delimiterlist.AddRange(numbers.Substring(2).Where((x, y) => !int.TryParse(x.ToString(), out y)));
                numbers = numbers.Substring(3);
            }
            return delimiterlist;
        }
    }
}