using EventManager.Domain.Entities;

namespace EventManager.Interfaces
{
    public interface IEventServices
    {
        Event GetById(int id);
    }
}
