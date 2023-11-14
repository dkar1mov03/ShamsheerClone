using ShamsheerClone.Domain.Enums.Messages;
using ShamsheerClone.Domain.Enums;

namespace ShamsheerClone.Service.DTOs.Masseges;

public class MassengerForCreateDto
{
    public MessageType Type { get; set; }
    public FormatType FormatType { get; set; }

    public long? ParentId { get; set; }

    public long ToId { get; set; }
}
