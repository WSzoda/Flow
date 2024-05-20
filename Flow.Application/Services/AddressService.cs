using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Entities;
using Flow.Core.Interfaces.Services;
using Flow.Infrastructure.Repositories;

namespace Flow.Application.Services;

public class AddressService : IAddressService
{
    private readonly AddressRepository _addressRepository;

    public AddressService(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task<Address> CreateAddress(AddressDto addressDto)
    {
        Address address = new Address
        {
            City = addressDto.City, AddressLine1 = addressDto.AddressLine1, AddressLine2 = addressDto.AddressLine2, Country = addressDto.Country, Latitude = "0",
            Longitude = "0", State = addressDto.State, PostalCode = addressDto.PostalCode
        };

        await _addressRepository.AddAddressAsync(address);
        Console.WriteLine(address);
        return address;
    }
}