using EventManager.Domain.Entities;

namespace EventManager.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetById(int id);
    }
}
