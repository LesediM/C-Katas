using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_05_10
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var digitList = GetDigitList(idNumber, 0);
            return digitList.Sum(x => int.Parse(x));
        }

        private List<string> GetDigitList(string idNumber, int startPosition)
        {
            var digitList = new List<string>();
            for (int i = startPosition; i < idNumber.Length - 1; i += 2)
            {
                digitList.Add(idNumber[i].ToString());
            }
            return digitList;
        }

        public int GetEvenPositionDigits(string idNumber)
        {
            var digitList = GetDigitList(idNumber, 1);
            var concatedResults = string.Concat(digitList);
            var results = int.Parse(concatedResults) * 2;
            return results;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = GetEvenPositionDigits(idNumber).ToString();
            var sum = evenPositionDigits.Sum(x => int.Parse(x.ToString()));
            return sum;
        }

        public int AddOddAndEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            return evenPositionDigits + oddPositionDigits;
        }

        public int GetTallyNumber(string idNumber)
        {
            var positionDigitsSum = AddOddAndEvenPositionDigits(idNumber).ToString();
            var subtractNumber = int.Parse(positionDigitsSum.Length > 1 ? positionDigitsSum[1].ToString() : positionDigitsSum);
            var tallyNumber = 10 - subtractNumber;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = idNumber.Last().ToString();
            var tallyNumber = GetTallyNumber(idNumber).ToString();
            return string.Equals(tallyNumber, controlDigit);
        }
    }
}