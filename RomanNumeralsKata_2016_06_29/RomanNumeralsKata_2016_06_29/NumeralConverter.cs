using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_06_29
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            CheckForStrangeNumerals(numeralString);
            CheckForCountViolation(numeralString);
            CheckForNonRepeatableNumeralViolation(numeralString);

            numeralString = ResolveSubtractingNumerals(numeralString);

            var sum = GetSum(numeralString);

            return sum;
        }

        private static void CheckForStrangeNumerals(string numeralString)
        {
            var romanNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var strangeNumerals = numeralString.Where(n => romanNumerals.Count(r => r == n.ToString()) == 0);
            if (strangeNumerals.Any())
            {
                var message = "Strange numerals not allowed: " + string.Join(",", strangeNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRepeatableNumeralViolation(string numeralString)
        {
            var romanNumerals = new[] { "V", "L", "D" };
            var nonRepititionViolation = romanNumerals.Where(r => numeralString.Count(n => n.ToString() == r) > 1);
            if (nonRepititionViolation.Any())
            {
                var message = "Repititions of non repeatable numerals not allowed: " + string.Join(",", nonRepititionViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForCountViolation(string numeralString)
        {
            var romanNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var countViolations = romanNumerals.Where(r => numeralString.Count(n => n.ToString() == r) > 3);
            if (countViolations.Any())
            {
                var message = "Repititions of numerals cannot be greater than 3: " + string.Join(",", countViolations.ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numeralString)
        {
            var sum = numeralString.Sum(n => GetDigit(n.ToString()));
            if (sum > 3000)
                throw new ArgumentException("Results cannot be greater than 3000");
            return sum;
        }

        private static string ResolveSubtractingNumerals(string numeralString)
        {
            return numeralString
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