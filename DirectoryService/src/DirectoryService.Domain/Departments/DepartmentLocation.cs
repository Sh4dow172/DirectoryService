using DirectoryService.Domain.Departments.VO;

namespace DirectoryService.Domain.Departments;

public class DepartmentLocation
{
    //efcore
    private DepartmentLocation() {}
    
    private DepartmentLocation(DepartmentLocationId departmentLocationId, Guid departmentId, Guid locationId)
    {
        Id = departmentLocationId;
        DepartmentId = departmentId;
        LocationId = locationId;
    }
    
    public DepartmentLocationId Id { get; private set; }

    public Guid DepartmentId { get; private set; }
    
    public Guid LocationId { get; private set; }

    public static DepartmentLocation Create
    (DepartmentLocationId departmentLocationId, Guid locationId, Guid departmentId) 
        => new DepartmentLocation(departmentLocationId, departmentId, locationId);
}