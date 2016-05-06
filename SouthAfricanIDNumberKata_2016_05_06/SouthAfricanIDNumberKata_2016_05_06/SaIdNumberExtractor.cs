namespace SouthAfricanIDNumberKata_2016_05_06
{
    public class SaIdNumberExtractor
    {
        public string ExtractDateOfBirth(string idNumber)
        {
            var yy = int.Parse(idNumber.Substring(0, 2));
            var prefixForYear = yy < 20 ? "20" : "19";
            var yyyy = string.Concat(prefixForYear, yy);
            var mm = idNumber.Substring(2, 2);
            var dd = idNumber.Substring(4, 2);
            return $"{dd}-{mm}-{yyyy}";
        }

        public string ExtractGender(string idNumber)
        {
            var g = int.Parse(idNumber.Substring(6));
            var gender = g < 5 ? "Female" : "Male";
            return gender;
        }

        public string ExtractCitizenshipStatus(string idNumber)
        {
            var c = int.Parse(idNumber.Substring(10, 1));
            var citizenshipStatus = c < 1 ? "SA" : "Other";
            return citizenshipStatus;
        }

        public string ExtractIDParts(string idNumber)
        {
            var dateOfBirth = ExtractDateOfBirth(idNumber);
            var gender = ExtractGender(idNumber);
            var citizenshipStatus = ExtractCitizenshipStatus(idNumber);
            return $"{dateOfBirth},{gender},{citizenshipStatus}";
        }
    }
}