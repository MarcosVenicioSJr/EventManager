using EventManager.Domain.Entities;

namespace EventManager.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task<Event> GetById(int id);
    }
}
