using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.Metadata;

public class MovieMetadata
{
    public Guid MediaItemId { get; set; }

    public MediaItem MediaItem { get; set; } = null!;
    public string Director { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
}