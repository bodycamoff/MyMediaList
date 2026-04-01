using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.Metadata;

public class BookMetadata
{
    
    public Guid MediaItemId { get; set; }
    public MediaItem MediaItem { get; set; } = null!;
    public string Author { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public int NumberOfPages { get; set; }
}