namespace DirectoryService.Domain.Positions.VO;

public record PositionId
{
    private PositionId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }
    
    public static PositionId NewId() => new(Guid.NewGuid());
    
    public static PositionId Empty() => new(Guid.Empty);
}