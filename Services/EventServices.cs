using EventManager.Domain.Entities;
using EventManager.Interfaces;

namespace EventManager.Services
{
    public class EventServices : IEventServices
    {
        private readonly IEventRepository _repository;

        public EventServices(IEventRepository repository)
        {
            _repository = repository;
        }

        public Event GetById(int id)
        {
            return _repository.GetById(id).Result;
        }
    }
}
