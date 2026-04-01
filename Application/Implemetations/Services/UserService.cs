using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Mappers;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.Extensions.Logging;

namespace Application.Implemetations.Services;

 
public class UserService : IUserService
{
    private readonly ILogger<UserService> _logger;
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository, ILogger<UserService> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public async Task<bool> IsUserExist(string email)
        => await _userRepository.IsEmailExists(email);

    public async Task RegisterUserAsync(CreateUserDto dto)
    {
        if (await _userRepository.IsEmailExists(dto.Email))
        {
            throw new UserAlreadyExistsException($"Email {dto.Email} уже сущесвует");
        }

        _logger.LogInformation("Регистрация нового пользователя {Email}", dto.Email);
        await _userRepository.AddUserAsync(UserMapper.ToEntity(dto));
    }

    public async Task<User> GetUserById(Guid id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user == null)
        {
            throw new UserNotFoundException($"Пользователь {id} не найден");
        }

        return user;
    }

    public async Task DeleteUserAsync(Guid id)
    {
        try
        {
            _logger.LogInformation("Удаление пользователя {Id}", id);
            await _userRepository.DeleteUserAsync(id);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    public async Task<IEnumerable<GetUserDto>> GetAllUsers()
    {
        var users = await _userRepository.GetAllUsersAsync();

        return users.Select(x => new GetUserDto
        {
            Id = x.Id,
            Email = x.Email,
            UserName = x.UserName
        });
    }
}