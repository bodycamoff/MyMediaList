using Application.DTOs;
using Application.Security;
using Domain.Entities;
using Domain.Enums;

namespace Application.Mappers;

public static class UserMapper
{
    public static User ToEntity(CreateUserDto dto)
    {
        return new User
        {
            Id = Guid.NewGuid(),
            Email = dto.Email,
            UserName = dto.UserName,
            PasswordHash = PasswordHasher.HashPassword(dto.Password),
            Role = Role.User
        };
    }
}