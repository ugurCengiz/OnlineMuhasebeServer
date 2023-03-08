﻿using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Queries
{
    public sealed record GetAllReportQuery(
        string CompanyId,
        int PageNumber =1,
        int PageSize = 5
        ) : IQuery<GetAllReportQueryResponse>;
}
