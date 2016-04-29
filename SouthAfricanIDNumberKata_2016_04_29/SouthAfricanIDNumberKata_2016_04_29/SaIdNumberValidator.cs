using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_29
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var listOfOddDigits = GetListOfDigits(idNumber, 0);
            return listOfOddDigits.Sum();
        }

        private List<int> GetListOfDigits(string idNumber, int startIndex)
        {
            var listOfOddDigits = new List<int>();
            for (int i = startIndex; i < idNumber.Length - 1; i += 2)
                listOfOddDigits.Add(int.Parse(idNumber[i].ToString()));
            return listOfOddDigits;
        }

        public int ResolveEvenPositionDigits(string idNumber)
        {
            var listOfEvenDigits = GetListOfDigits(idNumber, 1);
            var doubledResultOfEvenPositionsConcated = int.Parse(string.Concat(listOfEvenDigits)) * 2;
            return doubledResultOfEvenPositionsConcated;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var resolvedEvenPositionDigits = ResolveEvenPositionDigits(idNumber);
            var sum = resolvedEvenPositionDigits.ToString().Sum(x => int.Parse(x.ToString()));
            return sum;
        }

        public int AddPositionDigitsResults(string idNumber)
        {
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            var sumOfPositionDigits = oddPositionDigits + evenPositionDigits;
            return sumOfPositionDigits;
        }

        public int ResolveTallyNumber(string idNumber)
        {
            var digitsResults = AddPositionDigitsResults(idNumber).ToString();
            var secondDigit = digitsResults.Length > 1 ? int.Parse(digitsResults[1].ToString()) : int.Parse(digitsResults);
            var tallyNumber = 10 - secondDigit;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var tallyNumber = ResolveTallyNumber(idNumber).ToString();
            var controlDigit = idNumber.Last().ToString();
            return Equals(tallyNumber, controlDigit);
        }
    }
}