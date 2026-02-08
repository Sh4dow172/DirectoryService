using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Positions.VO;

public record PositionName
{
    private const int MinLength = 3;
    private const int MaxLength = 100;
    
    private PositionName(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<PositionName, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, "Position name cannot be empty");
        
        if (value.Length < MinLength || value.Length > MaxLength)
            return Error.Validation(null, $"Position name must be between {MinLength} and {MaxLength} symbols");
        
        return new PositionName(value);
    }
}