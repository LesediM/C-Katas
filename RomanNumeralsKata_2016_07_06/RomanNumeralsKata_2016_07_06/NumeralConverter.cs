using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RomanNumeralsKata_2016_07_06
{
    public class NumeralConverter
    {
        public int Convert(string numerals)
        {
            CheckForStrangeNumerals(numerals);
            CheckForRepeatCountViolation(numerals);
            numerals = ResolveSubtractingNumerals(numerals);
            return GetSum(numerals);
        }

        private static void CheckForStrangeNumerals(string numerals)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var strangeNumerals = numerals.Where(n => !validNumerals.Contains(n.ToString()));
            if (strangeNumerals.Any())
            {
                var message = "Unknown numerals: " + string.Join(",", strangeNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatCountViolation(string numerals)
        {
            CheckForRepeatingCountExceeded(numerals);
            CheckForNonRepeatRuleViolation(numerals);
        }

        private static void CheckForRepeatingCountExceeded(string numerals)
        {
            var repeatingNumerals = new[] { "M", "C", "X", "I" };
            var maxRepeatCountViolation = repeatingNumerals.Where(r => numerals.Count(n => n.ToString() == r) > 3);
            if (maxRepeatCountViolation.Any())
            {
                var message = "Numerals cannot repeat more than 3 times: " + string.Join(",", maxRepeatCountViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRepeatRuleViolation(string numerals)
        {
            var nonRepeatingNumerals = new[] { "D", "L", "V" };
            var nonRepeatingNumeralsRuleViolated = nonRepeatingNumerals.Where(r => numerals.Count(n => n.ToString() == r) > 1);
            if (nonRepeatingNumeralsRuleViolated.Any())
            {
                var message = "Numerals cannot repeat: " + string.Join(",", nonRepeatingNumeralsRuleViolated.ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numerals)
        {
            var sum = numerals.Sum(n => GetDigit(n.ToString()));
            CheckIfSumBelow3000(numerals, sum);
            return sum;
        }

        private static void CheckIfSumBelow3000(string numerals, int sum)
        {
            if (sum > 3000)
                throw new ArgumentException("Sum of numerals exceeds 3000: " + numerals);
        }

        private static string ResolveSubtractingNumerals(string numerals)
        {
            return numerals
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
        }

        private int GetDigit(string singleNumeral)
        {
            switch (singleNumeral)
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