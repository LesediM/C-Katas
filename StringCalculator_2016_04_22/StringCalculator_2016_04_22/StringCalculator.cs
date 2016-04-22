using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator_2016_04_22
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimiters = GetDelimiters(ref numbers);
            var numberStringToList = SplitNumberStringToList(numbers, delimiters);
            var numberlistWithOutNumbersAbove1000 = FilterOutNumbersAbove1000(numberStringToList);
            NegativeNumberCheck(numberlistWithOutNumbersAbove1000);
            return numberlistWithOutNumbersAbove1000.Sum(x => int.Parse(x));
        }

        private string[] FilterOutNumbersAbove1000(string[] numberStringToList)
        {
            var numberlistWithOutNumbersAbove1000 = numberStringToList.Where(x => int.Parse(x) <= 1000).ToArray();
            return numberlistWithOutNumbersAbove1000;
        }

        private void NegativeNumberCheck(string[] numberStringToList)
        {
            var negativeNumberList = numberStringToList.Where(x => int.Parse(x) < 0);
            if (negativeNumberList.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativeNumberList.ToArray()));
        }

        private string[] SplitNumberStringToList(string numbers, List<char> delimiters)
        {
            return numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        private List<char> GetDelimiters(ref string numbers)
        {
            var delimiters = new List<char>() { ',', '\n' };
            if (numbers.Contains("//"))
            {
                numbers = numbers.Substring(2);
                delimiters.AddRange(numbers.Where((x, y) => !int.TryParse(x.ToString(), out y)));
            }
            return delimiters;
        }
    }
}