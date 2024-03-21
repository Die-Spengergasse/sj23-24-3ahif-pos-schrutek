namespace Spg.SpengerAdmin.DomainModel.Model
{
    public record Address(string Street, string HouseNumber, string City, string ZipCode)
    {
        public override string ToString()
        {
            return $"{Street} {HouseNumber}, {ZipCode}-{City}";
        }
    }

    //public class Address
    //{
    //    public Address(string street, string houseNumber, string city, string zipCode)
    //    {
    //        Street = street;
    //        HouseNumber = houseNumber;
    //        City = city;
    //        ZipCode = zipCode;
    //    }

    //    public string Street { get; } = string.Empty;
    //    public string HouseNumber { get; } = string.Empty;
    //    public string City { get; } = string.Empty;
    //    public string ZipCode { get; } = string.Empty;
    //}
}
