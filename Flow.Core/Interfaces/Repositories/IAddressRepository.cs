using Flow.Core.Entities;

namespace Flow.Core.Interfaces.Repositories;

public interface IAddressRepository
{
    IQueryable<Address> GetAllAddresses();
    Task<Address?> GetAddressAsync(long addressId);
    Task AddAddressAsync(Address address);
    Task DeleteAddressAsync(long addressId);
    Task UpdateAddressAsync(Address address);
}