using System;

namespace SouthAfricanIDNumberKata_2016_04_19
{
    public class SAIDNumberExtractor
    {
        public string ExtractIDParts(string idNumber)
        {
            var dateOfBirth = ExtractDateOfBirth(idNumber);
            var gender = ExtractGender(idNumber);
            var citizenship = ExtractCitizenship(idNumber);
            return $"{dateOfBirth}, {gender} {citizenship}";
        }

        public string ExtractDateOfBirth(string idNumber)
        {
            var yy = int.Parse(idNumber.Substring(0, 2));
            var yyyy = (yy < 20 ? "20" : "19") + yy.ToString();
            var mm = idNumber.Substring(2, 2);
            var dd = idNumber.Substring(4, 2);
            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idNumber)
        {
            var g = idNumber.Substring(6, 1);
            return int.Parse(g) < 5 ? "Female" : "Male";
        }

        public string ExtractCitizenship(string idNumber)
        {
            var c = int.Parse(idNumber.Substring(10, 1));
            return c < 1 ? "SA" : "Other";
        }
    }
}