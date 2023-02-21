using OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AuthFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommand(string EmailOrUserName, string Password) : ICommand<LoginCommandResponse>;
}
