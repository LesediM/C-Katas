using System;
using System.Linq;

namespace RomanNumeralsKata_2016_07_22
{
    public class NumeralConverter
    {
        public int Convert(string numeral)
        {
            CheckForStrangeCharacters(numeral);
            CheckForNonRepeatViolations(numeral);
            CheckForRepeatLimitViolations(numeral);
            numeral = ResolveSubtractingCharacters(numeral);
            return GetSum(numeral);
        }

        private static void CheckForStrangeCharacters(string numeral)
        {
            var validCharacters = new[] { "M", "D", "C", "L", "X", "V", "I" };
            var strangeCharacters = numeral.Where(n => !validCharacters.Contains(n.ToString()));
            if (strangeCharacters.Any())
            {
                var message = "Character is not a roman numeral: " + string.Join(",", strangeCharacters.ToArray());
                ThrowArgumentException(message);
            }
        }

        private static void CheckForNonRepeatViolations(string numeral)
        {
            var nonRepeatableCharacters = new[] { "D", "L", "V" };
            var nonRepeatViolations = nonRepeatableCharacters.Where(r => numeral.Count(n => n.ToString() == r) > 1);
            if (nonRepeatViolations.Any())
            {
                var message = "Numeral character cannot be repeated: " + string.Join(",", nonRepeatViolations.ToArray());
                ThrowArgumentException(message);
            }
        }

        private static void CheckForRepeatLimitViolations(string numeral)
        {
            var repeatableCharacters = new[] { "M", "C", "X", "I" };
            var repeatLimitViolation = repeatableCharacters.Where(r => numeral.Count(n => n.ToString() == r) > 3);
            if (repeatLimitViolation.Any())
            {
                var message = "Numeral character cannot be repeated more than three times: " +
                               string.Join(",", repeatLimitViolation.ToArray());
                ThrowArgumentException(message);
            }
        }

        private static void ThrowArgumentException(string message)
        {
            throw new ArgumentException(message);
        }

        private static string ResolveSubtractingCharacters(string numeral)
        {
            return numeral
                .Replace("IV", "IIII")
                .Replace("IX", "VIIII")
                .Replace("XL", "XXXX")
                .Replace("XC", "LXXXX")
                .Replace("CD", "CCCC")
                .Replace("CM", "DCCCC");
        }

        private static int GetSum(string numeral)
        {
            var sum = numeral.Sum(n => GetDigit(n.ToString()));
            if (sum > 3000)
            {
                var message = "Numeral combination returns digit greater than 3000: " + numeral;
                ThrowArgumentException(message);
            }
            return sum;
        }

        private static int GetDigit(string numeral)
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