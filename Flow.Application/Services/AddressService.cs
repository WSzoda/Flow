using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Entities;
using Flow.Core.Interfaces.Repositories;
using Flow.Core.Interfaces.Services;
using Flow.Infrastructure.Repositories;

namespace Flow.Application.Services;

public class AddressService : IAddressService
{
  private readonly IAddressRepository _addressRepository;

  public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }


  public Address CreateAddress(AddressDto addressDto)
    {
    //Kod co wysyla zapytanie o long i lat do zewnetrznego api
    string longitude = "0";
    string lantitude = "0";

    return new Address();
    }
}