using Flow.Core.Entities;
using Flow.Core.Interfaces.Repositories;
using Flow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Flow.Infrastructure.Repositories;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _context;

    public AddressRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IQueryable<Address> GetAllAddresses()
    {
        return _context.Addresses.AsNoTracking().AsQueryable();
    }

    public async Task<Address?> GetAddressAsync(long addressId)
    {
        return await _context.Addresses.AsNoTracking().FirstOrDefaultAsync(a => a.Id == addressId);
    }

    public async Task AddAddressAsync(Address address)
    {
        await _context.Addresses.AddAsync(address);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAddressAsync(long addressId)
    {
        var address = await _context.Addresses.AsNoTracking().FirstOrDefaultAsync(a => a.Id == addressId);
        ArgumentNullException.ThrowIfNull(address);

        _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAddressAsync(Address address)
    {
        _context.Addresses.Update(address);
        await _context.SaveChangesAsync();
    }
}