using ShamsheerClone.Domain.Enums.Chats;
using ShamsheerClone.Service.Configurations;
using ShamsheerClone.Service.DTOs.Authorizations.Groups;

namespace ShamsheerClone.Service.Interfaces.Authorizations;

public interface IGroupRoleService
{
    Task<bool> Removeasync(long id);
    Task<GroupRoleForResultDto> RetrieveByIdAsync (long id);
    Task<GroupRoleForResultDto> CreateAsync(ChatRole chatRole);
    Task<IEnumerable<GroupRoleForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<GroupRoleForResultDto> Modifyasync(long id,ChatRole chatRole);
}
