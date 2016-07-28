using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace RomanCalculator_2016_07_26
{
    public class RomanCalculator
    {
        private readonly List<string> _numerals = new List<string>();
        public void Enter(string numeral)
        {
            _numerals.Add(numeral);
        }


        public string Add()
        {
            var rawString = _numerals[0] + _numerals[1];
            CheckForStrangeCharacters(rawString);
            var resolvedRepeatLimit = ResolveRepeatLimit(rawString);
            var sum = ResolveNonRepeat(resolvedRepeatLimit);
            return sum;
        }

        private static void CheckForStrangeCharacters(string rawString)
        {
            var romanNumerals = new[] { "I", "V", "X", "L", "C", "D", "M" };
            var strangeNumerals = rawString.Where(r => !romanNumerals.Contains(r.ToString()));
            if (strangeNumerals.Any())
            {
                var message = "Character is not a roman numeral: " + string.Join(",", strangeNumerals.ToArray());
                throw new ArgumentException(message);
            }
        }

        private static string ResolveNonRepeat(string resolvedSubtraction)
        {
            return resolvedSubtraction
                .Replace("VV", "X")
                .Replace("LL", "C")
                .Replace("DD", "M");
        }

        private static string ResolveRepeatLimit(string rawConcatedNumerals)
        {
            return rawConcatedNumerals
                .Replace("IIII", "IV")
                .Replace("XXXX", "XL")
                .Replace("CCCC", "CD");
        }
    }
}