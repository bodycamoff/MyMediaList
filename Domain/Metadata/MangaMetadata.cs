using Domain.Entities;
using Domain.Enums;

namespace Domain.Metadata;

public class MangaMetadata : IMetaData
{
    public Guid Id { get; init; }
    public MediaItem MediaItem { get; set; } = null!;
    public string Author { get; init; } = string.Empty;
    public int NumberOfChapters { get; init; }
    public MultiserialMediaStatus Status { get; init; }
}