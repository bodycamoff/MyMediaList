using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.Extensions.Logging;

namespace Application.Implemetations.Services;

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;
    private readonly ILogger<ReviewService> _logger;

    public ReviewService(IReviewRepository reviewRepository)
    {
        _reviewRepository = reviewRepository;
    }


    public async Task AddReviewAsync(Guid userId, Review review)
    {
        try
        {
            _reviewRepository.AddReviewAsync(userId, review);
        }
        catch (UnableToAddReviewException ex)
        {
            _logger.LogError(ex.Message, "Пользователь {UserId} не смог добавить обзор на {MediaItem}", userId,
                review.MediaItemId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

}