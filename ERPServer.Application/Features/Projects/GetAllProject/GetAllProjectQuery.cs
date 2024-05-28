

using ERPServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Projects.GetAllProject;

public sealed record GetAllProjectQuery() : IRequest<Result<List<Project>>>;
