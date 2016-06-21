using System;
using System.Collections.Generic;
using System.Linq;

namespace NumeralConverter
{
    internal class NumeralsConverter
    {
        public int GetDigit(string numeralString)
        {
            if (string.IsNullOrEmpty(numeralString))
                return 0;

            CheckForInValidNumerals(numeralString);
            CheckForNonRepeatingNumerals(numeralString);

            numeralString = ResolveSubtractionInNumeralString(numeralString);

            var sum = GetSum(numeralString);
            CheckForResultsExceedingThreeThousand(sum);
            return sum;
        }

        private static int GetSum(string numeralString)
        {
            var sum = numeralString.Sum(numeral => GetNumeralValue(numeral.ToString()));
            
            return sum;
        }

        private static string ResolveSubtractionInNumeralString(string numeralString)
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

        private static int GetNumeralValue(string numeral)
        {
            switch (numeral)
            {
                case "I":
                    return 1;
                case "X":
                    return 10;
                case "C":
                    return 100;
                case "M":
                    return 1000;
                case "V":
                    return 5;
                case "L":
                    return 50;
                case "D":
                    return 500;
                default:
                    return 0;
            }
        }

        private static void CheckForResultsExceedingThreeThousand(int resolveNumeral)
        {
            if (resolveNumeral > 3000)
                throw new ApplicationException("Digits cannot exceed 3000");
        }


        private static void CheckForNonRepeatingNumerals(string numeral)
        {
            var nonRepeatables = new[] { 'V', 'L', 'D' };
            var nonRepeatablesFound = numeral.Where(x => nonRepeatables.Contains(x));
            var nonRepeatList = new List<string>();
            foreach (var nonRepeat in nonRepeatablesFound)
            {
                if (nonRepeatablesFound.Count(x => x == nonRepeat) > 1)
                    nonRepeatList.Add(nonRepeat.ToString());
            }
            if (nonRepeatList.Any())
            {
                var message = "Non repeating numerals found: " + string.Join(",", nonRepeatList.Distinct().ToArray());
                throw new ArgumentException(message);
            }
        }

        private static void CheckForInValidNumerals(string numeral)
        {
            var validNumerals = new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            var inValidNumerals = numeral.Where(x => !validNumerals.Contains(x));
            if (inValidNumerals.Any())
            {
                var message = "Invalid numeral: " + inValidNumerals.First();
                Console.Write(message);
                throw new ArgumentException(message);
            }
        }
    }
}