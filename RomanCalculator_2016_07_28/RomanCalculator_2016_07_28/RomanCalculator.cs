using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanCalculator_2016_07_28
{
    public class RomanCalculator
    {
        private List<string> _numerals = new List<string>();


        public string Add()
        {
            var firstNumeral = _numerals[0];
            var secondNumeral = _numerals[1];
            var firstNumeralIsLarger = IsFirstNumeralLarger(firstNumeral, secondNumeral);
            var results = GetResults(firstNumeralIsLarger, firstNumeral, secondNumeral);
            var resolvedRepetitionViolation = ResolveRepetitionViolation(results);
            return resolvedRepetitionViolation;
        }

        private static string GetResults(bool firstNumeralIsLarger, string firstNumeral, string secondNumeral)
        {
            return firstNumeralIsLarger ? string.Concat(firstNumeral, secondNumeral) : string.Concat(secondNumeral, firstNumeral);
        }

        private bool IsFirstNumeralLarger(string firstNumeral, string secondNumeral)
        {
            var sumFirstNumeral = firstNumeral.Sum(x => GetDigit(x.ToString()));
            var sumSecondNumeral = secondNumeral.Sum(x => GetDigit(x.ToString()));
            return sumFirstNumeral > sumSecondNumeral;
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
            return Int32.MaxValue;
        }

        private static string ResolveRepetitionViolation(string results)
        {
            return results
                .Replace("IIII", "IV")
                .Replace("XXXX", "XL")
                .Replace("CCCC", "CD")
                .Replace("VV", "X")
                .Replace("LL", "C")
                .Replace("DD", "M");
        }

        public void Enter(string numeral)
        {
            _numerals.Add(numeral);
        }
    }
}