namespace Spg.SpengerAdmin.DomainModel.Model
{
    public record Address(
        string Street, 
        string HouseNumber, 
        string City, 
        string ZipCode
        )
    {
        //public List<Country> Country { get; set; }

        public override string ToString()
        {
            return $"{Street} {HouseNumber}, {ZipCode}-{City}";
        }
    }
}
