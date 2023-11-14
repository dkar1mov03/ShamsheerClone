using ShamsheerClone.Domain.Commons;
using ShamsheerClone.Domain.Enums;

namespace ShamsheerClone.Domain.Entities.Messages;

public class MessageContent : Auditable
{
    public byte[] Content { get; set; }
    public MessageType ContentType { get; set; }
    public long MessageId { get; set; }
    public Message Message { get; set; }
}
