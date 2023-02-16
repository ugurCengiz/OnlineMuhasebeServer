﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRoles
{
    public sealed class UpdateMainRolesCommandHandler:ICommandHandler<UpdateMainRolesCommand,UpdateMainRolesCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public UpdateMainRolesCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<UpdateMainRolesCommandResponse> Handle(UpdateMainRolesCommand request, CancellationToken cancellationToken)
        {
            MainRole mainRole = await _mainRoleService.GetByIdAsync(request.Id);

            if (mainRole == null) throw new Exception("Bu ana rol bulunamadı.");
            if (mainRole.Title == request.Title)
                throw new Exception("Güncellemeye çalıştığınız ana rol adı eski adı ile aynı !!!");
            if (mainRole.Title != request.Title)
            {
                MainRole checkMainRoleTitle =
                    await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.CompanyId);

                if (checkMainRoleTitle != null) throw new Exception("Bu rol adı daha önce kullanılmıştır");
            }

            mainRole.Title = request.Title;

            await _mainRoleService.UpdateAsync(mainRole);

            return new();

            
        }
    }
}
