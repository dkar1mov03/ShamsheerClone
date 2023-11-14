using ShamsheerClone.Domain.Entities.Authorizations.Groups;

namespace ShamsheerClone.Domain.Entities.Chats;

public class UserGroup : Chat
{
    public long MemberId { get; set; }
    public User Member { get; set; }

    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long RoleId { get; set; }
    public GroupRole Role { get; set; }
}
