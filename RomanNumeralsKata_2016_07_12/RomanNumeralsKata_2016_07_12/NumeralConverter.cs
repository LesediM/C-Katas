using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_07_12
{
    public class NumeralConverter
    {
        public int Convert(string numeral)
        {
            CheckForStrangeNumerals(numeral);
            CheckForRepeatViolations(numeral);
            numeral = ResolveSubtractingNumerals(numeral);
            return GetSum(numeral);
        }

        private static void CheckForStrangeNumerals(string numeral)
        {
            var romanNumerals = new[] { "M", "D", "C", "L", "X", "V", "I" };
            var strangeRomanNumerals = numeral.Where(n => !romanNumerals.Contains(n.ToString()));
            if (strangeRomanNumerals.Any())
            {
                var message = "Character is not roman numeral: " + string.Join(",", strangeRomanNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatViolations(string numeral)
        {
            CheckForTooManyNumeralRepition(numeral);
            CheckNonRepeatingNumeralViolation(numeral);
        }

        private static void CheckForTooManyNumeralRepition(string numeral)
        {
            var repeatableNumerals = new[] { "M", "C", "X", "I" };
            var repeatViolationsFound = repeatableNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 3);
            if (repeatViolationsFound.Any())
            {
                var message = "Numeral cannot repeat more than 3 times: " + string.Join(",", repeatViolationsFound.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckNonRepeatingNumeralViolation(string numeral)
        {
            var staticNumerals = new[] { "D", "L", "V" };
            var nonRepeatNumeralsRepeated = staticNumerals.Where(s => numeral.Count(n => n.ToString() == s) > 1);
            if (nonRepeatNumeralsRepeated.Any())
            {
                var message = "Numeral cannot be repeated: " + string.Join(",", nonRepeatNumeralsRepeated.ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numeral)
        {
            var sum = numeral.Sum(n => GetDigit(n.ToString()));
            if (sum > 3000)
                throw new ArgumentException("Numeral sum cannot exceed 3000");
            return sum;
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