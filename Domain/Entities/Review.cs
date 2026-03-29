namespace Domain.Entities;

public class Review
{
    public Guid Id { get; init; }
    public Guid MediaItemId { get; init; }
    public Guid UserId { get; init; }
    public User? User { get; set; }
    public DateTime PublishedAt { get; init; }
    public int Score { get; set; }
    public string? Comment { get; set; }
    public int Agreements { get; set; }
    public int Disagreements { get; set; }
}