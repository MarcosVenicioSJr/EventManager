using EventManager.Domain.Entities;

namespace EventManager.Interfaces.Services
{
    public interface IEventServices
    {
        Event GetById(int id);

        List<Event> GetAll();
    }
}
