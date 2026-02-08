using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using NodaTime;
using Shared;

namespace DirectoryService.Domain.Locations.VO;

public partial record LocationTimezone
{
    private LocationTimezone(string value)
    {
        Value = value;
    }
    
    public string Value { get; }
    
    public static Result<LocationTimezone, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null,"Value cannot be empty");
        
        value = value.Trim();
        
        if (!TimeZoneInfo.TryFindSystemTimeZoneById(value, out _))
            return Error.Validation(null, "Value is not a valid timezone");
        
        return new LocationTimezone(value);
    }
}