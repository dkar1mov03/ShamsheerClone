

using ShamsheerClone.Domain.Entities.Chats;

namespace ShamsheerClone.Domain.Entities.Assets;

public abstract class ChannelAsset : Asset
{
    public long ChannelId { get; set; }
    public Channel Channel { get ; set; }
}
