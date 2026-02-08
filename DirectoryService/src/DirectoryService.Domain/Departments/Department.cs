using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments.VO;
using Shared;

namespace DirectoryService.Domain.Departments;

public class Department
{
    //efcore
    private Department() {}
    
    public Department(
        DepartmentId id,
        DepartmentName name,
        DepartmentIdentifier identifier,
        Guid parentId,
        DepartmentPath path,
        short depth,
        bool isActive)
    {
        Id = id;
        Name = name;
        Identifier = identifier;
        ParentId = parentId;
        Path = path;
        Depth = depth;
        IsActive = isActive;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    private readonly List<DepartmentPosition> _departmentPositions = [];
    private readonly List<DepartmentLocation> _departmentLocations = [];
    private readonly List<Department> _subDepartments = [];
    
    public DepartmentId Id { get; private set; }
    
    public DepartmentName Name { get; private set; }
    
    public DepartmentIdentifier Identifier  { get; private set; }
    
    public Guid? ParentId { get; private set; }
    
    public DepartmentPath Path { get; private set; }
    
    public short Depth { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    
    public IReadOnlyList<DepartmentPosition> DepartmentPositions => _departmentPositions;
    
    public IReadOnlyList<DepartmentLocation> DepartmentLocations => _departmentLocations;
    
    public IReadOnlyList<Department> SubDepartments => _subDepartments;
}