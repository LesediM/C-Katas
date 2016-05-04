using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_04
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = ResolveDelimiters(numbers);
            Console.Write(numbers);
            var splitNumbers = SplitNumbers(numbers, delimiters);
            NegativeNumberCheck(splitNumbers);
            var sumOfNumbers = splitNumbers.Sum(x => int.Parse(x));

            return sumOfNumbers;
        }

        private void NegativeNumberCheck(string[] splitNumbers)
        {
            var negativeNumberList = splitNumbers.Where(x => int.Parse(x) < 0);
            if (negativeNumberList.Any())
            {
                throw new ArgumentException("negative numbers not allowed: " + string.Join(",", negativeNumberList.ToArray()));
            }
        }

        private string[] SplitNumbers(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private string ResolveDelimiters(string numbers)
        {
            var numberPart = numbers;
            if (numberPart.StartsWith("//"))
            {
                var splitOfNumbersString = numbers.Split('\n');
                var delimiterPart = splitOfNumbersString[0].Replace("//", "");
                var delimiterArray = delimiterPart.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                numberPart = splitOfNumbersString[1];
                foreach (var delimiter in delimiterArray)
                {
                    numberPart = numberPart.Replace(delimiter.Trim('[', ']'), ",");
                }
            }
            return numberPart;
        }
    }
}