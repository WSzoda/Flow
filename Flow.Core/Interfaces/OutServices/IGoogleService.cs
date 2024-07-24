using Flow.Core.DTOs.Request.Addresses;

namespace Flow.Core.Interfaces.OutServices;

public interface IGoogleService
{
    Task<string> GetCoordinates(AddressDto address);
}