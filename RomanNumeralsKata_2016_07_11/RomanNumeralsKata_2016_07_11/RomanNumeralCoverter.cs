using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_07_11
{
    public class RomanNumeralCoverter
    {
        public int Convert(string numeral)
        {
            CheckForStrangeNumerals(numeral);
            CheckForNonRepeatViolation(numeral);
            CheckForRepeatLimitViolation(numeral);
            numeral = ResolveSubtractingNumerals(numeral);
            return GetSum(numeral); ;
        }

        private int GetSum(string numeral)
        {
            var sum = numeral.Sum(n => GetDigit(n.ToString()));
            CheckSumResults(sum);
            return sum;
        }

        private static void CheckForStrangeNumerals(string numeral)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var strangeNumerals = numeral.Where(n => !validNumerals.Contains(n.ToString()));
            if (strangeNumerals.Any())
            {
                var message = "Character is not a roman numeral: " + string.Join(",", strangeNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRepeatViolation(string numeral)
        {
            var nonRepeatingNumerals = new[] { "D", "L", "V" };
            var nonRepeatViolation = nonRepeatingNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 1);
            if (nonRepeatViolation.Any())
            {
                var message = "Numeral cannot be repeated: " + string.Join(",", nonRepeatViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatLimitViolation(string numeral)
        {
            var repeatingNumerals = new[] { "M", "C", "X", "I" };
            var repeatLimitViolation = repeatingNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 3);
            if (repeatLimitViolation.Any())
            {
                var message = "Numeral cannot be repeated more than 3 times: " + string.Join(",", repeatLimitViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckSumResults(int sum)
        {
            if (sum > 3000)
                throw new ArgumentException("Numeral cannot be greater than 3000");
        }

        private static string ResolveSubtractingNumerals(string numeral)
        {
            numeral = numeral
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
            return numeral;
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