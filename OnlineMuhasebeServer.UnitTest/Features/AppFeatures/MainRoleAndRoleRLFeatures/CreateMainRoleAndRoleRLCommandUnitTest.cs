using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures
{
    public sealed class CreateMainRoleAndRoleRLCommandUnitTest
    {

        private readonly Mock<IMainRoleAndRoleRelationshipService> _service;

        public CreateMainRoleAndRoleRLCommandUnitTest()
        {
            _service = new();
        }

        [Fact]
        public async Task MainRoleAndRoleRelationshipShouldBeNull()
        {
            MainRoleAndRoleRelationship mainRoleAndRoleRelationship = (await _service.Object.GetByRoleIdAndMainRoleId(roleId: "cab9e453-f86e-462e-8bd8-bf3d2160a923", mainRoleId: "b2a39d48-1abf-47f7-9b35-6db9a0d39706", default))!;
            mainRoleAndRoleRelationship.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleAndRoleRLCommandResponseShouldNotBeNull()
        {

            var command = new CreateMainRoleAndRoleRLCommand(RoleId: "cab9e453-f86e-462e-8bd8-bf3d2160a923", MainRoleId: "b2a39d48-1abf-47f7-9b35-6db9a0d39706");

            var handler = new CreateMainRoleAndRoleRLCommandHandler(_service.Object);
            CreateMainRoleAndRoleRLCommandResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
