using ShamsheerClone.Domain.Entities.Authorizations.Channels;

namespace ShamsheerClone.Domain.Entities.Chats;

public class UserChannel : Chat
{
    public long SubscriberId { get; set; }
    public User Subscriber { get; set; }

    public long ChannelId { get; set; }
    public Channel Channel { get; set; }

    public long RoleId { get; set; }
    public ChannelRole ChannelRole { get; set; }
}
