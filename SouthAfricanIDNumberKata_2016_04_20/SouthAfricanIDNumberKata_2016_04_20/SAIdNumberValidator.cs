using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_20
{
    public class SAIdNumberValidator
    {
        public int AddOddPositionIDNumberDigits(string idNumber)
        {
            var oddPositionDigits = GetIDNumberDigitsByPosition(idNumber, 0);
            return oddPositionDigits.Sum();
        }

        private List<int> GetIDNumberDigitsByPosition(string idNumber, int startPosition)
        {
            var digits = new List<int>();
            for (int i = startPosition; i < idNumber.Length - 1; i += 2)
                digits.Add(int.Parse(idNumber[i].ToString()));
            return digits;
        }

        public int GetEvenPositionIDNumberDigits(string idNumber)
        {
            var evenPositionDigits = GetIDNumberDigitsByPosition(idNumber, 1);
            return int.Parse(string.Concat(evenPositionDigits)) * 2;
        }

        public int AddEvenPositionIDNumberDigits(string idNumber)
        {
            return GetEvenPositionIDNumberDigits(idNumber).ToString().Sum(x => int.Parse(x.ToString()));
        }

        public int SumDigitTotals(string idNumber)
        {
            return AddOddPositionIDNumberDigits(idNumber) + AddEvenPositionIDNumberDigits(idNumber);
        }

        public int GetTallyToken(string idNumber)
        {
            var lastDigitOfSummmedTotals = SumDigitTotals(idNumber).ToString().Last().ToString();
            var resultset = 10 - int.Parse(lastDigitOfSummmedTotals);
            var token = resultset.ToString().Length == 1 ? resultset : int.Parse(resultset.ToString().Last().ToString());
            return token;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = int.Parse(idNumber.Last().ToString());
            return controlDigit == GetTallyToken(idNumber);
        }
    }
}