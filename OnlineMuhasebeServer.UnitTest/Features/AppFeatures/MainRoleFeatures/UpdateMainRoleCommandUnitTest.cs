using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRoles;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures;

public sealed class UpdateMainRoleCommandUnitTest
{
    private readonly Mock<IMainRoleService> _mainRoleService;

    public UpdateMainRoleCommandUnitTest()
    {
        _mainRoleService = new();
    }

    [Fact]
    public async Task MainRoleShouldNotBeNull()
    {
        _mainRoleService
            .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());
    }

    [Fact]
    public async Task UpdateMainRoleCommandResponseShouldNotBeNull()
    {
        var command = new UpdateMainRolesCommand(
            Id: "165bee31-d37c-4dfc-9e72-b4684ed79902",
            Title: "Admin");

        var handler = new UpdateMainRolesCommandHandler(_mainRoleService.Object);

        _mainRoleService
            .Setup(x => x.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new MainRole());

        UpdateMainRolesCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}