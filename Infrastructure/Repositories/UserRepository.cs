using Application.Interfaces.Repositories;
using Domain.Entities;
using Domain.Exceptions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;
    private readonly ILogger<UserRepository> _logger;

    public UserRepository(AppDbContext dbContext, ILogger<UserRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task AddUserAsync(User user)
    {
        try
        {
            await _dbContext.Users.AddAsync(user);
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw new Exception("An error occured while adding user");
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(Guid id)
    {
        var user = await _dbContext.Users.FindAsync(id);
        if (user != null)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
        else
        {
            throw new UserNotFoundException($"Пользователь с Id: {id} не найден");
        }
    }

    public async Task<User?> GetUserByIdAsync(Guid id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _dbContext.Users.Select(x => x).ToListAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        var userToUpdate = await _dbContext.Users.FindAsync(user.Id);
        if (userToUpdate != null)
        {
            _dbContext.Users.Update(userToUpdate);
            await _dbContext.SaveChangesAsync();
        }
        else
        {
            _logger.LogWarning("не удалось найти пользователя {id}", user.Id);
        }
    }

    public async Task<bool> IsEmailExists(string email)
    {
        return await _dbContext.Users.Where(u => u.Email == email).AnyAsync();
    }
}