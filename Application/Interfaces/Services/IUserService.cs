using Application.DTOs;
using Domain.Entities;

namespace Application.Interfaces.Services;

public interface IUserService
{
    public Task<bool> IsUserExist(string email);
    public Task RegisterUserAsync(CreateUserDto dto);
    public Task<User> GetUserById(Guid id);
    public Task<IEnumerable<GetUserDto>> GetAllUsers();
    public Task DeleteUserAsync(Guid id);
}