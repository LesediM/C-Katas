using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_07_13
{
    internal class NumeralConverter
    {
        public int Convert(string numeral)
        {
            CheckForStrangeNumerals(numeral);
            CheckForNonRepeatablesRepeated(numeral);
            CheckForNumeralsRepeatingMoreThan3Times(numeral);
            numeral = ResolveSubtractingNumerals(numeral);
            return GetSum(numeral);
        }

        private int GetSum(string numeral)
        {
            var sum = numeral.Sum(n => GetDigit(n.ToString()));
            ValidateResults(sum);
            return sum;
        }

        private static void ValidateResults(int sum)
        {
            if (sum > 3000)
                throw new ArgumentException("Numeral not allowed to return greater than 3000");
        }

        private static void CheckForNumeralsRepeatingMoreThan3Times(string numeral)
        {
            var repeatableNumerals = new[] { "M", "C", "X", "I" };
            var repeatingMoreThan3Times = repeatableNumerals.Where(r => numeral.Count(n => n.ToString() == r) > 3);
            if (repeatingMoreThan3Times.Any())
            {
                var message = "Numeral not allowed to repeat more than 3 times: " + string.Join(",", repeatingMoreThan3Times.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRepeatablesRepeated(string numeral)
        {
            var nonRepeatableNumerals = new[] { "D", "L", "V" };
            var nonRepeatablesRepeated = nonRepeatableNumerals.Where(r => numeral.Count(n => r == n.ToString()) > 1);
            if (nonRepeatablesRepeated.Any())
            {
                var message = "Numeral not allowed to repeat: " + string.Join(",", nonRepeatablesRepeated.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForStrangeNumerals(string numeral)
        {
            var romanNumerals = new[] { "M", "D", "C", "L", "X", "V", "I" };
            var strangeNumerals = numeral.Where(n => !romanNumerals.Contains(n.ToString()));
            if (strangeNumerals.Any())
            {
                var message = "Character is not a numeral: " + string.Join(",", strangeNumerals.ToArray());
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