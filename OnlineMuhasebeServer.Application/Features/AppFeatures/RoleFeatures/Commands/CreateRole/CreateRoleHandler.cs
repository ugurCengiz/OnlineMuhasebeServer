using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private readonly IRoleService _roleService;

        public CreateRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetByCode(request.Code);

            if (role != null) throw new Exception("Bu rol daha önce kayıt edilmiştir.");

            role = new AppRole
            {
                Id = Guid.NewGuid().ToString(),
                Code = request.Code,
                Name = request.Name,
            };

            await _roleService.AddAsync(request);
            return new();
        }
    }
}
