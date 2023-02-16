using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRoles
{
    public sealed record UpdateMainRolesCommand(string Id, string Title) : ICommand<UpdateMainRolesCommandResponse>;

   
}
