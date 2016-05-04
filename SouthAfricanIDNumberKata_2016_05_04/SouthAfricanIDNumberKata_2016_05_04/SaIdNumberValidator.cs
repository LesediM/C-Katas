using System;
using System.Linq;

namespace SouthAfricanIDNumberKata_2016_05_03
{
    public class SaIdNumberValidator
    {
        public int AddOddPositionDigits(string idNumber)
        {
            var total = 0;
            for (int i = 0; i < idNumber.Length - 1; i += 2)
                total += int.Parse(idNumber[i].ToString());
            return total;
        }

        public int GetEvenPositionDigits(string idNumber)
        {
            var evenPosition = "";
            for (int i = 1; i < idNumber.Length; i += 2)
                evenPosition += int.Parse(idNumber[i].ToString());
            return int.Parse(evenPosition) * 2;
        }

        public int AddEvenPositionDigits(string idNumber)
        {
            var evenPositionDigits = GetEvenPositionDigits(idNumber).ToString();
            return evenPositionDigits.Sum(x => int.Parse(x.ToString()));
        }

        public int AddResolvedPositionDigits(string idNumber)
        {
            var oddPositionDigits = AddOddPositionDigits(idNumber);
            var evenPositionDigits = AddEvenPositionDigits(idNumber);
            return oddPositionDigits + evenPositionDigits;
        }

        public int ResolveTallyToken(string idNumber)
        {
            var resolvedPositionDigits = AddResolvedPositionDigits(idNumber).ToString();
            var numberToSubtract = resolvedPositionDigits.Length > 1 ? int.Parse(resolvedPositionDigits[1].ToString()) : int.Parse(resolvedPositionDigits);
            var tallyToken = 10 - numberToSubtract;
            return tallyToken;
        }

        public bool ValidateID(string idNumber)
        {
            var controlDigit = idNumber.Last().ToString();
            var tallyToken = ResolveTallyToken(idNumber).ToString();
            var idNumberIsValid = Equals(controlDigit, tallyToken);
            return idNumberIsValid;
        }
    }
}