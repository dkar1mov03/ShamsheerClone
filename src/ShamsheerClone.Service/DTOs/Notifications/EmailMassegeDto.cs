namespace ShamsheerClone.Service.DTOs.Notifications;

public class EmailMassegeDto
{
    public string Recipent { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
}
