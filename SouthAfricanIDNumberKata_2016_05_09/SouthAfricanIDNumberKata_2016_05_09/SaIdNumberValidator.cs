using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_05_09
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var numberList = GetNumberList(idNumber, 0);
            return numberList.Sum();
        }

        private List<int> GetNumberList(string idNumber, int startPostion)
        {
            var numberList = new List<int>();
            for (int i = startPostion; i < idNumber.Length - 1; i += 2)
            {
                numberList.Add(int.Parse(idNumber[i].ToString()));
            }
            return numberList;
        }

        public int GetEvenPositionDigits(string idNumber)
        {
            var numberList = GetNumberList(idNumber, 1);
            var results = int.Parse(string.Concat(numberList)) * 2;
            return results;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = GetEvenPositionDigits(idNumber);
            var sum = evenPositionDigits.ToString().Sum(x => int.Parse(x.ToString()));
            return sum;
        }

        public int AddPositionDigitCalculations(string idNumber)
        {
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            var results = oddPositionDigits + evenPositionDigits;
            return results;
        }

        public int GetTallyNumber(string idNumber)
        {
            var digitCalculations = AddPositionDigitCalculations(idNumber).ToString();
            var numberForSubtraction = digitCalculations.Length > 1 ? int.Parse(digitCalculations[1].ToString()) : int.Parse(digitCalculations);
            var tallyNumber = 10 - numberForSubtraction;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var tallyNumber = GetTallyNumber(idNumber).ToString();
            var controlDigit = idNumber.Last().ToString();
            return string.Equals(controlDigit, tallyNumber);
        }
    }
}