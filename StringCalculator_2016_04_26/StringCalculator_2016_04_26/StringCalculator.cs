using System;
using System.Linq;
using NUnit.Framework;

namespace StringCalculator_2016_04_26
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            numbers = DelimitersResolve(numbers);

            var splitNumbers = SplitNumbers(numbers);
            NegativeNumberCheck(splitNumbers);

            return splitNumbers.Where(x => int.Parse(x) <= 1000).Sum(x => int.Parse(x));

        }

        private string DelimitersResolve(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Substring(2);
                var splitDelimitersAndNumbers = numbers.Split('\n');
                var delimiterPart = splitDelimitersAndNumbers[0];
                var numberPart = splitDelimitersAndNumbers[1];

                foreach (var delimiter in delimiterPart.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    numberPart = numberPart.Replace(delimiter, ",");
                }
                numbers = numberPart;
            }
            return numbers;
        }

        private void NegativeNumberCheck(string[] splitNumbers)
        {
            var negativelist = splitNumbers.Where(x => int.Parse(x) < 0).ToArray();
            if (negativelist.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativelist));
        }

        private string[] SplitNumbers(string numbers)
        {
            return numbers.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}