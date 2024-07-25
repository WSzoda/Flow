using System.ComponentModel.DataAnnotations;
using Flow.Application.Exceptions;
using Flow.Core.DTOs.Interal;
using Flow.Core.DTOs.Request.Addresses;
using Flow.Core.Interfaces.OutServices;

namespace Flow.Application.OutServices;

public class GoogleService : IGoogleService
{
    private readonly string _apiKey;

    public GoogleService(string apiKey)
    {
        _apiKey = apiKey;
    }

    public async Task<Location> GetCoordinates(AddressDto address)
    {
        HttpClient httpClient = new HttpClient();

        string query = "https://maps.googleapis.com/maps/api/geocode/json";

        if (address.AddressLine1.Length != 0)
        {
            query += "?address=" + address.AddressLine1;
        }
        if (address.AddressLine2.Length != 0)
        {
            query += "," + address.AddressLine2;
        }
        if (address.State.Length != 0)
        {
            query += "," + address.State;
        }
        if (address.City.Length != 0)
        {
            query += "," + address.City;
        }
        if (address.Country.Length != 0)
        {
            query += "," + address.Country;
        }
        if (address.PostalCode.Length != 0)
        {
            query += "," + address.PostalCode;
        }

        query += "&key=" + _apiKey;

        Uri uri = new Uri(query);

        var response = await httpClient.GetAsync(uri);
        Root? responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(
            await response.Content.ReadAsStringAsync()
        );

        if (responseObject is not null)
        {
            return responseObject.results[0].geometry.location;
        }
        else
        {
            throw new GeolocalizationNotFoundException(
                "Couldn't find geolocalization for provided address"
            );
        }
    }
}
