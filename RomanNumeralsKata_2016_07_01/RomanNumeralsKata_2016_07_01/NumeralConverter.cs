using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata_2016_07_01
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            var repeatingChars = new[] { "M", "C", "X", "I" };
            var nonRepeatingChars = new[] { "D", "L", "V" };
            ValidateInput(numeralString, repeatingChars, nonRepeatingChars);

            numeralString = ResolveSubtractingNumerals(numeralString);
            var digit = ProduceDigit(numeralString);
            CheckResultsViolation(numeralString, digit);
            return digit;
        }

        private static void ValidateInput(string numeralString, string[] repeatingChars, string[] nonRepeatingChars)
        {
            CheckForInValidNumerals(numeralString, repeatingChars, nonRepeatingChars);
            CheckForRepeatViolations(numeralString, repeatingChars);
            CheckForNonRepeatingCharsViolation(numeralString, nonRepeatingChars);
        }

        private static void CheckForInValidNumerals(string numeralString, string[] repeatingChars, string[] nonRepeatingChars)
        {
            var validNumerals = repeatingChars.Concat(nonRepeatingChars).ToArray();
            var nonValidNumerals = numeralString.Where(n => !validNumerals.Contains(n.ToString()));
            if (nonValidNumerals.Any())
            {
                var message = "Non repeat chars violation found: " + string.Join(",", nonValidNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRepeatingCharsViolation(string numeralString, string[] nonRepeatingChars)
        {
            var nonRepeatingCharsViolation = nonRepeatingChars.Where(r => numeralString.Count(n => n.ToString() == r) > 1);
            if (nonRepeatingCharsViolation.Any())
            {
                var message = "Non repeat chars violation found: " + string.Join(",", nonRepeatingCharsViolation.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForRepeatViolations(string numeralString, string[] repeatingChars)
        {
            var repeatLimitViolations = repeatingChars.Where(r => numeralString.Count(n => n.ToString() == r) > 3);
            if (repeatLimitViolations.Any())
            {
                var message = "Repeat limit violated for: " + string.Join(",", repeatLimitViolations.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckResultsViolation(string numeralString, int digit)
        {
            if (digit > 3000)
                throw new ArgumentException("Sum cannot be greater than 3000: " + numeralString);
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

        private static int ProduceDigit(string numeralString)
        {
            var digit = 0;
            foreach (var numeral in numeralString)
            {
                switch (numeral.ToString())
                {
                    case "I":
                        digit += 1;
                        break;
                    case "V":
                        digit += 5;
                        break;
                    case "X":
                        digit += 10;
                        break;
                    case "L":
                        digit += 50;
                        break;
                    case "C":
                        digit += 100;
                        break;
                    case "D":
                        digit += 500;
                        break;
                    case "M":
                        digit += 1000;
                        break;
                }
            }
            return digit;
        }
    }
}