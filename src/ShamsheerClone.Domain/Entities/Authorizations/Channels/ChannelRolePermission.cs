using ShamsheerClone.Domain.Commons;

namespace ShamsheerClone.Domain.Entities.Authorizations.Channels;

public class ChannelRolePermission : Auditable
{
    public long RoleId { get; set; }
    public ChannelRole Role { get; set; }
    public long PermissionId { get; set; }
    public ChannelPermission Permission { get; set; }
}
