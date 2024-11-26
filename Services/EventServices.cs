using EventManager.Domain.Entities;
using EventManager.Interfaces.Repositories;
using EventManager.Interfaces.Services;

namespace EventManager.Services
{
    public class EventServices : IEventServices
    {
        private readonly IEventRepository _repository;

        public EventServices(IEventRepository repository)
        {
            _repository = repository;
        }

        public List<Event> GetAll()
        {
            return _repository.GetAll().Result;
        }

        public Event GetById(int id)
        {
            return _repository.GetById(id).Result;
        }
    }
}
