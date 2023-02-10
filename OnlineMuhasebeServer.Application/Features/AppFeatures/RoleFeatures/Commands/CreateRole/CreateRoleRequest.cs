using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleRequest : IRequest<CreateRoleResponse>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
