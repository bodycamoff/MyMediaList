using Application.Interfaces.Repositories;
using Application.Interfaces.Services;

namespace Application.Implemetations.Services;

public class MediaService : IMediaService
{
    private readonly IUserRepository _userRepository;

    public MediaService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
}