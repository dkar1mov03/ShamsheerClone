using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Authorizations.Groups;

public class GroupPermission : Auditable
{
    public GroupPermissionType Type { get; set; }
}
