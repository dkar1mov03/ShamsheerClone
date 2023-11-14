using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Authorizations.Channels;

public class ChannelPermission : Auditable
{
    public ChannelPermissionType Type { get; set; }
}
