using ShamsheerClone.Domain.Enums.Chats;
using ShamsheerClone.Service.DTOs.Authorizations.Channels;
using ShamsheerClone.Service.DTOs.Users;

namespace ShamsheerClone.Service.DTOs.UserChannels;

public class UserChannelForResultDto
{
    public long Id { get; set; }
    public UserForResultDto Subscriber { get; set; }
    public ChannelForResultDto Channel { get; set; }
    public ChatRole Role { get; set; }
}
