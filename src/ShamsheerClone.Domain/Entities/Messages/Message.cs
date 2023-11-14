using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Entities.Chats;
using ShamsheerClone.Domain.Enums.Messages;
using ShamsheerClone.Domain.Enums;

namespace ShamsheerClone.Domain.Entities.Messages;

public class Message : Auditable
{
    public MessageType Type { get; set; }
    public FormatType FormatType { get; set; }

    public long? ParentId { get; set; }
    public Message Parent { get; set; }
    public long FromId { get; set; }
    public User From { get; set; }

    public long ToId { get; set; }
    public User To { get; set; }
}
