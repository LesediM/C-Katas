using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_28_1
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = ResolveDelimiters(numbers);
            var numberSplit = GetNumberSplit(numbers);
            CheckForNegatives(numberSplit);
            return numberSplit.Sum(x => int.Parse(x));
        }

        private string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Replace("//", "");
                var indexOf = numbers.IndexOf("\n");
                var delimiterPart = numbers.Substring(0, indexOf);
                numbers = numbers.Substring(indexOf);
                foreach (var delimiter in delimiterPart.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries))
                {
                    numbers = numbers.Replace(delimiter, ",");
                }
                Console.WriteLine(numbers);
            }
            return numbers;
        }

        private string[] GetNumberSplit(string numbers)
        {
            return numbers.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private void CheckForNegatives(string[] numberSplit)
        {
            var negatives = numberSplit.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }
    }
}