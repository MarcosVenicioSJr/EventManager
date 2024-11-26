using EventManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace EventManager.Context
{
    public class EventManagerContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        public EventManagerContext(DbContextOptions<EventManagerContext> options) : base(options)
        {
        }
    }
}
