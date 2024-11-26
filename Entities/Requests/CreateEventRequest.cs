using EventManager.Domain.Entities.Enums;

namespace EventManager.Entities.Requests
{
    public class CreateEventRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryType Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
        public CreateAddressRequest Address { get; set; }
        public CreateOrganizerRequest Organizer { get; set; }
    }
}
