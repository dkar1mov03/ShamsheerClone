using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Service.DTOs.UserGroups;

public class UserGroupForUpdateDto
{
    public long MemberId { get; set; }
    public long GroupId { get; set; }
    public ChatRole Role { get; set; }
}
