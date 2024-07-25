using Flow.Core.DTOs.Interal;
using Flow.Core.DTOs.Request.Addresses;

namespace Flow.Core.Interfaces.OutServices;

public interface IGoogleService
{
    Task<Location> GetCoordinates(AddressDto address);
}