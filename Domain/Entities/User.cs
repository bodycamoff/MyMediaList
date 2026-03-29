using Domain.Enums;

namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; init; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public ICollection<Review>? UserReviews { get; set; }
    public  ICollection<MediaItem>? UserMediaLists { get; set; }
    public Role Role { get; set; }
}

