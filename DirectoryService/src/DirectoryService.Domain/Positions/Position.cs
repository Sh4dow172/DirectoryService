using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Positions.VO;
using Shared;

namespace DirectoryService.Domain.Positions;

public sealed class Position
{
    //efcore
    private Position() {}
    
    public Position(PositionId id, PositionName name, PositionDescription description, bool isActive, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    private readonly List<DepartmentPosition> _departmentPositions = [];
    
    public PositionId Id { get; private set; }
    
    public PositionName Name { get; private set; }
    
    public PositionDescription Description { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    
    public IReadOnlyList<DepartmentPosition> DepartmentLocations => _departmentPositions;
}