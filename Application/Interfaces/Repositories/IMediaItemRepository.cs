using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IMediaItemRepository
{
    public Task AddMediaItemAsync(MediaItem item);
    public Task DeleteMediaItemAsync(Guid id);
    public Task<MediaItem> GetMediaItemByIdAsync(Guid id);
    public Task<IEnumerable<MediaItem>> GetAllMediaItemsAsync();
    public Task UpdateMediaItemAsync(MediaItem item);
}