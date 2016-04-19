using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SouthAfricanIDNumberKata_2016_04_19
{
    public class SAIDNumberValidator
    {
        public bool ValidateID(string idNumber)
        {
            return TallyIDNumberControlDigit(idNumber);
        }

        public int AddDigitsInOddPositionsExceptLast(string idNumber)
        {
            var oddPositionNumberList = GetNumberList(idNumber, 0);
            return oddPositionNumberList.Sum();
        }

        private List<int> GetNumberList(string idNumber, int startPosition)
        {
            var numberList = new List<int>();
            for (int i = startPosition; i < idNumber.Length - 1; i += 2)
                numberList.Add(int.Parse(idNumber[i].ToString()));
            return numberList;
        }

        public string MoveEvenPositionsIntoField(string idNumber)
        {
            var evenPositionNumberList = GetNumberList(idNumber, 1);
            return string.Concat(evenPositionNumberList);
        }

        public int MultiplyEvenPositionFieldByTwo(string idNumber)
        {
            var evenPositionField = MoveEvenPositionsIntoField(idNumber);
            return int.Parse(evenPositionField) * 2;
        }

        public int AddDigitsOfMultipliedEvenPositionField(string idNumber)
        {
            var multipliedEvenPositions = MultiplyEvenPositionFieldByTwo(idNumber).ToString();
            return multipliedEvenPositions.Sum(x => int.Parse(x.ToString()));
        }

        public int AddSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits(string idNumber)
        {
            var addDigitsOfMultipliedEvenPositionField = AddDigitsOfMultipliedEvenPositionField(idNumber);
            var addDigitsInOddPositionsExceptLast = AddDigitsInOddPositionsExceptLast(idNumber);
            return addDigitsInOddPositionsExceptLast + addDigitsOfMultipliedEvenPositionField;
        }

        public bool TallyIDNumberControlDigit(string idNumber)
        {
            var addSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits = AddSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits(idNumber).ToString();
            var tallyNumber = 10 - int.Parse(addSumOfMultipliedEvenPositionDigitsAndSumOfOddPositionDigits.Last().ToString());
            var controlDigit = int.Parse(idNumber.Last().ToString());
            return Equals(tallyNumber, controlDigit);
        }
    }
}