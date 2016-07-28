using System;
using System.Collections.Generic;

namespace RomanCalculator_2016_07_27
{
    public class RomanCalculator
    {
        enum RomanNumerals
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }
        private List<string> _numerals = new List<string>();
        public void Enter(string numeral)
        {
            _numerals.Add(numeral);
        }

        public string Add()
        {
            var largerNumeral = _numerals[0] + _numerals[1];


            RomanNumerals roman = new RomanNumerals();

            Type enumType = roman.GetType();
            Enum.Parse(new RomanNumerals().GetType(), _numerals[0]);
            roman = (RomanNumerals)Enum.Parse(enumType, _numerals[0]);

            return largerNumeral
                .Replace("IIII", "IV")
                .Replace("XXXX", "XL")
                .Replace("CCCC", "CD")
                .Replace("VV", "X")
                .Replace("LL", "C")
                .Replace("DD", "M");
        }
    }
}