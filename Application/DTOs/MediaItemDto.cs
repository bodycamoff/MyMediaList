using Domain.Common;
using Domain.Enums;
using Domain.Metadata;

namespace Application.DTOs;

public record MediaItemDto(
    string Title,
    MediaType MediaType,
    string? Description,
    DateTime? ReleaseDate,
    ICollection<Genre>? Genres,
    double Rating
);