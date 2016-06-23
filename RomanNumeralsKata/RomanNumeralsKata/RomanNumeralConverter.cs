using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanNumeralConverter
    {
        public int Convert(string numerals)
        {
            if (string.IsNullOrEmpty(numerals))
                return 0;


            CheckForInValidNumerals(numerals);
            ResolveRepeatingNumberals(numerals);

            numerals = ResolveSubtractingNumerals(numerals);

            var sum = numerals.Sum(numeral => ResolveNumerals(numeral.ToString()));
            return sum;
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

        private static int ResolveNumerals(string numerals)
        {
            var sum = 0;
            switch (numerals)
            {
                case "I":
                    sum += 1;
                    break;
                case "V":
                    sum += 5;
                    break;
                case "X":
                    sum += 10;
                    break;
                case "L":
                    sum += 50;
                    break;
                case "C":
                    sum += 100;
                    break;
                case "D":
                    sum += 500;
                    break;
                case "M":
                    sum += 1000;
                    break;
            }
            return sum;
        }

        private static void ResolveRepeatingNumberals(string numerals)
        {
            var romanNonRepeatingNumerals = new[] { "V", "L", "D" };
            var numeralsDuplicated = romanNonRepeatingNumerals.Where(x => numerals.Count(c => c.ToString() == x) > 1);
            if (numeralsDuplicated.Any())
            {
                var message = "non repeating roman numerals repeated: " + string.Join(",", numeralsDuplicated.ToArray());
                throw new ApplicationException(message);
            }
        }

        private static void CheckForInValidNumerals(string numerals)
        {
            var romanNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var invalidNumerals = numerals.Where(x => !romanNumerals.Contains(x.ToString()));
            if (invalidNumerals.Any())
            {
                var message = "non roman numerals not allowed: " + string.Join(",", invalidNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }
    }
}