using ERPServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Activities.GetAllActivity;

public sealed record GetAllActivityQuery() : IRequest<Result<List<Activity>>>;

