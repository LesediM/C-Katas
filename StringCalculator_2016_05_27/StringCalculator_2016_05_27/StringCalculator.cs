using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_27
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//"))
            {
                numbers = ResoveDelimiters(numbers);
            }

            if (numbers.Contains(","))
            {
                return SumNumbers(numbers);
            }

            return int.Parse(numbers);
        }

        private static string ResoveDelimiters(string numbers)
        {
            var split = numbers.Split('\n');
            var delimiterPart = split[0].Replace("//", "");
            var numberPart = split[1];

            numberPart = ResolveSpecialDelimiters(delimiterPart, numberPart);
            numbers = numberPart.Replace(delimiterPart, ",");
            return numbers;
        }

        private static string ResolveSpecialDelimiters(string delimiterPart, string numberPart)
        {
            if (delimiterPart.Contains("["))
            {
                var delimiterList = delimiterPart.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
            }
            return numberPart;
        }

        private static int SumNumbers(string numbers)
        {
            var split = SplitNumbers(numbers);
            var sum = split.Sum(x => int.Parse(x));
            return sum;
        }

        private static string[] SplitNumbers(string numbers)
        {
            var separatorList = new[] { ',', '\n' };
            var splitOfNumbers = numbers.Split(separatorList);
            NegativeCheck(splitOfNumbers);
            return splitOfNumbers.Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void NegativeCheck(string[] splitOfNumbers)
        {
            var negativeList = splitOfNumbers.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }
    }
}