using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IReviewRepository
{
    public Task AddReviewAsync(Guid userId, Review review);
    public Task DeleteReviewAsync(Guid id);
    public Task<Review> GetReviewByIdAsync(Guid id);
    public Task UpdateMediaItemAsync(MediaItem item);
}