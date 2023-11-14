using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Service.DTOs.Authorizations.Channels;

public class ChannelForResultDto
{
    public long Id { get; set; }
    public ChatRole ChatRole { get; set; }
}
