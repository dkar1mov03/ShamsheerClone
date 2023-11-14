using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Authorizations.Channels;

public class ChannelRole : Auditable
{
    public ChatRole ChatRole { get; set; }
}
