using System.ComponentModel.DataAnnotations;

namespace EventManager.Domain.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Neighborhood { get; set; }
        public string PostalCode { get; set; }
    }
}
