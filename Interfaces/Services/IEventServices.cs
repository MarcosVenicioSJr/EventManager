using EventManager.Domain.Entities;
using EventManager.Entities.Requests;

namespace EventManager.Interfaces.Services
{
    public interface IEventServices
    {
        Event GetById(int id);

        List<Event> GetAll();

        Task Create(CreateEventRequest request);
    }
}
