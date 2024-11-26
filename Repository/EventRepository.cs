using EventManager.Context;
using EventManager.Domain.Entities;
using EventManager.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly EventManagerContext _context;

        public EventRepository(EventManagerContext context)
        {
            _context = context;
        }

        public async Task<Event> GetById(int id)
        {
            return await _context.Events.FirstOrDefaultAsync(x => x.EventId == id);
        }
    }
}
