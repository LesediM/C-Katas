using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_05_25
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            if (numbers.StartsWith("//"))
            {
                var split = numbers.Split('\n');
                var delimiterList = split[0].Replace("//", "").Split(new[] {'[', ']'},StringSplitOptions.RemoveEmptyEntries);
                var numberPart = split[1];
                foreach (var delimiter in delimiterList)
                {
                    numberPart = numberPart.Replace(delimiter.Substring(0,1), ",");
                }
                numbers = numberPart;
            }

            if (numbers.Contains(","))
            {
                var separatorList = new[] { ',', '\n' };
                var split = numbers.Split(separatorList,StringSplitOptions.RemoveEmptyEntries);
                NegativeCheck(split);
                var sum = split.Where(x=>int.Parse(x)<=1000).Sum(x => int.Parse(x));
                return sum;
            }

            return int.Parse(numbers);
        }

        private static void NegativeCheck(string[] split)
        {
            var negativeList = split.Where(x => int.Parse(x) < 0);
            if (negativeList.Any())
                throw new ArgumentException("negatives not allowed: " + String.Join(",", negativeList.ToArray()));
        }
    }
}