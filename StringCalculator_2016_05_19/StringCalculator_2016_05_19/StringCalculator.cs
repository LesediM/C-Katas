using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_19
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var separatorList = new[] { ',', '\n' };

            numbers = ResolveDelimiter(numbers);

            var splitNumberString = SplitNumberString(numbers, separatorList);
            NegativeCheck(splitNumberString);
            var sum = splitNumberString.Sum(x => int.Parse(x));

            return sum;
        }

        private static string[] SplitNumberString(string numbers, char[] separatorList)
        {
            return numbers.Split(separatorList).Where(x => int.Parse(x) <= 1000).ToArray();
        }

        private static void NegativeCheck(string[] splitNumberString)
        {
            var negativeList = splitNumberString.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeList.ToArray()));
        }

        private static string ResolveDelimiter(string numbers)
        {
            if (numbers.StartsWith("//"))
            {
                var splitNumberString = numbers.Split('\n');
                var delimiterSection = splitNumberString[0];
                var numberSection = splitNumberString[1];
                var delimiterList = delimiterSection.Replace("//", "").Split(new [] { '[', ']' },StringSplitOptions.RemoveEmptyEntries);
                foreach (var delimiter in delimiterList)
                {
                    numberSection = numberSection.Replace(delimiter, ",");
                }
                numbers = numberSection;
            }
            return numbers;
        }
    }
}