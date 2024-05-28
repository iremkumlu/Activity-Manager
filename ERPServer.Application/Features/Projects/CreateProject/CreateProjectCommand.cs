using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Projects.CreateProject;

public sealed record CreateProjectCommand
(
    string ProjectName,
    string Description,
    DateTime? StartDate,
    DateTime? EndDate,
    string ProjectStatus) : IRequest<Result<string>>;
