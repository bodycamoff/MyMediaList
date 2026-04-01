using System.ComponentModel.DataAnnotations;
using Domain.Entities;
using Domain.Enums;

namespace Domain.Metadata;

public class SeriesMetadata
{
    public Guid MediaItemId { get; set; }

    public MediaItem MediaItem { get; set; } = null!;
    public int NumberOfEpisodes { get; set; }
    public int NumberOfSeasons { get; set; }
    public DateTime ReleaseDate { get; set; }
    public DateTime EndDate { get; set; }
    public MultiserialMediaStatus Status { get; set; }
    public string Studio { get; set; } = string.Empty;
}