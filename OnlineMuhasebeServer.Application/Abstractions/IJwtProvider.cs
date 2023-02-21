using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Abstractions
{
    public interface IJwtProvider
    {
      Task< TokenRefreshTokenDto> CreateTokenAsync(AppUser user);


    }
}
