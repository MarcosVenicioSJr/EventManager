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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organizer>()
                .HasMany(o => o.Events)
                .WithOne(e => e.Organizer)
                .HasForeignKey(e => e.OrganizerId);
        }
    }
}
