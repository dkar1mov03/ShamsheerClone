namespace ShamsheerClone.Domain.Commons;

public  abstract class Auditable
{
    public long Id { get; set; }
    public long DeleteBy { get; set; }
    public long UpdateBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set;}
}
