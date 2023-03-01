﻿using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.RemoveByIdUCAF;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures
{
    public sealed class RemoveByIdUCAFCommandUnitTest
    {
        private readonly Mock<IUCAFService> _ucafService;

        public RemoveByIdUCAFCommandUnitTest()
        {
            _ucafService = new();
        }

        [Fact]
        public async Task RemoveByIdUCAFCommandResponseShouldNotBeNull()
        {
            var command = new RemoveByIdUCAFCommand(
                Id: "01c16882-d379-4a51-8c28-18c07841e71c",
                CompanyId: "585985c0-4576-4d62-ae67-59a6f72ae906");

            var checkIfAvaiblable = _ucafService.Object.CheckRemoveByIdUcafIsGroupAndAvailable(command.Id, command.CompanyId);
            
            var handler = new RemoveByIdUCAFCommandHandler(_ucafService.Object);

            RemoveByIdUCAFCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
