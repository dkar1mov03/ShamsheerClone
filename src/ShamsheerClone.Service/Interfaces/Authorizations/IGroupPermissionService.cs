using ShamsheerClone.Domain.Enums.Chats;
using ShamsheerClone.Service.Configurations;
using ShamsheerClone.Service.DTOs.Authorizations.GroupPermissions;

namespace ShamsheerClone.Service.Interfaces.Authorizations;

public interface IGroupPermissionService
{
    Task<bool> RmoveAsync(long id);
    Task<GroupPermissionForResultDto> RetrieveByIdAsync (long id);
    Task<IEnumerable<GroupPermissionForResultDto>> RetrieveAllAsync(PaginationParams @params);
    Task<GroupPermissionForResultDto> CreateAsync (GroupPermissionType type);
    Task<GroupPermissionForResultDto> ModifyAsync (long id, GroupPermissionType type);
}
