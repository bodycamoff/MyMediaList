using Domain.Enums;

namespace Domain.Common;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public MediaType? ApplicableTo { get; set; }
}