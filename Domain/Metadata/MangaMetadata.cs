using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Domain.Enums;

namespace Domain.Metadata;

public class MangaMetadata
{
    
    public Guid MediaItemId { get; set; }

    public MediaItem MediaItem { get; set; } = null!;
    public string Author { get; init; } = string.Empty;
    public int NumberOfChapters { get; init; }
    public MultiserialMediaStatus Status { get; init; }
}