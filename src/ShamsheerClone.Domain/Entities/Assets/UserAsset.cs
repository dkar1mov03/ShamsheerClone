using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Entities.Chats;

namespace ShamsheerClone.Domain.Entities.Assets;

public abstract class UserAsset : Asset
{
    public long UserId { get; set; }
    public User User { get; set; }
}
