using Domain.Entities;

namespace Domain.Metadata;

public class MovieMetadata : IMetaData
{
    public Guid Id { get; set; }
    public MediaItem MediaItem { get; set; } = null!;
    public string Director { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
}