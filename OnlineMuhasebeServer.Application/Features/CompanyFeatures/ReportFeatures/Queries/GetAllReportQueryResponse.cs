using EntityFrameworkCorePagination.Nuget.Pagination;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Queries
{
    public sealed record GetAllReportQueryResponse(
        PaginationResult<Report> Data);
}
