using EventManager.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Domain.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryType Category { get; set; }
        public Address Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinalDate { get; set; }
        public EventStatus Status { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
