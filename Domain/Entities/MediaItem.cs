using Domain.Common;
using Domain.Enums;
using Domain.Metadata;

namespace Domain.Entities;

public class MediaItem
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public MediaType MediaType { get; set; }
    public string? Description { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public ICollection<Review>? Reviews { get; set; }
    public ICollection<Genre>? Genres { get; set; }
    public double Rating { get; set; }

    public GameMetadata? GameMetadata { get; set; }
    public MovieMetadata? MovieMetadata { get; set; }
    public BookMetadata? BookMetadata { get; set; }
    public SeriesMetadata? SeriesMetadata { get; set; }
    public MangaMetadata? MangaMetadata { get; set; }
}