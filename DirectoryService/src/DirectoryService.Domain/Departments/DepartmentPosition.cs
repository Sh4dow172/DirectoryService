using DirectoryService.Domain.Departments.VO;

namespace DirectoryService.Domain.Departments;

public class DepartmentPosition
{
    //efcore
    private DepartmentPosition() {}
    
    public DepartmentPosition(DepartmentPositionId departmentLocationId, Guid positionId, Guid departmentId)
    {
        Id = departmentLocationId;
        PositionId = positionId;
        DepartmentId = departmentId;
    }
    
    public DepartmentPositionId Id { get; private set; }
    
    public Guid DepartmentId { get; private set; }
    
    public Guid PositionId { get; private set; }
}