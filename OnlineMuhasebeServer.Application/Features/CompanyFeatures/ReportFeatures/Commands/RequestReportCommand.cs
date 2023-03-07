using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Commands
{
    public sealed record RequestReportCommand(
        string Name,
        string CompanyId) : ICommand<RequestReportCommandResponse>;
}
