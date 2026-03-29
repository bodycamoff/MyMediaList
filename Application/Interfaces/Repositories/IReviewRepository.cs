using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IReviewRepository
{
    public Task AddReviewAsync(Guid userId, Review review);
    public Task DeleteReviewAsync(Guid id);
    public Task<MediaItem> GetMediaItemByIdAsync(Guid id);
    public Task<IEnumerable<MediaItem>> GetAllMediaItemsAsync();
    public Task UpdateMediaItemAsync(MediaItem item);
}