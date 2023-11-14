using ShamsheerClone.Domain.Commons;
using System.Security.Cryptography.X509Certificates;

namespace ShamsheerClone.Domain.Entities.Authorizations.Groups;

public class GroupRolePermission : Auditable
{
    public long RoleId { get; set; }
    public GroupRole Role { get; set; }
    public long PermissionId { get; set; }
    public GroupPermission Permission { get; set; }
}
