using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Entities;
using Flow.Core.Interfaces.OutServices;
using Flow.Core.Interfaces.Repositories;
using Flow.Core.Interfaces.Services;
using Flow.Infrastructure.Repositories;

namespace Flow.Application.Services;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;
    private readonly IGoogleService _googleService;
        
    public AddressService(IAddressRepository addressRepository, IGoogleService googleService)
    {
        _addressRepository = addressRepository;
        _googleService = googleService;
    }

    public async Task<Address> CreateAddress(AddressDto addressDto)
    {
        
        var localization = await _googleService.GetCoordinates(addressDto);
        Console.WriteLine(localization);
        
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