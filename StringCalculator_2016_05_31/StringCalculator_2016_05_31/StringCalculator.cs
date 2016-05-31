using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_31
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
                var split = SplitNumbers(numbers);
                var sum = SumNumbers(split);
                return sum;
            }

            return int.Parse(numbers);
        }

        private static string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterPart = split[0].Replace("//","");
                var numberPart = split[1];
                var delimiterList = delimiterPart.Split(new []{'[',']'},StringSplitOptions.RemoveEmptyEntries);

                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                return numberPart;
            }
            return numbers;
        }

        private static int SumNumbers(string[] split)
        {
            var sum = split.Where(x => int.Parse(x) <= 1000).Sum(x => int.Parse(x));
            return sum;
        }

        private static string[] SplitNumbers(string numbers)
        {
            var separatorList = new[] { ',', '\n' };
            var split = numbers.Split(separatorList);
            CheckForNegatives(split);
            return split;
        }

        private static void CheckForNegatives(string[] split)
        {
            var negativeList = split.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }
    }
}