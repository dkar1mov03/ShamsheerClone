using ShamsheerClone.Service.DTOs.Authorizations.Channels;

namespace ShamsheerClone.Service.Interfaces.Authorizations.Channels;

public interface IChannelRoleService
{
    Task<bool> RemoveAsync(long id);
    Task<ChannelPermissionForResultDto> RetrieveByIdAsync()
}
