using ShamsheerClone.Domain.Enums.Chats;
using ShamsheerClone.Service.DTOs.Authorizations.Groups;
using ShamsheerClone.Service.DTOs.Users;

namespace ShamsheerClone.Service.DTOs.UserGroups;

public class UserGroupForResultDto
{
    public long Id { get; set; }
    public UserForResultDto Member { get; set; }
    public GroupRoleForResultDto Group { get; set; }
    public ChatRole Role { get; set; }
}
