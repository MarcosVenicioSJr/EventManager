using EventManager.Domain.Entities;

namespace EventManager.Interfaces.Repositories
{
    public interface IOrganizerRepository
    {
        Task<Organizer> GetByMail(string mail);

        void Save(Organizer organizer);
    }
}
