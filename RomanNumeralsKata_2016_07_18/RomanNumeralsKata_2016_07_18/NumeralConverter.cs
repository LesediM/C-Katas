using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RomanNumeralsKata_2016_07_18
{
    public class NumeralConverter
    {
        public int Convert(string numeral)
        {
            CheckForStrangeNumerals(numeral);
            CheckForNonRepeatingCharsRepeated(numeral);
            CheckForRepeatViolations(numeral);
            numeral = ResolveSubtractingNumerals(numeral);
            return GetSum(numeral);
        }

        private static void CheckForStrangeNumerals(string numeral)
        {
            var romanNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var strangeNumerals = numeral.Where(n => !romanNumerals.Contains(n.ToString()));
            if (strangeNumerals.Any())
            {
                var message = "Numerals cannot be rendered: " + string.Join(",", strangeNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numeral)
        {
            var sum = numeral.Sum(x => GetDigit(x.ToString()));
            if (sum > 3000)
                throw new ArgumentException("Numerals cannot be above 3000");
            return sum;
        }

        private static void CheckForNonRepeatingCharsRepeated(string numeral)
        {
            var nonRepeatingNumerals = new[] { "D", "L", "V" };
            var nonRepeatViolation = nonRepeatingNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 1);
            if (nonRepeatViolation.Any())
            {
                var message = "Numerals cannot be repeated: " + string.Join(",", nonRepeatViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatViolations(string numeral)
        {
            var repeatableNumerals = new[] { "M", "C", "X", "I" };
            var repeatLimitViolation = repeatableNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 3);
            if (repeatLimitViolation.Any())
            {
                var message = "Numerals cannot be repeated more than 3 times: " + string.Join(",", repeatLimitViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static string ResolveSubtractingNumerals(string numeral)
        {
            return numeral
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
        }

        private int GetDigit(string numeral)
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
            return -1;
        }
    }
}