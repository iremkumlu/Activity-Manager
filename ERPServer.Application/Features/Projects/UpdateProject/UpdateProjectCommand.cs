using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace ERPServer.Application.Features.Projects.UpdateProject;

public sealed record UpdateProjectCommand(
    Guid Id,
    string ProjectName,
    string Description,
    DateTime? StartDate,
    DateTime? EndDate,
    string ProjectStatus) : IRequest<Result<string>>;
