using ShamsheerClone.Domain.Entities.Assets;

namespace ShamsheerClone.Domain.Entities.Chats;

public class User : Chat
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public ICollection<UserAsset> Assets { get; set; }
}
