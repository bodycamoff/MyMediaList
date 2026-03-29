namespace Application.DTOs;

public record CreateReviewDto(
    Guid MediaItemId,
    int Score,
    string Comment
);