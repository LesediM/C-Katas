using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_28
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = ResolveDelimiters(numbers);

            var splitNumberString = SplitNumberString(numbers);

            CheckForNegatives(splitNumberString);

            return SumNumbes(splitNumberString);
        }

        private string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterPart = split[0];
                var numberPart = split[1];
                foreach (var delimiter in delimiterPart.Split(new[] {'[', ']','/'}, StringSplitOptions.RemoveEmptyEntries))
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }

        private int SumNumbes(string[] splitNumberString)
        {
            return splitNumberString.Where(x => int.Parse(x) <= 1000).Sum(int.Parse);
        }

        private void CheckForNegatives(string[] splitNumberString)
        {
            var negatives = splitNumberString.Where(x => int.Parse(x) < 0);
            if (negatives.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }

        private string[] SplitNumberString(string numbers)
        {
            return numbers.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}