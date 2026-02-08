using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Positions.VO;

public sealed record PositionDescription
{
    private const int MaxLength = 1000;
    
    private PositionDescription(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<PositionDescription, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, $"Position description cannot be empty");
        
        if (value.Length > MaxLength)
            return Error.Validation(null, $"Position description must contain no more than {MaxLength} characters");

        return new PositionDescription(value);
    }
}