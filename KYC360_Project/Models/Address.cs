namespace KYC360_Project.Models
{
    public class Address:IEntity
    {
        public string? AddressLine { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
