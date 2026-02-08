namespace DirectoryService.Domain.Departments.VO;

public record DepartmentLocationId
{
    private DepartmentLocationId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }
    
    public static DepartmentLocationId NewId() => new(Guid.NewGuid());
    
    public static DepartmentLocationId Empty => new(Guid.Empty);
}