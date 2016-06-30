using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_06_30
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            Validate(numeralString);
            numeralString = ResolveSubtractingNumerals(numeralString);

            return GetSum(numeralString);

        }

        private static void Validate(string numeralString)
        {
            CheckForInValidNumerals(numeralString);
            CheckForRepeatCountViolation(numeralString);
            CheckForNonRepeatableRepeated(numeralString);
        }

        private static void CheckForNonRepeatableRepeated(string numeralString)
        {
            var nonRepeatingNumerals = new[] { "V", "L", "D" };
            var nonRepeatablesRepeated = nonRepeatingNumerals.Where(nr => numeralString.Count(n => n.ToString() == nr) > 1);
            if (nonRepeatablesRepeated.Any())
            {
                var message = "Non repeatable numerals repeated: " + string.Join(",", nonRepeatablesRepeated.OrderBy(n => n).ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatCountViolation(string numeralString)
        {
            var repeatingNumerals = new[] { "I", "X", "C", "M" };
            var repeatCountViolation = repeatingNumerals.Where(r => numeralString.Count(n => n.ToString() == r) > 3);
            if (repeatCountViolation.Any())
            {
                var message = "Numerals exceeding repeat count of 3 found: " + string.Join(",", repeatCountViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForInValidNumerals(string numeralString)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var inValidNumerals = numeralString.Where(n => !validNumerals.Contains(n.ToString()));
            if (inValidNumerals.Any())
            {
                var message = "Invalid numerals found: " + string.Join(",", inValidNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numeralString)
        {
            var sum = numeralString.Sum(n => GetNumeralDigit(n.ToString()));
            if (sum > 3000)
                throw new ArgumentException("Resulting digit will be greater than 3000: " + numeralString);
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

        private int GetNumeralDigit(string numeral)
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