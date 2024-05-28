using ERPServer.Domain.Dtos;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Activities.CreateActivity;

public sealed record CreateActivityCommand(
    Guid ProjectId,
    List<ActivityDetailDto> Details) : IRequest<Result<string>>;
