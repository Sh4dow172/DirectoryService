using DirectoryService.Domain.Departments.VO;

namespace DirectoryService.Domain.Departments;

public class DepartmentPosition
{
    //efcore
    private DepartmentPosition() {}
    
    private DepartmentPosition(DepartmentPositionId departmentLocationId, Guid positionId, Guid departmentId)
    {
        Id = departmentLocationId;
        PositionId = positionId;
        DepartmentId = departmentId;
    }
    
    public DepartmentPositionId Id { get; private set; }
    
    public Guid DepartmentId { get; private set; }
    
    public Guid PositionId { get; private set; }
    
    public static DepartmentPosition Create
        (DepartmentPositionId departmentPositionId, Guid positionId, Guid departmentId)
        => new DepartmentPosition(departmentPositionId, positionId, departmentId);
}