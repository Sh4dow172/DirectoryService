using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Locations.VO;

public record LocationAddress
{
    private LocationAddress(
        string country,
        string region,
        string city,
        string street,
        string houseNumber)
    {
        Country = country;
        Region = region;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
    }
    
    public string Country { get; }
    public string Region { get; }
    public string City { get; }
    public string Street { get; }
    public string HouseNumber { get; }
    
    public static Result<LocationAddress, Error> Create(
        string country,
        string region,
        string city,
        string street,
        string houseNumber)
    {
        if (string.IsNullOrWhiteSpace(country))
            return Error.Validation(null,"Country is required");
        
        if (string.IsNullOrWhiteSpace(region))
            return Error.Validation(null,"Region is required");
        
        if (string.IsNullOrWhiteSpace(city))
            return Error.Validation(null,"City is required");
        
        if (string.IsNullOrWhiteSpace(street))
            return Error.Validation(null,"Street is required");
        
        if (string.IsNullOrWhiteSpace(houseNumber))
            return Error.Validation(null,"House number is required");
        
        return new LocationAddress(country, region, city, street, houseNumber);
    }
}