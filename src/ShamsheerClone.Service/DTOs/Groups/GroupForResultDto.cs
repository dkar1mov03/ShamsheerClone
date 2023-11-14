using ShamsheerClone.Domain.Enums.Chats;
using ShamsheerClone.Service.DTOs.Users;

namespace ShamsheerClone.Service.DTOs.Groups;

public class GroupForResultDto
{
    public long Id { get; set; }
    public UserForResultDto Owner { get; set; }
    public string Description { get; set; }
    public string Username { get; set; }
    public string Title { get; set; }
    public string InviteLink { get; set; }
    public ChatAccessType AccessType { get; set; }
}
