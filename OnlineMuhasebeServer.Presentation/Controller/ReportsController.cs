using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Commands;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.ReportFeatures.Queries;
using OnlineMuhasebeServer.Presentation.Abstraction;
using System.Net;

namespace OnlineMuhasebeServer.Presentation.Controller;

[Authorize(AuthenticationSchemes = "Bearer")]
public class ReportsController : ApiController
{

    public ReportsController(IMediator mediator) : base(mediator) { }

    [HttpPost("[action]")]
    public async Task<IActionResult> GetAll(GetAllReportQuery request)
    {
        GetAllReportQueryResponse response = await _mediator.Send(request);
        return Ok(response);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> RequestReport(RequestReportCommand request, CancellationToken cancellationToken)
    {
        RequestReportCommandResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}