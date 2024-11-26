using System.ComponentModel.DataAnnotations;

namespace EventManager.Domain.Entities
{
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public List<Event> Events { get; set; }
    }
}
