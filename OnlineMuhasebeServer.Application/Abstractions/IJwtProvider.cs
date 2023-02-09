using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Abstractions
{
    public interface IJwtProvider
    {
      Task< string> CreateTokenAsync(AppUser user,List<string> roles);


    }
}
