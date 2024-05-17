using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Entities;

namespace Flow.Core.Interfaces.Services;

public interface IAddressService
{
   Task<Address> CreateAddress(AddressDto addressDto);
}