using System;
using System.Collections.Generic;
using System.Linq;

namespace StringKata
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var delimterlist = new List<char> { ',', '\n' };
            var numberlist = ExtractNumberlist(GetDelimiters(numbers, delimterlist), delimterlist.ToArray());
            NegativesInListCheck(numberlist);
            return SumNumberList(numberlist);
        }

        private string GetDelimiters(string numbers, List<char> delimterlist)
        {
            if (numbers.Contains("//"))
            {
                numbers = numbers.Substring(2);
                delimterlist.AddRange(GetNewDelimiterList(numbers));
            }
            return numbers;
        }

        private IEnumerable<char> GetLongDelimiter(string numbers)
        {
            return numbers.ToCharArray().TakeWhile(x => x == numbers[0]);
        }

        private List<char> GetNewDelimiterList(string numbers)
        {
            return numbers.ToCharArray().TakeWhile(x => IsCharAInteger(x) == false).ToList();
        }

        private void NegativesInListCheck(string[] numberlist)
        {
            var negatives = numberlist.Where(x => ConvertToInt(x) < 0);
            if (negatives.Any())
                throw new ApplicationException("negatives not allowed: " + string.Join(",", negatives.ToArray()));
        }

        private string[] ExtractNumberlist(string numbers, char[] delimiterlist)
        {
            return numbers.Split(delimiterlist);
        }

        private int SumNumberList(string[] numberlist)
        {
            return numberlist.Sum(ConvertToInt);
        }

        private int ConvertToInt(string x)
        {
            int y = (int.TryParse(x, out y) ? y : 0);
            return y <= 1000 ? y : 0;
        }
        private bool IsCharAInteger(char x)
        {
            int y = 0;
            return int.TryParse(x.ToString(), out y);
        }
    }
}