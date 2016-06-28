using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_06_24
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            CheckForNonRomanNumerals(numeralString);
            CheckForDuplicatedNumerals(numeralString);
            numeralString = numeralString
                .Replace("IV", "IIII");

            return GetSum(numeralString);
        }

        private static void CheckForResultsExceeding3000(int sum)
        {
            if (sum > 3000)
                throw new ApplicationException("sum exceeds 3000");
        }

        private static int GetSum(string numeralString)
        {
            var sum = numeralString.Sum(numeral => ResolveNumeral(numeral.ToString()));
            CheckForResultsExceeding3000(sum);
            return sum;
        }

        private static int ResolveNumeral(string numeral)
        {
            switch (numeral)
            {
                case "I":
                    return 1;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
            }
            return 0;
        }

        private static void CheckForDuplicatedNumerals(string numeralString)
        {
            var nonRepeatingNumerals = new[] { "V", "L", "D" };
            var duplicatedNumerals = nonRepeatingNumerals.Where(nR => numeralString.Count(x => x.ToString() == nR) > 1);
            if (duplicatedNumerals.Any())
            {
                var message = "non repeating numerals character: " + string.Join(",", duplicatedNumerals.ToArray());
                throw new ApplicationException(message);
            }
        }

        private static void CheckForNonRomanNumerals(string numeralString)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var inValidNumerals = numeralString.Where(x => !validNumerals.Contains(x.ToString()));
            if (inValidNumerals.Any())
            {
                var message = "non roman numeral character found: " + string.Join(",", inValidNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }
    }
}