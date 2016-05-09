using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_09
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = GetDelimiters(numbers);
            var numberlist = SplitNumberlist(numbers, delimiters);
            NegativeNumberCheck(numberlist);
            return numberlist.Sum(x => int.Parse(x.ToString()));
        }

        private static string GetDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var splitNumberString = numbers.Split('\n');
                var delimiterList = splitNumberString[0].Replace("//", "")
                    .Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                var newNumberString = splitNumberString[1];
                foreach (var delimiter in delimiterList)
                {
                    newNumberString = newNumberString.Replace(delimiter, ",");
                }
                numbers = newNumberString;
            }
            return numbers;
        }

        private string[] SplitNumberlist(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private void NegativeNumberCheck(string[] numberlist)
        {
            var negativenumbers = numberlist.Where(x => int.Parse(x.ToString()) < 0);
            if (negativenumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativenumbers.ToArray()));
        }
    }
}