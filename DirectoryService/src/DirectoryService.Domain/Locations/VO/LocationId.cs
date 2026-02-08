namespace DirectoryService.Domain.Locations.VO;

public record LocationId
{
    private LocationId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }
    
    public static LocationId NewId() => new(Guid.NewGuid());
    
    public static LocationId Empty => new(Guid.Empty);
}