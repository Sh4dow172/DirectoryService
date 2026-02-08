using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using Shared;

namespace DirectoryService.Domain.Departments.VO;

public record DepartmentPath
{
    private DepartmentPath(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<DepartmentPath, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation(null, "Department path cannot be empty");

        string trimmed = value.Trim().ToLower();
        
        if (!Regex.IsMatch(trimmed, @"^[a-z0-9]+(\.[a-z0-9]+)*$"))
            return Error.Validation(null, "Department path contains invalid characters");
        
        return new DepartmentPath(value);
    }
}