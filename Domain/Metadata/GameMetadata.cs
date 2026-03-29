using Domain.Entities;
using Domain.Enums;

namespace Domain.Metadata;

public class GameMetadata : IMetaData
{
    public Guid Id { get; set; }
    public MediaItem MediaItem { get; set; } = null!;
    public string Developer { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public ICollection<GamePlatform> SupportedPlatforms { get; set; }
}