namespace EventManager.Entities.Requests
{
    public class CreateAddressRequest
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Neighborhood { get; set; }
        public string PostalCode { get; set; }
    }
}
