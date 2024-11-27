using EventManager.Domain.Entities;

namespace EventManager.Interfaces.Repositories
{
    public interface IAddressRepository
    {
        Task<Address> GetByZipCode(string code);
        void Save(Address address);
    }
}
