using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Queries
{
    public sealed record GetAllReportQuery(
        string CompanyId) : IQuery<GetAllReportQueryResponse>;
}
