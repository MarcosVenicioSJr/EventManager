using EventManager.Context;
using EventManager.Domain.Entities;
using EventManager.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Repository
{
    public class OrganizerRepository : IOrganizerRepository
    {
        private readonly EventManagerContext _context;

        public OrganizerRepository(EventManagerContext context)
        {
            _context = context;
        }

        public async Task<Organizer> GetByMail(string mail)
        {
            return await _context.Organizers.FirstOrDefaultAsync(x => x.Mail == mail);
        }

        public async void Save(Organizer organizer)
        {
            await _context.Organizers.AddAsync(organizer);
        }
    }
}
