using Domain.Entities;

namespace Domain.Metadata;

public class BookMetadata : IMetaData
{
    public Guid Id { get; init; }
    public MediaItem MediaItem { get; set; } = null!;
    public string Author { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public int NumberOfPages { get; set; }
}