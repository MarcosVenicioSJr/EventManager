using EventManager.Context;
using EventManager.Domain.Entities;
using EventManager.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly EventManagerContext _context;

        public AddressRepository(EventManagerContext context)
        {
            _context = context;
        }

        public async Task<Address> GetByZipCode(string code)
        {
            return await _context.Address.FirstOrDefaultAsync(x => x.PostalCode == code);
        }
    }
}
