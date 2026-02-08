namespace DirectoryService.Domain.Departments.VO;

public sealed record DepartmentPositionId
{
    private DepartmentPositionId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }
    
    public static DepartmentPositionId NewId() => new(Guid.NewGuid());
    
    public static DepartmentPositionId Empty() => new(Guid.Empty);
}