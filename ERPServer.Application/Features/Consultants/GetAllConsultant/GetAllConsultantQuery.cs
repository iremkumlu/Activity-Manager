using ERPServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace ERPServer.Application.Features.Consultants.GetAllConsultant;

public sealed record GetAllConsultantQuery() : IRequest<Result<List<Consultant>>>;
    

