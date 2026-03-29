namespace Application.DTOs;

public record CreateUserDto(
    string Email,
    string UserName,
    string Password
);