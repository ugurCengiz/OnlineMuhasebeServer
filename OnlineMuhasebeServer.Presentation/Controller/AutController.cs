﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Queries.GetRolesByUserIdAndCompanyId;
using OnlineMuhasebeServer.Application.Features.AuthFeatures.AuthFeatures.Commands.Login;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    public class AutController : ApiController
    {
        public AutController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        //[HttpPost("[action]")]
        //public async Task<IActionResult> GetTokenByRefreshToken(GetTokenByRefreshTokenCommand request)
        //{
        //    GetTokenByRefreshTokenCommandResponse response = await _mediator.Send(request);
        //    return Ok(response);
        //}

        [HttpPost("[action]")]
        public async Task<IActionResult> GetRolesByUserIdAndCompanyId(GetRolesByUserIdAndCompanyIdQuery request)
        {
            GetRolesByUserIdAndCompanyIdQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }


    }
}
