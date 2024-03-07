using Domain.Dtos.Users;
using Domain.Interfaces.Services;

namespace Application.Handlers.Users.ResetUserPaswordHandler;

public class ChangeUserPaswordHandler : IChangeUserPaswordHandler
{
    private readonly IUserService _userService;

    public ChangeUserPaswordHandler(IUserService userService)
    {
        _userService = userService;
    }
    public Task<RecoverPasswordResultDto> HandleAsync(ChangeUserPaswordHandlerRequest request)
        => _userService.RecoverPassword(request.Email);
}
