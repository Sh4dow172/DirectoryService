using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Locations.VO;

public record LocationName
{
    private const int MinLength = 3;
    private const int MaxLength = 120;
    
    private LocationName(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<LocationName, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, "Location name cannot be empty");

        if (value.Length > MaxLength || value.Length < MinLength)
            return Error.Validation(null, $"Location name must be between {MinLength} and {MaxLength}");

        return new LocationName(value);
    }
}