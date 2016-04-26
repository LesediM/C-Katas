using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_26
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var numbers = GetNumberList(idNumber, 0, 2, idNumber.Length - 1);
            return numbers.Sum();
        }

        public int ResolveEvenPositionDigits(string idNumber)
        {
            var numbers = GetNumberList(idNumber, 1, 2, idNumber.Length);
            return int.Parse(string.Concat(numbers.ToArray())) * 2;
        }

        private List<int> GetNumberList(string idNumber, int startIndex, int stepValue, int endIndex)
        {
            var numbers = new List<int>();
            for (int i = startIndex; i < endIndex; i += stepValue)
            {
                numbers.Add(int.Parse(idNumber[i].ToString()));
            }
            return numbers;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var resolvedEvenPositionDigits = ResolveEvenPositionDigits(idNumber).ToString();
            return resolvedEvenPositionDigits.Sum(x => int.Parse(x.ToString()));
        }

        public int ResolveAllResults(string idNumber)
        {
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            return oddPositionDigits + evenPositionDigits;
        }

        public int ResolveTallyNumber(string idNumber)
        {
            var results = 10 - int.Parse(ResolveAllResults(idNumber).ToString().Last().ToString());
            var tallyNumber = int.Parse(results.ToString().Last().ToString());
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = idNumber.Last().ToString();
            var tallyNumber = ResolveTallyNumber(idNumber).ToString();
            return Equals(tallyNumber, controlDigit);
        }
    }
}