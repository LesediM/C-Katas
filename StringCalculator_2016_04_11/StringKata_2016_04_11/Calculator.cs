using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace StringKata_2016_04_11
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (IsNumberStringEmpty(numbers))
                return 0;

            return GetSumFromNumberString(numbers);
        }

        private int GetSumFromNumberString(string numbers)
        {
            var Delimiters = GetDelimitersFromNumberString(numbers);
            var numberArray = SplitNumberString(numbers, Delimiters.ToArray());
            NegativeNumberExceptionCheck(numberArray);

            return numberArray.Sum(ConvertStringToInt);
        }

        private void NegativeNumberExceptionCheck(string[] numberArray)
        {
            var negativenumbers = numberArray.Where(x => ConvertStringToInt(x) < 0);
            if (negativenumbers.Any())
                throw new ArgumentException("negatives not allowed: " + string.Join(",", negativenumbers.ToArray()));
        }

        private List<char> GetDelimitersFromNumberString(string numbers)
        {
            List<char> Delimiters = new List<char>() { ',', '\n' };
            if (numbers.Contains("//"))
            {
                Delimiters.AddRange(GetAdditionalDelimiters(numbers).ToArray());
            }
            return Delimiters;
        }

        private List<char> GetAdditionalDelimiters(string numbers)
        {
            return numbers.Substring(2).ToCharArray().TakeWhile((x, y) => !CanConvertStringToNumber(Convert.ToString(x), out y)).ToList();
        }

        private string[] SplitNumberString(string numbers, char[] Delimiters)
        {
            return numbers.Split(Delimiters);
        }

        private int ConvertStringToInt(string x)
        {
            int y = CanConvertStringToNumber(x, out y) ? y : 0;
            return y <= 1000 ? y : 0;
        }

        private bool CanConvertStringToNumber(string x, out int y)
        {
            return int.TryParse(x, out y);
        }

        private bool IsNumberStringEmpty(string numbers)
        {
            return string.IsNullOrEmpty(numbers);
        }
    }
}