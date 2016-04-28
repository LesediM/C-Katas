using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_28
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var listNumbers = GetNumbers(idNumber, 0, idNumber.Length - 1);
            return listNumbers.Sum(x => int.Parse(x));
        }

        private List<string> GetNumbers(string idNumber, int startPosition, int endPosition)
        {
            var listNumbers = new List<string>();
            for (int i = startPosition; i < endPosition; i += 2)
            {
                listNumbers.Add(idNumber[i].ToString());
            }
            return listNumbers;
        }

        public int GetEvenPositionDigits(string idNumber)
        {
            var listNumbers = GetNumbers(idNumber, 1, idNumber.Length);
            return int.Parse(string.Concat(listNumbers.ToArray())) * 2;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = GetEvenPositionDigits(idNumber);
            return evenPositionDigits.ToString().Sum(x => int.Parse(x.ToString()));
        }

        public int ResolvePositionDigits(string idNumber)
        {
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            return oddPositionDigits + evenPositionDigits;
        }

        public int ResolveTallyNumber(string idNumber)
        {
            var results = ResolvePositionDigits(idNumber).ToString();
            var secondDigit = results.Length > 1 ? int.Parse(results[1].ToString()) : int.Parse(results);
            return 10 - secondDigit;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = int.Parse(idNumber.Last().ToString());
            var tallyNumber = ResolveTallyNumber(idNumber);
            return Equals(tallyNumber, controlDigit);
        }
    }
}