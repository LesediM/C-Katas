namespace SouthAfricanIDNumberKata_2016_04_21
{
    public class SAIdNumberExtractor
    {
        public string ExtractDateOfBirth(string idNumber)
        {
            var yy = int.Parse(idNumber.Substring(0, 2));
            var yyyy = string.Concat(yy < 20 ? "20" : "19", yy);
            var mm = idNumber.Substring(2, 2);
            var dd = idNumber.Substring(4, 2);

            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idNumber)
        {
            var g = int.Parse(idNumber.Substring(6, 1));
            return g < 5 ? "Female" : "Male";
        }

        public string ExtractCitizenship(string idNumber)
        {
            var c = int.Parse(idNumber.Substring(10, 1));
            return c < 5 ? "SA" : "Other";
        }

        public string ExtractIDParts(string idNumber)
        {
            var dateOfBirth = ExtractDateOfBirth(idNumber);
            var gender = ExtractGender(idNumber);
            var citizenship = ExtractCitizenship(idNumber);
            return $"{dateOfBirth}, {gender} {citizenship}";
        }
    }
}