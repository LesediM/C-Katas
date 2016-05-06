using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_05_06
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionIdNumberDigits(string idNumber)
        {
            var listDigits = GetDigits(idNumber, 0);
            var sumOfDigits = listDigits.Sum(x => int.Parse(x.ToString()));
            return sumOfDigits;
        }

        private List<int> GetDigits(string idNumber, int startPosition)
        {
            var listDigits = new List<int>();
            for (int i = startPosition; i < idNumber.Length - 1; i += 2)
                listDigits.Add(int.Parse(idNumber[i].ToString()));
            return listDigits;
        }

        public int GetEvenPositionIdNumberDigits(string idNumber)
        {
            var digits = GetDigits(idNumber, 1);
            var concatedDigits = string.Concat(digits.ToArray());
            var doubleConcatedDigits = int.Parse(concatedDigits) * 2;
            return doubleConcatedDigits;
        }

        public int AddEvenPositionIdNumberDigits(string idNumber)
        {
            var digits = GetEvenPositionIdNumberDigits(idNumber);
            var sumOfDigits = digits.ToString().Sum(x => int.Parse(x.ToString()));
            return sumOfDigits;
        }

        public int AddAllResultsOfPositionDigits(string idNumber)
        {
            var addoddPositionDigitsTotal = AddOddPositionIdNumberDigits(idNumber);
            var addEvenPositionDigitsTotal = AddEvenPositionIdNumberDigits(idNumber);
            var totalOfResults = addoddPositionDigitsTotal + addEvenPositionDigitsTotal;
            return totalOfResults;
        }

        public int GetTallyNumber(string idNumber)
        {
            var resultsOfPositionDigits = AddAllResultsOfPositionDigits(idNumber).ToString();
            var subtractionDigit = resultsOfPositionDigits.Length > 1 ? int.Parse(resultsOfPositionDigits[1].ToString()) : int.Parse(resultsOfPositionDigits);
            var tallyNumber = 10 - subtractionDigit;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = idNumber.Last().ToString();
            var tallyNumber = GetTallyNumber(idNumber).ToString();
            return string.Equals(controlDigit, tallyNumber);
        }
    }
}