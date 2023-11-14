using ShamsheerClone.Domain.Commons;
using System.Text.RegularExpressions;

namespace ShamsheerClone.Domain.Entities.Assets;

public abstract class GroupAsset : Asset
{
    public long GroupId { get; set; }
    public Group Group { get; set; }
}
