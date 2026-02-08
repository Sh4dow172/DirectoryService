using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Departments.VO;

public record DepartmentName
{
    private const int MaxLength = 150;
    private const int MinLength = 3;
    
    private DepartmentName(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<DepartmentName, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, "Department name cannot be empty");
        
        if (value.Length > MaxLength || value.Length < MinLength)
            return Error.Validation(null, $"Department name must be between {MinLength} and {MaxLength} characters");
        
        return new DepartmentName(value);
    }
}