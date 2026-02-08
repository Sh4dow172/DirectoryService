using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Locations.VO;
using Shared;

namespace DirectoryService.Domain.Locations;

public class Location
{
    //efcore
    private Location() {}
    
    private Location(LocationId id, LocationName name, LocationAddress address, LocationTimezone timezone,bool isActive, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Address = address;
        Timezone = timezone;
        IsActive = isActive;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    
    private readonly List<DepartmentLocation> _departmentLocations = [];
    
    public LocationId Id { get; private set; }
    
    public LocationName Name { get; private set; }
    
    public LocationAddress Address { get; private set; }
    
    public LocationTimezone Timezone { get; private set; }
    
    public bool IsActive { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public DateTime UpdatedAt { get; private set; }
    
    public IReadOnlyList<DepartmentLocation> DepartmentLocations => _departmentLocations;

    public static Result<Location, Error> Create(
        LocationId id,
        LocationName name,
        LocationAddress address,
        LocationTimezone timezone,
        bool isActive,
        DateTime createdAt,
        DateTime updatedAt)
    {
        return new Location(id, name, address, timezone, isActive, createdAt, updatedAt);
    }
}