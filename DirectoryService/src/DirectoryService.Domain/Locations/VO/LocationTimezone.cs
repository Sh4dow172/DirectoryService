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
    
    [GeneratedRegex(@"^(UTC|[A-Z][A-Za-z0-9._+-]*(?:/[A-Z][A-Za-z0-9._+-]*)+)$")]
    private static partial Regex IanaFormatRegex();

    public static Result<LocationTimezone, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null,"Value cannot be empty");
        
        value = value.Trim();
        
        if (!IanaFormatRegex().IsMatch(value))
            return Error.Validation(null,"Value is not a valid Iana");
        
        var zone = DateTimeZoneProviders.Tzdb.GetZoneOrNull(value);
        if (zone is null)
            return Error.Validation(null,"Value is not a valid timezone");
        
        return new LocationTimezone(value);
    }
}