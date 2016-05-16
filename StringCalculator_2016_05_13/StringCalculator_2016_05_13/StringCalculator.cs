using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_13
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = new[] { ',', '\n' };
            numbers = ResolveDelimiters(numbers);
            var splitNumberString = SplitNumberString(numbers, delimiters);
            NegativeNumberCheck(splitNumberString);
            return splitNumberString.Sum(x => int.Parse(x));

        }

        private  string ResolveDelimiters(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterSection = split[0].Replace("//", "");
                var delimiterList = delimiterSection.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                var numberSection = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberSection = numberSection.Replace(delimiter, ",");
                }
                numbers = numberSection;
            }
            return numbers;
        }

        private static void NegativeNumberCheck(string[] splitNumberString)
        {
            var negativeNumberList = splitNumberString.Where(x => int.Parse(x) < 0);
            if (negativeNumberList.Any())
                throw new ArgumentException("negative numbers not allowed: " + string.Join(",", negativeNumberList.ToArray()));
        }

        private string[] SplitNumberString(string numbers, char[] delimiters)
        {
            return numbers.Split(delimiters).Where(x => int.Parse(x) <= 1000).ToArray();
        }
    }
}