using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Departments.VO;

public sealed record DepartmentIdentifier
{
    private const int MinLength = 3;
    private const int MaxLength = 150;
    
    private DepartmentIdentifier(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<DepartmentIdentifier, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, "Department identifier cannot be empty");
        
        if (value.Length < MinLength || value.Length > MaxLength)
            return Error.Validation(null, $"Department identifier must be between {MinLength} and {MaxLength} characters");
        
        if (value.All(c => char.IsWhiteSpace(c) || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') ))
            return Error.Validation(null, "Department identifier must contain only Latin letters");
        
        return new DepartmentIdentifier(value);
    }
}