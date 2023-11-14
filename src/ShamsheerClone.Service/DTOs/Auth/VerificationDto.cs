namespace ShamsheerClone.Service.DTOs.Auth;

public class VerificationDto
{
    public long Code { get; set; }
    public long Attempt { get; set; }
    public DateTime CreatedAt { get; set; }
}
