using System;
using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_21
{
    public class SAIdNumberValidator
    {
        public int SumOddPositionDigits(string idNumber)
        {
            var numberList = GetNumberList(idNumber, 0);
            return numberList.Sum();
        }

        private List<int> GetNumberList(string idNumber, int startPosition)
        {
            var numberList = new List<int>();
            for (var i = startPosition; i < idNumber.Length - 1; i += 2)
                numberList.Add(int.Parse(idNumber[i].ToString()));
            return numberList;
        }

        public int DoubleConcatedEvenPositionDigits(string idNumber)
        {
            var numberList = GetNumberList(idNumber, 1);
            return int.Parse(string.Concat(numberList)) * 2;
        }

        public int SumEvenPositionDigits(string idNumber)
        {
            return DoubleConcatedEvenPositionDigits(idNumber).ToString().Sum(x => int.Parse(x.ToString()));
        }

        public int SumOddAndEvenPositionDigits(string idNumber)
        {
            return SumEvenPositionDigits(idNumber) + SumOddPositionDigits(idNumber);
        }

        public int GetTallyToken(string idNumber)
        {
            return 10 - int.Parse(SumOddAndEvenPositionDigits(idNumber).ToString().Last().ToString());
        }

        public bool ValidateId(string idNumber)
        {
            var tallyToken = GetTallyToken(idNumber).ToString();
            var controlDigit = idNumber.Last().ToString();
            return Equals(controlDigit, tallyToken);
        }
    }
}