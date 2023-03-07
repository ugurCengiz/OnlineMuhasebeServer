using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Queries
{
    public sealed record GetAllReportQueryResponse(
        IList<Report> Data);
}
