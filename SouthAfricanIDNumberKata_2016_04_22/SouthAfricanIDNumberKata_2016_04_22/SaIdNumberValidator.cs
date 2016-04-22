using System.Linq;

namespace SouthAfricanIDNumberKata_2016_04_22
{
    public class SaIdNumberValidator
    {
        public int AddOddPostionDigits(string idNumber)
        {
            var total = AddDigits(idNumber, 0, 2, idNumber.Length - 1);
            return total;
        }

        private int AddDigits(string idNumber, int startPosition, int step, int stopIndex)
        {
            var total = 0;
            for (int i = startPosition; i < stopIndex; i += step)
                total += int.Parse(idNumber[i].ToString());
            return total;
        }

        public int DoubleTheConcatedEvenPositionDigits(string idNumber)
        {
            var evenPositions = GetEvenPositions(idNumber);
            return int.Parse(evenPositions) * 2;
        }

        private string GetEvenPositions(string idNumber)
        {
            var evenPositions = "";
            for (int i = 1; i < idNumber.Length - 1; i += 2)
                evenPositions += idNumber[i].ToString();
            return evenPositions;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositions = DoubleTheConcatedEvenPositionDigits(idNumber).ToString();
            var total = AddDigits(evenPositions, 0, 1, evenPositions.Length);
            return total;
        }

        public int AddOddAndEvenPositionTotals(string idNumber)
        {
            var addOddPostionDigits = AddOddPostionDigits(idNumber);
            var addEvenPositionDigits = AddEvenPositionDigits(idNumber);
            return addOddPostionDigits + addEvenPositionDigits;
        }

        public int GetTallyNumber(string idNumber)
        {
            var results = AddOddPostionDigits(idNumber).ToString();
            var numberToUse = (results.Length > 1 ? int.Parse(results.Last().ToString()) : int.Parse(results));
            var tallyNumber = 10 - numberToUse;
            return tallyNumber;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = int.Parse(idNumber.Last().ToString());
            var tallyNumber = GetTallyNumber(idNumber);
            return controlDigit == tallyNumber;
        }
    }
}