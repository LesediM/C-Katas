using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_25
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//"))
                numbers = ReplaceDelimitersWithDefault(numbers);

            var numberlist = SplitDelimiters(numbers);
            var filteroutNumbersAbove1000 = FilteroutNumbersAbove1000(numberlist);
            NegativeNumberCheck(filteroutNumbersAbove1000);

            return filteroutNumbersAbove1000.Sum(x => int.Parse(x));
        }

        private string ReplaceDelimitersWithDefault(string numbers)
        {
            var splitNumbersAndDelimiters = numbers.Split('\n');
            var delimiterString = splitNumbersAndDelimiters[0];
            var numberString = splitNumbersAndDelimiters[1];
            foreach (var delimiterPart in delimiterString.Split(new[] { '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries))
            {
                Console.WriteLine(delimiterPart);
                numberString = numberString.Replace(delimiterPart, ",");
            }
            return numberString;
        }

        private string[] FilteroutNumbersAbove1000(string[] numberlist)
        {
            return numberlist.Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private void NegativeNumberCheck(string[] numberlist)
        {
            var negativelist = numberlist.Where(x => int.Parse(x) < 0);
            if (negativelist.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativelist.ToArray()));
        }

        private string[] SplitDelimiters(string numbers)
        {
            return numbers.Split(',');
        }

    }
}