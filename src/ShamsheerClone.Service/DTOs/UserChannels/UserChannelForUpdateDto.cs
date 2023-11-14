using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Service.DTOs.UserChannels;

public class UserChannelForUpdateDto
{
    public long SubscriberId { get; set; }
    public long ChannelId { get; set; }
    public ChatRole Role { get; set; }
}
