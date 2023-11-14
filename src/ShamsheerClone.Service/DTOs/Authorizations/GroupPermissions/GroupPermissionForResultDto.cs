using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Service.DTOs.Authorizations.GroupPermissions;

public class GroupPermissionForResultDto
{
    public long Id { get; set; }
    public GroupPermissionType Type { get; set; }
}
