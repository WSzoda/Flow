using Flow.Core.Interfaces.OutServices;

namespace Flow.Application.OutServices;

public class GoogleService : IGoogleService
{
    private readonly string _apiKey;

    public GoogleService(string apiKey)
    {
        _apiKey = apiKey;
    }
}