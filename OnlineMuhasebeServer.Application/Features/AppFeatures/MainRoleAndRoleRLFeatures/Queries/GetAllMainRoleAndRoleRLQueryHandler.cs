using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppServices;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Queries
{
    public sealed class GetAllMainRoleAndRoleRLQueryHandler : IQueryHandler<GetAllMainRoleAndRoleRLQuery, GetAllMainRoleAndRoleRLQueryResponse>
    {
        private readonly IMainRoleAndRoleRelationshipService _mainRoleAndRoleRelationshipService;

        public GetAllMainRoleAndRoleRLQueryHandler(IMainRoleAndRoleRelationshipService mainRoleAndRoleRelationshipService)
        {
            _mainRoleAndRoleRelationshipService = mainRoleAndRoleRelationshipService;
        }

        public async Task<GetAllMainRoleAndRoleRLQueryResponse> Handle(GetAllMainRoleAndRoleRLQuery request, CancellationToken cancellationToken)
        {
            return new(
                await _mainRoleAndRoleRelationshipService.GetAll().Include("AppRole").Include("MainRole").ToListAsync(cancellationToken));
        }
    }
}
