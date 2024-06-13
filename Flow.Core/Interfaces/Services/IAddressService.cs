using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Entities;

namespace Flow.Core.Interfaces.Services;

public interface IAddressService
{
    Address CreateAddress(AddressDto addressDto);
}