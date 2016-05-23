using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;

namespace StringCalculator_2016_05_23
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var separatorList = new[] { ',', '\n' };
            numbers = ResovleDelimiters(numbers);
            var splitNumbers = SplitNumbers(numbers, separatorList);
            NegativeNumberCheck(splitNumbers);
            var sum = splitNumbers.Sum(x => int.Parse(x));
            return sum;
        }

        private static void NegativeNumberCheck(string[] splitNumbers)
        {
            var negativeList = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " +string.Join(",",negativeList.ToArray()));
        }

        private static string[] SplitNumbers(string numbers, char[] separatorList)
        {
            return numbers.Split(separatorList).Where(x=>int.Parse(x)<=1000).ToArray();
        }

        private static string ResovleDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterPart = split[0];
                var numberPart = split[1];
                var delimiterList = delimiterPart.Replace("//", "").Split(new []{'[',']'},StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }
    }
}