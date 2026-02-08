namespace DirectoryService.Domain.Departments.VO;

public sealed record DepartmentId
{
    private DepartmentId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static DepartmentId NewId(Guid id) => new(Guid.NewGuid());
    
    public static DepartmentId Empty() => new(Guid.Empty);
}