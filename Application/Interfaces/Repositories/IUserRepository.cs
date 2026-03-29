using Application.DTOs;
using Domain.Entities;
using Domain.Enums;

namespace Application.Interfaces.Repositories;

public interface IUserRepository
{
    public Task AddUserAsync(CreateUserDto dto);
    public Task DeleteUserAsync(Guid id);
    public Task<User> GetUserByIdAsync(Guid id);
    public Task<IEnumerable<User>> GetAllUsersAsync();
    public Task UpdateUserAsync(User user);
}