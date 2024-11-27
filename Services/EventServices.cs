using EventManager.Domain.Entities;
using EventManager.Entities.Requests;
using EventManager.Interfaces.Repositories;
using EventManager.Interfaces.Services;

namespace EventManager.Services
{
    public class EventServices : IEventServices
    {
        private readonly IEventRepository _repository;
        private readonly IOrganizerService _organizerService;
        private readonly IAddressService _addressService;

        public EventServices(IEventRepository repository, IOrganizerService organizerService, IAddressService addressService)
        {
            _repository = repository;
            _organizerService = organizerService;
            _addressService = addressService;
        }

        public async Task Create(CreateEventRequest request)
        {
            _organizerService.CreateOrganizer(request.Organizer);
            _addressService.CreateAddress(request.Address);

            Event entity = new Event()
            {
                Name = request.Name,
                Description = request.Description,
                Category = request.Category,
                Address = new Address()
                {
                    City = request.Address.City,
                    Country = request.Address.Country,
                    Neighborhood = request.Address.Neighborhood,
                    PostalCode = request.Address.PostalCode,
                    Street = request.Address.Street,
                },
                Organizer = new Organizer()
                {
                    Name = request.Organizer.Name,
                    Mail = request.Organizer.Mail,
                    PhoneNumber = request.Organizer.PhoneNumber,
                },
                StartDate = DateTime.UtcNow,
                FinalDate = DateTime.UtcNow,
                Status = Domain.Entities.Enums.EventStatus.Created
            };

            await _repository.Save(entity);
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
