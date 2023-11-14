using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums.Chats;

namespace ShamsheerClone.Domain.Entities.Chats;

public class Chat : Auditable
{
    public string Describtion {  get; set; }
    public string UserName { get; set; }
    public ChatType ChatType { get; set; }
}
