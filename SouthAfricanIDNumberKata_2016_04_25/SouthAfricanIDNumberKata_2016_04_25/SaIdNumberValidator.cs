using System.Collections.Generic;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_25
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var numbers = GetNumbers(idNumber, 0, 2);
            return numbers.Sum();
        }

        private List<int> GetNumbers(string idNumber, int startPosition, int step)
        {
            var numbers = new List<int>();
            for (int i = startPosition; i < idNumber.Length && idNumber[i] != idNumber.Last(); i += step)
                numbers.Add(int.Parse(idNumber[i].ToString()));
            return numbers;
        }

        public int AddEvenPositionDigitsThenDouble(string idNumber)
        {
            var numbers = GetNumbers(idNumber, 1, 2);
            return int.Parse(string.Concat(numbers)) * 2;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = AddEvenPositionDigitsThenDouble(idNumber).ToString();
            return evenPositionDigits.Sum(x => int.Parse(x.ToString()));
        }

        public int AddOddAndEvenPositionReults(string idNumber)
        {
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            return evenPositionDigits + oddPositionDigits;
        }

        public int GetTallyNumber(string idNumber)
        {
            var subtractingNumber = int.Parse(AddOddAndEvenPositionReults(idNumber).ToString().Last().ToString());
            var tallyNumber = 10 - subtractingNumber;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = idNumber.Last().ToString();
            var tallyNumber = GetTallyNumber(idNumber).ToString();
            return Equals(controlDigit, tallyNumber);
        }
    }
}