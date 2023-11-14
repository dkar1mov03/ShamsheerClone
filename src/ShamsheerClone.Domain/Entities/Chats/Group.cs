using ShamsheerClone.Domain.Entities.Assets;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Chats;

public class Group : Chat
{
    public long OwnerId { get; set; }
    public User Owner { get; set; }
    public string Title { get; set; }
    public ChatAccessType AccessType { get; set; }
    public string InviteLink { get; set; }
    public ICollection<UserGroup> Members { get; set; }
    public ICollection<GroupAsset> Assets { get; set; }
}
