﻿using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AuthFeatures.AuthFeatures.Commands.Login
{
    public sealed record LoginCommandResponse(
        TokenRefreshTokenDto Token,
        string Email, 
        string UserId, 
        string NameLastName,
        IList<CompanyDto> Companies,
        CompanyDto Company);

}
