using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using NUnit.Framework.Constraints;

namespace RomanNumeralsKata_2016_06_27
{
    public class NumeralConverter
    {
        public int Convert(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            CheckForNonRomanNumerals(numeralString);
            CheckForNonRepeatingNumeralsThatRepeated(numeralString);
            CheckForRepetitionCountViolation(numeralString);
            var sum = 0;
            numeralString = ResolveSubtractingNumerals(numeralString, out sum);

            sum += numeralString.Sum(x => ConvertNumeral(x.ToString()));
            return sum;
        }

        private static void CheckForRepetitionCountViolation(string numeralString)
        {
            var repeatableNumerals = new[] { "I", "X", "C", "M" };
            var repeatableCountViolations = repeatableNumerals.Where(x => numeralString.Count(n => n.ToString() == x) > 3);
            if (repeatableCountViolations.Any())
            {
                var message = "repeating numerals repeating more than 3 times: " + string.Join(",", repeatableCountViolations.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static string ResolveSubtractingNumerals(string numeralString, out int sum)
        {
            sum = 0;
            if (numeralString.Contains("IV"))
            {
                sum += 4;
                return numeralString.Replace("IV", "");
            }
            if (numeralString.Contains("IX"))
            {
                sum += 9;
                return numeralString.Replace("IX", "");
            }
            if (numeralString.Contains("XL"))
            {
                sum += 40;
                return numeralString.Replace("XL", "");
            }
            if (numeralString.Contains("XC"))
            {
                sum += 90;
                return numeralString.Replace("XC", "");
            }
            if (numeralString.Contains("CD"))
            {
                sum += 400;
                return numeralString.Replace("CD", "");
            }
            if (numeralString.Contains("CM"))
            {
                sum += 900;
                return numeralString.Replace("CM", "");
            }
            return numeralString;
        }

        private static void CheckForNonRepeatingNumeralsThatRepeated(string numeralString)
        {
            var nonRepeatingNumerals = new[] { "V", "L", "D" };
            var nonRepeatingNumeralsFound = nonRepeatingNumerals.Where(x => numeralString.Count(n => x == n.ToString()) > 1);
            if (nonRepeatingNumeralsFound.Any())
            {
                var message = "non repeating numerals repeating not allowed: " + string.Join(",", nonRepeatingNumeralsFound.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForNonRomanNumerals(string numeralString)
        {
            var validNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var nonValidNumerals = numeralString.Where(x => !validNumerals.Contains(x.ToString()));
            if (nonValidNumerals.Any())
            {
                var message = "non roman numerals not allowed: " + string.Join(",", nonValidNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static int ConvertNumeral(string numeralString)
        {
            var convertedNumeral = 0;
            switch (numeralString)
            {
                case "I":
                    convertedNumeral += 1;
                    break;
                case "V":
                    convertedNumeral += 5;
                    break;
                case "X":
                    convertedNumeral += 10;
                    break;
                case "L":
                    convertedNumeral += 50;
                    break;
                case "C":
                    convertedNumeral += 100;
                    break;
                case "D":
                    convertedNumeral += 500;
                    break;
                case "M":
                    convertedNumeral += 1000;
                    break;
            }
            return convertedNumeral;
        }
    }
}