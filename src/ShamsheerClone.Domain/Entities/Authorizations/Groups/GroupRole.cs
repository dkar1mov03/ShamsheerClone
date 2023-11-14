using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Authorizations.Groups;

public class GroupRole : Auditable
{
    public  ChatRole ChatRole { get; set; }
}
