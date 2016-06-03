using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_06_01
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = ResolveDelimiters(numbers);

            if (numbers.Contains(","))
            {
                return SumNumbers(numbers);
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = split[0].Replace("//", "").Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                var numberPart = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                return numberPart;
            }
            return numbers;
        }

        private static int SumNumbers(string numbers)
        {
            var separators = new[] { ',', '\n' };
            var split = SplitNumbers(numbers, separators);
            CheckForNeghatives(split);
            var sum = split.Sum(x => int.Parse(x));
            return sum;
        }

        private static void CheckForNeghatives(string[] split)
        {
            var negativeList = split.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }

        private static string[] SplitNumbers(string numbers, char[] separators)
        {
            return numbers.Split(separators).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}