using Application.DTOs;
using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyMediaList.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
    {
        await _userService.RegisterUserAsync(createUserDto);
        return Ok();
    }

    [HttpGet]
    [Route("{id:guid}")]
    public async Task<ActionResult<GetUserDto>> GetUsersById(Guid id)
    {
        var user = await _userService.GetUserById(id);
        return Ok(new GetUserDto
        {
            Id = user.Id,
            Email = user.Email,
            UserName = user.UserName,
        });
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetUserDto>>> GetAllUsers(Guid id)
    {
        var users = await _userService.GetAllUsers();
        return Ok(users);
    }

    [HttpDelete]
    [Route("{id:guid}")]
    public async Task<ActionResult> DeleteUserAsync(Guid id)
    {
        await _userService.DeleteUserAsync(id);
        return NoContent();
    }
}