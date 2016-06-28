using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_06_28
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            CheckForNonRomanNumerals(numeralString);
            CheckForInValidRepetitions(numeralString);
            CheckForTooManyRepetitions(numeralString);

            numeralString = ResolveSubtractingNumbers(numeralString);

            return GetSum(numeralString);
        }

        private static string ResolveSubtractingNumbers(string numeralString)
        {
            numeralString = numeralString
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
            return numeralString;
        }

        private static void CheckForTooManyRepetitions(string numeralString)
        {
            var repeatableNumerals = new[] { "I", "X", "C", "M" };
            var inValidRepetitions = repeatableNumerals.Where(x => numeralString.Count(n => n.ToString() == x) > 3);
            if (inValidRepetitions.Any())
            {
                var message = "Numerals repeating more than 3 times detected: " + string.Join(",", inValidRepetitions.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForInValidRepetitions(string numeralString)
        {
            var repeatingNumerals = new[] { "V", "L", "D" };
            var invalidRepetitions = repeatingNumerals.Where(x => numeralString.Count(n => n.ToString() == x) > 1);
            if (invalidRepetitions.Any())
            {
                var message = "Non repeating numerals repeating detected: " + string.Join(",", invalidRepetitions.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRomanNumerals(string numeralString)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var notValidNumerals = numeralString.Where(x => !validNumerals.Contains(x.ToString()));
            if (notValidNumerals.Any())
            {
                var message = "Non roman numerals detected: " + string.Join(",", notValidNumerals.Distinct().ToArray());
                throw new ArgumentException(message);
            }
        }

        private int GetSum(string numeralString)
        {
            var sum = numeralString.Sum(x => GetNumeral(x.ToString()));
            if (sum > 3000)
                throw new ArgumentException("Results exceed 3000");
            return sum;
        }

        private int GetNumeral(string numeral)
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
    }
}